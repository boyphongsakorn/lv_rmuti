<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice2
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
        Me.txtBath = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radUnLock = New System.Windows.Forms.RadioButton()
        Me.radLock = New System.Windows.Forms.RadioButton()
        Me.radUs = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radKorea = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณอัตราแลกเปลี่ยน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เงินไทย"
        '
        'txtBath
        '
        Me.txtBath.Location = New System.Drawing.Point(83, 56)
        Me.txtBath.Name = "txtBath"
        Me.txtBath.Size = New System.Drawing.Size(100, 22)
        Me.txtBath.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radUnLock)
        Me.GroupBox1.Controls.Add(Me.radLock)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'radUnLock
        '
        Me.radUnLock.AutoSize = True
        Me.radUnLock.Location = New System.Drawing.Point(16, 73)
        Me.radUnLock.Name = "radUnLock"
        Me.radUnLock.Size = New System.Drawing.Size(77, 21)
        Me.radUnLock.TabIndex = 8
        Me.radUnLock.TabStop = True
        Me.radUnLock.Text = "UnLock"
        Me.radUnLock.UseVisualStyleBackColor = True
        '
        'radLock
        '
        Me.radLock.AutoSize = True
        Me.radLock.Location = New System.Drawing.Point(16, 34)
        Me.radLock.Name = "radLock"
        Me.radLock.Size = New System.Drawing.Size(59, 21)
        Me.radLock.TabIndex = 7
        Me.radLock.TabStop = True
        Me.radLock.Text = "Lock"
        Me.radLock.UseVisualStyleBackColor = True
        '
        'radUs
        '
        Me.radUs.AutoSize = True
        Me.radUs.Location = New System.Drawing.Point(16, 103)
        Me.radUs.Name = "radUs"
        Me.radUs.Size = New System.Drawing.Size(78, 21)
        Me.radUs.TabIndex = 4
        Me.radUs.TabStop = True
        Me.radUs.Text = "US (39)"
        Me.radUs.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(13, 131)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(103, 21)
        Me.radFrench.TabIndex = 5
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French (37)"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radKorea
        '
        Me.radKorea.AutoSize = True
        Me.radKorea.Location = New System.Drawing.Point(13, 159)
        Me.radKorea.Name = "radKorea"
        Me.radKorea.Size = New System.Drawing.Size(97, 21)
        Me.radKorea.TabIndex = 6
        Me.radKorea.TabStop = True
        Me.radKorea.Text = "Korea (30)"
        Me.radKorea.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "แลกได้"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(80, 225)
        Me.lblResult.MinimumSize = New System.Drawing.Size(100, 50)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 50)
        Me.lblResult.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(215, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "ปิด"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPractice2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 296)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.radKorea)
        Me.Controls.Add(Me.radFrench)
        Me.Controls.Add(Me.radUs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPractice2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBath As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radUnLock As RadioButton
    Friend WithEvents radLock As RadioButton
    Friend WithEvents radUs As RadioButton
    Friend WithEvents radFrench As RadioButton
    Friend WithEvents radKorea As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnExit As Button
End Class
