Public Class BasicCvTezsiSettingsForm
    Private Sub BasicCvTezsiSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BgChangeButton_Click(sender As Object, e As EventArgs) Handles BgChangeButton.Click
        Try
            ColorDialog1.ShowDialog()
        Catch ex As Exception

        Finally
            Form1.BackColor = ColorDialog1.Color

        End Try


    End Sub

    Private Sub ChangePgBarColorButton_Click(sender As Object, e As EventArgs) Handles ChangePgBarColorButton.Click
        Try
            ColorDialog1.ShowDialog()
        Catch ex As Exception

        Finally
            Form1.TimeTickProgressBar.ForeColor = ColorDialog1.Color
        End Try
    End Sub
End Class