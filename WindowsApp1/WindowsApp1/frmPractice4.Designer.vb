<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice4
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProAmount = New System.Windows.Forms.TextBox()
        Me.lblProId = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.lblProTotal = New System.Windows.Forms.Label()
        Me.radProCash = New System.Windows.Forms.RadioButton()
        Me.radProCredit = New System.Windows.Forms.RadioButton()
        Me.lblProNet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ราคาต่อหน่วย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "จำนวน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "การชำระเงิน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ยอดชำระ"
        '
        'txtProAmount
        '
        Me.txtProAmount.Location = New System.Drawing.Point(108, 133)
        Me.txtProAmount.MinimumSize = New System.Drawing.Size(150, 4)
        Me.txtProAmount.Name = "txtProAmount"
        Me.txtProAmount.Size = New System.Drawing.Size(150, 22)
        Me.txtProAmount.TabIndex = 7
        '
        'lblProId
        '
        Me.lblProId.AutoSize = True
        Me.lblProId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProId.Location = New System.Drawing.Point(105, 25)
        Me.lblProId.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblProId.Name = "lblProId"
        Me.lblProId.Size = New System.Drawing.Size(150, 20)
        Me.lblProId.TabIndex = 8
        '
        'lblProName
        '
        Me.lblProName.AutoSize = True
        Me.lblProName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProName.Location = New System.Drawing.Point(106, 61)
        Me.lblProName.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(150, 20)
        Me.lblProName.TabIndex = 9
        '
        'lblProPrice
        '
        Me.lblProPrice.AutoSize = True
        Me.lblProPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProPrice.Location = New System.Drawing.Point(109, 102)
        Me.lblProPrice.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(150, 20)
        Me.lblProPrice.TabIndex = 10
        '
        'lblProTotal
        '
        Me.lblProTotal.AutoSize = True
        Me.lblProTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProTotal.Location = New System.Drawing.Point(109, 189)
        Me.lblProTotal.MinimumSize = New System.Drawing.Size(150, 20)
        Me.lblProTotal.Name = "lblProTotal"
        Me.lblProTotal.Size = New System.Drawing.Size(150, 20)
        Me.lblProTotal.TabIndex = 11
        '
        'radProCash
        '
        Me.radProCash.AutoSize = True
        Me.radProCash.Location = New System.Drawing.Point(105, 224)
        Me.radProCash.Name = "radProCash"
        Me.radProCash.Size = New System.Drawing.Size(63, 21)
        Me.radProCash.TabIndex = 12
        Me.radProCash.TabStop = True
        Me.radProCash.Text = "เงินสด"
        Me.radProCash.UseVisualStyleBackColor = True
        '
        'radProCredit
        '
        Me.radProCredit.AutoSize = True
        Me.radProCredit.Location = New System.Drawing.Point(174, 227)
        Me.radProCredit.Name = "radProCredit"
        Me.radProCredit.Size = New System.Drawing.Size(67, 21)
        Me.radProCredit.TabIndex = 13
        Me.radProCredit.TabStop = True
        Me.radProCredit.Text = "เงินเชื่อ"
        Me.radProCredit.UseVisualStyleBackColor = True
        '
        'lblProNet
        '
        Me.lblProNet.AutoSize = True
        Me.lblProNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProNet.Location = New System.Drawing.Point(109, 276)
        Me.lblProNet.MinimumSize = New System.Drawing.Size(150, 40)
        Me.lblProNet.Name = "lblProNet"
        Me.lblProNet.Size = New System.Drawing.Size(150, 40)
        Me.lblProNet.TabIndex = 14
        '
        'frmPractice4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 554)
        Me.Controls.Add(Me.lblProNet)
        Me.Controls.Add(Me.radProCredit)
        Me.Controls.Add(Me.radProCash)
        Me.Controls.Add(Me.lblProTotal)
        Me.Controls.Add(Me.lblProPrice)
        Me.Controls.Add(Me.lblProName)
        Me.Controls.Add(Me.lblProId)
        Me.Controls.Add(Me.txtProAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPractice4"
        Me.Text = "frmPractice4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProAmount As TextBox
    Friend WithEvents lblProId As Label
    Friend WithEvents lblProName As Label
    Friend WithEvents lblProPrice As Label
    Friend WithEvents lblProTotal As Label
    Friend WithEvents radProCash As RadioButton
    Friend WithEvents radProCredit As RadioButton
    Friend WithEvents lblProNet As Label
End Class
