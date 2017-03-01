<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vbForm4
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
        Me.accGroupBox = New System.Windows.Forms.GroupBox
        Me.navCheckBox = New System.Windows.Forms.CheckBox
        Me.interiorCheckBox = New System.Windows.Forms.CheckBox
        Me.stereoCheckBox = New System.Windows.Forms.CheckBox
        Me.finishGroupBox = New System.Windows.Forms.GroupBox
        Me.customRadioButton = New System.Windows.Forms.RadioButton
        Me.pearlizedRadioButton = New System.Windows.Forms.RadioButton
        Me.standardRadioButton = New System.Windows.Forms.RadioButton
        Me.calcButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.saleLabel = New System.Windows.Forms.Label
        Me.accLabel = New System.Windows.Forms.Label
        Me.taxLabel = New System.Windows.Forms.Label
        Me.subLabel = New System.Windows.Forms.Label
        Me.tradeLabel = New System.Windows.Forms.Label
        Me.dueLabel = New System.Windows.Forms.Label
        Me.saleTextBox = New System.Windows.Forms.TextBox
        Me.accTextBox = New System.Windows.Forms.TextBox
        Me.taxTextBox = New System.Windows.Forms.TextBox
        Me.subTextBox = New System.Windows.Forms.TextBox
        Me.tradeTextBox = New System.Windows.Forms.TextBox
        Me.dueTextBox = New System.Windows.Forms.TextBox
        Me.totalLabel = New System.Windows.Forms.Label
        Me.totalTextBox = New System.Windows.Forms.TextBox
        Me.accGroupBox.SuspendLayout()
        Me.finishGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'accGroupBox
        '
        Me.accGroupBox.Controls.Add(Me.navCheckBox)
        Me.accGroupBox.Controls.Add(Me.interiorCheckBox)
        Me.accGroupBox.Controls.Add(Me.stereoCheckBox)
        Me.accGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accGroupBox.ForeColor = System.Drawing.Color.Black
        Me.accGroupBox.Location = New System.Drawing.Point(15, 15)
        Me.accGroupBox.Name = "accGroupBox"
        Me.accGroupBox.Size = New System.Drawing.Size(200, 150)
        Me.accGroupBox.TabIndex = 2
        Me.accGroupBox.TabStop = False
        Me.accGroupBox.Text = "Accessories"
        '
        'navCheckBox
        '
        Me.navCheckBox.AutoSize = True
        Me.navCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.navCheckBox.Location = New System.Drawing.Point(20, 105)
        Me.navCheckBox.Name = "navCheckBox"
        Me.navCheckBox.Size = New System.Drawing.Size(153, 20)
        Me.navCheckBox.TabIndex = 2
        Me.navCheckBox.Text = "Computer &Navigation"
        Me.navCheckBox.UseVisualStyleBackColor = True
        '
        'interiorCheckBox
        '
        Me.interiorCheckBox.AutoSize = True
        Me.interiorCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.interiorCheckBox.Location = New System.Drawing.Point(20, 70)
        Me.interiorCheckBox.Name = "interiorCheckBox"
        Me.interiorCheckBox.Size = New System.Drawing.Size(115, 20)
        Me.interiorCheckBox.TabIndex = 1
        Me.interiorCheckBox.Text = "Leather &Interior"
        Me.interiorCheckBox.UseVisualStyleBackColor = True
        '
        'stereoCheckBox
        '
        Me.stereoCheckBox.AutoSize = True
        Me.stereoCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stereoCheckBox.Location = New System.Drawing.Point(20, 35)
        Me.stereoCheckBox.Name = "stereoCheckBox"
        Me.stereoCheckBox.Size = New System.Drawing.Size(115, 20)
        Me.stereoCheckBox.TabIndex = 0
        Me.stereoCheckBox.Text = "&Stereo System"
        Me.stereoCheckBox.UseVisualStyleBackColor = True
        '
        'finishGroupBox
        '
        Me.finishGroupBox.Controls.Add(Me.customRadioButton)
        Me.finishGroupBox.Controls.Add(Me.pearlizedRadioButton)
        Me.finishGroupBox.Controls.Add(Me.standardRadioButton)
        Me.finishGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finishGroupBox.ForeColor = System.Drawing.Color.Black
        Me.finishGroupBox.Location = New System.Drawing.Point(15, 175)
        Me.finishGroupBox.Name = "finishGroupBox"
        Me.finishGroupBox.Size = New System.Drawing.Size(200, 150)
        Me.finishGroupBox.TabIndex = 3
        Me.finishGroupBox.TabStop = False
        Me.finishGroupBox.Text = "Exterior Finish"
        '
        'customRadioButton
        '
        Me.customRadioButton.AutoSize = True
        Me.customRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customRadioButton.Location = New System.Drawing.Point(20, 105)
        Me.customRadioButton.Name = "customRadioButton"
        Me.customRadioButton.Size = New System.Drawing.Size(152, 20)
        Me.customRadioButton.TabIndex = 2
        Me.customRadioButton.Text = "Customized &Detailing"
        Me.customRadioButton.UseVisualStyleBackColor = True
        '
        'pearlizedRadioButton
        '
        Me.pearlizedRadioButton.AutoSize = True
        Me.pearlizedRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pearlizedRadioButton.Location = New System.Drawing.Point(20, 70)
        Me.pearlizedRadioButton.Name = "pearlizedRadioButton"
        Me.pearlizedRadioButton.Size = New System.Drawing.Size(83, 20)
        Me.pearlizedRadioButton.TabIndex = 1
        Me.pearlizedRadioButton.Text = "&Pearlized"
        Me.pearlizedRadioButton.UseVisualStyleBackColor = True
        '
        'standardRadioButton
        '
        Me.standardRadioButton.AutoSize = True
        Me.standardRadioButton.Checked = True
        Me.standardRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.standardRadioButton.Location = New System.Drawing.Point(20, 35)
        Me.standardRadioButton.Name = "standardRadioButton"
        Me.standardRadioButton.Size = New System.Drawing.Size(81, 20)
        Me.standardRadioButton.TabIndex = 0
        Me.standardRadioButton.Text = "S&tandard"
        Me.standardRadioButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcButton.ForeColor = System.Drawing.Color.Black
        Me.calcButton.Location = New System.Drawing.Point(230, 295)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(100, 30)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.Color.Black
        Me.clearButton.Location = New System.Drawing.Point(340, 295)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 30)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.Color.Black
        Me.exitButton.Location = New System.Drawing.Point(450, 295)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 30)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'saleLabel
        '
        Me.saleLabel.AutoSize = True
        Me.saleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saleLabel.ForeColor = System.Drawing.Color.Black
        Me.saleLabel.Location = New System.Drawing.Point(288, 29)
        Me.saleLabel.Name = "saleLabel"
        Me.saleLabel.Size = New System.Drawing.Size(112, 16)
        Me.saleLabel.TabIndex = 5
        Me.saleLabel.Text = "C&ar Sale Price:"
        Me.saleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'accLabel
        '
        Me.accLabel.AutoSize = True
        Me.accLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accLabel.ForeColor = System.Drawing.Color.Black
        Me.accLabel.Location = New System.Drawing.Point(264, 64)
        Me.accLabel.Name = "accLabel"
        Me.accLabel.Size = New System.Drawing.Size(136, 16)
        Me.accLabel.TabIndex = 6
        Me.accLabel.Text = "Accessories && Finish:"
        Me.accLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxLabel.ForeColor = System.Drawing.Color.Black
        Me.taxLabel.Location = New System.Drawing.Point(298, 134)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(102, 16)
        Me.taxLabel.TabIndex = 7
        Me.taxLabel.Text = "Sales Tax (8%):"
        Me.taxLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'subLabel
        '
        Me.subLabel.AutoSize = True
        Me.subLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subLabel.ForeColor = System.Drawing.Color.Black
        Me.subLabel.Location = New System.Drawing.Point(340, 99)
        Me.subLabel.Name = "subLabel"
        Me.subLabel.Size = New System.Drawing.Size(60, 16)
        Me.subLabel.TabIndex = 8
        Me.subLabel.Text = "Subtotal:"
        Me.subLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'tradeLabel
        '
        Me.tradeLabel.AutoSize = True
        Me.tradeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tradeLabel.ForeColor = System.Drawing.Color.Black
        Me.tradeLabel.Location = New System.Drawing.Point(273, 204)
        Me.tradeLabel.Name = "tradeLabel"
        Me.tradeLabel.Size = New System.Drawing.Size(127, 16)
        Me.tradeLabel.TabIndex = 9
        Me.tradeLabel.Text = "T&rade-In Allowance:"
        Me.tradeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dueLabel
        '
        Me.dueLabel.AutoSize = True
        Me.dueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueLabel.ForeColor = System.Drawing.Color.Red
        Me.dueLabel.Location = New System.Drawing.Point(305, 241)
        Me.dueLabel.Name = "dueLabel"
        Me.dueLabel.Size = New System.Drawing.Size(95, 16)
        Me.dueLabel.TabIndex = 10
        Me.dueLabel.Text = "Amount Due:"
        Me.dueLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'saleTextBox
        '
        Me.saleTextBox.Location = New System.Drawing.Point(425, 25)
        Me.saleTextBox.Name = "saleTextBox"
        Me.saleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.saleTextBox.TabIndex = 0
        Me.saleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'accTextBox
        '
        Me.accTextBox.Location = New System.Drawing.Point(425, 60)
        Me.accTextBox.Name = "accTextBox"
        Me.accTextBox.ReadOnly = True
        Me.accTextBox.Size = New System.Drawing.Size(100, 20)
        Me.accTextBox.TabIndex = 12
        Me.accTextBox.TabStop = False
        Me.accTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'taxTextBox
        '
        Me.taxTextBox.Location = New System.Drawing.Point(425, 130)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.ReadOnly = True
        Me.taxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.taxTextBox.TabIndex = 13
        Me.taxTextBox.TabStop = False
        Me.taxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'subTextBox
        '
        Me.subTextBox.Location = New System.Drawing.Point(425, 95)
        Me.subTextBox.Name = "subTextBox"
        Me.subTextBox.ReadOnly = True
        Me.subTextBox.Size = New System.Drawing.Size(100, 20)
        Me.subTextBox.TabIndex = 14
        Me.subTextBox.TabStop = False
        Me.subTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tradeTextBox
        '
        Me.tradeTextBox.Location = New System.Drawing.Point(425, 200)
        Me.tradeTextBox.Name = "tradeTextBox"
        Me.tradeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.tradeTextBox.TabIndex = 1
        Me.tradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dueTextBox
        '
        Me.dueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dueTextBox.Location = New System.Drawing.Point(425, 235)
        Me.dueTextBox.Name = "dueTextBox"
        Me.dueTextBox.ReadOnly = True
        Me.dueTextBox.Size = New System.Drawing.Size(100, 22)
        Me.dueTextBox.TabIndex = 16
        Me.dueTextBox.TabStop = False
        Me.dueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.ForeColor = System.Drawing.Color.Black
        Me.totalLabel.Location = New System.Drawing.Point(358, 169)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(42, 16)
        Me.totalLabel.TabIndex = 17
        Me.totalLabel.Text = "Total:"
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(425, 165)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.totalTextBox.TabIndex = 18
        Me.totalTextBox.TabStop = False
        Me.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'vbForm4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 341)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.dueTextBox)
        Me.Controls.Add(Me.tradeTextBox)
        Me.Controls.Add(Me.subTextBox)
        Me.Controls.Add(Me.taxTextBox)
        Me.Controls.Add(Me.accTextBox)
        Me.Controls.Add(Me.saleTextBox)
        Me.Controls.Add(Me.dueLabel)
        Me.Controls.Add(Me.tradeLabel)
        Me.Controls.Add(Me.subLabel)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.accLabel)
        Me.Controls.Add(Me.saleLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.finishGroupBox)
        Me.Controls.Add(Me.accGroupBox)
        Me.Name = "vbForm4"
        Me.Text = "VB Auto Center"
        Me.accGroupBox.ResumeLayout(False)
        Me.accGroupBox.PerformLayout()
        Me.finishGroupBox.ResumeLayout(False)
        Me.finishGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents accGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents finishGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents saleLabel As System.Windows.Forms.Label
    Friend WithEvents accLabel As System.Windows.Forms.Label
    Friend WithEvents taxLabel As System.Windows.Forms.Label
    Friend WithEvents subLabel As System.Windows.Forms.Label
    Friend WithEvents tradeLabel As System.Windows.Forms.Label
    Friend WithEvents dueLabel As System.Windows.Forms.Label
    Friend WithEvents saleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents accTextBox As System.Windows.Forms.TextBox
    Friend WithEvents taxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents subTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents navCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents interiorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents stereoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents customRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents pearlizedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents standardRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents totalTextBox As System.Windows.Forms.TextBox

End Class
