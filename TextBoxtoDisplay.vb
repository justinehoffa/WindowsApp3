Public Class TextBoxtoDisplay
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        ValidateTextBoxes()
        If AccumulateMessage("", False) = "" Then
            AlertUser(AccumulateMessage("", True))
        Else
            Display()
        End If

    End Sub


    Sub ValidateTextBoxes()
        Dim problem As Boolean = False

        If LastNameTextBox.Text = "" Then
            AccumulateMessage("Last Name is a required field.", False)
            LastNameTextBox.Focus()
            problem = True
        End If

        If FirstNameTextBox.Text = "" Then
            AccumulateMessage("First Name is a required field.", False)
            FirstNameTextBox.Focus()
            problem = True
        End If

        If EmailTextBox.Text = "" And Not problem Then
            CreateEmail()
        End If

    End Sub

    Sub AlertUser(ByVal Message As String)
        MsgBox(Message)
        AccumulateMessage("", True)
    End Sub


    Function AccumulateMessage(ByVal newMessage As String, Clear As Boolean) As String
        Static message As String
        If Clear Then
            message = ""
            message &= newMessage & vbNewLine
        End If
        Return message
    End Function

    Sub CreateEmail()
        EmailTextBox.Text = FirstNameTextBox.Text & "." & LastNameTextBox.Text & "@acme.com"
    End Sub

    Sub Display()
        DisplayLabel.Text = FirstNameTextBox.Text & vbNewLine & LastNameTextBox.Text & vbNewLine & EmailTextBox.Text
    End Sub

End Class
