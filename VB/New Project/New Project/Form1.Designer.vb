<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Buy = New System.Windows.Forms.Button()
        Me.ccTextBox = New System.Windows.Forms.TextBox()
        Me.expTextBox = New System.Windows.Forms.TextBox()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.amountTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(8, 44)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(148, 34)
        Me.NameTextBox.TabIndex = 1
        '
        'Buy
        '
        Me.Buy.ForeColor = System.Drawing.Color.Green
        Me.Buy.Location = New System.Drawing.Point(406, 534)
        Me.Buy.Margin = New System.Windows.Forms.Padding(4)
        Me.Buy.Name = "Buy"
        Me.Buy.Size = New System.Drawing.Size(221, 67)
        Me.Buy.TabIndex = 2
        Me.Buy.Text = "Buy"
        Me.Buy.UseVisualStyleBackColor = True
        '
        'ccTextBox
        '
        Me.ccTextBox.Location = New System.Drawing.Point(12, 152)
        Me.ccTextBox.Name = "ccTextBox"
        Me.ccTextBox.Size = New System.Drawing.Size(148, 34)
        Me.ccTextBox.TabIndex = 3
        '
        'expTextBox
        '
        Me.expTextBox.Location = New System.Drawing.Point(8, 267)
        Me.expTextBox.Name = "expTextBox"
        Me.expTextBox.Size = New System.Drawing.Size(148, 34)
        Me.expTextBox.TabIndex = 4
        '
        'zipTextBox
        '
        Me.zipTextBox.Location = New System.Drawing.Point(8, 379)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(148, 34)
        Me.zipTextBox.TabIndex = 5
        '
        'amountTextBox
        '
        Me.amountTextBox.Location = New System.Drawing.Point(12, 484)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(148, 34)
        Me.amountTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 27)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CC#:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 27)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Exp Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Zip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 27)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Amount:"
        '
        'Cancel
        '
        Me.Cancel.ForeColor = System.Drawing.Color.Red
        Me.Cancel.Location = New System.Drawing.Point(634, 534)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(213, 67)
        Me.Cancel.TabIndex = 11
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.New_Project.My.Resources.Resources.master_card_logo_5806741801_seeklogo_com
        Me.PictureBox1.Location = New System.Drawing.Point(496, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(491, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 27)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fee:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(496, 267)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 34)
        Me.TextBox1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(870, 608)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.zipTextBox)
        Me.Controls.Add(Me.expTextBox)
        Me.Controls.Add(Me.ccTextBox)
        Me.Controls.Add(Me.Buy)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "My App"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Buy As Button
    Friend WithEvents ccTextBox As TextBox
    Friend WithEvents expTextBox As TextBox
    Friend WithEvents zipTextBox As TextBox
    Friend WithEvents amountTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
