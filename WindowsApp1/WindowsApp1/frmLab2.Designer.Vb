<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab2
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
        Me.radHide = New System.Windows.Forms.RadioButton()
        Me.radShow = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radProtect = New System.Windows.Forms.RadioButton()
        Me.radUse = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radTax = New System.Windows.Forms.RadioButton()
        Me.radIncome = New System.Windows.Forms.RadioButton()
        Me.radBonus = New System.Windows.Forms.RadioButton()
        Me.radSalaryYear = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bntRestart = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radHide)
        Me.GroupBox1.Controls.Add(Me.radShow)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "การแสดงผล"
        '
        'radHide
        '
        Me.radHide.AutoSize = True
        Me.radHide.Location = New System.Drawing.Point(20, 57)
        Me.radHide.Name = "radHide"
        Me.radHide.Size = New System.Drawing.Size(53, 21)
        Me.radHide.TabIndex = 1
        Me.radHide.TabStop = True
        Me.radHide.Text = "ซ่อน"
        Me.radHide.UseVisualStyleBackColor = True
        '
        'radShow
        '
        Me.radShow.AutoSize = True
        Me.radShow.Location = New System.Drawing.Point(20, 22)
        Me.radShow.Name = "radShow"
        Me.radShow.Size = New System.Drawing.Size(87, 21)
        Me.radShow.TabIndex = 0
        Me.radShow.TabStop = True
        Me.radShow.Text = "มองเห็นได้"
        Me.radShow.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radProtect)
        Me.GroupBox2.Controls.Add(Me.radUse)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การใช้งาน"
        '
        'radProtect
        '
        Me.radProtect.AutoSize = True
        Me.radProtect.Location = New System.Drawing.Point(20, 60)
        Me.radProtect.Name = "radProtect"
        Me.radProtect.Size = New System.Drawing.Size(67, 21)
        Me.radProtect.TabIndex = 1
        Me.radProtect.TabStop = True
        Me.radProtect.Text = "ป้องกัน"
        Me.radProtect.UseVisualStyleBackColor = True
        '
        'radUse
        '
        Me.radUse.AutoSize = True
        Me.radUse.Location = New System.Drawing.Point(20, 22)
        Me.radUse.Name = "radUse"
        Me.radUse.Size = New System.Drawing.Size(79, 21)
        Me.radUse.TabIndex = 0
        Me.radUse.TabStop = True
        Me.radUse.Text = "ใข้งานได้"
        Me.radUse.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radTax)
        Me.GroupBox3.Controls.Add(Me.radIncome)
        Me.GroupBox3.Controls.Add(Me.radBonus)
        Me.GroupBox3.Controls.Add(Me.radSalaryYear)
        Me.GroupBox3.Location = New System.Drawing.Point(436, 178)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "การคำนวณ"
        '
        'radTax
        '
        Me.radTax.AutoSize = True
        Me.radTax.Location = New System.Drawing.Point(151, 60)
        Me.radTax.Name = "radTax"
        Me.radTax.Size = New System.Drawing.Size(52, 21)
        Me.radTax.TabIndex = 3
        Me.radTax.TabStop = True
        Me.radTax.Text = "ภาษี"
        Me.radTax.UseVisualStyleBackColor = True
        '
        'radIncome
        '
        Me.radIncome.AutoSize = True
        Me.radIncome.Location = New System.Drawing.Point(12, 60)
        Me.radIncome.Name = "radIncome"
        Me.radIncome.Size = New System.Drawing.Size(86, 21)
        Me.radIncome.TabIndex = 2
        Me.radIncome.TabStop = True
        Me.radIncome.Text = "รายได้รวม"
        Me.radIncome.UseVisualStyleBackColor = True
        '
        'radBonus
        '
        Me.radBonus.AutoSize = True
        Me.radBonus.Location = New System.Drawing.Point(151, 22)
        Me.radBonus.Name = "radBonus"
        Me.radBonus.Size = New System.Drawing.Size(59, 21)
        Me.radBonus.TabIndex = 1
        Me.radBonus.TabStop = True
        Me.radBonus.Text = "โบนัส"
        Me.radBonus.UseVisualStyleBackColor = True
        '
        'radSalaryYear
        '
        Me.radSalaryYear.AutoSize = True
        Me.radSalaryYear.Location = New System.Drawing.Point(12, 22)
        Me.radSalaryYear.Name = "radSalaryYear"
        Me.radSalaryYear.Size = New System.Drawing.Size(115, 21)
        Me.radSalaryYear.TabIndex = 0
        Me.radSalaryYear.TabStop = True
        Me.radSalaryYear.Text = "เงินเดือนทั้งหมด"
        Me.radSalaryYear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(445, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ผลลัพธ์"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(484, 38)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 22)
        Me.txtSalary.TabIndex = 4
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(484, 80)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(100, 22)
        Me.txtSale.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(409, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "เงินเดือน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ยอดขาย"
        '
        'bntRestart
        '
        Me.bntRestart.Location = New System.Drawing.Point(75, 324)
        Me.bntRestart.Name = "bntRestart"
        Me.bntRestart.Size = New System.Drawing.Size(75, 23)
        Me.bntRestart.TabIndex = 8
        Me.bntRestart.Text = "Restart"
        Me.bntRestart.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.Color.Red
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(532, 308)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(53, 19)
        Me.lblOutput.TabIndex = 9
        Me.lblOutput.Text = "Label4"
        '
        'frmLab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.bntRestart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLab2"
        Me.Text = "dw"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radHide As RadioButton
    Friend WithEvents radShow As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radProtect As RadioButton
    Friend WithEvents radUse As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radTax As RadioButton
    Friend WithEvents radIncome As RadioButton
    Friend WithEvents radBonus As RadioButton
    Friend WithEvents radSalaryYear As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bntRestart As Button
    Friend WithEvents lblOutput As Label
End Class
