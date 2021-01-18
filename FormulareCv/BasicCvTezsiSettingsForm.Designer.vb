<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicCvTezsiSettingsForm
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BgChangeButton = New System.Windows.Forms.Button()
        Me.ChangePgBarColorButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AllowFullOpen = False
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.ShowHelp = True
        Me.ColorDialog1.SolidColorOnly = True
        '
        'BgChangeButton
        '
        Me.BgChangeButton.Location = New System.Drawing.Point(12, 12)
        Me.BgChangeButton.Name = "BgChangeButton"
        Me.BgChangeButton.Size = New System.Drawing.Size(119, 49)
        Me.BgChangeButton.TabIndex = 0
        Me.BgChangeButton.Text = "Zmenit barvu pozadi"
        Me.BgChangeButton.UseVisualStyleBackColor = True
        '
        'ChangePgBarColorButton
        '
        Me.ChangePgBarColorButton.Location = New System.Drawing.Point(12, 82)
        Me.ChangePgBarColorButton.Name = "ChangePgBarColorButton"
        Me.ChangePgBarColorButton.Size = New System.Drawing.Size(119, 49)
        Me.ChangePgBarColorButton.TabIndex = 2
        Me.ChangePgBarColorButton.Text = "Zmenit barvu progressBaru"
        Me.ChangePgBarColorButton.UseVisualStyleBackColor = True
        '
        'BasicCvTezsiSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ChangePgBarColorButton)
        Me.Controls.Add(Me.BgChangeButton)
        Me.Name = "BasicCvTezsiSettingsForm"
        Me.Text = "Nastaveni"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColorDialog1 As Windows.Forms.ColorDialog
    Friend WithEvents BgChangeButton As Windows.Forms.Button
    Friend WithEvents ChangePgBarColorButton As Windows.Forms.Button
End Class
