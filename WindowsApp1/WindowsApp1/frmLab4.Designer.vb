<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.lblYearSalary = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblAllIncome = New System.Windows.Forms.Label()
        Me.lblAllowance = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCalTax = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLongDate = New System.Windows.Forms.RadioButton()
        Me.radGenDate = New System.Windows.Forms.RadioButton()
        Me.radShortDate = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณภาษี (อย่างหยาบ)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightCoral
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "วันที่"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.DarkGray
        Me.lblDate.Location = New System.Drawing.Point(128, 68)
        Me.lblDate.MinimumSize = New System.Drawing.Size(200, 30)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(200, 30)
        Me.lblDate.TabIndex = 9
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(131, 114)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(197, 22)
        Me.txtSalary.TabIndex = 10
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(131, 156)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(197, 22)
        Me.txtSale.TabIndex = 11
        Me.txtSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblYearSalary
        '
        Me.lblYearSalary.AutoSize = True
        Me.lblYearSalary.BackColor = System.Drawing.Color.DarkGray
        Me.lblYearSalary.Location = New System.Drawing.Point(128, 189)
        Me.lblYearSalary.MinimumSize = New System.Drawing.Size(200, 30)
        Me.lblYearSalary.Name = "lblYearSalary"
        Me.lblYearSalary.Size = New System.Drawing.Size(200, 30)
        Me.lblYearSalary.TabIndex = 12
        Me.lblYearSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBonus
        '
        Me.lblBonus.AutoSize = True
        Me.lblBonus.BackColor = System.Drawing.Color.DarkGray
        Me.lblBonus.Location = New System.Drawing.Point(128, 233)
        Me.lblBonus.MinimumSize = New System.Drawing.Size(200, 30)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(200, 30)
        Me.lblBonus.TabIndex = 13
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllIncome
        '
        Me.lblAllIncome.AutoSize = True
        Me.lblAllIncome.BackColor = System.Drawing.Color.DarkGray
        Me.lblAllIncome.Location = New System.Drawing.Point(128, 273)
        Me.lblAllIncome.MinimumSize = New System.Drawing.Size(200, 30)
        Me.lblAllIncome.Name = "lblAllIncome"
        Me.lblAllIncome.Size = New System.Drawing.Size(200, 30)
        Me.lblAllIncome.TabIndex = 14
        Me.lblAllIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllowance
        '
        Me.lblAllowance.AutoSize = True
        Me.lblAllowance.BackColor = System.Drawing.Color.DarkGray
        Me.lblAllowance.Location = New System.Drawing.Point(128, 318)
        Me.lblAllowance.MinimumSize = New System.Drawing.Size(200, 30)
        Me.lblAllowance.Name = "lblAllowance"
        Me.lblAllowance.Size = New System.Drawing.Size(200, 30)
        Me.lblAllowance.TabIndex = 15
        Me.lblAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BackColor = System.Drawing.Color.DarkGray
        Me.lblTax.Location = New System.Drawing.Point(128, 359)
        Me.lblTax.MinimumSize = New System.Drawing.Size(200, 30)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(200, 30)
        Me.lblTax.TabIndex = 16
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightCoral
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(12, 189)
        Me.Label3.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 30)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "เงินเดือนทั้งปี"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightCoral
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(12, 233)
        Me.Label4.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 30)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "รับเงินโบนัส"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightCoral
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(12, 273)
        Me.Label5.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 30)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "รวมรายได้"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightCoral
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(12, 318)
        Me.Label6.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 30)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "หักค่าลดหย่อน"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightCoral
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(12, 359)
        Me.Label7.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 30)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "ภาษีต้องชำระ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightCoral
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(12, 148)
        Me.Label8.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 30)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "ยอดขายทั้งปี"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightCoral
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(12, 106)
        Me.Label9.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 30)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "เงินเดือน"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCalTax
        '
        Me.btnCalTax.Location = New System.Drawing.Point(334, 273)
        Me.btnCalTax.Name = "btnCalTax"
        Me.btnCalTax.Size = New System.Drawing.Size(200, 116)
        Me.btnCalTax.TabIndex = 24
        Me.btnCalTax.Text = "คำนวณ"
        Me.btnCalTax.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radLongDate)
        Me.GroupBox1.Controls.Add(Me.radGenDate)
        Me.GroupBox1.Controls.Add(Me.radShortDate)
        Me.GroupBox1.Location = New System.Drawing.Point(334, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแบบวันที่"
        '
        'radLongDate
        '
        Me.radLongDate.AutoSize = True
        Me.radLongDate.Location = New System.Drawing.Point(7, 73)
        Me.radLongDate.Name = "radLongDate"
        Me.radLongDate.Size = New System.Drawing.Size(147, 21)
        Me.radLongDate.TabIndex = 2
        Me.radLongDate.TabStop = True
        Me.radLongDate.Text = "วันที่แบบ Long Date"
        Me.radLongDate.UseVisualStyleBackColor = True
        '
        'radGenDate
        '
        Me.radGenDate.AutoSize = True
        Me.radGenDate.Location = New System.Drawing.Point(7, 46)
        Me.radGenDate.Name = "radGenDate"
        Me.radGenDate.Size = New System.Drawing.Size(166, 21)
        Me.radGenDate.TabIndex = 1
        Me.radGenDate.TabStop = True
        Me.radGenDate.Text = "วันที่แบบ General Date"
        Me.radGenDate.UseVisualStyleBackColor = True
        '
        'radShortDate
        '
        Me.radShortDate.AutoSize = True
        Me.radShortDate.Location = New System.Drawing.Point(7, 22)
        Me.radShortDate.Name = "radShortDate"
        Me.radShortDate.Size = New System.Drawing.Size(149, 21)
        Me.radShortDate.TabIndex = 0
        Me.radShortDate.TabStop = True
        Me.radShortDate.Text = "วันที่แบบ Short Date"
        Me.radShortDate.UseVisualStyleBackColor = True
        '
        'frmLab4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalTax)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblAllowance)
        Me.Controls.Add(Me.lblAllIncome)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblYearSalary)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab4"
        Me.Text = "frmLab4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents lblYearSalary As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblAllIncome As Label
    Friend WithEvents lblAllowance As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalTax As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radLongDate As RadioButton
    Friend WithEvents radGenDate As RadioButton
    Friend WithEvents radShortDate As RadioButton
End Class
