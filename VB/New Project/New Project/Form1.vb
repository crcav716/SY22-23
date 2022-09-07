Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buy.Click
        Dim amount As Decimal
        Decimal.TryParse(amountTextBox.Text, amount)
        NameTextBox.Clear()
        ccTextBox.Clear()
        expTextBox.Clear()
        zipTextBox.Clear()
        amountTextBox.Clear()
        Dim fee As Decimal
        fee = amount * 0.03
        feebox.Text = fee.ToString("C2")
    End Sub
End Class
