Public Class frmPractice5
    Dim decTotal, decDiscount, decNet As Decimal

    Private Sub TxtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        Call btnCalculate_Click(sender, e)
    End Sub

    Private Sub TxtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        Call btnCalculate_Click(sender, e)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)

        If decTotal < 1000 Then
            decDiscount = 0
        ElseIf decTotal < 5000 Then
            decDiscount = 300
        ElseIf decTotal < 10000 Then
            decDiscount = 500
        Else
            decDiscount = 1000
        End If

        decNet = decTotal - decDiscount
        lblTotal.Text = FormatNumber(decTotal)
        lblDiscount.Text = FormatNumber(decDiscount)
        lblNet.Text = FormatNumber(decNet)
    End Sub
End Class