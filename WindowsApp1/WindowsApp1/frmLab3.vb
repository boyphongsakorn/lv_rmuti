Public Class frmLab3
    Private Sub LblFRed_Click(sender As Object, e As EventArgs) Handles lblFRed.Click
        txtInput.ForeColor = Color.Red
    End Sub

    Private Sub LblFBlue_Click(sender As Object, e As EventArgs) Handles lblFBlue.Click
        txtInput.ForeColor = Color.Blue
    End Sub

    Private Sub LblFGreen_Click(sender As Object, e As EventArgs) Handles lblFGreen.Click
        txtInput.ForeColor = Color.Green
    End Sub

    Private Sub LblFViolet_Click(sender As Object, e As EventArgs) Handles lblFViolet.Click
        txtInput.ForeColor = Color.Violet
    End Sub

    Private Sub LblFBlack_Click(sender As Object, e As EventArgs) Handles lblFBlack.Click
        txtInput.ForeColor = Color.Black
    End Sub

    Private Sub LblFOrange_Click(sender As Object, e As EventArgs) Handles lblFOrange.Click
        txtInput.ForeColor = Color.Orange
    End Sub

    Private Sub LblFYellow_Click(sender As Object, e As EventArgs) Handles lblFYellow.Click
        txtInput.ForeColor = Color.Yellow
    End Sub

    Private Sub LblFBrown_Click(sender As Object, e As EventArgs) Handles lblFBrown.Click
        txtInput.ForeColor = Color.Brown
    End Sub

    Private Sub LblFWhite_Click(sender As Object, e As EventArgs) Handles lblFWhite.Click
        txtInput.ForeColor = Color.White
    End Sub

    Private Sub LblFSky_Click(sender As Object, e As EventArgs) Handles lblFSky.Click
        txtInput.ForeColor = Color.SkyBlue
    End Sub

    Private Sub LblBRed_Click(sender As Object, e As EventArgs) Handles lblBRed.Click
        txtInput.BackColor = Color.Red
    End Sub

    Private Sub LblBBlue_Click(sender As Object, e As EventArgs) Handles lblBBlue.Click
        txtInput.BackColor = Color.Blue
    End Sub

    Private Sub LblBGreen_Click(sender As Object, e As EventArgs) Handles lblBGreen.Click
        txtInput.BackColor = Color.Green
    End Sub

    Private Sub LblBViolet_Click(sender As Object, e As EventArgs) Handles lblBViolet.Click
        txtInput.BackColor = Color.Violet
    End Sub

    Private Sub LblBBlack_Click(sender As Object, e As EventArgs) Handles lblBBlack.Click
        txtInput.BackColor = Color.Black
    End Sub

    Private Sub LblBOrange_Click(sender As Object, e As EventArgs) Handles lblBOrange.Click
        txtInput.BackColor = Color.Orange
    End Sub

    Private Sub LblBYellow_Click(sender As Object, e As EventArgs) Handles lblBYellow.Click
        txtInput.BackColor = Color.Yellow
    End Sub

    Private Sub LblBBrown_Click(sender As Object, e As EventArgs) Handles lblBBrown.Click
        txtInput.BackColor = Color.Brown
    End Sub

    Private Sub LblBWhite_Click(sender As Object, e As EventArgs) Handles lblBWhite.Click
        txtInput.BackColor = Color.White
    End Sub

    Private Sub LblBSky_Click(sender As Object, e As EventArgs) Handles lblBSky.Click
        txtInput.BackColor = Color.SkyBlue
    End Sub

    Private Sub BthUp_Click(sender As Object, e As EventArgs) Handles bthUp.Click
        If IsNumeric(txtInput.Text) Then
            txtInput.Text = txtInput.Text + 2
        Else
            txtInput.Text = 0
        End If
    End Sub

    Private Sub BthDown_Click(sender As Object, e As EventArgs) Handles bthDown.Click
        If IsNumeric(txtInput.Text) Then
            txtInput.Text = txtInput.Text - 2
        Else
            txtInput.Text = 0
        End If
    End Sub

    Private Sub cboSize_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSize.SelectedValueChanged
        txtInput.Font = New Font("Microsoft Sans Serif", cboSize.SelectedItem, FontStyle.Regular)
    End Sub
End Class