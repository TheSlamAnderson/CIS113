<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vbForm7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vbForm7))
        Me.pkgComboBox = New System.Windows.Forms.ComboBox
        Me.pkgMsgLabel = New System.Windows.Forms.Label
        Me.extListBox = New System.Windows.Forms.ListBox
        Me.intListBox = New System.Windows.Forms.ListBox
        Me.fragComboBox = New System.Windows.Forms.ComboBox
        Me.fragMsgLabel = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.extMsgLabel = New System.Windows.Forms.Label
        Me.intMsgLabel = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pkgComboBox
        '
        Me.pkgComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pkgComboBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pkgComboBox.FormattingEnabled = True
        Me.pkgComboBox.Items.AddRange(New Object() {"Standard", "Deluxe", "Executive", "Luxury"})
        Me.pkgComboBox.Location = New System.Drawing.Point(18, 65)
        Me.pkgComboBox.Name = "pkgComboBox"
        Me.pkgComboBox.Size = New System.Drawing.Size(218, 24)
        Me.pkgComboBox.TabIndex = 0
        '
        'pkgMsgLabel
        '
        Me.pkgMsgLabel.AutoSize = True
        Me.pkgMsgLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pkgMsgLabel.Location = New System.Drawing.Point(15, 45)
        Me.pkgMsgLabel.Name = "pkgMsgLabel"
        Me.pkgMsgLabel.Size = New System.Drawing.Size(125, 16)
        Me.pkgMsgLabel.TabIndex = 1
        Me.pkgMsgLabel.Text = "Select A Package:"
        '
        'extListBox
        '
        Me.extListBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extListBox.FormattingEnabled = True
        Me.extListBox.ItemHeight = 16
        Me.extListBox.Location = New System.Drawing.Point(18, 129)
        Me.extListBox.Name = "extListBox"
        Me.extListBox.Size = New System.Drawing.Size(218, 84)
        Me.extListBox.TabIndex = 2
        '
        'intListBox
        '
        Me.intListBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intListBox.FormattingEnabled = True
        Me.intListBox.ItemHeight = 16
        Me.intListBox.Location = New System.Drawing.Point(18, 253)
        Me.intListBox.Name = "intListBox"
        Me.intListBox.Size = New System.Drawing.Size(218, 68)
        Me.intListBox.TabIndex = 3
        '
        'fragComboBox
        '
        Me.fragComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fragComboBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fragComboBox.FormattingEnabled = True
        Me.fragComboBox.Items.AddRange(New Object() {"Hawaiian Mist", "Baby Powder", "Pine", "Country Floral", "Pina Colada", "Vanilla"})
        Me.fragComboBox.Location = New System.Drawing.Point(18, 361)
        Me.fragComboBox.Name = "fragComboBox"
        Me.fragComboBox.Size = New System.Drawing.Size(218, 24)
        Me.fragComboBox.TabIndex = 4
        '
        'fragMsgLabel
        '
        Me.fragMsgLabel.AutoSize = True
        Me.fragMsgLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fragMsgLabel.Location = New System.Drawing.Point(15, 341)
        Me.fragMsgLabel.Name = "fragMsgLabel"
        Me.fragMsgLabel.Size = New System.Drawing.Size(136, 16)
        Me.fragMsgLabel.TabIndex = 5
        Me.fragMsgLabel.Text = "Select A Fragrance:"
        Me.fragMsgLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(252, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'extMsgLabel
        '
        Me.extMsgLabel.AutoSize = True
        Me.extMsgLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extMsgLabel.Location = New System.Drawing.Point(15, 109)
        Me.extMsgLabel.Name = "extMsgLabel"
        Me.extMsgLabel.Size = New System.Drawing.Size(117, 16)
        Me.extMsgLabel.TabIndex = 7
        Me.extMsgLabel.Text = "Exterior Options:"
        '
        'intMsgLabel
        '
        Me.intMsgLabel.AutoSize = True
        Me.intMsgLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intMsgLabel.Location = New System.Drawing.Point(15, 233)
        Me.intMsgLabel.Name = "intMsgLabel"
        Me.intMsgLabel.Size = New System.Drawing.Size(116, 16)
        Me.intMsgLabel.TabIndex = 8
        Me.intMsgLabel.Text = "Interior Options:"
        '
        'vbForm7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 406)
        Me.Controls.Add(Me.intMsgLabel)
        Me.Controls.Add(Me.extMsgLabel)
        Me.Controls.Add(Me.fragMsgLabel)
        Me.Controls.Add(Me.fragComboBox)
        Me.Controls.Add(Me.intListBox)
        Me.Controls.Add(Me.extListBox)
        Me.Controls.Add(Me.pkgMsgLabel)
        Me.Controls.Add(Me.pkgComboBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "vbForm7"
        Me.Text = "VB Auto Center"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pkgComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents pkgMsgLabel As System.Windows.Forms.Label
    Friend WithEvents extListBox As System.Windows.Forms.ListBox
    Friend WithEvents intListBox As System.Windows.Forms.ListBox
    Friend WithEvents fragComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents fragMsgLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents extMsgLabel As System.Windows.Forms.Label
    Friend WithEvents intMsgLabel As System.Windows.Forms.Label

End Class
