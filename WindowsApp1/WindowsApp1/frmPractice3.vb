Public Class frmPractice3
    Private Sub Lab3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab3ToolStripMenuItem.Click
        Dim Lab3 As frmLab3 = New frmLab3
        Lab3.Show()
    End Sub

    Private Sub Lab1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab1ToolStripMenuItem.Click
        Dim Lab1 As Form1 = New Form1
        Lab1.Show()
    End Sub

    Private Sub Lab2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab2ToolStripMenuItem.Click
        Dim Lab2 As frmLab2 = New frmLab2
        Lab2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("WOW")
    End Sub

    Private Sub Lab4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab4ToolStripMenuItem.Click
        Dim Lab4 As frmLab4 = New frmLab4
        Lab4.Show()
    End Sub

    Private Sub Practice5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Practice5ToolStripMenuItem.Click
        Dim Practice5 As frmPractice5 = New frmPractice5
        Practice5.Show()
    End Sub

    Private Sub Lab5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab5ToolStripMenuItem.Click
        Dim Lab5 As frmLab5 = New frmLab5
        Lab5.Show()
    End Sub

    Private Sub Practice2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Practice2ToolStripMenuItem.Click
        Dim Practice2 As frmPractice2 = New frmPractice2
        Practice2.Show()
    End Sub

    Private Sub Lab6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab6ToolStripMenuItem.Click
        Dim Lab6 As frmLab6 = New frmLab6
        Lab6.Show()
    End Sub

    Private Sub Lab7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab7ToolStripMenuItem.Click
        Dim Lab7 As frmLab7 = New frmLab7
        Lab7.Show()
    End Sub

    Private Sub Practice6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Practice6ToolStripMenuItem.Click
        frmPractice6.Show()
    End Sub

    Private Sub frmPractice3_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        Label1.Location = New Point((Me.Size.Width / 2) - 188.5, (Me.Size.Height / 2) - 55)

    End Sub

    Private Sub Lab9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab9ToolStripMenuItem.Click
        frmLab9.Show()
    End Sub

    Private Sub frmPractice3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = System.Net.Dns.GetHostName + Environment.NewLine + Label1.Text
    End Sub

    Private Sub Lab11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab11ToolStripMenuItem.Click
        frmLab11.Show()
    End Sub
End Class