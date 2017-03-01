'Project:       VB Auto Center
'Programmer:    Christopher Anderson
'Date:          June 07, 2007
'Description:   Valley Boulevard (VB) Auto Center Program

Public Class vbForm

    Private Sub salesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salesButton.Click
        'Display the Auto Sales message.

        Me.msgLabel.Text = "Family wagon, immaculate condition $12,995"
    End Sub

    Private Sub detailButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detailButton.Click
        'Display the Detail Shop message.

        Me.msgLabel.Text = "Lube, oil, filter $25.99"
    End Sub

    Private Sub serviceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serviceButton.Click
        'Display the Service Center message.

        Me.msgLabel.Text = "Complete detail $79.95 for most cars"
    End Sub

    Private Sub empButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empButton.Click
        'Display the Employment Opportunities message.

        Me.msgLabel.Text = "Sales position, contact Mr. Mann 551-2134 x475"
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Exit the program.

        Me.Close()
    End Sub

End Class