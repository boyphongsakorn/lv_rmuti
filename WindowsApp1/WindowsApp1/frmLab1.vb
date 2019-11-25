Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sellprice As Double
        Dim sellcount As Double
        Dim sellsum As Double
        Dim peoplecount As Double
        Dim percount As Double
        Dim countsum As Double
        Dim exchange As Double
        sellprice = txt_sp.Text
        sellcount = txt_sc.Text
        sellsum = sellprice * sellcount
        txt_p.Text = sellsum
        peoplecount = txt_mwc.Text
        percount = txt_s.Text
        countsum = peoplecount * percount
        txt_ss.Text = countsum
        exchange = sellsum - countsum
        txt_ex.Text = exchange
    End Sub
End Class
