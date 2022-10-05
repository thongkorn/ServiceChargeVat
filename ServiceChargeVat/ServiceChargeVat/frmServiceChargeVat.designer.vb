<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceChargeVat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServiceChargeSum = New System.Windows.Forms.TextBox()
        Me.txtNonServiceCharge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtNetTotal = New System.Windows.Forms.TextBox()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblNetTotal = New System.Windows.Forms.Label()
        Me.txtServiceCharge = New System.Windows.Forms.TextBox()
        Me.cmbTax = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(4, 3)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(892, 323)
        Me.dgvData.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.Location = New System.Drawing.Point(4, 334)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(125, 31)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Row F7"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnRemove.Location = New System.Drawing.Point(137, 334)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(125, 31)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove Row F8"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.Color.LightCyan
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.Location = New System.Drawing.Point(761, 334)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(135, 26)
        Me.txtTotal.TabIndex = 3
        Me.txtTotal.Text = "txtTotal"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(554, 337)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(199, 18)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total (1+2) :"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 371)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Service Charge 10% (1) :"
        '
        'txtServiceChargeSum
        '
        Me.txtServiceChargeSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServiceChargeSum.BackColor = System.Drawing.Color.Yellow
        Me.txtServiceChargeSum.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtServiceChargeSum.ForeColor = System.Drawing.Color.Black
        Me.txtServiceChargeSum.Location = New System.Drawing.Point(419, 368)
        Me.txtServiceChargeSum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServiceChargeSum.Name = "txtServiceChargeSum"
        Me.txtServiceChargeSum.ReadOnly = True
        Me.txtServiceChargeSum.Size = New System.Drawing.Size(135, 26)
        Me.txtServiceChargeSum.TabIndex = 6
        Me.txtServiceChargeSum.Text = "txtServiceChargeSum"
        Me.txtServiceChargeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNonServiceCharge
        '
        Me.txtNonServiceCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNonServiceCharge.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtNonServiceCharge.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNonServiceCharge.ForeColor = System.Drawing.Color.Black
        Me.txtNonServiceCharge.Location = New System.Drawing.Point(419, 402)
        Me.txtNonServiceCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNonServiceCharge.Name = "txtNonServiceCharge"
        Me.txtNonServiceCharge.ReadOnly = True
        Me.txtNonServiceCharge.Size = New System.Drawing.Size(135, 26)
        Me.txtNonServiceCharge.TabIndex = 7
        Me.txtNonServiceCharge.Text = "txtNoneServiceCharge"
        Me.txtNonServiceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 337)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Service Charge :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(209, 405)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "None Service Charge (2) :"
        '
        'txtVat
        '
        Me.txtVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVat.BackColor = System.Drawing.Color.Cornsilk
        Me.txtVat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVat.ForeColor = System.Drawing.Color.Blue
        Me.txtVat.Location = New System.Drawing.Point(761, 368)
        Me.txtVat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(135, 26)
        Me.txtVat.TabIndex = 10
        Me.txtVat.Text = "txtVat"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetTotal
        '
        Me.txtNetTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNetTotal.BackColor = System.Drawing.Color.Crimson
        Me.txtNetTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNetTotal.ForeColor = System.Drawing.Color.Yellow
        Me.txtNetTotal.Location = New System.Drawing.Point(761, 402)
        Me.txtNetTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.ReadOnly = True
        Me.txtNetTotal.Size = New System.Drawing.Size(135, 26)
        Me.txtNetTotal.TabIndex = 11
        Me.txtNetTotal.Text = "txtNetTotal"
        Me.txtNetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVat
        '
        Me.lblVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblVat.Location = New System.Drawing.Point(580, 371)
        Me.lblVat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(176, 18)
        Me.lblVat.TabIndex = 12
        Me.lblVat.Text = "Exclude Vat (7%) :"
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNetTotal
        '
        Me.lblNetTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNetTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNetTotal.Location = New System.Drawing.Point(562, 405)
        Me.lblNetTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNetTotal.Name = "lblNetTotal"
        Me.lblNetTotal.Size = New System.Drawing.Size(191, 18)
        Me.lblNetTotal.TabIndex = 13
        Me.lblNetTotal.Text = "Net Total :"
        Me.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServiceCharge
        '
        Me.txtServiceCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServiceCharge.BackColor = System.Drawing.Color.PaleGreen
        Me.txtServiceCharge.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtServiceCharge.ForeColor = System.Drawing.Color.Black
        Me.txtServiceCharge.Location = New System.Drawing.Point(419, 334)
        Me.txtServiceCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServiceCharge.Name = "txtServiceCharge"
        Me.txtServiceCharge.ReadOnly = True
        Me.txtServiceCharge.Size = New System.Drawing.Size(135, 26)
        Me.txtServiceCharge.TabIndex = 14
        Me.txtServiceCharge.Text = "txtServiceCharge"
        Me.txtServiceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbTax
        '
        Me.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTax.FormattingEnabled = True
        Me.cmbTax.Location = New System.Drawing.Point(4, 397)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Size = New System.Drawing.Size(121, 26)
        Me.cmbTax.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 376)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "TAX"
        '
        'frmServiceChargeVat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 439)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbTax)
        Me.Controls.Add(Me.txtServiceCharge)
        Me.Controls.Add(Me.lblNetTotal)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.txtNetTotal)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNonServiceCharge)
        Me.Controls.Add(Me.txtServiceChargeSum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvData)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(913, 478)
        Me.Name = "frmServiceChargeVat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Charge with Calculate VAT - coDe bY: Thongkorn Tubtimkrob"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtServiceChargeSum As System.Windows.Forms.TextBox
    Friend WithEvents txtNonServiceCharge As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents txtNetTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents lblNetTotal As System.Windows.Forms.Label
    Friend WithEvents txtServiceCharge As System.Windows.Forms.TextBox
    Friend WithEvents cmbTax As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
