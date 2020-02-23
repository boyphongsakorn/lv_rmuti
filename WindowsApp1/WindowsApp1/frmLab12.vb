Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmLab12
    Dim linesql As String = ConfigurationManager.ConnectionStrings("WindowsApp1.My.MySettings.onlytwoone").ConnectionString
    Dim myConn As New SqlConnection
    Dim myDR As SqlDataReader
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Dim Wow As String 'เก็บ String ของ คำสั่ง SQL
    Dim cs As String 'เก็บ String เพื่อนำไปเช็ค ตอนกดปุุ่ม Save
    Private Sub connectDB()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
        myConn.ConnectionString = linesql
        myConn.Open()
    End Sub
    Private Sub frmLab12_Load(sender As Object, e As EventArgs) Handles Me.Load
        myDS.Tables.Clear()
        connectDB()
        Wow = "SELECT tbEmployee.empId,tbEmployee.empName,tbEmployee.empLname,tbEmployee.salary,tbDepartment.depName FROM tbEmployee,tbDepartment WHERE tbEmployee.depId = tbDepartment.depId"
        myDA = New SqlDataAdapter(Wow, myConn)
        myDA.Fill(myDS, "wow")
        myConn.Close()
        DgvEmp.DataSource = myDS.Tables("wow")

        'ดึงชื่อตารางมาใส่ cboDepart
        connectDB()
        Wow = "SELECT depName FROM tbDepartment"
        Dim command As New SqlCommand(Wow, myConn)
        myDR = command.ExecuteReader()
        Dim i As Integer = 0
        While myDR.Read()
            cboDepart.Items.Add(myDR(i))
        End While
        myConn.Close()
    End Sub
    Private Sub DgvEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmp.CellClick
        Dim yourse As Integer = DgvEmp.CurrentCell.RowIndex
        connectDB()
        Wow = "SELECT sex,address FROM tbEmployee WHERE empId = '" & DgvEmp.Rows(0).Cells(0).Value & "'"
        Dim command As New SqlCommand(Wow, myConn)
        myDR = command.ExecuteReader()
        myDR.Read()
        If myDR(0) = "Male" Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If
        txtAddress.Text = myDR(1)
        myConn.Close()
        txtEmpId.Text = DgvEmp.Rows(yourse).Cells(0).Value
        txtEmpName.Text = DgvEmp.Rows(yourse).Cells(1).Value
        txtEmpLname.Text = DgvEmp.Rows(yourse).Cells(2).Value
        txtSalary.Text = DgvEmp.Rows(yourse).Cells(3).Value
        cboDepart.SelectedItem = DgvEmp.Rows(yourse).Cells(4).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        cs = "insert"
        btnInsert.Enabled = False
        panEmp.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        DgvEmp.Enabled = False
        txtEmpId.Text = True
        txtEmpId.Text = ""
        txtEmpName.Text = ""
        txtEmpLname.Text = ""
        txtSalary.Text = ""
        txtAddress.Text = ""
        cboDepart.SelectedIndex = -1
        radMale.Checked = False
        radFemale.Checked = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        panEmp.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        DgvEmp.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnInsert.Enabled = True
        txtEmpId.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        cs = "edit"
        btnEdit.Enabled = False
        panEmp.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        DgvEmp.Enabled = False
        txtEmpId.Enabled = False
        btnInsert.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cs = "insert" Then
            MessageBox.Show("Check")
            connectDB()
            Wow = "SELECT empid FROM tbEmployee WHERE empid = '" & txtEmpId.Text & "'"
            Dim command As New SqlCommand(Wow, myConn)
            myDR = command.ExecuteReader()
            Dim i As Integer = 0
            If myDR.HasRows Then
                MessageBox.Show("รหัสพนักงานนี้ มีอยู่แล้ว")
                myConn.Close()
                Exit Sub
            End If
            myConn.Close()

            connectDB()
            MessageBox.Show(cboDepart.SelectedItem)
            Wow = "SELECT depID FROM tbDepartment WHERE depName = '" & cboDepart.SelectedItem & "'"
            command.CommandText = Wow
            myDR = command.ExecuteReader()
            myDR.Read()
            Dim dId As String = myDR(0)
            myConn.Close()

            connectDB()
            Wow = "INSERT INTO tbEmployee VALUES(@eId,@en,@eln,@es,@ea,@esa,'" & dId & "')"

            command.CommandText = Wow
            command.Parameters.Clear()

            command.Parameters.Add("en", SqlDbType.VarChar).Value = txtEmpName.Text
            command.Parameters.Add("eln", SqlDbType.VarChar).Value = txtEmpLname.Text
            If radFemale.Checked Then
                command.Parameters.Add("es", SqlDbType.VarChar).Value = "Female"
            Else
                command.Parameters.Add("es", SqlDbType.VarChar).Value = "Male"
            End If
            command.Parameters.Add("ea", SqlDbType.VarChar).Value = txtAddress.Text
            command.Parameters.Add("esa", SqlDbType.VarChar).Value = txtSalary.Text
            command.Parameters.Add("eId", SqlDbType.VarChar).Value = txtEmpId.Text

            If command.ExecuteNonQuery() Then
                MessageBox.Show("บันทึกเสร็จเรียบร้อยแล้ว")
                myConn.Close()
                Call frmLab12_Load(sender, e)
            Else
                myConn.Close()
            End If
        ElseIf cs = "edit" Then
            connectDB()
            Wow = "SELECT depID FROM tbDepartment WHERE depName = '" & cboDepart.SelectedItem & "'"
            Dim command As New SqlCommand(Wow, myConn)
            myDR = command.ExecuteReader()
            myDR.Read()
            Dim dId As String = myDR(0)
            myConn.Close()

            connectDB()
            Wow = "UPDATE tbEmployee SET empName = @en,empLname = @eln,sex=@es,address=@ea,salary=@esl,depId='" & dId & "' WHERE empId=@eId"

            command.CommandText = Wow

            command.Parameters.Add("en", SqlDbType.VarChar).Value = txtEmpName.Text
            command.Parameters.Add("eln", SqlDbType.VarChar).Value = txtEmpLname.Text
            If radFemale.Checked Then
                command.Parameters.Add("es", SqlDbType.VarChar).Value = "Female"
            Else
                command.Parameters.Add("es", SqlDbType.VarChar).Value = "Male"
            End If
            command.Parameters.Add("ea", SqlDbType.VarChar).Value = txtAddress.Text
            command.Parameters.Add("esl", SqlDbType.VarChar).Value = txtSalary.Text
            command.Parameters.Add("eId", SqlDbType.VarChar).Value = txtEmpId.Text

            If command.ExecuteNonQuery() Then
                MessageBox.Show("แก้ไขเสร็จเรียบร้อยแล้ว")
                Call frmLab12_Load(sender, e)
                myConn.Close()
            Else
                myConn.Close()
            End If
        ElseIf cs = "delete" Then
            MessageBox.Show("มาที่นี้ได้ยังไง?")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connectDB()

        If MessageBox.Show("คุณต้องการลบ พนักงาน ไอดีที่" & DgvEmp.Rows(DgvEmp.CurrentCell.RowIndex).Cells(0).Value & "ใช่หรือไม่", "ลบพนักงาร", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Wow = "DELETE FROM tbEmployee WHERE empid='" & DgvEmp.Rows(DgvEmp.CurrentCell.RowIndex).Cells(0).Value & "'"
            Dim command As New SqlCommand(Wow, myConn)
            If command.ExecuteNonQuery() Then
                MessageBox.Show("ลบเรียบร้อยแล้ว")
                Call frmLab12_Load(sender, e)
                myConn.Close()
            Else
                myConn.Close()
            End If
        End If
    End Sub
End Class