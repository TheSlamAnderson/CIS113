'Project:       Unit 6 VB Auto Center
'Date:          July 16, 2007
'Programmer:    Christopher M. Anderson
'Description:   Main Form To Launch Sales Form And About Box.

Option Strict On

Public Class mainForm

    Private Sub InputSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputSaleToolStripMenuItem.Click
        'Show The Sales Form

        vbForm6.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit The Program

        Me.Close()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        'Change The Color Of The Form Text

        With Me
            With .ColorDialog1
                .ShowDialog()
                Me.mainLabel1.ForeColor = .Color
                Me.mainLabel2.ForeColor = .Color
            End With
        End With
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        'Change The Font Of The Form Text

        With FontDialog1
            .ShowDialog()
            Me.mainLabel1.Font = .Font
            Me.mainLabel2.Font = .Font
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Show The AboutBox Form

        aboutBox.Show()
    End Sub

End Class