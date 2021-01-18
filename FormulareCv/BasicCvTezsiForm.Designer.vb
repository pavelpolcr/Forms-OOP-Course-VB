<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicCvTezsiForm
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
        Me.components = New System.ComponentModel.Container()
        Me.TimeTickProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.FileObsTExtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ActTimeStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LastFileStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SouborToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtevritToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UlozitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NastaveníToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Val2TextBox = New System.Windows.Forms.TextBox()
        Me.NumOpsResultLabel = New System.Windows.Forms.Label()
        Me.ColorsComboBox = New System.Windows.Forms.ComboBox()
        Me.OrderOutputLabel = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.AmmoutSumLabel = New System.Windows.Forms.Label()
        Me.ProgressBarResetButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MaterialChoice1RadioButton = New System.Windows.Forms.RadioButton()
        Me.MaterialChoice2RadioButton = New System.Windows.Forms.RadioButton()
        Me.MaterialChoice3RadioButton = New System.Windows.Forms.RadioButton()
        Me.MaterialChoice4RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Val1TextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimeTickProgressBar
        '
        Me.TimeTickProgressBar.Location = New System.Drawing.Point(154, 456)
        Me.TimeTickProgressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeTickProgressBar.Maximum = 10
        Me.TimeTickProgressBar.Name = "TimeTickProgressBar"
        Me.TimeTickProgressBar.Size = New System.Drawing.Size(681, 35)
        Me.TimeTickProgressBar.Step = 1
        Me.TimeTickProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.TimeTickProgressBar.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.TimeTickProgressBar, "Progress Bar ")
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'FileObsTExtBox
        '
        Me.FileObsTExtBox.Location = New System.Drawing.Point(536, 74)
        Me.FileObsTExtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FileObsTExtBox.Multiline = True
        Me.FileObsTExtBox.Name = "FileObsTExtBox"
        Me.FileObsTExtBox.Size = New System.Drawing.Size(455, 162)
        Me.FileObsTExtBox.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.FileObsTExtBox, "Zde se objevi obsah nacteneho souboru")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 504)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActTimeStatusLabel, Me.LastFileStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1067, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ActTimeStatusLabel
        '
        Me.ActTimeStatusLabel.Name = "ActTimeStatusLabel"
        Me.ActTimeStatusLabel.Size = New System.Drawing.Size(0, 16)
        '
        'LastFileStatusLabel
        '
        Me.LastFileStatusLabel.Name = "LastFileStatusLabel"
        Me.LastFileStatusLabel.Size = New System.Drawing.Size(0, 16)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SouborToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SouborToolStripMenuItem
        '
        Me.SouborToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtevritToolStripMenuItem, Me.UlozitToolStripMenuItem, Me.NastaveníToolStripMenuItem})
        Me.SouborToolStripMenuItem.Name = "SouborToolStripMenuItem"
        Me.SouborToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.SouborToolStripMenuItem.Text = "Soubor"
        '
        'OtevritToolStripMenuItem
        '
        Me.OtevritToolStripMenuItem.Name = "OtevritToolStripMenuItem"
        Me.OtevritToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OtevritToolStripMenuItem.Text = "Otevrit"
        '
        'UlozitToolStripMenuItem
        '
        Me.UlozitToolStripMenuItem.Name = "UlozitToolStripMenuItem"
        Me.UlozitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UlozitToolStripMenuItem.Text = "Ulozit"
        '
        'NastaveníToolStripMenuItem
        '
        Me.NastaveníToolStripMenuItem.Name = "NastaveníToolStripMenuItem"
        Me.NastaveníToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NastaveníToolStripMenuItem.Text = "Nastavení"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = Global.FormulareCv.My.Resources.Resources.troll
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(277, 143)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(160, 22)
        Me.NumericUpDown1.TabIndex = 7
        '
        'Val2TextBox
        '
        Me.Val2TextBox.Location = New System.Drawing.Point(212, 143)
        Me.Val2TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Val2TextBox.Name = "Val2TextBox"
        Me.Val2TextBox.Size = New System.Drawing.Size(56, 22)
        Me.Val2TextBox.TabIndex = 8
        '
        'NumOpsResultLabel
        '
        Me.NumOpsResultLabel.AutoSize = True
        Me.NumOpsResultLabel.Location = New System.Drawing.Point(139, 188)
        Me.NumOpsResultLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumOpsResultLabel.Name = "NumOpsResultLabel"
        Me.NumOpsResultLabel.Size = New System.Drawing.Size(0, 17)
        Me.NumOpsResultLabel.TabIndex = 10
        '
        'ColorsComboBox
        '
        Me.ColorsComboBox.FormattingEnabled = True
        Me.ColorsComboBox.Location = New System.Drawing.Point(212, 314)
        Me.ColorsComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ColorsComboBox.Name = "ColorsComboBox"
        Me.ColorsComboBox.Size = New System.Drawing.Size(204, 24)
        Me.ColorsComboBox.TabIndex = 11
        '
        'OrderOutputLabel
        '
        Me.OrderOutputLabel.AutoSize = True
        Me.OrderOutputLabel.Location = New System.Drawing.Point(97, 412)
        Me.OrderOutputLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OrderOutputLabel.Name = "OrderOutputLabel"
        Me.OrderOutputLabel.Size = New System.Drawing.Size(0, 17)
        Me.OrderOutputLabel.TabIndex = 12
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(4, 47)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(63, 21)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Vyšší"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(4, 25)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(61, 21)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "Delší"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(4, 4)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(69, 21)
        Me.CheckBox3.TabIndex = 15
        Me.CheckBox3.Text = "Hlubší"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 10
        Me.TrackBar1.Location = New System.Drawing.Point(143, 228)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(295, 56)
        Me.TrackBar1.TabIndex = 18
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.Value = 1
        '
        'AmmoutSumLabel
        '
        Me.AmmoutSumLabel.AutoSize = True
        Me.AmmoutSumLabel.Location = New System.Drawing.Point(151, 283)
        Me.AmmoutSumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AmmoutSumLabel.Name = "AmmoutSumLabel"
        Me.AmmoutSumLabel.Size = New System.Drawing.Size(0, 17)
        Me.AmmoutSumLabel.TabIndex = 19
        '
        'ProgressBarResetButton
        '
        Me.ProgressBarResetButton.BackgroundImage = Global.FormulareCv.My.Resources.Resources.sticker_png_computer_icons_arrow_symbol_left_arrow_angle_rectangle
        Me.ProgressBarResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProgressBarResetButton.Location = New System.Drawing.Point(891, 456)
        Me.ProgressBarResetButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBarResetButton.Name = "ProgressBarResetButton"
        Me.ProgressBarResetButton.Size = New System.Drawing.Size(100, 35)
        Me.ProgressBarResetButton.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.ProgressBarResetButton, "Stiskni k resetovani progressBaru")
        Me.ProgressBarResetButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.FileName = "soubor.txt"
        Me.OpenFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        Me.OpenFileDialog1.Title = "Otevrit"
        '
        'MaterialChoice1RadioButton
        '
        Me.MaterialChoice1RadioButton.AutoSize = True
        Me.MaterialChoice1RadioButton.Location = New System.Drawing.Point(7, 22)
        Me.MaterialChoice1RadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialChoice1RadioButton.Name = "MaterialChoice1RadioButton"
        Me.MaterialChoice1RadioButton.Size = New System.Drawing.Size(65, 21)
        Me.MaterialChoice1RadioButton.TabIndex = 0
        Me.MaterialChoice1RadioButton.TabStop = True
        Me.MaterialChoice1RadioButton.Text = "drevo"
        Me.MaterialChoice1RadioButton.UseVisualStyleBackColor = True
        '
        'MaterialChoice2RadioButton
        '
        Me.MaterialChoice2RadioButton.AutoSize = True
        Me.MaterialChoice2RadioButton.Location = New System.Drawing.Point(7, 51)
        Me.MaterialChoice2RadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialChoice2RadioButton.Name = "MaterialChoice2RadioButton"
        Me.MaterialChoice2RadioButton.Size = New System.Drawing.Size(53, 21)
        Me.MaterialChoice2RadioButton.TabIndex = 4
        Me.MaterialChoice2RadioButton.TabStop = True
        Me.MaterialChoice2RadioButton.Text = "Kov"
        Me.MaterialChoice2RadioButton.UseVisualStyleBackColor = True
        '
        'MaterialChoice3RadioButton
        '
        Me.MaterialChoice3RadioButton.AutoSize = True
        Me.MaterialChoice3RadioButton.Location = New System.Drawing.Point(7, 78)
        Me.MaterialChoice3RadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialChoice3RadioButton.Name = "MaterialChoice3RadioButton"
        Me.MaterialChoice3RadioButton.Size = New System.Drawing.Size(60, 21)
        Me.MaterialChoice3RadioButton.TabIndex = 4
        Me.MaterialChoice3RadioButton.TabStop = True
        Me.MaterialChoice3RadioButton.Text = "Plast"
        Me.MaterialChoice3RadioButton.UseVisualStyleBackColor = True
        '
        'MaterialChoice4RadioButton
        '
        Me.MaterialChoice4RadioButton.AutoSize = True
        Me.MaterialChoice4RadioButton.Location = New System.Drawing.Point(7, 106)
        Me.MaterialChoice4RadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialChoice4RadioButton.Name = "MaterialChoice4RadioButton"
        Me.MaterialChoice4RadioButton.Size = New System.Drawing.Size(56, 21)
        Me.MaterialChoice4RadioButton.TabIndex = 4
        Me.MaterialChoice4RadioButton.TabStop = True
        Me.MaterialChoice4RadioButton.Text = "Sklo"
        Me.MaterialChoice4RadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialChoice1RadioButton)
        Me.GroupBox1.Controls.Add(Me.MaterialChoice4RadioButton)
        Me.GroupBox1.Controls.Add(Me.MaterialChoice2RadioButton)
        Me.GroupBox1.Controls.Add(Me.MaterialChoice3RadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(536, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 156)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material"
        Me.ToolTip.SetToolTip(Me.GroupBox1, "Vyber materialu objednavaneho vyrobku")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Location = New System.Drawing.Point(430, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(87, 100)
        Me.Panel1.TabIndex = 21
        Me.ToolTip.SetToolTip(Me.Panel1, "Vyber atypickych atributu objednavaneho vyrobku")
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipTitle = "Napoveda:"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        '
        'Val1TextBox
        '
        Me.Val1TextBox.Location = New System.Drawing.Point(143, 142)
        Me.Val1TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Val1TextBox.Name = "Val1TextBox"
        Me.Val1TextBox.Size = New System.Drawing.Size(56, 22)
        Me.Val1TextBox.TabIndex = 22
        '
        'BasicCvTezsiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Val1TextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AmmoutSumLabel)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.OrderOutputLabel)
        Me.Controls.Add(Me.ColorsComboBox)
        Me.Controls.Add(Me.NumOpsResultLabel)
        Me.Controls.Add(Me.Val2TextBox)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FileObsTExtBox)
        Me.Controls.Add(Me.ProgressBarResetButton)
        Me.Controls.Add(Me.TimeTickProgressBar)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BasicCvTezsiForm"
        Me.Text = "BasicCvTezsi Formular I Komplet"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimeTickProgressBar As Windows.Forms.ProgressBar
    Friend WithEvents ProgressBarResetButton As Windows.Forms.Button
    Friend WithEvents Timer As Windows.Forms.Timer
    Friend WithEvents FileObsTExtBox As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ActTimeStatusLabel As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LastFileStatusLabel As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents SouborToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtevritToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UlozitToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents Val2TextBox As Windows.Forms.TextBox
    Friend WithEvents NastaveníToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumOpsResultLabel As Windows.Forms.Label
    Friend WithEvents ColorsComboBox As Windows.Forms.ComboBox
    Friend WithEvents OrderOutputLabel As Windows.Forms.Label
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As Windows.Forms.CheckBox
    Friend WithEvents TrackBar1 As Windows.Forms.TrackBar
    Friend WithEvents AmmoutSumLabel As Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents MaterialChoice1RadioButton As Windows.Forms.RadioButton
    Friend WithEvents MaterialChoice2RadioButton As Windows.Forms.RadioButton
    Friend WithEvents MaterialChoice3RadioButton As Windows.Forms.RadioButton
    Friend WithEvents MaterialChoice4RadioButton As Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents ToolTip As Windows.Forms.ToolTip
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
    Friend WithEvents Val1TextBox As Windows.Forms.TextBox
End Class
