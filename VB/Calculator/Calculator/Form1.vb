Public Class Form1
    Dim Num1 As Decimal
    Dim Num2 As Decimal
    Dim oper As String
    Dim mem As Decimal
    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B1.Click, B0.Click, DecimalButton.Click
        DisplayTextBox.Text = DisplayTextBox.Text + sender.text
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        DisplayTextBox.Clear()
    End Sub

    Private Sub Addition_Click(sender As Object, e As EventArgs) Handles Addition.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        oper = "+"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        Decimal.TryParse(DisplayTextBox.Text, Num2)
        If oper = "+" Then
            DisplayTextBox.Text = Num1 + Num2
        End If
        If oper = "-" Then
            DisplayTextBox.Text = Num1 - Num2
        End If
        If oper = "*" Then
            DisplayTextBox.Text = Num1 * Num2
        End If
        If oper = "/" Then
            DisplayTextBox.Text = Num1 / Num2
        End If


    End Sub

    Private Sub Subtraction_Click(sender As Object, e As EventArgs) Handles Subtraction.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        oper = "-"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Multiplication_Click(sender As Object, e As EventArgs) Handles Multiplication.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        oper = "*"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        oper = "/"
        DisplayTextBox.Clear()
    End Sub

    Private Sub SquareRootButton_Click(sender As Object, e As EventArgs) Handles SquareRootButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        DisplayTextBox.Text = Math.Sqrt(Num1)
    End Sub

    Private Sub SinButton_Click(sender As Object, e As EventArgs) Handles SinButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        DisplayTextBox.Text = Math.Sin(Num1)
    End Sub

    Private Sub CosButton_Click(sender As Object, e As EventArgs) Handles CosButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        DisplayTextBox.Text = Math.Cos(Num1)
    End Sub

    Private Sub TanButton_Click(sender As Object, e As EventArgs) Handles TanButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        DisplayTextBox.Text = Math.Tan(Num1)
    End Sub

    Private Sub PiButton_Click(sender As Object, e As EventArgs) Handles PiButton.Click
        DisplayTextBox.Text = Math.PI
    End Sub

    Private Sub MplusButton_Click(sender As Object, e As EventArgs) Handles MplusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, mem)
    End Sub

    Private Sub MrButton_Click(sender As Object, e As EventArgs) Handles MrButton.Click
        DisplayTextBox.Text = mem
    End Sub

    Private Sub McButton_Click(sender As Object, e As EventArgs) Handles McButton.Click
        mem = 0
    End Sub
End Class
