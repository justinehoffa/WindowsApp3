Public Class WindowsApp3
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Display()
    End Sub

    Sub Display()
        'TODO validate textbox data
        'MsgBox("Go!")
        If EmailTextBox.Text = "" Then
            CreateEmail()
        End If
        DisplayLabel.Text = FirstNameTextBox.Text _
                            & vbNewLine & LastNameTextBox.Text _
                            & vbNewLine & EmailTextBox.Text
    End Sub

    Sub CreateEmail()
        EmailTextBox.Text = FirstNameTextBox.Text _
                            & "." & LastNameTextBox.Text _
                            & "@gmail.com"
    End Sub
End Class
