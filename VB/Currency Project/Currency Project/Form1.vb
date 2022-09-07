Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EurosButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(USDtextbox.Text, Dollars)
        Dim Euros As Decimal
        Euros = Dollars * 1.0
        Convertedtextbox.Text = Euros.ToString("n2")
    End Sub

    Private Sub PesosButton_Click(sender As Object, e As EventArgs) Handles PesosButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(USDtextbox.Text, Dollars)
        Dim Pesos As Decimal
        Pesos = Dollars * 20
        Convertedtextbox.Text = Pesos.ToString("n2")
    End Sub

    Private Sub RenimbiButton_Click(sender As Object, e As EventArgs) Handles RenimbiButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(USDtextbox.Text, Dollars)
        Dim Renimbi As Decimal
        Renimbi = Dollars * 6.9
        Convertedtextbox.Text = Renimbi.ToString("n2")
    End Sub

    Private Sub JapaneseYenButton_Click(sender As Object, e As EventArgs) Handles JapaneseYenButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(USDtextbox.Text, Dollars)
        Dim JapaneseYen As Decimal
        JapaneseYen = Dollars * 138.96
        Convertedtextbox.Text = JapaneseYen.ToString("n2")
    End Sub

    Private Sub BritishPoundButton_Click(sender As Object, e As EventArgs) Handles BritishPound.Click
        Dim Dollars As Decimal
        Decimal.TryParse(USDtextbox.Text, Dollars)
        Dim BritishPound As Decimal
        BritishPound = Dollars * 0.86
        Convertedtextbox.Text = BritishPound.ToString("n2")
    End Sub

    Private Sub AustralianDollarButton_Click(sender As Object, e As EventArgs) Handles AustralianDollar.Click
        Dim Dollars As Decimal
        Decimal.TryParse(USDtextbox.Text, Dollars)
        Dim AustralianDollar As Decimal
        AustralianDollar = Dollars * 1.46
        Convertedtextbox.Text = AustralianDollar.ToString("n2")
    End Sub
End Class
