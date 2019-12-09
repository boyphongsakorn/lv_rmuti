Public Class frmLab5
    Dim decSumSale, decDiscount, decGrant, decCredit As Single

    Private Sub radCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles radCustomer.CheckedChanged
        lblDiscount.Text = ""
        lblGrant.Text = ""
        lblCredit.Text = ""
        gpbPaid.Enabled = True 'ถ้าเป็น ลูกค้าภายใน ให้กรอบชำระเงินใช้ได้'
    End Sub

    Private Sub radNone_CheckedChanged(sender As Object, e As EventArgs) Handles radNone.CheckedChanged
        lblDiscount.Text = ""
        lblGrant.Text = ""
        lblCredit.Text = ""
        radCash.Focus() 'ภายนอก บังคับให้ตัวเลือกการชำระเงินเป็นแบบ สด'
        gpbPaid.Enabled = False 'ถ้าเป็น ลูกค้าภายนอก ให้กรอบชำระเงินใช้งานไม่ได้'
    End Sub

    Private Sub radCash_CheckedChanged(sender As Object, e As EventArgs) Handles radCash.CheckedChanged
        lblDiscount.Text = ""
        lblGrant.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged
        lblDiscount.Text = ""
        lblGrant.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub txtProAmount_TextChanged(sender As Object, e As EventArgs) Handles txtProAmount.TextChanged
        lblSumSale.Text = Val(txtProPrice.Text) * Val(txtProAmount.Text)
        decSumSale = lblSumSale.Text
    End Sub

    Private Sub txtProPrice_TextChanged(sender As Object, e As EventArgs) Handles txtProPrice.TextChanged
        Call txtProAmount_TextChanged(sender, e)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If (txtProduct.Text = "" Or txtProPrice.Text = "" Or txtProAmount.Text = "") Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
            Exit Sub
        End If

        If (radCustomer.Checked = True And radCash.Checked = True) Then 'ถ้า เป็นลูกค้า ภายใน และ จ่ายเงินสด'

            If (Val(lblSumSale.Text) < 2500) Then
                decDiscount = decSumSale * 0
            ElseIf (Val(lblSumSale.Text) < 10000) Then
                decDiscount = decSumSale * 0.1
            ElseIf (Val(lblSumSale.Text) < 20000) Then
                decDiscount = decSumSale * 0.15
            ElseIf (Val(lblSumSale.Text) >= 20000) Then
                decDiscount = decSumSale * 0.2
            End If
            lblDiscount.Text = decDiscount
            decGrant = decSumSale - decDiscount
        Else 'ถ้าไม่ได้เป็นลูกค้า ภายใน และ จ่ายเงินสด'
            decGrant = decSumSale
        End If

        If (radCash.Checked = True) Then 'ถ้าเลือกเป็น เงินสด'
            decCredit = 0
        Else 'ถ้าไม่ได้เลือกเป็น เงินสด'
            decCredit = decSumSale
        End If

        lblCredit.Text = decCredit
        lblGrant.Text = decGrant
    End Sub
End Class