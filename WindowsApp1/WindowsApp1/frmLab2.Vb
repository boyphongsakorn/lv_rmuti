Public Class frmLab2
    Private Sub RadSalaryYear_CheckedChanged(sender As Object, e As EventArgs) Handles radSalaryYear.CheckedChanged
        lblOutput.Text = txtSalary.Text * 12
    End Sub

    Private Sub RadBonus_CheckedChanged(sender As Object, e As EventArgs) Handles radBonus.CheckedChanged
        lblOutput.Text = txtSale.Text * 0.2
    End Sub

    Private Sub RadIncome_CheckedChanged(sender As Object, e As EventArgs) Handles radIncome.CheckedChanged
        lblOutput.Text = (txtSalary.Text * 12) + (txtSale.Text * 0.2)
    End Sub

    Private Sub RadTax_CheckedChanged(sender As Object, e As EventArgs) Handles radTax.CheckedChanged
        lblOutput.Text = ((txtSalary.Text * 12) + (txtSale.Text * 0.2)) * 0.07
    End Sub

    Private Sub RadShow_CheckedChanged(sender As Object, e As EventArgs) Handles radShow.CheckedChanged
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        GroupBox3.Visible = True
        lblOutput.Visible = True
        txtSalary.Visible = True
        txtSale.Visible = True
    End Sub

    Private Sub RadHide_CheckedChanged(sender As Object, e As EventArgs) Handles radHide.CheckedChanged
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        GroupBox3.Visible = False
        lblOutput.Visible = False
        txtSalary.Visible = False
        txtSale.Visible = False
    End Sub

    Private Sub RadUse_CheckedChanged(sender As Object, e As EventArgs) Handles radUse.CheckedChanged
        Label1.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
        GroupBox3.Enabled = True
        lblOutput.Enabled = True
        txtSalary.Enabled = True
        txtSale.Enabled = True
    End Sub

    Private Sub RadProtect_CheckedChanged(sender As Object, e As EventArgs) Handles radProtect.CheckedChanged
        Label1.Enabled = False
        Label2.Enabled = False
        Label3.Enabled = False
        GroupBox3.Enabled = False
        lblOutput.Enabled = False
        txtSalary.Enabled = False
        txtSale.Enabled = False
    End Sub

    Private Sub BntRestart_Click(sender As Object, e As EventArgs) Handles bntRestart.Click
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        GroupBox3.Visible = True
        lblOutput.Visible = True
        txtSalary.Visible = True
        txtSale.Visible = True
        Label1.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
        GroupBox3.Enabled = True
        lblOutput.Enabled = True
        txtSalary.Enabled = True
        txtSale.Enabled = True
    End Sub
End Class