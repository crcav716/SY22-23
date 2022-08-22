Public Class Form1
    Private Sub ChocolatePictureButton_Click(sender As Object, e As EventArgs) Handles ChocolateButton.Click
        displayPictureBox.Image = ChocolatePictureBox.Image
        nameLabel.Text = "White Chocolate"
        shapesLabel.Text = "Circle"
        flavorsLabel.Text = "Milky"
        orginatedfromLabel.Text = "Switzerland"
        bestbrandLabel.Text = "Ghirardelli Chocolate Company"
    End Sub

    Private Sub darkchocolateButton_Click(sender As Object, e As EventArgs) Handles darkchocolateButton.Click
        displayPictureBox.Image = darkchocolatePictureBox.Image
        nameLabel.Text = "Dark Chocolate"
        shapesLabel.Text = "Square"
        flavorsLabel.Text = "Bitter"
        orginatedfromLabel.Text = "Mexico/South America"
        bestbrandLabel.Text = "Lindt Chocolate"

    End Sub

    Private Sub milkchocolateButton_Click(sender As Object, e As EventArgs) Handles milkchocolateButton.Click
        displayPictureBox.Image = milkchocolatePictureBox.Image
        nameLabel.Text = "Milk Chocolate"
        shapesLabel.Text = "Rectangle"
        flavorsLabel.Text = "Sweet and Chocolatey"
        orginatedfromLabel.Text = "Switzerland"
        bestbrandLabel.Text = "Hersey Chocolate Company"
    End Sub

    Private Sub semisweetchocolateButton_Click(sender As Object, e As EventArgs) Handles semisweetchocolateButton.Click
        displayPictureBox.Image = semisweetchocolatePictureBox.Image
        nameLabel.Text = "Semisweet Chocolate"
        shapesLabel.Text = "Round"
        flavorsLabel.Text = "Bitter"
        orginatedfromLabel.Text = "United States"
        bestbrandLabel.Text = "Ghirardelli Semi-Sweet Premium Chocolate Chips"
    End Sub

    Private Sub sweetgermanButton_Click(sender As Object, e As EventArgs) Handles sweetgermanButton.Click
        displayPictureBox.Image = sweetgermanchocolatePictureBox.Image
        nameLabel.Text = "Sweet German Chocolate"
        shapesLabel.Text = "Cubes"
        flavorsLabel.Text = "Sweet"
        orginatedfromLabel.Text = "United States"
        bestbrandLabel.Text = "Ritter Sport"
    End Sub


End Class
