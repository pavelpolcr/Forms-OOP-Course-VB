Imports System.Windows.Forms

Public Class BasicCvTezsiForm
    Dim lastFileOpened As String
    Dim ActOrder As New Order
    Dim valT1 As Integer
    Dim valT2 As Integer
    Dim NumOpsResult As Long
    Dim NumOpsResult2 As Long
    Dim nowTime As Date
    Dim progressBarTicksToGo As Integer = 10
    Dim possibleColors As New List(Of String)
    ''' <summary>
    ''' Adds new colours to possibleColors list to be used to set order color. Updates ColorsComboBox.Items
    ''' </summary>
    ''' <param name="values">Color names as Array of strings</param>
    Public Sub AddColorChoices(values As String())
        For Each val As String In values
            possibleColors.Add(val)
        Next
        ColorsComboBox.Items.Clear()
        ColorsComboBox.Items.AddRange(possibleColors.ToArray)

    End Sub
    ''' <summary>
    ''' Removes colours from possibleColors list to be used to set order color. Updates ColorsComboBox.Items
    ''' </summary>
    ''' <param name="values"></param>
    Public Sub RemoveColorChoices(values As String())
        For Each val As String In values
            possibleColors.Remove(val)
        Next
        ColorsComboBox.Items.Clear()
        ColorsComboBox.Items.AddRange(possibleColors.ToArray)
    End Sub
    ''' <summary>
    ''' Used to update Form elements, must be called after every element change(for included elements)
    ''' </summary>
    Public Sub UpdateForm()
        Label1.Text = "ProgressBar pobezi jeste " + progressBarTicksToGo.ToString + " s."
        Label1.Update()
        NumOpsResult = valT1 + valT2 + NumericUpDown1.Value
        NumOpsResultLabel.Text = NumOpsResult.ToString()
        NumOpsResultLabel.Update()
        NumOpsResult2 = NumOpsResult * TrackBar1.Value
        ActOrder.ammount = NumOpsResult2
        AmmoutSumLabel.Text = NumOpsResult2
        AmmoutSumLabel.Update()
        OrderOutputLabel.Text = ActOrder.ToString
        OrderOutputLabel.Update()


    End Sub



    Private Sub NumOps_TextChanged(sender As Object, e As EventArgs) Handles Val2TextBox.TextChanged
        valT2 = ValidateTextBoxForIntWithSign(sender)
        UpdateForm()
    End Sub
    ''' <summary>
    ''' Handles all the material choice radiobuttons CheckedChanged events
    ''' </summary>
    ''' <param name="sender">Radiobutton</param>
    ''' <param name="e"></param>
    Private Sub RadioButton_CheckedChanged(sender As RadioButton, e As EventArgs) Handles MaterialChoice1RadioButton.CheckedChanged, MaterialChoice2RadioButton.CheckedChanged, MaterialChoice3RadioButton.CheckedChanged, MaterialChoice4RadioButton.CheckedChanged
        If sender.Checked = True Then
            ActOrder.materialChoice = sender.Text
            UpdateForm()
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        UpdateFooter()
        UpdateProgressBar()
    End Sub
    ''' <summary>
    ''' UpdateFooterInfo. Needs to be called every Timer Tick and on new file opening.
    ''' </summary>
    Private Sub UpdateFooter()
        ActTimeStatusLabel.Text = "Aktualni cas: " + DateTime.Now.ToString("HH:mm:ss")
        LastFileStatusLabel.Text = lastFileOpened
    End Sub
    ''' <summary>
    ''' Handling method for all checkbox choices for Order.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckBoxs_CheckStateChanged(sender As CheckBox, e As EventArgs) Handles CheckBox3.CheckStateChanged, CheckBox2.CheckStateChanged, CheckBox1.CheckStateChanged
        Select Case sender.Checked
            Case 1
                ActOrder.abnormalityChoices.Add(sender.Text)
            Case 0
                ActOrder.abnormalityChoices.Remove(sender.Text)
        End Select
        UpdateForm()
    End Sub

    Private Sub ProgressBarResetButton_Click(sender As Object, e As EventArgs) Handles ProgressBarResetButton.Click
        ResetProgressBar()
    End Sub
    Private Sub ResetProgressBar()
        TimeTickProgressBar.Value = 0
        progressBarTicksToGo = 10
        UpdateForm()
    End Sub
    Private Sub UpdateProgressBar()
        If (TimeTickProgressBar.Value < 10) Then
            TimeTickProgressBar.Value += 1
            progressBarTicksToGo -= 1
            UpdateForm()
        End If
    End Sub

    Private Sub ColorsComboBox_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles ColorsComboBox.SelectedIndexChanged
        ActOrder.colorChoice = sender.SelectedItem.ToString
        UpdateForm()
    End Sub

    Private Sub ColorsComboBox_TextChanged(sender As ComboBox, e As EventArgs) Handles ColorsComboBox.TextChanged
        ActOrder.colorChoice = sender.Text
        UpdateForm()
    End Sub
    ''' <summary>
    ''' Opens new file, stores filename to lastFileOpened, the text from file to FileObsTExtBox.Text
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OtevritToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtevritToolStripMenuItem.Click
        Dim dialResult As DialogResult
        dialResult = OpenFileDialog1.ShowDialog()
        If dialResult.Equals(DialogResult.OK) Then 'Check for valid file choice and opening - user pressed 
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
            lastFileOpened = OpenFileDialog1.FileName
            Try
                Input(1, FileObsTExtBox.Text)
            Catch
                MsgBox("Chyba!")
            Finally
                FileClose(1)
                UpdateFooter()
            End Try
        End If
    End Sub
    ''' <summary>
    ''' Save text from FileObsTExtBox.Text to chosen file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UlozitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UlozitToolStripMenuItem.Click
        Dim dialResult As DialogResult
        dialResult = SaveFileDialog1.ShowDialog
        If dialResult.Equals(DialogResult.OK) Then 'Check for valid file choice 
            FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
            Try
                Write(1, FileObsTExtBox.Text)
            Catch ex As Exception
                MsgBox("Chyba!")
            Finally
                FileClose(1)
            End Try
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Toto je napoveda",, "Napoveda")
    End Sub
    ''' <summary>
    ''' Function takes TextBox Object as input and returns Int Value of That Textbox.Text. Nonparseable input results in TextBox Clearing.
    ''' </summary>
    ''' <param name="tb">Textbox</param>
    ''' <returns></returns>
    Public Function ValidateTextBoxForIntWithSign(ByRef tb As TextBox) As Integer
        Dim Result As Integer
        If (Integer.TryParse(tb.Text, Result)) Then
            Return Result
        Else

            If Not tb.Text.Equals("-") Then
                tb.Text = ""
            End If
            Return Result
        End If
    End Function

    Private Sub Val1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Val1TextBox.TextChanged
        valT1 = ValidateTextBoxForIntWithSign(sender)
        UpdateForm()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        UpdateForm()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

        UpdateForm()
    End Sub

    Private Sub NastaveníToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NastaveníToolStripMenuItem.Click
        SettingsF1.ShowDialog()
    End Sub
End Class
''' <summary>
''' Represents Order prepared with choices made. Should be upgraded to have non public variables, to keep things easy for learning puproses this was ommited.
''' </summary>
Class Order
    Public ammount As Long
    Public abnormalityChoices As New List(Of String)
    Public materialChoice As String
    Public colorChoice As String
    Public Overrides Function ToString() As String
        Dim out As String = " "
        out += ammount.ToString + " "
        For Each Str As String In abnormalityChoices
            out += Str + ", "
        Next
        out += materialChoice
        out += colorChoice
        Return out
    End Function
End Class