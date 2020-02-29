Imports System.Data
Imports System.Data.SqlClient

Public Class frmLab13
    Dim linesql As String = "Server=localhost\SQLEXPRESS;Database=northwind;Trusted_Connection=True;"
    Dim myConn As New SqlConnection(linesql)
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim rpt As New rptLab15
    Private Sub frmLab13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSql As String = "SELECT        [Order Details].ProductID, Products.ProductName, Products.QuantityPerUnit, Products.UnitPrice, [Order Details].Quantity, Orders.OrderID, [Order Details].OrderID AS OD_ID, [Order Details].Discount, 
                         Customers.Address, Customers.City, Customers.Country, Customers.PostalCode, Customers.CustomerID, Orders.OrderDate, Employees.FirstName, Employees.LastName, Customers.ContactName, 
                         Orders.RequiredDate
FROM            Orders INNER JOIN
                         Employees ON Orders.EmployeeID = Employees.EmployeeID INNER JOIN
                         Customers ON Orders.CustomerID = Customers.CustomerID INNER JOIN
                         [Order Details] ON Orders.OrderID = [Order Details].OrderID INNER JOIN
                         Products ON [Order Details].ProductID = Products.ProductID CROSS JOIN
                         Company"
        da = New SqlDataAdapter(strSql, myConn)
        da.Fill(ds, "dtProduct")

        rpt.SetDataSource(ds.Tables("dtProduct"))

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Show()

        CrystalReportViewer1.Size = New Size(Me.Size.Width - 50, Me.Size.Height - 125)


    End Sub

    Private Sub frmLab13_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        CrystalReportViewer1.Size = New Size(Me.Size.Width - 50, Me.Size.Height - 125)
    End Sub
End Class