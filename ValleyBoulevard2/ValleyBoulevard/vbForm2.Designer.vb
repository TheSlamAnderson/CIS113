<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vbForm2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vbForm2))
        Me.msgLabel = New System.Windows.Forms.Label
        Me.imgSales = New System.Windows.Forms.PictureBox
        Me.imgDetail = New System.Windows.Forms.PictureBox
        Me.imgService = New System.Windows.Forms.PictureBox
        Me.imgEmployment = New System.Windows.Forms.PictureBox
        Me.lblSales = New System.Windows.Forms.Label
        Me.lblDetail = New System.Windows.Forms.Label
        Me.lblService = New System.Windows.Forms.Label
        Me.lblEmployment = New System.Windows.Forms.Label
        Me.imgClear = New System.Windows.Forms.PictureBox
        Me.lblClear = New System.Windows.Forms.Label
        Me.imgExit = New System.Windows.Forms.PictureBox
        Me.lblExit = New System.Windows.Forms.Label
        Me.gbRadio = New System.Windows.Forms.GroupBox
        Me.rbGray = New System.Windows.Forms.RadioButton
        Me.rbAquamarine = New System.Windows.Forms.RadioButton
        Me.rbCrimson = New System.Windows.Forms.RadioButton
        Me.cbHours = New System.Windows.Forms.CheckBox
        Me.lblHours = New System.Windows.Forms.Label
        Me.ttSales = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttDetail = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttService = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEmployment = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttClear = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttExit = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.imgSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEmployment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRadio.SuspendLayout()
        Me.SuspendLayout()
        '
        'msgLabel
        '
        Me.msgLabel.AutoSize = True
        Me.msgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgLabel.Location = New System.Drawing.Point(55, 23)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(0, 16)
        Me.msgLabel.TabIndex = 5
        '
        'imgSales
        '
        Me.imgSales.AccessibleDescription = ""
        Me.imgSales.AccessibleName = ""
        Me.imgSales.Image = CType(resources.GetObject("imgSales.Image"), System.Drawing.Image)
        Me.imgSales.Location = New System.Drawing.Point(27, 115)
        Me.imgSales.Name = "imgSales"
        Me.imgSales.Size = New System.Drawing.Size(50, 50)
        Me.imgSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSales.TabIndex = 6
        Me.imgSales.TabStop = False
        Me.ttSales.SetToolTip(Me.imgSales, "Auto Sales")
        '
        'imgDetail
        '
        Me.imgDetail.Image = CType(resources.GetObject("imgDetail.Image"), System.Drawing.Image)
        Me.imgDetail.Location = New System.Drawing.Point(132, 115)
        Me.imgDetail.Name = "imgDetail"
        Me.imgDetail.Size = New System.Drawing.Size(50, 50)
        Me.imgDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDetail.TabIndex = 7
        Me.imgDetail.TabStop = False
        Me.ttDetail.SetToolTip(Me.imgDetail, "Detail Shop")
        '
        'imgService
        '
        Me.imgService.Image = CType(resources.GetObject("imgService.Image"), System.Drawing.Image)
        Me.imgService.Location = New System.Drawing.Point(237, 115)
        Me.imgService.Name = "imgService"
        Me.imgService.Size = New System.Drawing.Size(50, 50)
        Me.imgService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgService.TabIndex = 8
        Me.imgService.TabStop = False
        Me.ttService.SetToolTip(Me.imgService, "Service Center")
        '
        'imgEmployment
        '
        Me.imgEmployment.Image = CType(resources.GetObject("imgEmployment.Image"), System.Drawing.Image)
        Me.imgEmployment.Location = New System.Drawing.Point(342, 115)
        Me.imgEmployment.Name = "imgEmployment"
        Me.imgEmployment.Size = New System.Drawing.Size(50, 50)
        Me.imgEmployment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEmployment.TabIndex = 9
        Me.imgEmployment.TabStop = False
        Me.ttEmployment.SetToolTip(Me.imgEmployment, "Employment Opportunities")
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(25, 100)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(58, 13)
        Me.lblSales.TabIndex = 10
        Me.lblSales.Text = "Auto Sales"
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = True
        Me.lblDetail.Location = New System.Drawing.Point(130, 100)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(62, 13)
        Me.lblDetail.TabIndex = 11
        Me.lblDetail.Text = "Detail Shop"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(235, 100)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(77, 13)
        Me.lblService.TabIndex = 12
        Me.lblService.Text = "Service Center"
        '
        'lblEmployment
        '
        Me.lblEmployment.AutoSize = True
        Me.lblEmployment.Location = New System.Drawing.Point(340, 100)
        Me.lblEmployment.Name = "lblEmployment"
        Me.lblEmployment.Size = New System.Drawing.Size(129, 13)
        Me.lblEmployment.TabIndex = 13
        Me.lblEmployment.Text = "Employment Opportunities"
        '
        'imgClear
        '
        Me.imgClear.Image = CType(resources.GetObject("imgClear.Image"), System.Drawing.Image)
        Me.imgClear.Location = New System.Drawing.Point(132, 210)
        Me.imgClear.Name = "imgClear"
        Me.imgClear.Size = New System.Drawing.Size(50, 50)
        Me.imgClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClear.TabIndex = 14
        Me.imgClear.TabStop = False
        Me.ttClear.SetToolTip(Me.imgClear, "Clear Special Notices")
        '
        'lblClear
        '
        Me.lblClear.AutoSize = True
        Me.lblClear.Location = New System.Drawing.Point(130, 195)
        Me.lblClear.Name = "lblClear"
        Me.lblClear.Size = New System.Drawing.Size(108, 13)
        Me.lblClear.TabIndex = 15
        Me.lblClear.Text = "Clear Special Notices"
        '
        'imgExit
        '
        Me.imgExit.Image = CType(resources.GetObject("imgExit.Image"), System.Drawing.Image)
        Me.imgExit.Location = New System.Drawing.Point(342, 210)
        Me.imgExit.Name = "imgExit"
        Me.imgExit.Size = New System.Drawing.Size(50, 50)
        Me.imgExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgExit.TabIndex = 16
        Me.imgExit.TabStop = False
        Me.ttExit.SetToolTip(Me.imgExit, "Exit")
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Location = New System.Drawing.Point(340, 195)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(24, 13)
        Me.lblExit.TabIndex = 17
        Me.lblExit.Text = "Exit"
        '
        'gbRadio
        '
        Me.gbRadio.BackColor = System.Drawing.SystemColors.Control
        Me.gbRadio.Controls.Add(Me.rbGray)
        Me.gbRadio.Controls.Add(Me.rbAquamarine)
        Me.gbRadio.Controls.Add(Me.rbCrimson)
        Me.gbRadio.ForeColor = System.Drawing.Color.Black
        Me.gbRadio.Location = New System.Drawing.Point(130, 290)
        Me.gbRadio.Name = "gbRadio"
        Me.gbRadio.Size = New System.Drawing.Size(310, 50)
        Me.gbRadio.TabIndex = 18
        Me.gbRadio.TabStop = False
        Me.gbRadio.Text = "Choose a Color for the label"
        '
        'rbGray
        '
        Me.rbGray.AutoSize = True
        Me.rbGray.BackColor = System.Drawing.SystemColors.Control
        Me.rbGray.Location = New System.Drawing.Point(193, 20)
        Me.rbGray.Name = "rbGray"
        Me.rbGray.Size = New System.Drawing.Size(47, 17)
        Me.rbGray.TabIndex = 2
        Me.rbGray.Text = "Gray"
        Me.rbGray.UseVisualStyleBackColor = False
        '
        'rbAquamarine
        '
        Me.rbAquamarine.AutoSize = True
        Me.rbAquamarine.BackColor = System.Drawing.SystemColors.Control
        Me.rbAquamarine.ForeColor = System.Drawing.Color.Black
        Me.rbAquamarine.Location = New System.Drawing.Point(102, 20)
        Me.rbAquamarine.Name = "rbAquamarine"
        Me.rbAquamarine.Size = New System.Drawing.Size(81, 17)
        Me.rbAquamarine.TabIndex = 1
        Me.rbAquamarine.Text = "Aquamarine"
        Me.rbAquamarine.UseVisualStyleBackColor = False
        '
        'rbCrimson
        '
        Me.rbCrimson.AutoSize = True
        Me.rbCrimson.BackColor = System.Drawing.SystemColors.Control
        Me.rbCrimson.ForeColor = System.Drawing.Color.Black
        Me.rbCrimson.Location = New System.Drawing.Point(20, 20)
        Me.rbCrimson.Name = "rbCrimson"
        Me.rbCrimson.Size = New System.Drawing.Size(62, 17)
        Me.rbCrimson.TabIndex = 0
        Me.rbCrimson.Text = "Crimson"
        Me.rbCrimson.UseVisualStyleBackColor = False
        '
        'cbHours
        '
        Me.cbHours.AutoSize = True
        Me.cbHours.Location = New System.Drawing.Point(25, 310)
        Me.cbHours.Name = "cbHours"
        Me.cbHours.Size = New System.Drawing.Size(54, 17)
        Me.cbHours.TabIndex = 19
        Me.cbHours.Text = "Hours"
        Me.cbHours.UseVisualStyleBackColor = True
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(55, 53)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(193, 16)
        Me.lblHours.TabIndex = 20
        Me.lblHours.Text = "Open 24 Hours - 7 days a week"
        '
        'vbForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 357)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.cbHours)
        Me.Controls.Add(Me.gbRadio)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.imgExit)
        Me.Controls.Add(Me.lblClear)
        Me.Controls.Add(Me.imgClear)
        Me.Controls.Add(Me.lblEmployment)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.imgEmployment)
        Me.Controls.Add(Me.imgService)
        Me.Controls.Add(Me.imgDetail)
        Me.Controls.Add(Me.imgSales)
        Me.Controls.Add(Me.msgLabel)
        Me.Name = "vbForm2"
        Me.Text = "VB Auto Center"
        CType(Me.imgSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEmployment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRadio.ResumeLayout(False)
        Me.gbRadio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msgLabel As System.Windows.Forms.Label
    Friend WithEvents imgSales As System.Windows.Forms.PictureBox
    Friend WithEvents imgDetail As System.Windows.Forms.PictureBox
    Friend WithEvents imgService As System.Windows.Forms.PictureBox
    Friend WithEvents imgEmployment As System.Windows.Forms.PictureBox
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents lblEmployment As System.Windows.Forms.Label
    Friend WithEvents imgClear As System.Windows.Forms.PictureBox
    Friend WithEvents lblClear As System.Windows.Forms.Label
    Friend WithEvents imgExit As System.Windows.Forms.PictureBox
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents gbRadio As System.Windows.Forms.GroupBox
    Friend WithEvents rbCrimson As System.Windows.Forms.RadioButton
    Friend WithEvents rbAquamarine As System.Windows.Forms.RadioButton
    Friend WithEvents rbGray As System.Windows.Forms.RadioButton
    Friend WithEvents cbHours As System.Windows.Forms.CheckBox
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents ttSales As System.Windows.Forms.ToolTip
    Friend WithEvents ttDetail As System.Windows.Forms.ToolTip
    Friend WithEvents ttService As System.Windows.Forms.ToolTip
    Friend WithEvents ttEmployment As System.Windows.Forms.ToolTip
    Friend WithEvents ttClear As System.Windows.Forms.ToolTip
    Friend WithEvents ttExit As System.Windows.Forms.ToolTip

End Class
