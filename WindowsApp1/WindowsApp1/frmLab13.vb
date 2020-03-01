Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Windows.Forms

Public Class frmLab13
    Dim linesql As String = "Server=localhost\SQLEXPRESS;Database=northwind;Trusted_Connection=True;"
    Dim myConn As New SqlConnection(linesql)
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim rpt As New rptLab15
    Dim ic As String

    Private Sub connectDB()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
        myConn.ConnectionString = linesql
        myConn.Open()
    End Sub

    Private Sub selectreport(a As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(a, myConn)
        da.Fill(ds, "dtProduct")

        rpt.SetDataSource(ds.Tables("dtProduct"))

        If RadioButton1.Checked = True Then
            rpt.SetParameterValue("Condition", "")
        ElseIf RadioButton2.Checked = True Then
            rpt.SetParameterValue("Condition", "ใบเลขที่สั่ง :" & ds.Tables(0).Rows(0).Item(5).ToString)
        Else
            rpt.SetParameterValue("Condition", "ใบสั่งบริษัท :" & ds.Tables(0).Rows(0).Item(19).ToString)
        End If
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Show()

        myConn.Close()

        CrystalReportViewer1.Size = New Size(Me.Size.Width - 50, Me.Size.Height - 125)
    End Sub
    Private Sub frmLab13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        selectreport("SELECT        [Order Details].ProductID, Products.ProductName, Products.QuantityPerUnit, Products.UnitPrice, [Order Details].Quantity, Orders.OrderID, [Order Details].OrderID AS OD_ID, [Order Details].Discount, 
                         Customers.Address, Customers.City, Customers.Country, Customers.PostalCode, Orders.OrderDate, Employees.FirstName, Employees.LastName, Company.Name_company, Company.Address_company,
                          Customers.ContactName, Orders.RequiredDate, Customers.CompanyName
FROM            Orders INNER JOIN
                         Employees ON Orders.EmployeeID = Employees.EmployeeID INNER JOIN
                         Customers ON Orders.CustomerID = Customers.CustomerID INNER JOIN
                         [Order Details] ON Orders.OrderID = [Order Details].OrderID INNER JOIN
                         Products ON [Order Details].ProductID = Products.ProductID CROSS JOIN
                         Company")

        connectDB()
        ic = "SELECT OrderID FROM Orders ORDER BY OrderID ASC"
        Dim command As New SqlCommand(ic, myConn)
        dr = command.ExecuteReader()
        Dim i As Integer = 0
        While dr.Read()
            ComboBox1.Items.Add(dr(i))
        End While
        myConn.Close()

        connectDB()
        ic = "SELECT CompanyName FROM Customers ORDER BY CompanyName ASC"
        command.CommandText = ic
        dr = command.ExecuteReader()
        i = 0
        While dr.Read()
            ComboBox2.Items.Add(dr(i))
        End While
        myConn.Close()

    End Sub

    Private Sub frmLab13_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        CrystalReportViewer1.Size = New Size(Me.Size.Width - 50, Me.Size.Height - 125)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MessageBox.Show(ComboBox1.SelectedItem.ToString)
        selectreport("SELECT        [Order Details].ProductID, Products.ProductName, Products.QuantityPerUnit, Products.UnitPrice, [Order Details].Quantity, Orders.OrderID, [Order Details].OrderID AS OD_ID, [Order Details].Discount, 
                         Customers.Address, Customers.City, Customers.Country, Customers.PostalCode, Orders.OrderDate, Employees.FirstName, Employees.LastName, Company.Name_company, Company.Address_company,
                          Customers.ContactName, Orders.RequiredDate, Customers.CompanyName
FROM            Orders INNER JOIN
                         Employees ON Orders.EmployeeID = Employees.EmployeeID INNER JOIN
                         Customers ON Orders.CustomerID = Customers.CustomerID INNER JOIN
                         [Order Details] ON Orders.OrderID = [Order Details].OrderID INNER JOIN
                         Products ON [Order Details].ProductID = Products.ProductID CROSS JOIN
                         Company WHERE [Order Details].OrderID = '" & ComboBox1.SelectedItem.ToString & "'")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Call frmLab13_Load(sender, e)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        MessageBox.Show(ComboBox2.SelectedItem.ToString)
        selectreport("SELECT        [Order Details].ProductID, Products.ProductName, Products.QuantityPerUnit, Products.UnitPrice, [Order Details].Quantity, Orders.OrderID, [Order Details].OrderID AS OD_ID, [Order Details].Discount, 
                         Customers.Address, Customers.City, Customers.Country, Customers.PostalCode, Orders.OrderDate, Employees.FirstName, Employees.LastName, Company.Name_company, Company.Address_company,
                          Customers.ContactName, Orders.RequiredDate, Customers.CompanyName
FROM            Orders INNER JOIN
                         Employees ON Orders.EmployeeID = Employees.EmployeeID INNER JOIN
                         Customers ON Orders.CustomerID = Customers.CustomerID INNER JOIN
                         [Order Details] ON Orders.OrderID = [Order Details].OrderID INNER JOIN
                         Products ON [Order Details].ProductID = Products.ProductID CROSS JOIN
                         Company WHERE Customers.CompanyName = '" & ComboBox2.SelectedItem.ToString & "'")
    End Sub
End Class