<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.showcate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvnorth = New System.Windows.Forms.DataGridView()
        CType(Me.dgvnorth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'showcate
        '
        Me.showcate.Location = New System.Drawing.Point(12, 12)
        Me.showcate.Name = "showcate"
        Me.showcate.Size = New System.Drawing.Size(140, 91)
        Me.showcate.TabIndex = 0
        Me.showcate.Text = "Button1"
        Me.showcate.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(158, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 91)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvnorth
        '
        Me.dgvnorth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnorth.Location = New System.Drawing.Point(12, 109)
        Me.dgvnorth.Name = "dgvnorth"
        Me.dgvnorth.RowHeadersWidth = 51
        Me.dgvnorth.RowTemplate.Height = 24
        Me.dgvnorth.Size = New System.Drawing.Size(742, 329)
        Me.dgvnorth.TabIndex = 2
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvnorth)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.showcate)
        Me.Name = "test"
        Me.Text = "test"
        CType(Me.dgvnorth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents showcate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvnorth As DataGridView
End Class
