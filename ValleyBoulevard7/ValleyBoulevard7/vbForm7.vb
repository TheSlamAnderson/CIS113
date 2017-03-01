'Project:       Unit 7 VB Auto Center
'Date:          July 21, 2007
'Programmer:    Christopher M. Anderson
'Description:   VB Auto Center Car Wash Form For Interior And Exterior Options

Option Strict On

Public Class vbForm7

    Private Sub ClearAll()
        'Function To Clear List Boxes

        Me.extListBox.Items.Clear()
        Me.intListBox.Items.Clear()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Function To Print Document

        'Printing Variables
        Dim headerFont As New Font("Tahoma", 24, FontStyle.Bold)
        Dim titleFont As New Font("Tahoma", 12, FontStyle.Bold)
        Dim printFont As New Font("Tahoma", 12)
        Dim lineHeightSingle As Single = printFont.GetHeight
        Dim horizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim verticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim printLineString As String
        Dim extIndexInteger As Integer
        Dim intIndexInteger As Integer

        'Print Page Header
        printLineString = "VB AUTO CENTER"
        e.Graphics.DrawString(printLineString, headerFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        'Print Programmer Information
        printLineString = "Programmer:"
        verticalPrintLocationSingle += lineHeightSingle * 4
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = "Christopher Anderson"
        verticalPrintLocationSingle += lineHeightSingle + 2
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        'Print Package Information
        printLineString = "Package:"
        verticalPrintLocationSingle += lineHeightSingle * 2
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = Me.pkgComboBox.SelectedItem.ToString()
        verticalPrintLocationSingle += lineHeightSingle + 2
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        'Print Exterior Information
        printLineString = "Exterior:"
        verticalPrintLocationSingle += lineHeightSingle * 2
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        For extIndexInteger = 0 To Me.extListBox.Items.Count - 1
            verticalPrintLocationSingle += lineHeightSingle + 2
            printLineString = Me.extListBox.Items(extIndexInteger).ToString()
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)
        Next extIndexInteger

        'Print Interior Information
        printLineString = "Interior:"
        verticalPrintLocationSingle += lineHeightSingle * 2
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        For intIndexInteger = 0 To Me.intListBox.Items.Count - 1
            verticalPrintLocationSingle += lineHeightSingle + 2
            printLineString = Me.intListBox.Items(intIndexInteger).ToString()
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)
        Next intIndexInteger

        'Print Fragrance Information
        printLineString = "Fragrance Selected:"
        verticalPrintLocationSingle += lineHeightSingle * 2
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = Me.fragComboBox.SelectedItem.ToString()
        verticalPrintLocationSingle += lineHeightSingle + 2
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        'Check Form And Call Print Preview

        'Check For Package Selected
        If pkgComboBox.SelectedIndex <> -1 Then

            'Check For Fragrance Selected
            If fragComboBox.SelectedIndex <> -1 Then
                'Print Preview The Document
                Me.PrintPreviewDialog1.Document = PrintDocument1
                Me.PrintPreviewDialog1.ShowDialog()
            Else
                MessageBox.Show("Please Choose A Fragrance.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            MessageBox.Show("Please Choose A Package.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear List Box Values And Reset Combo Box Values To Unselected

        Me.pkgComboBox.SelectedIndex = -1
        Me.fragComboBox.SelectedIndex = -1
        Me.pkgComboBox.Focus()
        ClearAll()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit The Program

        Me.Close()
    End Sub

    Private Sub pkgComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pkgComboBox.SelectedIndexChanged
        'Display Interior And Exterior List Box Contents

        'Interior Constants
        Const WASH_String As String = "Hand Wash"
        Const WAX_String As String = "Hand Wax"
        Const CHECK_String As String = "Check Engine Fluids"
        Const ENGINE_String As String = "Detail Engine Compartment"
        Const CARRIAGE_String As String = "Detail Under Carriage"

        'Exterior Constants
        Const FRAG_String As String = "Fragrance"
        Const CARPETS_String As String = "Shampoo Carpets"
        Const COAT_String As String = "Interior Protection Coat"
        Const UP_String As String = "Shampoo Upholstery"
        Const SCOTCH_String As String = "Scotchguard"

        If pkgComboBox.SelectedIndex = -1 Then
            'If No Options Selected
            ClearAll()

        ElseIf pkgComboBox.SelectedIndex = 0 Then
            'If Standard Package Selected
            ClearAll()
            Me.extListBox.Items.Add(WASH_String)
            Me.intListBox.Items.Add(FRAG_String)

        ElseIf pkgComboBox.SelectedIndex = 1 Then
            'If Deluxe Package Selected
            ClearAll()
            Me.extListBox.Items.Add(WASH_String)
            Me.extListBox.Items.Add(WAX_String)
            Me.intListBox.Items.Add(FRAG_String)
            Me.intListBox.Items.Add(CARPETS_String)

        ElseIf pkgComboBox.SelectedIndex = 2 Then
            'If Executive Package Selected
            ClearAll()
            Me.extListBox.Items.Add(WASH_String)
            Me.extListBox.Items.Add(WAX_String)
            Me.extListBox.Items.Add(CHECK_String)
            Me.intListBox.Items.Add(FRAG_String)
            Me.intListBox.Items.Add(CARPETS_String)
            Me.intListBox.Items.Add(COAT_String)

        ElseIf pkgComboBox.SelectedIndex = 3 Then
            'If Luxury Package Selected
            ClearAll()
            Me.extListBox.Items.Add(WASH_String)
            Me.extListBox.Items.Add(WAX_String)
            Me.extListBox.Items.Add(CHECK_String)
            Me.extListBox.Items.Add(ENGINE_String)
            Me.extListBox.Items.Add(CARRIAGE_String)
            Me.intListBox.Items.Add(FRAG_String)
            Me.intListBox.Items.Add(CARPETS_String)
            Me.intListBox.Items.Add(UP_String)
            Me.intListBox.Items.Add(SCOTCH_String)

        End If
    End Sub

End Class