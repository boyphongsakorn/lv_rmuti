﻿Public Class frmPractice3
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
End Class