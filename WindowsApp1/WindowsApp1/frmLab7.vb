Public Class frmLab7
    Private Sub txtAddData_TextChanged(sender As Object, e As EventArgs) Handles txtAddData.TextChanged
        If txtAddData.Text.Trim <> "" Then
            bthAddData.Enabled = True
        Else
            bthAddData.Enabled = False
        End If
    End Sub

    Private Sub bthAddData_Click(sender As Object, e As EventArgs) Handles bthAddData.Click
        lstData.Items.Add(txtAddData.Text)
        txtAddData.Text = ""
        lstData.SelectedIndex = lstData.Items.Count - 1
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        If lstData.SelectedIndex <> -1 Or lstData.Items.Count <> 0 Then
            Dim checkdex As Integer
            checkdex = lstData.SelectedIndex
            cboTarget.Items.Add(lstData.Items(checkdex))
            lstData.Items.RemoveAt(checkdex)
            If lstData.Items.Count = 0 Then
                lstData.SelectedIndex = -1
            ElseIf checkdex = lstData.Items.Count Then
                lstData.SelectedIndex = lstData.Items.Count - 1
            Else
                lstData.SelectedIndex = checkdex
            End If
            cboTarget.SelectedIndex = cboTarget.Items.Count - 1
        Else
            MessageBox.Show("ไม่มีรายการข้อมูล หรือไม่ได้เลือกรายการใน ListBox")
        End If
    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        If lstData.Items.Count <> 0 Then
            Dim checkcount As Integer
            Dim startcount As Integer
            checkcount = lstData.Items.Count - 1
            startcount = 0
            While startcount <= checkcount
                cboTarget.Items.Add(lstData.Items(startcount))
                startcount = startcount + 1
            End While
            cboTarget.SelectedIndex = cboTarget.Items.Count - 1
            lstData.Items.Clear()
        Else
            MessageBox.Show("ไม่มีรายการข้อมูลใน ListBox")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If cboTarget.SelectedIndex <> -1 Or cboTarget.Items.Count <> 0 Then
            Dim checkdex As Integer
            checkdex = cboTarget.SelectedIndex
            lstData.Items.Add(cboTarget.Items(checkdex))
            cboTarget.Items.RemoveAt(checkdex)
            lstData.SelectedIndex = lstData.Items.Count - 1
            If cboTarget.Items.Count = 0 Then
                cboTarget.SelectedIndex = -1
                cboTarget.Text = ""
                lblTarget.Text = ""
            ElseIf checkdex = cboTarget.Items.Count Then
                cboTarget.SelectedIndex = cboTarget.Items.Count - 1
            Else
                cboTarget.SelectedIndex = checkdex
            End If
        Else
            MessageBox.Show("ไม่มีรายการข้อมูล หรือไม่ได้เลือกรายการใน ComboBox")
        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        If cboTarget.Items.Count <> 0 Then
            Dim checkcount As Integer
            Dim startcount As Integer
            checkcount = cboTarget.Items.Count - 1
            startcount = 0
            While startcount <= checkcount
                lstData.Items.Add(cboTarget.Items(startcount))
                startcount = startcount + 1
            End While
            lstData.SelectedIndex = lstData.Items.Count - 1
            cboTarget.Items.Clear()
            cboTarget.Text = ""
            lblTarget.Text = ""
        Else
            MessageBox.Show("ไม่มีรายการข้อมูลใน ComboBox")
        End If
    End Sub

    Private Sub bthClear_Click(sender As Object, e As EventArgs) Handles bthClear.Click
        cboTarget.Items.Clear()
        cboTarget.Text = ""
        lstData.Items.Clear()
        txtAddData.Text = ""
        lblTarget.Text = ""
    End Sub

    Private Sub cboTarget_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTarget.SelectedIndexChanged
        lblTarget.Text = cboTarget.Items(cboTarget.SelectedIndex)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class