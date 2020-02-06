Imports System.Data
Imports System.Data.SqlClient
Public Class frmLab11
    Dim linesql As String = "Server=localhost\SQLEXPRESS;Database=northwind;Trusted_Connection=True;"
    Dim myConn As New SqlConnection(linesql)

    Private Sub btnChoice1_Click(sender As Object, e As EventArgs) Handles btnChoice1.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Products WHERE ProductName LIKE 'N%'")
    End Sub
    Function sendselect(Wow As String) As DataTable
        myConn.Open()
        Dim myDA As New SqlDataAdapter
        Dim myDS As New DataSet
        myDA = New SqlDataAdapter(Wow, myConn)
        myDA.Fill(myDS, "wow")
        myConn.Close()
        Return myDS.Tables("wow")
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChoice2_Click(sender As Object, e As EventArgs) Handles btnChoice2.Click
        dgvData.DataSource = sendselect("SELECT (UnitPrice) FROM dbo.Products WHERE ProductID = 64")
    End Sub

    Private Sub btnChoice3_Click(sender As Object, e As EventArgs) Handles btnChoice3.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Customers WHERE Country = 'Brazil'")
    End Sub

    Private Sub btnChoice4_Click(sender As Object, e As EventArgs) Handles btnChoice4.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Customers WHERE ContactName = 'Yang Wang'")
    End Sub

    Private Sub btnChoice5_Click(sender As Object, e As EventArgs) Handles btnChoice5.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Products WHERE UnitsInStock < 10")
    End Sub

    Private Sub btnChoice6_Click(sender As Object, e As EventArgs) Handles btnChoice6.Click
        dgvData.DataSource = sendselect("SELECT * FROM [Order Details] WHERE OrderID = 10255")
    End Sub

    Private Sub btnChoice7_Click(sender As Object, e As EventArgs) Handles btnChoice7.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Orders WHERE OrderID = 10255")
    End Sub

    Private Sub btnChoice8_Click(sender As Object, e As EventArgs) Handles btnChoice8.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Orders WHERE OrderID = 10347")
    End Sub

    Private Sub btnChoice9_Click(sender As Object, e As EventArgs) Handles btnChoice9.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Orders WHERE ShipName = 'Exotic Liquids'")
    End Sub

    Private Sub btnChoice10_Click(sender As Object, e As EventArgs) Handles btnChoice10.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Orders WHERE ShipCountry = 'ITALY'")
    End Sub
End Class