<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tips
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.subtotalTextBox = New System.Windows.Forms.TextBox()
        Me.grandTotalLabel = New System.Windows.Forms.Label()
        Me.GrandtotalTextBox = New System.Windows.Forms.TextBox()
        Me.subtotalLabel = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SalesTaxLabel = New System.Windows.Forms.Label()
        Me.SalesTaxTextBox = New System.Windows.Forms.TextBox()
        Me.AddSalesTax = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "0%"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'subtotalTextBox
        '
        Me.subtotalTextBox.Location = New System.Drawing.Point(19, 68)
        Me.subtotalTextBox.Name = "subtotalTextBox"
        Me.subtotalTextBox.Size = New System.Drawing.Size(138, 22)
        Me.subtotalTextBox.TabIndex = 1
        '
        'grandTotalLabel
        '
        Me.grandTotalLabel.AutoSize = True
        Me.grandTotalLabel.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grandTotalLabel.Location = New System.Drawing.Point(472, 28)
        Me.grandTotalLabel.Name = "grandTotalLabel"
        Me.grandTotalLabel.Size = New System.Drawing.Size(181, 37)
        Me.grandTotalLabel.TabIndex = 2
        Me.grandTotalLabel.Text = "Grand Total:"
        '
        'GrandtotalTextBox
        '
        Me.GrandtotalTextBox.Location = New System.Drawing.Point(480, 68)
        Me.GrandtotalTextBox.Name = "GrandtotalTextBox"
        Me.GrandtotalTextBox.Size = New System.Drawing.Size(173, 22)
        Me.GrandtotalTextBox.TabIndex = 6
        '
        'subtotalLabel
        '
        Me.subtotalLabel.AutoSize = True
        Me.subtotalLabel.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotalLabel.Location = New System.Drawing.Point(12, 28)
        Me.subtotalLabel.Name = "subtotalLabel"
        Me.subtotalLabel.Size = New System.Drawing.Size(134, 37)
        Me.subtotalLabel.TabIndex = 7
        Me.subtotalLabel.Text = "Subtotal:"
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(139, 96)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(123, 37)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "15%"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(268, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 37)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "20%"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(398, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 37)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "25%"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(530, 96)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 37)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "50%"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SalesTaxLabel
        '
        Me.SalesTaxLabel.AutoSize = True
        Me.SalesTaxLabel.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesTaxLabel.Location = New System.Drawing.Point(231, 28)
        Me.SalesTaxLabel.Name = "SalesTaxLabel"
        Me.SalesTaxLabel.Size = New System.Drawing.Size(141, 37)
        Me.SalesTaxLabel.TabIndex = 12
        Me.SalesTaxLabel.Text = "Sales Tax:"
        '
        'SalesTaxTextBox
        '
        Me.SalesTaxTextBox.Location = New System.Drawing.Point(238, 68)
        Me.SalesTaxTextBox.Name = "SalesTaxTextBox"
        Me.SalesTaxTextBox.Size = New System.Drawing.Size(162, 22)
        Me.SalesTaxTextBox.TabIndex = 13
        '
        'AddSalesTax
        '
        Me.AddSalesTax.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSalesTax.Location = New System.Drawing.Point(238, 165)
        Me.AddSalesTax.Name = "AddSalesTax"
        Me.AddSalesTax.Size = New System.Drawing.Size(169, 53)
        Me.AddSalesTax.TabIndex = 14
        Me.AddSalesTax.Text = " Add Sales Tax"
        Me.AddSalesTax.UseVisualStyleBackColor = True
        '
        'Tips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(675, 459)
        Me.Controls.Add(Me.AddSalesTax)
        Me.Controls.Add(Me.SalesTaxTextBox)
        Me.Controls.Add(Me.SalesTaxLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.subtotalLabel)
        Me.Controls.Add(Me.GrandtotalTextBox)
        Me.Controls.Add(Me.grandTotalLabel)
        Me.Controls.Add(Me.subtotalTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Tips"
        Me.Text = "Tips"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents subtotalTextBox As TextBox
    Friend WithEvents grandTotalLabel As Label
    Friend WithEvents GrandtotalTextBox As TextBox
    Friend WithEvents subtotalLabel As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents SalesTaxLabel As Label
    Friend WithEvents SalesTaxTextBox As TextBox
    Friend WithEvents AddSalesTax As Button
End Class
