<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice6
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
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtMidterm = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.txtLabScore = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSumScore = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อนักศึกษา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "คะแนนเก็บ (40)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "คะแนนกลางภาค (30)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "คะแนนปลายภาค (30)"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(184, 71)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(213, 22)
        Me.txtStudentName.TabIndex = 5
        '
        'txtMidterm
        '
        Me.txtMidterm.Location = New System.Drawing.Point(184, 179)
        Me.txtMidterm.Name = "txtMidterm"
        Me.txtMidterm.Size = New System.Drawing.Size(100, 22)
        Me.txtMidterm.TabIndex = 6
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(185, 230)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(100, 22)
        Me.txtFinal.TabIndex = 7
        '
        'txtLabScore
        '
        Me.txtLabScore.Location = New System.Drawing.Point(185, 125)
        Me.txtLabScore.Name = "txtLabScore"
        Me.txtLabScore.Size = New System.Drawing.Size(100, 22)
        Me.txtLabScore.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 75)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "btnCalculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "คะแนนรวม (100)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(190, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "เกรดที่ได้"
        '
        'lblSumScore
        '
        Me.lblSumScore.AutoSize = True
        Me.lblSumScore.Location = New System.Drawing.Point(304, 280)
        Me.lblSumScore.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblSumScore.Name = "lblSumScore"
        Me.lblSumScore.Size = New System.Drawing.Size(100, 20)
        Me.lblSumScore.TabIndex = 12
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(304, 311)
        Me.lblGrade.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblGrade.TabIndex = 13
        '
        'frmPractice6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblSumScore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtLabScore)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtMidterm)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice6"
        Me.Text = "frmPractice6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtMidterm As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents txtLabScore As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSumScore As Label
    Friend WithEvents lblGrade As Label
End Class
