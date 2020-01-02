Public Class frmPractice6
    Dim intSumScore As Integer
    Dim strGrade As String
    Dim drResult As DialogResult

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtStudentName.Text = txtStudentName.Text.Trim()
        If txtStudentName.Text.Length = 0 Then
            MessageBox.Show("ท่านไม่ไดป้้อนชื่อนกั ศึกษากรุณาป้อนใหเ้รียบรอ้ย", "Invalid Data", MessageBoxButtons.OK)
            Exit Sub
        ElseIf Not (IsNumeric(txtLabScore.Text) And IsNumeric(txtMidterm.Enabled) And IsNumeric(txtFinal.Text)) Then
            MessageBox.Show("ท่านป้ อนคะแนนบางรายการไม่เป็ นตัวเลข", "Invalid Data", MessageBoxButtons.OK)
            Exit Sub
        ElseIf Val(txtLabScore.Text) < 0 Or Val(txtLabScore.Text) > 40 Or Val(txtMidterm.Text) < 0 Or Val(txtMidterm.Text) > 30 Or Val(txtFinal.Text) < 0 Or Val(txtFinal.Text > 30) Then
            MessageBox.Show("ท่านป้อนคะแนนต า่ หรือสงูเกินเกณฑค์ ะแนนที่กา หนด", "Invalid Data", MessageBoxButtons.OK)
            Exit Sub
        Else
            intSumScore = Val(txtLabScore.Text) + Val(txtMidterm.Text) + Val(txtFinal.Text)
            If intSumScore < 50 Then
                If (40 + Val(txtMidterm.Text) + Val(txtFinal.Text)) >= 50 Then
                    drResult = MessageBox.Show("ระดับคะแนนอยู่ในเกณฑ์ช่วยได้หากปรบัคะแนนเก็บเพิ่มข้ึน" &
ControlChars.NewLine & "ท่านต้องการติด I ไว้ก่อนหรือไม่", "สอบถาม", MessageBoxButtons.YesNo,
MessageBoxIcon.Question)

                    If drResult = Windows.Forms.DialogResult.Yes Then
                        strGrade = "I"
                    Else
                        strGrade = "F"
                    End If
                Else
                    strGrade = "F"
                End If
            Else
                Select Case intSumScore
                    Case Is < 55 : strGrade = "D"
                    Case Is < 60 : strGrade = "D+"
                    Case Is < 65 : strGrade = "C"
                    Case Is < 70 : strGrade = "C+"
                    Case Is < 75 : strGrade = "B"
                    Case Is < 80 : strGrade = "B+"
                    Case Else : strGrade = "A"
                End Select
            End If
        End If
        lblSumScore.Text = intSumScore
        lblGrade.Text = strGrade
    End Sub
End Class