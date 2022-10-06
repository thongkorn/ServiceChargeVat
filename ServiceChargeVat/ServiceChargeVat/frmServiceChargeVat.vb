#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: http://www.facebook.com/g2gnet (for Thailand)
' / Facebook: http://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com
' /
' / Purpose: Demonstrate Calculate Service Charge and VAT.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Public Class frmServiceChargeVat

    ' / --------------------------------------------------------------------------------
    '/ Don't forget to set Form has KeyPreview = True
    Private Sub frmServiceChargeVat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        '/ การกดฟังค์ชั่นคีย์
        Select Case e.KeyCode
            Case Keys.F7
                '/ Add Row
                Call btnAddRow_Click(sender, e)
            Case Keys.F8
                '/ Remove Row
                Call btnRemoveRow_Click(sender, e)
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub frmServiceChargeVat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True  '/ สามารถกดปุ่มฟังค์ชั่นคีย์ลงในฟอร์มได้
        With cmbTax
            .Items.Add("None Vat")
            .Items.Add("Include Vat")
            .Items.Add("Exclude Vat")
        End With
        cmbTax.SelectedIndex = 2
        '//
        Call InitializeGrid()
        Call FillDataSample()   '/ ตัวอย่างสมมุติ
        Call CalSumTotal()  '/ รวมจำนวนเงิน
        '// แก้ไข: ลืมตอนกำหนด Design Time
        Label7.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
        cmbTax.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / การตั้งค่า DataGridView แบบ @Run Time หรือ Dynamically.
    Private Sub InitializeGrid()
        With dgvData
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .ReadOnly = False
            .RowTemplate.MinimumHeight = 27
            .RowTemplate.Height = 27
            .Font = New Font("Tahoma", 10)
            '/ Columns Specified
            '/ Index = 0
            .Columns.Add("PK", "Primary Key")
            With .Columns("PK")
                .ReadOnly = True
                .DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                .Visible = True 'False '/ ปกติหลัก Primary Key จะต้องถูกซ่อนไว้
            End With
            .Columns.Add("ProductID", "Product ID") '/ Index = 1
            .Columns.Add("ProductName", "Product Name") '/ Index = 2
            '/ Read Only
            .Columns(1).ReadOnly = True '/ รหัสสินค้า
            .Columns(2).ReadOnly = True '/ ชื่อสินค้า
            '/
            .Columns.Add("Quantity", "Quantity") '/ Index = 3
            .Columns("Quantity").ValueType = GetType(Integer)
            .Columns.Add("UnitPrice", "Unit Price") '/ Index = 4
            .Columns("UnitPrice").ValueType = GetType(Double)
            '/ Index = 5 (CheckBox) ... เลือกว่าคิด Service Charge หรือไม่
            Dim chkServiceCharge As New DataGridViewCheckBoxColumn
            .Columns.Add(chkServiceCharge)
            chkServiceCharge.HeaderText = "Service Charge"
            chkServiceCharge.Name = "chkServiceCharge"
            '/ Index = 6 ... Total = (จำนวน x ราคา)
            .Columns.Add("Total", "Total")
            .Columns("Total").ValueType = GetType(Double)
            '/ Total Column
            With .Columns("Total")
                .ReadOnly = True
                .DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                .DefaultCellStyle.ForeColor = Color.Blue
                .DefaultCellStyle.Font = New Font(dgvData.Font, FontStyle.Bold)
            End With
            '/ Alignment MiddleRight only columns 3, 4 and 6
            For i As Byte = 3 To 6
                If i <> 5 Then
                    .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    '// กรณีหลัก 5 เป็น CheckBox ให้จัดตำแหน่งตรงกึ่งกลางของเซลล์
                Else
                    .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If
            Next
            '/ Auto size column width of each main by sorting the field.
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '/ Adjust Header Styles
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Crimson
                .ForeColor = Color.White
                .Font = New Font("Tahoma", 10, FontStyle.Bold)
            End With
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 36
            '/ กำหนดให้ EnableHeadersVisualStyles = False เพื่อให้ยอมรับการเปลี่ยนแปลงสีพื้นหลังของ Header
            .EnableHeadersVisualStyles = False
        End With

    End Sub

    ' / --------------------------------------------------------------------------------
    ' / DATA SAMPLE ... ทำตัวอย่างให้ง่ายต่อการคำนวณ
    Private Sub FillDataSample()
        Try
            '/ Primary Key, Product ID, Product Name, Quantity, UnitPrice, ServiceCharge, Total
            Dim row As String() = New String() {"1", "PRO00001", "Product 1", "1", "1000.00", CBool(1), "0.00"}
            dgvData.Rows.Add(row)
            row = New String() {"2", "PRO00002", "Product 2", "1", "1000.00", CBool(0), "0.00"}
            dgvData.Rows.Add(row)
            row = New String() {"3", "PRO00003", "Product 3", "1", "1000.00", CBool(0), "0.00"}
            dgvData.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Add new row
    Private Sub btnAddRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Position As Integer = dgvData.Rows.Count - 1
        Dim PK As Integer = 1   '/ Initialize value if without rows.
        '/ Get value at the last row
        Dim LastRow As New DataGridViewRow
        '/ ตรวจสอบค่าแถวสุดท้ายว่ามีค่า Primary Key เท่าไหร่ก็ให้บวก 1 (เป็นการจำลองการทำงาน โดยไม่ติดต่อกับ DataBase)
        '/ กรณีใช้ฐานข้อมูลจริงๆ ให้ตัดส่วนนี้ทิ้งแล้วใช้ Primary Key ของสินค้าจากฐานข้อมูลแทน
        If Position >= 0 Then
            '/ ไปแถวสุดท้าย
            LastRow = dgvData.Rows.OfType(Of DataGridViewRow).Last()
            '/ จากนั้นให้เพิ่มค่าขึ้น +1 (Column Index = 0)
            PK = LastRow.Cells(0).Value + 1
        End If
        Dim RandomClass As New Random()
        '/ Sample data
        '/ Primary Key, Product ID, Product Name, Quantity, UnitPrice, ServiceCharge, Total
        Dim row As String() = New String() {PK, "PRO0000" & PK, "Product " & PK, "1", Format(RandomClass.Next(100, 2000), "0.00"), RandomClass.Next(2) = 0, "0.00"}
        dgvData.Rows.Add(row)
        '/ โฟกัสไปที่ Column(3) หรือ Quantity (จำนวน)
        dgvData.CurrentCell = dgvData.Rows(dgvData.RowCount - 1).Cells(3)
        dgvData.Focus()

        '/ ไปคำนวณหาค่าผลรวม
        Call CalSumTotal()
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Remove select row
    Private Sub btnRemoveRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dgvData.RowCount = 0 Then Exit Sub
        '/
        dgvData.Rows.Remove(dgvData.CurrentRow)
        dgvData.Refresh()
        '/ เมื่อแถวรายการถูกลบออกไป และยังคงมีแถวรายการอยู่ ต้องไปคำนวณหาค่าผลรวมใหม่
        If dgvData.RowCount > 0 Then Call CalSumTotal()
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Calcualte sum of Total (Column Index = 6)
    ' / ทำทุกครั้งที่มีการเพิ่มหรือลบแถวรายการ และมีการเปลี่ยนแปลงค่าในเซลล์ Quantity, UnitPrice และ Service Charge
    Private Sub CalSumTotal()
        Dim ServiceCharge As Double = 0
        Dim NoneServiceCharge As Double = 0
        'txtTotal.Text = "0.00"
        'txtVat.Text = "0.00"
        'txtNetTotal.Text = "0.00"
        'txtServiceCharge.Text = "0.00"
        'txtServiceChargeSum.Text = "0.00"
        'txtNonServiceCharge.Text = "0.00"

        '// Set all TextBox Control to Zero.
        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            tb.Text = "0.00"
        Next
        '/ วนรอบตามจำนวนแถวที่มีอยู่ปัจจุบัน
        For nRow As Integer = 0 To dgvData.RowCount - 1
            '// หากติ๊กเครื่องหมายถูกหลักที่ 6 (Index = 5) จะคำนวณหาส่วนของสินค้า/บริการที่คิด Service Charge
            If CBool(dgvData.Rows(nRow).Cells(5).Value) Then
                '// [จำนวน x ราคา]
                ServiceCharge = Format(dgvData.Rows(nRow).Cells(3).Value * dgvData.Rows(nRow).Cells(4).Value, "#,##0.00")
                '// รวมราคาที่คิด Service Charge เป็นค่าที่ยังไม่ได้คิด 10%
                txtServiceCharge.Text = Format(CDbl(txtServiceCharge.Text) + ServiceCharge, "#,##0.00")
                '// คิด Service Charge 10% ของราคา
                ServiceCharge = ServiceCharge + (ServiceCharge * 10 / 100)
                '// รวมจำนวนราคาและ Service Charge 10%
                txtServiceChargeSum.Text = Format(CDbl(txtServiceChargeSum.Text) + ServiceCharge, "#,##0.00")

                '// None Service Charge
            Else
                NoneServiceCharge = Format(dgvData.Rows(nRow).Cells(3).Value * dgvData.Rows(nRow).Cells(4).Value, "#,##0.00")
                txtNonServiceCharge.Text = Format(CDbl(txtNonServiceCharge.Text) + NoneServiceCharge, "#,##0.00")
            End If
            '/ หลักสุดท้ายของตารางกริด = [จำนวน x ราคา]
            dgvData.Rows(nRow).Cells(6).Value = Format(dgvData.Rows(nRow).Cells(3).Value * dgvData.Rows(nRow).Cells(4).Value, "#,##0.00")
        Next

        '// รวมราคาสินค้า/บริการ = Service Charge + None Service Charge
        Dim SumPrice As Double = Format(CDbl(txtServiceChargeSum.Text) + CDbl(txtNonServiceCharge.Text), "#,##0.00")
        '// TAX - การคิดภาษี
        Select Case cmbTax.SelectedIndex
            '// ไม่คิดภาษี
            Case 0
                txtTotal.Text = Format(SumPrice, "#,##0.00")
                txtVat.Text = "0.00"
                '// รวมจำนวนเงินทั้งหมด
                txtNetTotal.Text = Format(CDbl(txtTotal.Text) + CDbl(txtVat.Text), "#,##0.00")
                '// หรือ txtNetTotal.Text = Format(SumPrice, "#,##0.00")
                lblTotal.Text = "Total (1+2) :"
                lblVat.Text = "None Vat : "
                lblNetTotal.Text = "Net Total (Total) :"

                '// รวมภาษี (Include Tax)
            Case 1
                '// คิดภาษี 7% (Include VAT)
                txtVat.Text = Format(SumPrice - (SumPrice / 1.07), "#,##0.00")
                '// หาราคาสินค้าที่แท้จริง ... ราคาสินค้าทั้งหมดลบออกจากภาษี
                txtTotal.Text = Format(SumPrice - CDbl(txtVat.Text), "#,##0.00")
                '// รวมจำนวนเงินทั้งหมด
                txtNetTotal.Text = Format(SumPrice, "#,##0.00")
                lblTotal.Text = "Total (1+2-Vat) :"
                lblVat.Text = "Include Vat (7%) : "
                lblNetTotal.Text = "Net Total (Total+Vat) :"

                '// แยกภาษี (Exclude Tax)
            Case 2
                txtTotal.Text = Format(SumPrice, "#,##0.00")
                '// คิดแยกภาษี 7% (Exclude VAT)
                txtVat.Text = Format(CDbl(txtTotal.Text) * 7 / 100, "#,##0.00")
                '// รวมจำนวนเงินทั้งหมด
                txtNetTotal.Text = Format(CDbl(txtTotal.Text) + CDbl(txtVat.Text), "#,##0.00")
                lblTotal.Text = "Total (1+2) :"
                lblVat.Text = "Exclude Vat (7%) : "
                lblNetTotal.Text = "Net Total (Total+Vat) :"
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / หลังจากการแก้ไขค่าในเซลล์และเกิดการกด Enter
    Private Sub dgvData_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellEndEdit
        '/ เกิดการเปลี่ยนแปลงค่าในหลัก Index ที่ 3 หรือ 4
        Select Case e.ColumnIndex
            Case 3, 4 '/ Column Index = 3 (Quantity), Column Index = 4 (UnitPrice)
                '/ Quantity
                '/ การดัก Error กรณีมีค่า Null Value ให้ใส่ค่า 0 ลงไปแทน
                If IsDBNull(dgvData.Rows(e.RowIndex).Cells(3).Value) Then dgvData.Rows(e.RowIndex).Cells(3).Value = "0"
                Dim Quantity As Integer = dgvData.Rows(e.RowIndex).Cells(3).Value

                '/ UnitPrice
                '/ If Null Value
                If IsDBNull(dgvData.Rows(e.RowIndex).Cells(4).Value) Then dgvData.Rows(e.RowIndex).Cells(4).Value = "0.00"
                dgvData.Rows(e.RowIndex).Cells(4).Value = Format(CDbl(dgvData.Rows(e.RowIndex).Cells(4).Value), "0.00")
                Dim UnitPrice As Double = dgvData.Rows(e.RowIndex).Cells(4).Value
                '/ Quantity x UnitPrice ในหลักที่ 7 (Index = 6)
                dgvData.Rows(e.RowIndex).Cells(6).Value = (Quantity * UnitPrice).ToString("#,##0.00")
                '/ Calculate Summary
                Call CalSumTotal()
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Validate Cell ... Quantity = Integer, UnitPrice = Double
    Private Sub dgvData_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvData.EditingControlShowing
        Select Case dgvData.Columns(dgvData.CurrentCell.ColumnIndex).Name
            ' / Can use both Colume Index or Field Name
            Case "Quantity", "UnitPrice"
                '/ Stop and Start event handler
                RemoveHandler e.Control.KeyPress, AddressOf ValidKeyPress
                AddHandler e.Control.KeyPress, AddressOf ValidKeyPress
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub ValidKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tb As TextBox = sender
        Select Case dgvData.CurrentCell.ColumnIndex
            Case 3  ' Quantity is Integer
                Select Case e.KeyChar
                    Case "0" To "9"   ' digits 0 - 9 allowed
                    Case ChrW(Keys.Back)    ' backspace allowed for deleting (Delete key automatically overrides)

                    Case Else ' everything else ....
                        ' True = CPU cancel the KeyPress event
                        e.Handled = True ' and it's just like you never pressed a key at all
                End Select

            Case 4  ' UnitPrice is Double
                Select Case e.KeyChar
                    Case "0" To "9"
                        ' Allowed "."
                    Case "."
                        ' can present "." only one
                        If InStr(tb.Text, ".") Then e.Handled = True

                    Case ChrW(Keys.Back)
                        '/ Return False is Default value

                    Case Else
                        e.Handled = True

                End Select
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    '// เหตุการณ์ในการคลิ๊กเมาส์ลงในเซลล์ของหลักที่ 6 (Index = 5)
    Private Sub dgvData_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        '// Column Index = 5
        If dgvData.Columns(e.ColumnIndex).Name = "chkServiceCharge" Then
            Dim isChecked As Boolean = dgvData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            If isChecked = False Then
                dgvData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
            Else
                dgvData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
            End If
        End If
        '//
        '// คำนวณหาราคาใหม่
        Call CalSumTotal()
    End Sub

    Private Sub cmbTax_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTax.SelectedIndexChanged
        Call CalSumTotal()
    End Sub

    Private Sub frmServiceChargeVat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

End Class
