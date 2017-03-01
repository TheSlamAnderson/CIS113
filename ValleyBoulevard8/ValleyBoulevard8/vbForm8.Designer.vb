<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vbForm8
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
        Me.brandGroupBox = New System.Windows.Forms.GroupBox
        Me.xRadioButton = New System.Windows.Forms.RadioButton
        Me.cRadioButton = New System.Windows.Forms.RadioButton
        Me.aRadioButton = New System.Windows.Forms.RadioButton
        Me.partGroupBox = New System.Windows.Forms.GroupBox
        Me.searchTextBox = New System.Windows.Forms.TextBox
        Me.vbpartGroupBox = New System.Windows.Forms.GroupBox
        Me.resultTextBox = New System.Windows.Forms.TextBox
        Me.searchButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.brandGroupBox.SuspendLayout()
        Me.partGroupBox.SuspendLayout()
        Me.vbpartGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'brandGroupBox
        '
        Me.brandGroupBox.Controls.Add(Me.xRadioButton)
        Me.brandGroupBox.Controls.Add(Me.cRadioButton)
        Me.brandGroupBox.Controls.Add(Me.aRadioButton)
        Me.brandGroupBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brandGroupBox.ForeColor = System.Drawing.Color.Black
        Me.brandGroupBox.Location = New System.Drawing.Point(15, 15)
        Me.brandGroupBox.Name = "brandGroupBox"
        Me.brandGroupBox.Size = New System.Drawing.Size(125, 125)
        Me.brandGroupBox.TabIndex = 3
        Me.brandGroupBox.TabStop = False
        Me.brandGroupBox.Text = "Select Brand"
        '
        'xRadioButton
        '
        Me.xRadioButton.AutoSize = True
        Me.xRadioButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xRadioButton.Location = New System.Drawing.Point(25, 90)
        Me.xRadioButton.Name = "xRadioButton"
        Me.xRadioButton.Size = New System.Drawing.Size(71, 20)
        Me.xRadioButton.TabIndex = 2
        Me.xRadioButton.Text = "Brand X"
        Me.xRadioButton.UseVisualStyleBackColor = True
        '
        'cRadioButton
        '
        Me.cRadioButton.AutoSize = True
        Me.cRadioButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cRadioButton.Location = New System.Drawing.Point(25, 60)
        Me.cRadioButton.Name = "cRadioButton"
        Me.cRadioButton.Size = New System.Drawing.Size(71, 20)
        Me.cRadioButton.TabIndex = 1
        Me.cRadioButton.Text = "Brand C"
        Me.cRadioButton.UseVisualStyleBackColor = True
        '
        'aRadioButton
        '
        Me.aRadioButton.AutoSize = True
        Me.aRadioButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aRadioButton.Location = New System.Drawing.Point(25, 30)
        Me.aRadioButton.Name = "aRadioButton"
        Me.aRadioButton.Size = New System.Drawing.Size(71, 20)
        Me.aRadioButton.TabIndex = 0
        Me.aRadioButton.Text = "Brand A"
        Me.aRadioButton.UseVisualStyleBackColor = True
        '
        'partGroupBox
        '
        Me.partGroupBox.Controls.Add(Me.searchTextBox)
        Me.partGroupBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partGroupBox.ForeColor = System.Drawing.Color.Black
        Me.partGroupBox.Location = New System.Drawing.Point(160, 15)
        Me.partGroupBox.Name = "partGroupBox"
        Me.partGroupBox.Size = New System.Drawing.Size(150, 125)
        Me.partGroupBox.TabIndex = 4
        Me.partGroupBox.TabStop = False
        Me.partGroupBox.Text = "Enter Part Number"
        '
        'searchTextBox
        '
        Me.searchTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.Color.Black
        Me.searchTextBox.Location = New System.Drawing.Point(15, 55)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(121, 23)
        Me.searchTextBox.TabIndex = 0
        '
        'vbpartGroupBox
        '
        Me.vbpartGroupBox.Controls.Add(Me.resultTextBox)
        Me.vbpartGroupBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vbpartGroupBox.ForeColor = System.Drawing.Color.Black
        Me.vbpartGroupBox.Location = New System.Drawing.Point(330, 15)
        Me.vbpartGroupBox.Name = "vbpartGroupBox"
        Me.vbpartGroupBox.Size = New System.Drawing.Size(150, 125)
        Me.vbpartGroupBox.TabIndex = 5
        Me.vbpartGroupBox.TabStop = False
        Me.vbpartGroupBox.Text = "VB Part Number"
        '
        'resultTextBox
        '
        Me.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultTextBox.ForeColor = System.Drawing.Color.Black
        Me.resultTextBox.Location = New System.Drawing.Point(15, 55)
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.ReadOnly = True
        Me.resultTextBox.Size = New System.Drawing.Size(121, 23)
        Me.resultTextBox.TabIndex = 0
        '
        'searchButton
        '
        Me.searchButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.Location = New System.Drawing.Point(55, 165)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(100, 30)
        Me.searchButton.TabIndex = 6
        Me.searchButton.Text = "Lookup"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.Color.Black
        Me.clearButton.Location = New System.Drawing.Point(185, 165)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 30)
        Me.clearButton.TabIndex = 7
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.Color.Black
        Me.exitButton.Location = New System.Drawing.Point(315, 165)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 30)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'vbForm8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 211)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.vbpartGroupBox)
        Me.Controls.Add(Me.partGroupBox)
        Me.Controls.Add(Me.brandGroupBox)
        Me.Name = "vbForm8"
        Me.Text = "VB Auto Center"
        Me.brandGroupBox.ResumeLayout(False)
        Me.brandGroupBox.PerformLayout()
        Me.partGroupBox.ResumeLayout(False)
        Me.partGroupBox.PerformLayout()
        Me.vbpartGroupBox.ResumeLayout(False)
        Me.vbpartGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents brandGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents xRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents cRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents aRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents partGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents searchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents vbpartGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents resultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
