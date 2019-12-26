<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab7
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.bthAddData = New System.Windows.Forms.Button()
        Me.bthClear = New System.Windows.Forms.Button()
        Me.txtAddData = New System.Windows.Forms.TextBox()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboTarget = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(36, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมควบคุม Listbox - ComboBox"
        '
        'lstData
        '
        Me.lstData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 25
        Me.lstData.Location = New System.Drawing.Point(17, 56)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(149, 154)
        Me.lstData.TabIndex = 1
        '
        'btnMove
        '
        Me.btnMove.BackColor = System.Drawing.SystemColors.Control
        Me.btnMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMove.Location = New System.Drawing.Point(178, 60)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(50, 50)
        Me.btnMove.TabIndex = 3
        Me.btnMove.Text = ">"
        Me.btnMove.UseVisualStyleBackColor = False
        '
        'btnMoveAll
        '
        Me.btnMoveAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnMoveAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMoveAll.Location = New System.Drawing.Point(178, 111)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(50, 50)
        Me.btnMoveAll.TabIndex = 4
        Me.btnMoveAll.Text = ">>"
        Me.btnMoveAll.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack.Location = New System.Drawing.Point(178, 160)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 50)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnBackAll
        '
        Me.btnBackAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnBackAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBackAll.Location = New System.Drawing.Point(178, 211)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(50, 50)
        Me.btnBackAll.TabIndex = 6
        Me.btnBackAll.Text = "<<"
        Me.btnBackAll.UseVisualStyleBackColor = False
        '
        'bthAddData
        '
        Me.bthAddData.Enabled = False
        Me.bthAddData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bthAddData.Location = New System.Drawing.Point(57, 216)
        Me.bthAddData.Name = "bthAddData"
        Me.bthAddData.Size = New System.Drawing.Size(75, 40)
        Me.bthAddData.TabIndex = 7
        Me.bthAddData.Text = "เพิ่ม"
        Me.bthAddData.UseVisualStyleBackColor = True
        '
        'bthClear
        '
        Me.bthClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bthClear.Location = New System.Drawing.Point(277, 221)
        Me.bthClear.Name = "bthClear"
        Me.bthClear.Size = New System.Drawing.Size(75, 40)
        Me.bthClear.TabIndex = 8
        Me.bthClear.Text = "เคลียร์"
        Me.bthClear.UseVisualStyleBackColor = True
        '
        'txtAddData
        '
        Me.txtAddData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAddData.Location = New System.Drawing.Point(41, 273)
        Me.txtAddData.Name = "txtAddData"
        Me.txtAddData.Size = New System.Drawing.Size(100, 30)
        Me.txtAddData.TabIndex = 9
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.BackColor = System.Drawing.Color.White
        Me.lblTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTarget.Location = New System.Drawing.Point(263, 276)
        Me.lblTarget.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(100, 27)
        Me.lblTarget.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.Location = New System.Drawing.Point(148, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 30)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "ปิดหน้าต่าง"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cboTarget
        '
        Me.cboTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboTarget.FormattingEnabled = True
        Me.cboTarget.Location = New System.Drawing.Point(242, 60)
        Me.cboTarget.Name = "cboTarget"
        Me.cboTarget.Size = New System.Drawing.Size(121, 33)
        Me.cboTarget.TabIndex = 12
        '
        'frmLab7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 350)
        Me.Controls.Add(Me.cboTarget)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.txtAddData)
        Me.Controls.Add(Me.bthClear)
        Me.Controls.Add(Me.bthAddData)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMoveAll)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab7"
        Me.Text = "frmLab7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstData As ListBox
    Friend WithEvents btnMove As Button
    Friend WithEvents btnMoveAll As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnBackAll As Button
    Friend WithEvents bthAddData As Button
    Friend WithEvents bthClear As Button
    Friend WithEvents txtAddData As TextBox
    Friend WithEvents lblTarget As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents cboTarget As ComboBox
End Class
