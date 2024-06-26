Public Class MainForm
    Private Sub MainFormLoaded(sender As Object, e As EventArgs) Handles MyBase.Load
        OKButton.Enabled = False

        Dim appName As String = Application.ProductName
        Dim appVersion As String = Application.ProductVersion
        Me.Text = appName + " ver" + appVersion
    End Sub

    Private Sub OKButtonClick(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim message As String = MessageTextBox.Text
        Dim title As String = TitleTextBox.Text
        If IconComboBox.SelectedIndex = 0 Then
            MessageBox.Show(message, title,
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf IconComboBox.SelectedIndex = 1 Then
            MessageBox.Show(message, title,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf IconComboBox.SelectedIndex = 2 Then
            MessageBox.Show(message, title,
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IconComboBox.SelectedIndex = 3 Then
            MessageBox.Show(message, title,
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            MessageBox.Show(message, title,
                            MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub CloseButtonClick(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub IconComboBoxSelectedIndexChanged(sender As Object, e As EventArgs) Handles IconComboBox.SelectedIndexChanged
        If IconComboBox.SelectedIndex > -1 Then
            OKButton.Enabled = True
        Else
            OKButton.Enabled = False
        End If
    End Sub
End Class
