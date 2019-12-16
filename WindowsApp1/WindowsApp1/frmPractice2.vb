Public Class frmPractice2
    Private Sub radUs_Click(sender As Object, e As EventArgs) Handles radUs.Click
        lblResult.Text = Val(txtBath.Text) / 39
    End Sub

    Private Sub radFrench_Click(sender As Object, e As EventArgs) Handles radFrench.Click
        lblResult.Text = Val(txtBath.Text) / 37
    End Sub

    Private Sub radKorea_Click(sender As Object, e As EventArgs) Handles radKorea.Click
        lblResult.Text = Val(txtBath.Text) / 30
    End Sub

    Private Sub radLock_Click(sender As Object, e As EventArgs) Handles radLock.Click
        txtBath.Enabled = False
        radUs.Enabled = False
        radFrench.Enabled = False
        radKorea.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class