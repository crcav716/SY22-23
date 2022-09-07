Public Class Tips
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Dollars As Decimal
        Decimal.TryParse(SalesTaxTextBox.Text, Dollars)
        Dim Button1 As Decimal
        Button1 = Dollars * 1
        GrandtotalTextBox.Text = Button1.ToString("n2")


    End Sub

    Private Sub AddSalesTax_Click(sender As Object, e As EventArgs) Handles AddSalesTax.Click
        Dim Dollars As Decimal
        Decimal.TryParse(subtotalTextBox.Text, Dollars)
        Dim Button1 As Decimal
        Button1 = Dollars * 1.056
        SalesTaxTextBox.Text = Button1.ToString("n2")

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Dollars As Decimal
        Decimal.TryParse(SalesTaxTextBox.Text, Dollars)
        Dim Button1 As Decimal
        Button1 = Dollars * 1.15
        GrandtotalTextBox.Text = Button1.ToString("n2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Dollars As Decimal
        Decimal.TryParse(SalesTaxTextBox.Text, Dollars)
        Dim Button1 As Decimal
        Button1 = Dollars * 1.2
        GrandtotalTextBox.Text = Button1.ToString("n2")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Dollars As Decimal
        Decimal.TryParse(SalesTaxTextBox.Text, Dollars)
        Dim Button1 As Decimal
        Button1 = Dollars * 1.25
        GrandtotalTextBox.Text = Button1.ToString("n2")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Dollars As Decimal
        Decimal.TryParse(SalesTaxTextBox.Text, Dollars)
        Dim Button1 As Decimal
        Button1 = Dollars * 1.5
        GrandtotalTextBox.Text = Button1.ToString("n2")

    End Sub
End Class
