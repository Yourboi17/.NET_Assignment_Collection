Public Class Form1
    Private Sub btnGenerateSeries_Click(sender As Object, e As EventArgs) Handles btnGenerateSeries.Click
        lstSeries.Items.Clear()

        For i As Integer = 1 To 10
            lstSeries.Items.Add(i * i)
        Next
    End Sub

End Class
