<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab13
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
        Me.radAll = New System.Windows.Forms.RadioButton()
        Me.radOrderID = New System.Windows.Forms.RadioButton()
        Me.cboOrderID = New System.Windows.Forms.ComboBox()
        Me.radCompanyName = New System.Windows.Forms.RadioButton()
        Me.cboCompanyName = New System.Windows.Forms.ComboBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.crvData = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptLab151 = New WindowsApp1.rptLab15()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายงานข้อมูลการสั่งซื้อสินค้า"
        '
        'radAll
        '
        Me.radAll.AutoSize = True
        Me.radAll.Checked = True
        Me.radAll.Location = New System.Drawing.Point(9, 37)
        Me.radAll.Margin = New System.Windows.Forms.Padding(2)
        Me.radAll.Name = "radAll"
        Me.radAll.Size = New System.Drawing.Size(65, 17)
        Me.radAll.TabIndex = 1
        Me.radAll.TabStop = True
        Me.radAll.Text = "ดูทั้งหมด"
        Me.radAll.UseVisualStyleBackColor = True
        '
        'radOrderID
        '
        Me.radOrderID.AutoSize = True
        Me.radOrderID.Location = New System.Drawing.Point(88, 37)
        Me.radOrderID.Margin = New System.Windows.Forms.Padding(2)
        Me.radOrderID.Name = "radOrderID"
        Me.radOrderID.Size = New System.Drawing.Size(143, 17)
        Me.radOrderID.TabIndex = 2
        Me.radOrderID.Text = "รายงานตามใบสั่งซื้อสินค้า"
        Me.radOrderID.UseVisualStyleBackColor = True
        '
        'cboOrderID
        '
        Me.cboOrderID.Enabled = False
        Me.cboOrderID.FormattingEnabled = True
        Me.cboOrderID.Location = New System.Drawing.Point(240, 36)
        Me.cboOrderID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboOrderID.Name = "cboOrderID"
        Me.cboOrderID.Size = New System.Drawing.Size(148, 21)
        Me.cboOrderID.TabIndex = 3
        '
        'radCompanyName
        '
        Me.radCompanyName.AutoSize = True
        Me.radCompanyName.Location = New System.Drawing.Point(407, 37)
        Me.radCompanyName.Margin = New System.Windows.Forms.Padding(2)
        Me.radCompanyName.Name = "radCompanyName"
        Me.radCompanyName.Size = New System.Drawing.Size(133, 17)
        Me.radCompanyName.TabIndex = 4
        Me.radCompanyName.Text = "รายงานตามบริษัทลูกค้า"
        Me.radCompanyName.UseVisualStyleBackColor = True
        '
        'cboCompanyName
        '
        Me.cboCompanyName.Enabled = False
        Me.cboCompanyName.FormattingEnabled = True
        Me.cboCompanyName.Location = New System.Drawing.Point(544, 36)
        Me.cboCompanyName.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCompanyName.Name = "cboCompanyName"
        Me.cboCompanyName.Size = New System.Drawing.Size(148, 21)
        Me.cboCompanyName.TabIndex = 5
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(705, 38)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(56, 19)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "รายงาน"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'crvData
        '
        Me.crvData.ActiveViewIndex = 0
        Me.crvData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvData.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvData.Location = New System.Drawing.Point(9, 66)
        Me.crvData.Margin = New System.Windows.Forms.Padding(2)
        Me.crvData.Name = "crvData"
        Me.crvData.ReportSource = Me.rptLab151
        Me.crvData.Size = New System.Drawing.Size(752, 335)
        Me.crvData.TabIndex = 7
        Me.crvData.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmLab13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 410)
        Me.Controls.Add(Me.crvData)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.cboCompanyName)
        Me.Controls.Add(Me.radCompanyName)
        Me.Controls.Add(Me.cboOrderID)
        Me.Controls.Add(Me.radOrderID)
        Me.Controls.Add(Me.radAll)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmLab13"
        Me.Text = "frmLab13"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radAll As RadioButton
    Friend WithEvents radOrderID As RadioButton
    Friend WithEvents cboOrderID As ComboBox
    Friend WithEvents radCompanyName As RadioButton
    Friend WithEvents cboCompanyName As ComboBox
    Friend WithEvents btnShow As Button
    Friend WithEvents crvData As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptLab151 As rptLab15
End Class
