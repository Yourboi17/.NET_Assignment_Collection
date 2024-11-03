Public Class Form1
    Dim result As Double = 0
    Dim operation As String = ""

    ' This label will display the selected operation
    Private Sub UpdateOperationLabel()
        lblOperation.Text = "Operation: " & operation
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        operation = "+"
        UpdateOperationLabel()
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        operation = "-"
        UpdateOperationLabel()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        operation = "*"
        UpdateOperationLabel()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        operation = "/"
        UpdateOperationLabel()
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        operation = "^"
        UpdateOperationLabel()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim num1 As Double = Convert.ToDouble(txtNum1.Text)
        Dim num2 As Double = Convert.ToDouble(txtNum2.Text)

        Select Case operation
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                If num2 <> 0 Then
                    result = num1 / num2
                Else
                    lblResult.Text = "Cannot divide by zero!"
                    Return
                End If
            Case "^"
                result = Math.Pow(num1, num2)
        End Select

        lblResult.Text = "Result: " & result.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum1.Clear()
        txtNum2.Clear()
        lblResult.Text = "Result:"
        lblOperation.Text = "Operation: " ' Clear the operation display
        operation = ""
    End Sub
End Class
