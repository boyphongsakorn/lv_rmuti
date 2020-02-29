Public Class FrmLab10

    Dim decArrSale(5, 2), decMaxsale, decSumsaleA, decSumsaleB, decSumsaleC As Decimal

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsNumeric(txtSaleA.Text) And IsNumeric(txtSaleB.Text) And IsNumeric(txtSaleC.Text) Then
            strEmpName(cboIndex.SelectedIndex) = txtEmpName.Text
            decArrSale(cboIndex.SelectedIndex, 0) = Val(txtSaleA.Text)
            decArrSale(cboIndex.SelectedIndex, 1) = Val(txtSaleB.Text)
            decArrSale(cboIndex.SelectedIndex, 2) = Val(txtSaleC.Text)
            displaySaleData()
        Else
            MessageBox.Show("กรุณาป้อนข้อมูลยอดขายเป็นตัวเลขเท่านั้น", "คำเตือน")
            Exit Sub

        End If

        txtEmpName.Text = ""
        txtSaleA.Text = ""
        txtSaleB.Text = ""
        txtSaleC.Text = ""
    End Sub

    Dim strEmpName(5) As String
    Dim i, intIndexMax As Integer
    Private Sub frmLAB10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboIndex.SelectedIndex = 0
    End Sub
    Private Sub displaySaleData()
        Dim empSale(5) As Decimal
        decSumsaleA = decArrSale(0, 0) + decArrSale(1, 0) + decArrSale(2, 0) + decArrSale(3, 0) + decArrSale(4, 0) + decArrSale(5, 0)
        decSumsaleB = decArrSale(0, 1) + decArrSale(1, 1) + decArrSale(2, 1) + decArrSale(3, 1) + decArrSale(4, 1) + decArrSale(5, 1)
        decSumsaleC = decArrSale(0, 2) + decArrSale(1, 2) + decArrSale(2, 2) + decArrSale(3, 2) + decArrSale(4, 2) + decArrSale(5, 2)
        decMaxsale = empSale(0)
        lstSaleInfo.Items.Clear()

        For i = 0 To strEmpName.Length - 1
            lstSaleInfo.Items.Add(strEmpName(i) & "," & decArrSale(i, 0) & "," & decArrSale(i, 1) & "," & decArrSale(i, 2))
            empSale(i) = decArrSale(i, 0) + decArrSale(i, 1) + decArrSale(i, 2)
            If empSale(i) > decMaxsale Then
                decMaxsale = empSale(i)
                intIndexMax = i

            End If

        Next
        lblSumSaleA.Text = FormatNumber(decSumsaleA)
        lblSumSaleB.Text = FormatNumber(decSumsaleB)
        lblSumSaleC.Text = FormatNumber(decSumsaleC)
        lblMaxEmpSale.Text = strEmpName(intIndexMax)
        lblMaxSale.Text = FormatNumber(decMaxsale)
    End Sub
End Class