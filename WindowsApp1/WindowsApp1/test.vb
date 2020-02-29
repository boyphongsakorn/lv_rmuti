Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Public Class test
    Dim myCon As New SqlConnection
    Dim myDa As New SqlDataAdapter
    Dim myDs As New DataSet

    Dim strCon As String = ConfigurationManager.ConnectionStrings("WindowsApp1.My.MySettings.sqlline").ConnectionString
    Dim strSQL As String

    Private Sub connectDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub showcate_Click(sender As Object, e As EventArgs) Handles showcate.Click
        connectDB()
        strSQL = "Select * from Categories"
        myDa = New SqlDataAdapter(strSQL, myCon)
        myDa.Fill(myDs, "tbcat")
        dgvnorth.DataSource = myDs.Tables("tbcat")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connectDB()
        strSQL = "Select ProductID,ProductName,QuantityPerUnit,UnitPrice,UnitsInStock from Products"
        myDa = New SqlDataAdapter(strSQL, myCon)
        myDa.Fill(myDs, "tbcat")
        dgvnorth.DataSource = myDs.Tables("tbcat")
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbCompany_xxxDataSet.tbEmployee' table. You can move, or remove it, as needed.
    End Sub
End Class