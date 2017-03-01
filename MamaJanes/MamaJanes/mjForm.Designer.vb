<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mjForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mjForm))
        Me.nameLabel = New System.Windows.Forms.Label
        Me.nameTextBox = New System.Windows.Forms.TextBox
        Me.addLabel = New System.Windows.Forms.Label
        Me.addTextBox = New System.Windows.Forms.TextBox
        Me.cityLabel = New System.Windows.Forms.Label
        Me.cityTextBox = New System.Windows.Forms.TextBox
        Me.stLabel = New System.Windows.Forms.Label
        Me.stTextBox = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.zipLabel = New System.Windows.Forms.Label
        Me.zipTextBox = New System.Windows.Forms.TextBox
        Me.topGroupBox = New System.Windows.Forms.GroupBox
        Me.excCheckBox = New System.Windows.Forms.CheckBox
        Me.onionCheckBox = New System.Windows.Forms.CheckBox
        Me.pepCheckBox = New System.Windows.Forms.CheckBox
        Me.discGroupBox = New System.Windows.Forms.GroupBox
        Me.prefRadioButton = New System.Windows.Forms.RadioButton
        Me.coupRadioButton = New System.Windows.Forms.RadioButton
        Me.noneRadioButton = New System.Windows.Forms.RadioButton
        Me.sizeLabel = New System.Windows.Forms.Label
        Me.sizeComboBox = New System.Windows.Forms.ComboBox
        Me.styleLabel = New System.Windows.Forms.Label
        Me.styleComboBox = New System.Windows.Forms.ComboBox
        Me.pizzaLabel = New System.Windows.Forms.Label
        Me.pizzaTextBox = New System.Windows.Forms.TextBox
        Me.topLabel = New System.Windows.Forms.Label
        Me.discLabel = New System.Windows.Forms.Label
        Me.taxLabel = New System.Windows.Forms.Label
        Me.dueLabel = New System.Windows.Forms.Label
        Me.topTextBox = New System.Windows.Forms.TextBox
        Me.discTextBox = New System.Windows.Forms.TextBox
        Me.taxTextBox = New System.Windows.Forms.TextBox
        Me.dueTextBox = New System.Windows.Forms.TextBox
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.calcButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.printButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.MenuStrip1.SuspendLayout()
        Me.topGroupBox.SuspendLayout()
        Me.discGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.Black
        Me.nameLabel.Location = New System.Drawing.Point(11, 50)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(114, 16)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Customer Name:"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'nameTextBox
        '
        Me.nameTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTextBox.ForeColor = System.Drawing.Color.Black
        Me.nameTextBox.Location = New System.Drawing.Point(130, 43)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(355, 23)
        Me.nameTextBox.TabIndex = 0
        '
        'addLabel
        '
        Me.addLabel.AutoSize = True
        Me.addLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addLabel.ForeColor = System.Drawing.Color.Black
        Me.addLabel.Location = New System.Drawing.Point(12, 90)
        Me.addLabel.Name = "addLabel"
        Me.addLabel.Size = New System.Drawing.Size(113, 16)
        Me.addLabel.TabIndex = 2
        Me.addLabel.Text = "Street Address:"
        Me.addLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'addTextBox
        '
        Me.addTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTextBox.ForeColor = System.Drawing.Color.Black
        Me.addTextBox.Location = New System.Drawing.Point(130, 83)
        Me.addTextBox.Name = "addTextBox"
        Me.addTextBox.Size = New System.Drawing.Size(355, 23)
        Me.addTextBox.TabIndex = 1
        '
        'cityLabel
        '
        Me.cityLabel.AutoSize = True
        Me.cityLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityLabel.ForeColor = System.Drawing.Color.Black
        Me.cityLabel.Location = New System.Drawing.Point(87, 130)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(38, 16)
        Me.cityLabel.TabIndex = 4
        Me.cityLabel.Text = "City:"
        Me.cityLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'cityTextBox
        '
        Me.cityTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityTextBox.ForeColor = System.Drawing.Color.Black
        Me.cityTextBox.Location = New System.Drawing.Point(130, 123)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(125, 23)
        Me.cityTextBox.TabIndex = 2
        '
        'stLabel
        '
        Me.stLabel.AutoSize = True
        Me.stLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stLabel.ForeColor = System.Drawing.Color.Black
        Me.stLabel.Location = New System.Drawing.Point(265, 130)
        Me.stLabel.Name = "stLabel"
        Me.stLabel.Size = New System.Drawing.Size(49, 16)
        Me.stLabel.TabIndex = 6
        Me.stLabel.Text = "State:"
        Me.stLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'stTextBox
        '
        Me.stTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.stTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stTextBox.ForeColor = System.Drawing.Color.Black
        Me.stTextBox.Location = New System.Drawing.Point(319, 123)
        Me.stTextBox.MaxLength = 2
        Me.stTextBox.Name = "stTextBox"
        Me.stTextBox.Size = New System.Drawing.Size(40, 23)
        Me.stTextBox.TabIndex = 3
        Me.stTextBox.Text = "TN"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HeloToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(767, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StyleToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'StyleToolStripMenuItem
        '
        Me.StyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.StyleToolStripMenuItem.Name = "StyleToolStripMenuItem"
        Me.StyleToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.StyleToolStripMenuItem.Text = "&Style"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'HeloToolStripMenuItem
        '
        Me.HeloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HeloToolStripMenuItem.Name = "HeloToolStripMenuItem"
        Me.HeloToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HeloToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'zipLabel
        '
        Me.zipLabel.AutoSize = True
        Me.zipLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipLabel.ForeColor = System.Drawing.Color.Black
        Me.zipLabel.Location = New System.Drawing.Point(369, 130)
        Me.zipLabel.Name = "zipLabel"
        Me.zipLabel.Size = New System.Drawing.Size(31, 16)
        Me.zipLabel.TabIndex = 9
        Me.zipLabel.Text = "Zip:"
        Me.zipLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'zipTextBox
        '
        Me.zipTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipTextBox.ForeColor = System.Drawing.Color.Black
        Me.zipTextBox.Location = New System.Drawing.Point(405, 123)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(80, 23)
        Me.zipTextBox.TabIndex = 4
        '
        'topGroupBox
        '
        Me.topGroupBox.Controls.Add(Me.excCheckBox)
        Me.topGroupBox.Controls.Add(Me.onionCheckBox)
        Me.topGroupBox.Controls.Add(Me.pepCheckBox)
        Me.topGroupBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topGroupBox.ForeColor = System.Drawing.Color.Black
        Me.topGroupBox.Location = New System.Drawing.Point(60, 175)
        Me.topGroupBox.Name = "topGroupBox"
        Me.topGroupBox.Size = New System.Drawing.Size(200, 150)
        Me.topGroupBox.TabIndex = 5
        Me.topGroupBox.TabStop = False
        Me.topGroupBox.Text = "Toppings"
        '
        'excCheckBox
        '
        Me.excCheckBox.AutoSize = True
        Me.excCheckBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excCheckBox.Location = New System.Drawing.Point(25, 105)
        Me.excCheckBox.Name = "excCheckBox"
        Me.excCheckBox.Size = New System.Drawing.Size(102, 20)
        Me.excCheckBox.TabIndex = 2
        Me.excCheckBox.Text = "&Extra Cheese"
        Me.excCheckBox.UseVisualStyleBackColor = True
        '
        'onionCheckBox
        '
        Me.onionCheckBox.AutoSize = True
        Me.onionCheckBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onionCheckBox.Location = New System.Drawing.Point(25, 70)
        Me.onionCheckBox.Name = "onionCheckBox"
        Me.onionCheckBox.Size = New System.Drawing.Size(66, 20)
        Me.onionCheckBox.TabIndex = 1
        Me.onionCheckBox.Text = "&Onions"
        Me.onionCheckBox.UseVisualStyleBackColor = True
        '
        'pepCheckBox
        '
        Me.pepCheckBox.AutoSize = True
        Me.pepCheckBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pepCheckBox.Location = New System.Drawing.Point(25, 35)
        Me.pepCheckBox.Name = "pepCheckBox"
        Me.pepCheckBox.Size = New System.Drawing.Size(73, 20)
        Me.pepCheckBox.TabIndex = 0
        Me.pepCheckBox.Text = "&Peppers"
        Me.pepCheckBox.UseVisualStyleBackColor = True
        '
        'discGroupBox
        '
        Me.discGroupBox.Controls.Add(Me.prefRadioButton)
        Me.discGroupBox.Controls.Add(Me.coupRadioButton)
        Me.discGroupBox.Controls.Add(Me.noneRadioButton)
        Me.discGroupBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discGroupBox.ForeColor = System.Drawing.Color.Black
        Me.discGroupBox.Location = New System.Drawing.Point(285, 175)
        Me.discGroupBox.Name = "discGroupBox"
        Me.discGroupBox.Size = New System.Drawing.Size(200, 150)
        Me.discGroupBox.TabIndex = 6
        Me.discGroupBox.TabStop = False
        Me.discGroupBox.Text = "Discount"
        '
        'prefRadioButton
        '
        Me.prefRadioButton.AutoSize = True
        Me.prefRadioButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prefRadioButton.Location = New System.Drawing.Point(25, 105)
        Me.prefRadioButton.Name = "prefRadioButton"
        Me.prefRadioButton.Size = New System.Drawing.Size(139, 20)
        Me.prefRadioButton.TabIndex = 2
        Me.prefRadioButton.Text = "P&referred Customer"
        Me.prefRadioButton.UseVisualStyleBackColor = True
        '
        'coupRadioButton
        '
        Me.coupRadioButton.AutoSize = True
        Me.coupRadioButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coupRadioButton.Location = New System.Drawing.Point(25, 70)
        Me.coupRadioButton.Name = "coupRadioButton"
        Me.coupRadioButton.Size = New System.Drawing.Size(120, 20)
        Me.coupRadioButton.TabIndex = 1
        Me.coupRadioButton.Text = "10% Off &Coupon"
        Me.coupRadioButton.UseVisualStyleBackColor = True
        '
        'noneRadioButton
        '
        Me.noneRadioButton.AutoSize = True
        Me.noneRadioButton.Checked = True
        Me.noneRadioButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noneRadioButton.Location = New System.Drawing.Point(25, 35)
        Me.noneRadioButton.Name = "noneRadioButton"
        Me.noneRadioButton.Size = New System.Drawing.Size(55, 20)
        Me.noneRadioButton.TabIndex = 0
        Me.noneRadioButton.TabStop = True
        Me.noneRadioButton.Text = "&None"
        Me.noneRadioButton.UseVisualStyleBackColor = True
        '
        'sizeLabel
        '
        Me.sizeLabel.AutoSize = True
        Me.sizeLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sizeLabel.ForeColor = System.Drawing.Color.Black
        Me.sizeLabel.Location = New System.Drawing.Point(556, 49)
        Me.sizeLabel.Name = "sizeLabel"
        Me.sizeLabel.Size = New System.Drawing.Size(39, 16)
        Me.sizeLabel.TabIndex = 13
        Me.sizeLabel.Text = "Size:"
        Me.sizeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'sizeComboBox
        '
        Me.sizeComboBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sizeComboBox.ForeColor = System.Drawing.Color.Black
        Me.sizeComboBox.FormattingEnabled = True
        Me.sizeComboBox.Location = New System.Drawing.Point(600, 42)
        Me.sizeComboBox.Name = "sizeComboBox"
        Me.sizeComboBox.Size = New System.Drawing.Size(150, 24)
        Me.sizeComboBox.TabIndex = 7
        '
        'styleLabel
        '
        Me.styleLabel.AutoSize = True
        Me.styleLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.styleLabel.ForeColor = System.Drawing.Color.Black
        Me.styleLabel.Location = New System.Drawing.Point(549, 89)
        Me.styleLabel.Name = "styleLabel"
        Me.styleLabel.Size = New System.Drawing.Size(46, 16)
        Me.styleLabel.TabIndex = 15
        Me.styleLabel.Text = "Style:"
        Me.styleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'styleComboBox
        '
        Me.styleComboBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.styleComboBox.ForeColor = System.Drawing.Color.Black
        Me.styleComboBox.FormattingEnabled = True
        Me.styleComboBox.Location = New System.Drawing.Point(600, 82)
        Me.styleComboBox.Name = "styleComboBox"
        Me.styleComboBox.Size = New System.Drawing.Size(150, 24)
        Me.styleComboBox.TabIndex = 8
        '
        'pizzaLabel
        '
        Me.pizzaLabel.AutoSize = True
        Me.pizzaLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizzaLabel.ForeColor = System.Drawing.Color.Black
        Me.pizzaLabel.Location = New System.Drawing.Point(574, 175)
        Me.pizzaLabel.Name = "pizzaLabel"
        Me.pizzaLabel.Size = New System.Drawing.Size(46, 16)
        Me.pizzaLabel.TabIndex = 17
        Me.pizzaLabel.Text = "Pizza:"
        Me.pizzaLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'pizzaTextBox
        '
        Me.pizzaTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizzaTextBox.ForeColor = System.Drawing.Color.Black
        Me.pizzaTextBox.Location = New System.Drawing.Point(625, 168)
        Me.pizzaTextBox.Name = "pizzaTextBox"
        Me.pizzaTextBox.ReadOnly = True
        Me.pizzaTextBox.Size = New System.Drawing.Size(125, 23)
        Me.pizzaTextBox.TabIndex = 9
        Me.pizzaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'topLabel
        '
        Me.topLabel.AutoSize = True
        Me.topLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLabel.ForeColor = System.Drawing.Color.Black
        Me.topLabel.Location = New System.Drawing.Point(550, 205)
        Me.topLabel.Name = "topLabel"
        Me.topLabel.Size = New System.Drawing.Size(70, 16)
        Me.topLabel.TabIndex = 19
        Me.topLabel.Text = "Toppings:"
        Me.topLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'discLabel
        '
        Me.discLabel.AutoSize = True
        Me.discLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discLabel.ForeColor = System.Drawing.Color.Black
        Me.discLabel.Location = New System.Drawing.Point(551, 235)
        Me.discLabel.Name = "discLabel"
        Me.discLabel.Size = New System.Drawing.Size(69, 16)
        Me.discLabel.TabIndex = 20
        Me.discLabel.Text = "Discount:"
        Me.discLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxLabel.ForeColor = System.Drawing.Color.Black
        Me.taxLabel.Location = New System.Drawing.Point(509, 265)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(111, 16)
        Me.taxLabel.TabIndex = 21
        Me.taxLabel.Text = "Sales Tax (8%):"
        Me.taxLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dueLabel
        '
        Me.dueLabel.AutoSize = True
        Me.dueLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueLabel.ForeColor = System.Drawing.Color.Black
        Me.dueLabel.Location = New System.Drawing.Point(527, 295)
        Me.dueLabel.Name = "dueLabel"
        Me.dueLabel.Size = New System.Drawing.Size(93, 16)
        Me.dueLabel.TabIndex = 22
        Me.dueLabel.Text = "Amount Due:"
        Me.dueLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'topTextBox
        '
        Me.topTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topTextBox.ForeColor = System.Drawing.Color.Black
        Me.topTextBox.Location = New System.Drawing.Point(625, 198)
        Me.topTextBox.Name = "topTextBox"
        Me.topTextBox.ReadOnly = True
        Me.topTextBox.Size = New System.Drawing.Size(125, 23)
        Me.topTextBox.TabIndex = 10
        Me.topTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'discTextBox
        '
        Me.discTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discTextBox.ForeColor = System.Drawing.Color.Black
        Me.discTextBox.Location = New System.Drawing.Point(625, 230)
        Me.discTextBox.Name = "discTextBox"
        Me.discTextBox.ReadOnly = True
        Me.discTextBox.Size = New System.Drawing.Size(125, 23)
        Me.discTextBox.TabIndex = 11
        Me.discTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'taxTextBox
        '
        Me.taxTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxTextBox.ForeColor = System.Drawing.Color.Black
        Me.taxTextBox.Location = New System.Drawing.Point(625, 260)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.ReadOnly = True
        Me.taxTextBox.Size = New System.Drawing.Size(125, 23)
        Me.taxTextBox.TabIndex = 12
        Me.taxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dueTextBox
        '
        Me.dueTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueTextBox.ForeColor = System.Drawing.Color.Black
        Me.dueTextBox.Location = New System.Drawing.Point(625, 290)
        Me.dueTextBox.Name = "dueTextBox"
        Me.dueTextBox.ReadOnly = True
        Me.dueTextBox.Size = New System.Drawing.Size(125, 23)
        Me.dueTextBox.TabIndex = 13
        Me.dueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calcButton
        '
        Me.calcButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcButton.ForeColor = System.Drawing.Color.Black
        Me.calcButton.Location = New System.Drawing.Point(60, 360)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(125, 30)
        Me.calcButton.TabIndex = 23
        Me.calcButton.Text = "Calculate Order"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.Color.Black
        Me.clearButton.Location = New System.Drawing.Point(225, 360)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(125, 30)
        Me.clearButton.TabIndex = 24
        Me.clearButton.Text = "Clear Order"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printButton.ForeColor = System.Drawing.Color.Black
        Me.printButton.Location = New System.Drawing.Point(390, 360)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(125, 30)
        Me.printButton.TabIndex = 25
        Me.printButton.Text = "Print Order"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.Color.Black
        Me.exitButton.Location = New System.Drawing.Point(555, 360)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(125, 30)
        Me.exitButton.TabIndex = 26
        Me.exitButton.Text = "Exit Program"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
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
        'mjForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 416)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.dueTextBox)
        Me.Controls.Add(Me.taxTextBox)
        Me.Controls.Add(Me.discTextBox)
        Me.Controls.Add(Me.topTextBox)
        Me.Controls.Add(Me.dueLabel)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.discLabel)
        Me.Controls.Add(Me.topLabel)
        Me.Controls.Add(Me.pizzaTextBox)
        Me.Controls.Add(Me.pizzaLabel)
        Me.Controls.Add(Me.styleComboBox)
        Me.Controls.Add(Me.styleLabel)
        Me.Controls.Add(Me.sizeComboBox)
        Me.Controls.Add(Me.sizeLabel)
        Me.Controls.Add(Me.discGroupBox)
        Me.Controls.Add(Me.topGroupBox)
        Me.Controls.Add(Me.zipTextBox)
        Me.Controls.Add(Me.zipLabel)
        Me.Controls.Add(Me.stTextBox)
        Me.Controls.Add(Me.stLabel)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.cityLabel)
        Me.Controls.Add(Me.addTextBox)
        Me.Controls.Add(Me.addLabel)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mjForm"
        Me.Text = "Mama Jane's Pizza"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.topGroupBox.ResumeLayout(False)
        Me.topGroupBox.PerformLayout()
        Me.discGroupBox.ResumeLayout(False)
        Me.discGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addLabel As System.Windows.Forms.Label
    Friend WithEvents addTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cityLabel As System.Windows.Forms.Label
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stLabel As System.Windows.Forms.Label
    Friend WithEvents stTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents zipLabel As System.Windows.Forms.Label
    Friend WithEvents zipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents topGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents discGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents sizeLabel As System.Windows.Forms.Label
    Friend WithEvents sizeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents styleLabel As System.Windows.Forms.Label
    Friend WithEvents styleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents pizzaLabel As System.Windows.Forms.Label
    Friend WithEvents pizzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents topLabel As System.Windows.Forms.Label
    Friend WithEvents discLabel As System.Windows.Forms.Label
    Friend WithEvents taxLabel As System.Windows.Forms.Label
    Friend WithEvents dueLabel As System.Windows.Forms.Label
    Friend WithEvents topTextBox As System.Windows.Forms.TextBox
    Friend WithEvents discTextBox As System.Windows.Forms.TextBox
    Friend WithEvents taxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents excCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents onionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents pepCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents prefRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents coupRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents noneRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
