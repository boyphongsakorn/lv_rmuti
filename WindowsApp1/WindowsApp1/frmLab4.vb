Public Class frmLab4
    Const decR_BONUS As Double = 0.2
    Const decR_ALLOW As Double = 0.01
    Const decR_TAX As Double = 0.07
    Dim datNowDate As Date = Date.Now
    Dim dblTax, dblBonus, dblYearSalary, dblAllowance, dblAllIncome As Single

    Private Sub RadGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = FormatDateTime(datNowDate, DateFormat.GeneralDate)
    End Sub

    Private Sub RadLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = FormatDateTime(datNowDate, DateFormat.LongDate)
    End Sub

    Private Sub RadShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = FormatDateTime(datNowDate, DateFormat.ShortDate)
    End Sub

    Private Sub frmLab4_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblDate.Text = datNowDate
    End Sub

    Private Sub BtnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        dblYearSalary = txtSalary.Text * 12
        dblBonus = (txtSale.Text * decR_BONUS)
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX

        lblYearSalary.Text = FormatNumber(dblYearSalary)
        lblBonus.Text = FormatNumber(dblBonus)
        lblAllIncome.Text = FormatNumber(dblAllIncome)
        lblAllowance.Text = FormatNumber(dblAllowance)
        lblTax.Text = FormatNumber(dblTax)
    End Sub
End Class