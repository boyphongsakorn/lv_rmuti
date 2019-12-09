<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice5
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
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ราคาสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "จำนวน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "เป็นเงิน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ส่วนลด"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ราคาสิทธิ"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(84, 10)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 5
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(84, 53)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(100, 22)
        Me.txtUnit.TabIndex = 6
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(84, 107)
        Me.lblTotal.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblTotal.TabIndex = 7
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(84, 144)
        Me.lblDiscount.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 20)
        Me.lblDiscount.TabIndex = 8
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Location = New System.Drawing.Point(84, 185)
        Me.lblNet.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(100, 20)
        Me.lblNet.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(84, 229)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmPractice5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice5"
        Me.Text = "frmPractice5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents btnCalculate As Button
End Class
