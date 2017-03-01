<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vbForm
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
        Me.salesButton = New System.Windows.Forms.Button
        Me.detailButton = New System.Windows.Forms.Button
        Me.serviceButton = New System.Windows.Forms.Button
        Me.empButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.msgLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'salesButton
        '
        Me.salesButton.Location = New System.Drawing.Point(32, 100)
        Me.salesButton.Name = "salesButton"
        Me.salesButton.Size = New System.Drawing.Size(100, 40)
        Me.salesButton.TabIndex = 0
        Me.salesButton.Text = "Auto Sales"
        Me.salesButton.UseVisualStyleBackColor = True
        '
        'detailButton
        '
        Me.detailButton.Location = New System.Drawing.Point(32, 150)
        Me.detailButton.Name = "detailButton"
        Me.detailButton.Size = New System.Drawing.Size(100, 40)
        Me.detailButton.TabIndex = 1
        Me.detailButton.Text = "Detail Shop"
        Me.detailButton.UseVisualStyleBackColor = True
        '
        'serviceButton
        '
        Me.serviceButton.Location = New System.Drawing.Point(157, 100)
        Me.serviceButton.Name = "serviceButton"
        Me.serviceButton.Size = New System.Drawing.Size(100, 40)
        Me.serviceButton.TabIndex = 2
        Me.serviceButton.Text = "Service Center"
        Me.serviceButton.UseVisualStyleBackColor = True
        '
        'empButton
        '
        Me.empButton.Location = New System.Drawing.Point(157, 150)
        Me.empButton.Name = "empButton"
        Me.empButton.Size = New System.Drawing.Size(100, 40)
        Me.empButton.TabIndex = 3
        Me.empButton.Text = "Employment Opportunities"
        Me.empButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(94, 200)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 40)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'msgLabel
        '
        Me.msgLabel.AutoSize = True
        Me.msgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgLabel.Location = New System.Drawing.Point(32, 25)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(0, 13)
        Me.msgLabel.TabIndex = 5
        '
        'vbForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.empButton)
        Me.Controls.Add(Me.serviceButton)
        Me.Controls.Add(Me.detailButton)
        Me.Controls.Add(Me.salesButton)
        Me.Name = "vbForm"
        Me.Text = "VB Auto Center"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents salesButton As System.Windows.Forms.Button
    Friend WithEvents detailButton As System.Windows.Forms.Button
    Friend WithEvents serviceButton As System.Windows.Forms.Button
    Friend WithEvents empButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents msgLabel As System.Windows.Forms.Label

End Class
