<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab5
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radCustomer = New System.Windows.Forms.RadioButton()
        Me.gpbPaid = New System.Windows.Forms.GroupBox()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtProPrice = New System.Windows.Forms.TextBox()
        Me.txtProAmount = New System.Windows.Forms.TextBox()
        Me.lblSumSale = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblGrant = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gpbPaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Chartreuse
        Me.GroupBox1.Controls.Add(Me.radNone)
        Me.GroupBox1.Controls.Add(Me.radCustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "กลุ่มลูกค้า"
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(73, 25)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(74, 21)
        Me.radNone.TabIndex = 1
        Me.radNone.TabStop = True
        Me.radNone.Text = "ภายนอก"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'radCustomer
        '
        Me.radCustomer.AutoSize = True
        Me.radCustomer.Location = New System.Drawing.Point(6, 25)
        Me.radCustomer.Name = "radCustomer"
        Me.radCustomer.Size = New System.Drawing.Size(65, 21)
        Me.radCustomer.TabIndex = 0
        Me.radCustomer.TabStop = True
        Me.radCustomer.Text = "ภายใน"
        Me.radCustomer.UseVisualStyleBackColor = True
        '
        'gpbPaid
        '
        Me.gpbPaid.BackColor = System.Drawing.Color.Chartreuse
        Me.gpbPaid.Controls.Add(Me.radCredit)
        Me.gpbPaid.Controls.Add(Me.radCash)
        Me.gpbPaid.Enabled = False
        Me.gpbPaid.Location = New System.Drawing.Point(169, 162)
        Me.gpbPaid.Name = "gpbPaid"
        Me.gpbPaid.Size = New System.Drawing.Size(148, 57)
        Me.gpbPaid.TabIndex = 1
        Me.gpbPaid.TabStop = False
        Me.gpbPaid.Text = "การชำระเงิน"
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Location = New System.Drawing.Point(66, 25)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(64, 21)
        Me.radCredit.TabIndex = 3
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เครคิต"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Location = New System.Drawing.Point(6, 25)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(44, 21)
        Me.radCash.TabIndex = 2
        Me.radCash.TabStop = True
        Me.radCash.Text = "สด"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ชื่อสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ราคา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "จำนวน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "เป็นเงิน"
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(117, 10)
        Me.txtProduct.MinimumSize = New System.Drawing.Size(200, 30)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(200, 22)
        Me.txtProduct.TabIndex = 6
        '
        'txtProPrice
        '
        Me.txtProPrice.Location = New System.Drawing.Point(217, 46)
        Me.txtProPrice.MinimumSize = New System.Drawing.Size(100, 30)
        Me.txtProPrice.Name = "txtProPrice"
        Me.txtProPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtProPrice.TabIndex = 7
        '
        'txtProAmount
        '
        Me.txtProAmount.Location = New System.Drawing.Point(217, 82)
        Me.txtProAmount.MinimumSize = New System.Drawing.Size(100, 30)
        Me.txtProAmount.Name = "txtProAmount"
        Me.txtProAmount.Size = New System.Drawing.Size(100, 22)
        Me.txtProAmount.TabIndex = 8
        '
        'lblSumSale
        '
        Me.lblSumSale.AutoSize = True
        Me.lblSumSale.BackColor = System.Drawing.Color.White
        Me.lblSumSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumSale.Location = New System.Drawing.Point(217, 118)
        Me.lblSumSale.MinimumSize = New System.Drawing.Size(100, 30)
        Me.lblSumSale.Name = "lblSumSale"
        Me.lblSumSale.Size = New System.Drawing.Size(100, 30)
        Me.lblSumSale.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "จำนวนเงินต้องชำระ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ยอดค้างชำระ"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BackColor = System.Drawing.Color.White
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(216, 233)
        Me.lblDiscount.MinimumSize = New System.Drawing.Size(100, 30)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 30)
        Me.lblDiscount.TabIndex = 13
        '
        'lblGrant
        '
        Me.lblGrant.AutoSize = True
        Me.lblGrant.BackColor = System.Drawing.Color.White
        Me.lblGrant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrant.Location = New System.Drawing.Point(217, 270)
        Me.lblGrant.MinimumSize = New System.Drawing.Size(100, 30)
        Me.lblGrant.Name = "lblGrant"
        Me.lblGrant.Size = New System.Drawing.Size(100, 30)
        Me.lblGrant.TabIndex = 14
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.BackColor = System.Drawing.Color.White
        Me.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCredit.Location = New System.Drawing.Point(217, 308)
        Me.lblCredit.MinimumSize = New System.Drawing.Size(100, 30)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(100, 30)
        Me.lblCredit.TabIndex = 15
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(217, 346)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 23)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmLab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblGrant)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblSumSale)
        Me.Controls.Add(Me.txtProAmount)
        Me.Controls.Add(Me.txtProPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpbPaid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLab5"
        Me.Text = "frmLab5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbPaid.ResumeLayout(False)
        Me.gpbPaid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gpbPaid As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtProPrice As TextBox
    Friend WithEvents txtProAmount As TextBox
    Friend WithEvents lblSumSale As Label
    Friend WithEvents radNone As RadioButton
    Friend WithEvents radCustomer As RadioButton
    Friend WithEvents radCredit As RadioButton
    Friend WithEvents radCash As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblGrant As Label
    Friend WithEvents lblCredit As Label
    Friend WithEvents btnCalculate As Button
End Class
