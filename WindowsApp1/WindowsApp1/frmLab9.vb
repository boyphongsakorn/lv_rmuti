Public Class frmLab9
    Dim allScore, allCredit As Double
    Dim NewGrade As Double
    Function proCalNewData()
        Dim i As Integer = 0
        Dim Grade, NewCredit As Decimal
        Do Until i > lstCredit.Items.Count - 1
            NewCredit = lstCredit.Items(i)
            i += 1
        Loop
        Grade = NewGrade * NewCredit
        allScore = allScore + Grade
        allCredit = allCredit + NewCredit
        lblNewGPA.Text = FormatNumber(allScore / allCredit)
    End Function
    Function getCalNewGrade(a As Decimal) As String
        If a >= 80 And a <= 100 Then
            lstGrade.Items.Add("A")
            NewGrade = 4
        ElseIf a >= 75 And a <= 79 Then
            lstGrade.Items.Add("B+")
            NewGrade = 3.5
        ElseIf a >= 70 And a <= 74 Then
            lstGrade.Items.Add("B")
            NewGrade = 3
        ElseIf a >= 65 And a <= 69 Then
            lstGrade.Items.Add("C+")
            NewGrade = 2.5
        ElseIf a >= 60 And a <= 64 Then
            lstGrade.Items.Add("C")
            NewGrade = 2
        ElseIf a >= 55 And a <= 59 Then
            lstGrade.Items.Add("D+")
            NewGrade = 1.5
        ElseIf a >= 50 And a <= 54 Then
            lstGrade.Items.Add("D")
            NewGrade = 1
        Else
            lstGrade.Items.Add("F")
            NewGrade = 0
        End If
    End Function
    Function getCalNewGPA(a As Double, b As Double)
        lblOldGPA.Text = FormatNumber(a / b)
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCourse.Text.Trim = "" And txtCredit.Text.Trim = "" And txtScore.Text.Trim = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่ครบ")
            Exit Sub
        Else
            lstCourse.Items.Add(txtCourse.Text)
            lstScore.Items.Add(txtScore.Text)
            lstCredit.Items.Add(txtCredit.Text)
            getCalNewGrade(txtScore.Text)
            proCalNewData()
            txtCourse.Text = ""
            txtCredit.Text = ""
            txtScore.Text = ""
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstCourse.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
        lstScore.Items.Clear()
        allScore = 0
        allCredit = 0
        txtCourse.Text = ""
        txtCredit.Text = ""
        txtScore.Text = ""
        lblNewGPA.Text = ""
        Call frmLab9_Load(sender, e)
    End Sub

    Private Sub frmLab9_Load(sender As Object, e As EventArgs) Handles Me.Load
        allScore = 150
        allCredit = 50
        lblAllScore.Text = allScore
        lblAllCredit.Text = allCredit
        getCalNewGPA(allScore, allCredit)
    End Sub

    Private Sub lstCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourse.SelectedIndexChanged
        lstCredit.SelectedIndex = lstCourse.SelectedIndex
        lstGrade.SelectedIndex = lstCourse.SelectedIndex
        lstScore.SelectedIndex = lstCourse.SelectedIndex
    End Sub
End Class