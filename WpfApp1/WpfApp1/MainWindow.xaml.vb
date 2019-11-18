Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Dim h As Integer
        Dim r As Double
        Dim p As Double

        r = textBox.Text
        p = textBox_Copy.Text

        h = r * p

        label1.Content = h
    End Sub
End Class
