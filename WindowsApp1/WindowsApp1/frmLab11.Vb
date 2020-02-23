Imports System.Data
Imports System.Data.SqlClient
Public Class frmLab11
    Dim linesql As String = "Server=localhost\SQLEXPRESS;Database=northwind;Trusted_Connection=True;"
    Dim myConn As New SqlConnection(linesql)
    Dim myDS As New DataSet
    Dim myDA As New SqlDataAdapter

    Private Sub btnChoice1_Click(sender As Object, e As EventArgs) Handles btnChoice1.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Products WHERE ProductName LIKE 'N%'")
    End Sub
    Function sendselect(Wow As String) As DataTable
        myConn.Open()
        myDS.Tables.Clear()
        myDA = New SqlDataAdapter(Wow, myConn)
        myDA.Fill(myDS, "wow")
        myConn.Close()
        Return myDS.Tables("wow")
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChoice2_Click(sender As Object, e As EventArgs) Handles btnChoice2.Click
        dgvData.DataSource = sendselect("select ProductID, ProductName, UnitPrice, UnitsInStock, UnitsInStock * UnitPrice total from Products where ProductID ='64'")
    End Sub

    Private Sub btnChoice3_Click(sender As Object, e As EventArgs) Handles btnChoice3.Click
        dgvData.DataSource = sendselect("Select count(*) จำนวน from Customers where Country='Brazil'")
    End Sub

    Private Sub btnChoice4_Click(sender As Object, e As EventArgs) Handles btnChoice4.Click
        'dgvData.DataSource = sendselect("SELECT dbo.Customers.ContactName,COUNT(dbo.[Order Details].OrderID) FROM dbo.Customers LEFT JOIN dbo.[Order Details] ON dbo.Orders.OrderID = dbo.[Order Details].OrderID LEFT JOIN dbo.Orders ON dbo.Orders.CustomerID = dbo.Customers.CustomerID WHERE dbo.Customers.ContactName = 'Yang Wang' GROUP BY dbo.Customers.ContactName")
        'dgvData.DataSource = sendselect("SELECT dbo.Customers.ContactName,SUM(dbo.[Order Details].Quantity) FROM dbo.[Order Details] LEFT JOIN dbo.Orders ON dbo.Orders.OrderID = dbo.[Order Details].OrderID LEFT JOIN dbo.Customers ON dbo.Orders.CustomerID = dbo.Customers.CustomerID WHERE dbo.Customers.ContactName = 'Yang Wang' GROUP BY dbo.Customers.ContactName")
        dgvData.DataSource = sendselect("SELECT dbo.Products.ProductName,dbo.[Order Details].Quantity FROM dbo.[Order Details] LEFT JOIN dbo.Products ON dbo.Products.ProductID = dbo.[Order Details].ProductID LEFT JOIN dbo.Orders ON dbo.Orders.OrderID = dbo.[Order Details].OrderID LEFT JOIN dbo.Customers ON dbo.Orders.CustomerID = dbo.Customers.CustomerID WHERE dbo.Customers.ContactName = 'Yang Wang'")
    End Sub

    Private Sub btnChoice5_Click(sender As Object, e As EventArgs) Handles btnChoice5.Click
        dgvData.DataSource = sendselect("SELECT ProductName,UnitsInStock FROM dbo.Products WHERE UnitsInStock < 10")
    End Sub

    Private Sub btnChoice6_Click(sender As Object, e As EventArgs) Handles btnChoice6.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Products LEFT JOIN [Order Details] ON dbo.Products.ProductID = dbo.[Order Details].ProductID WHERE OrderID = 10255")
    End Sub

    Private Sub btnChoice7_Click(sender As Object, e As EventArgs) Handles btnChoice7.Click
        dgvData.DataSource = sendselect("select orderid, sum(unitprice*quantity) totall from [order details] group by orderid having orderid ='10255'")
    End Sub

    Private Sub btnChoice8_Click(sender As Object, e As EventArgs) Handles btnChoice8.Click
        dgvData.DataSource = sendselect("SELECT * FROM dbo.Customers LEFT JOIN dbo.Orders ON dbo.Orders.CustomerID = dbo.Customers.CustomerID WHERE OrderID = 10347")
        'dgvData.DataSource = sendselect("SELECT * FROM dbo.Orders WHERE OrderID = 10347")
    End Sub

    Private Sub btnChoice9_Click(sender As Object, e As EventArgs) Handles btnChoice9.Click
        dgvData.DataSource = sendselect("Select *, suppliers.companyname from products inner join suppliers on products.supplierID = Suppliers.supplierid where suppliers.companyname = 'exotic liquids'")
    End Sub

    Private Sub btnChoice10_Click(sender As Object, e As EventArgs) Handles btnChoice10.Click
        dgvData.DataSource = sendselect("Select count(*) from orders inner join customers on orders.customerid = customers.customerid group by customers.country having customers.country='ITALY'")

    End Sub
End Class