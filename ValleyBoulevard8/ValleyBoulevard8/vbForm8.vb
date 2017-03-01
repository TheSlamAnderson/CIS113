'Project:       Unit 8 VB Auto Center
'Date:          July 27, 2007
'Programmer:    Christopher M. Anderson
'Description:   VB Auto Center Parts Search

Option Strict On

Public Class vbForm8

    'Declare Variables
    Private brandInteger As Integer
    Private selectedButtonString As String

    'Declare Parts Array
    Dim partString(8, 3) As String

    Private Sub vbForm8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Set Up Parts Array For Part 0
        partString(0, 0) = "PR214"
        partString(0, 1) = "MR43T"
        partString(0, 2) = "RBL8"
        partString(0, 3) = "14K22"

        'Set Up Parts Array For Part 1
        partString(1, 0) = "PR223"
        partString(1, 1) = "R43"
        partString(1, 2) = "RJ6"
        partString(1, 3) = "14K24"

        'Set Up Parts Array For Part 2
        partString(2, 0) = "PR224"
        partString(2, 1) = "R43N"
        partString(2, 2) = "RN4"
        partString(2, 3) = "14K30"

        'Set Up Parts Array For Part 3
        partString(3, 0) = "PR246"
        partString(3, 1) = "R46N"
        partString(3, 2) = "RN8"
        partString(3, 3) = "14K32"

        'Set Up Parts Array For Part 4
        partString(4, 0) = "PR247"
        partString(4, 1) = "R46TS"
        partString(4, 2) = "RBL17Y"
        partString(4, 3) = "14K33"

        'Set Up Parts Array For Part 5
        partString(5, 0) = "PR248"
        partString(5, 1) = "R46TX"
        partString(5, 2) = "RBL12-6"
        partString(5, 3) = "14K35"

        'Set Up Parts Array For Part 6
        partString(6, 0) = "PR324"
        partString(6, 1) = "S46"
        partString(6, 2) = "J11"
        partString(6, 3) = "14K38"

        'Set Up Parts Array For Part 7
        partString(7, 0) = "PR326"
        partString(7, 1) = "SR46E"
        partString(7, 2) = "XEJ8"
        partString(7, 3) = "14K40"

        'Set Up Parts Array For Part 8
        partString(8, 0) = "PR444"
        partString(8, 1) = "47L"
        partString(8, 2) = "H12"
        partString(8, 3) = "14K44"

    End Sub

    Private Sub aRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aRadioButton.CheckedChanged, cRadioButton.CheckedChanged, xRadioButton.CheckedChanged

        'Save The Name Of The Selected Radio Button
        'This Procedure Is Executed Each Time Any Radio Button Is Selected
        selectedButtonString = CType(sender, RadioButton).Name

    End Sub

    Private Sub searchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click

        'Set Up Search Variables
        Dim searchString As String
        Dim resultString As String = ""
        Dim searchFoundBoolean As Boolean = False
        Dim indexInteger As Integer = 0

        'Determine Which Radio Button Is Checked
        Select Case selectedButtonString
            Case "aRadioButton"
                brandInteger = 1
            Case "cRadioButton"
                brandInteger = 2
            Case "xRadioButton"
                brandInteger = 3
            Case Else
                brandInteger = 0
        End Select

        'Run Process Unless No Radio Checked
        If brandInteger <> 0 Then

            'Retreive Search String From Text Box
            searchString = Me.searchTextBox.Text.ToString().ToString

            'Run Process If Search Not Blank
            If searchString = "" Then
                MessageBox.Show("Please enter a part number for your search.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                'Search Array For Search Input
                Do Until searchFoundBoolean Or indexInteger > 8
                    If searchString = partString(indexInteger, brandInteger) Then
                        resultString = partString(indexInteger, 0)
                        searchFoundBoolean = True
                    Else
                        indexInteger += 1
                    End If
                Loop

                'Display Error If Not Found
                If Not searchFoundBoolean Then
                    MessageBox.Show("No matches for this part number found.", "No Matching Part", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                'Set Result Text Box Equal To Result String
                Me.resultTextBox.Text = resultString

            End If

        Else

            MessageBox.Show("Please select a brand name for your search.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click

        'Clear The Radio Buttons and Text Boxes
        Me.aRadioButton.Checked = False
        Me.cRadioButton.Checked = False
        Me.xRadioButton.Checked = False
        Me.searchTextBox.Clear()
        Me.resultTextBox.Clear()

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click

        'Exit The Program
        Me.Close()

    End Sub

End Class
