<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBAutoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.salesLabel = New System.Windows.Forms.Label
        Me.priceLabel = New System.Windows.Forms.Label
        Me.costLabel = New System.Windows.Forms.Label
        Me.salesTextBox = New System.Windows.Forms.TextBox
        Me.priceTextBox = New System.Windows.Forms.TextBox
        Me.costTextBox = New System.Windows.Forms.TextBox
        Me.CommLabel = New System.Windows.Forms.Label
        Me.calcButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.valueTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'salesLabel
        '
        Me.salesLabel.AutoSize = True
        Me.salesLabel.Location = New System.Drawing.Point(25, 25)
        Me.salesLabel.Name = "salesLabel"
        Me.salesLabel.Size = New System.Drawing.Size(68, 13)
        Me.salesLabel.TabIndex = 0
        Me.salesLabel.Text = "Salesperson:"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(25, 55)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(68, 13)
        Me.priceLabel.TabIndex = 1
        Me.priceLabel.Text = "Selling Price:"
        '
        'costLabel
        '
        Me.costLabel.AutoSize = True
        Me.costLabel.Location = New System.Drawing.Point(25, 85)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(61, 13)
        Me.costLabel.TabIndex = 2
        Me.costLabel.Text = "Cost Value:"
        '
        'salesTextBox
        '
        Me.salesTextBox.Location = New System.Drawing.Point(120, 18)
        Me.salesTextBox.Name = "salesTextBox"
        Me.salesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.salesTextBox.TabIndex = 3
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(120, 48)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.priceTextBox.TabIndex = 4
        '
        'costTextBox
        '
        Me.costTextBox.Location = New System.Drawing.Point(120, 78)
        Me.costTextBox.Name = "costTextBox"
        Me.costTextBox.Size = New System.Drawing.Size(100, 20)
        Me.costTextBox.TabIndex = 5
        '
        'CommLabel
        '
        Me.CommLabel.AutoSize = True
        Me.CommLabel.Location = New System.Drawing.Point(25, 115)
        Me.CommLabel.Name = "CommLabel"
        Me.CommLabel.Size = New System.Drawing.Size(65, 13)
        Me.CommLabel.TabIndex = 6
        Me.CommLabel.Text = "Commission:"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(25, 150)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(100, 30)
        Me.calcButton.TabIndex = 8
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(150, 150)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 30)
        Me.clearButton.TabIndex = 9
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(275, 150)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 30)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'valueTextBox
        '
        Me.valueTextBox.Location = New System.Drawing.Point(120, 109)
        Me.valueTextBox.Name = "valueTextBox"
        Me.valueTextBox.ReadOnly = True
        Me.valueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.valueTextBox.TabIndex = 11
        '
        'VBAutoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 201)
        Me.Controls.Add(Me.valueTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.CommLabel)
        Me.Controls.Add(Me.costTextBox)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.salesTextBox)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.salesLabel)
        Me.Name = "VBAutoForm"
        Me.Text = "VB Auto Center"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents salesLabel As System.Windows.Forms.Label
    Friend WithEvents priceLabel As System.Windows.Forms.Label
    Friend WithEvents costLabel As System.Windows.Forms.Label
    Friend WithEvents salesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents costTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents valueTextBox As System.Windows.Forms.TextBox

End Class
