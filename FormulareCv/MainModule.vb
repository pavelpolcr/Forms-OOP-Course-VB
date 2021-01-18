Option Explicit On
Option Strict On
Module MainModule

    Public Form1 As New BasicCvTezsiForm
    Public SettingsF1 As New BasicCvTezsiSettingsForm


    Sub Main()
        Form1.KeyPreview = True
        Form1.AddColorChoices({"cervena", "Zelena", "Modra", "Hneda"})
        Form1.ShowDialog()

    End Sub

End Module
