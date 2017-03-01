'Project:       VB Auto Center
'Programmer:    Christopher Anderson
'Date:          June 07, 2007
'Description:   Valley Boulevard (VB) Auto Center Program

Public Class vbForm2

    Private Sub imgSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgSales.Click
        'Display the Auto Sales message.

        Me.msgLabel.Text = "Family wagon, immaculate condition $12,995"
    End Sub

    Private Sub imgDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgDetail.Click
        'Display the Detail Shop message.

        Me.msgLabel.Text = "Lube, oil, filter $25.99"
    End Sub

    Private Sub imgService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgService.Click
        'Display the Service Center message.

        Me.msgLabel.Text = "Complete detail $79.95 for most cars"
    End Sub

    Private Sub imgEmployment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgEmployment.Click
        'Display the Employment Opportunities message.

        Me.msgLabel.Text = "Sales position, contact Mr. Mann 551-2134 x475"
    End Sub

    Private Sub imgClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgClear.Click
        'Display the Employment Opportunities message.

        Me.msgLabel.Text = ""
    End Sub

    Private Sub imgExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgExit.Click
        'Exit the program.

        Me.Close()
    End Sub

    Private Sub rbCrimson_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCrimson.CheckedChanged
        'Change the Background Color of the Message to Crimson

        Me.msgLabel.BackColor = Color.Crimson
    End Sub

    Private Sub rbAquamarine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAquamarine.CheckedChanged
        'Change the Background Color of the Message to Aquamarine

        Me.msgLabel.BackColor = Color.Aquamarine
    End Sub

    Private Sub rbGray_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGray.CheckedChanged
        'Change the Background Color of the Message to Gray

        Me.msgLabel.BackColor = Color.Gray
    End Sub

    Private Sub cbHours_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHours.CheckedChanged
        'Set visibility for lblHours

        Me.lblHours.Visible = cbHours.Checked
    End Sub

    Private Sub vbForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblHours.Visible = False
    End Sub
End Class