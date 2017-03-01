'Project:       Mama Jane's Pizza (Final Exam)
'Date:          July 30, 2007
'Programmer:    Christopher M. Anderson
'Description:   Program To Create Pizza Order

Option Strict On

Public Class mjForm

    'Declare Structure And Module-Level Variables
    Structure Group
        Dim pizzaPriceDecimal As Decimal
    End Structure

    'Determine If Order Is Printable
    Dim printBoolean As Boolean = False

    'Declare Pizza Price Array
    Private pizzaArray(3, 1) As Group

    Private Sub mjForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Set Up Pizza Size Combo Box
        Me.sizeComboBox.Items.Insert(0, "Small")
        Me.sizeComboBox.Items.Insert(1, "Medium")
        Me.sizeComboBox.Items.Insert(2, "Large")
        Me.sizeComboBox.Items.Insert(3, "Monster")
        Me.sizeComboBox.Text = "Please Select Size"

        'Set Up Pizza Style Combo Box
        Me.styleComboBox.Items.Insert(0, "Regular")
        Me.styleComboBox.Items.Insert(1, "Stuffed Crust")
        Me.styleComboBox.Text = "Please Select Style"

        'Set Up Pizza Price Array
        pizzaArray(0, 0).pizzaPriceDecimal = 5.99D
        pizzaArray(0, 1).pizzaPriceDecimal = 7.99D
        pizzaArray(1, 0).pizzaPriceDecimal = 6.99D
        pizzaArray(1, 1).pizzaPriceDecimal = 8.99D
        pizzaArray(2, 0).pizzaPriceDecimal = 7.99D
        pizzaArray(2, 1).pizzaPriceDecimal = 9.99D
        pizzaArray(3, 0).pizzaPriceDecimal = 8.99D
        pizzaArray(3, 1).pizzaPriceDecimal = 10.99D

    End Sub

    Private Sub clearForm()
        'Clear The Form

        'Clear All Text Boxes
        Me.nameTextBox.Clear()
        Me.addTextBox.Clear()
        Me.cityTextBox.Clear()
        Me.stTextBox.Text = "TN"
        Me.zipTextBox.Clear()
        Me.pizzaTextBox.Clear()
        Me.topTextBox.Clear()
        Me.discTextBox.Clear()
        Me.taxTextBox.Clear()
        Me.dueTextBox.Clear()

        'Reset Amount Due Label
        Me.dueLabel.Font = New System.Drawing.Font("Tahoma", 9.75, FontStyle.Bold)
        Me.dueLabel.ForeColor = Color.Black

        'Clear All Checkboxes
        Me.pepCheckBox.Checked = False
        Me.onionCheckBox.Checked = False
        Me.excCheckBox.Checked = False

        'Clear All Radio Buttons
        Me.noneRadioButton.Checked = True
        Me.coupRadioButton.Checked = False
        Me.prefRadioButton.Checked = False

        'Reset Combo Boxes
        Me.sizeComboBox.SelectedIndex = -1
        Me.sizeComboBox.Text = "Please Select Size"
        Me.styleComboBox.SelectedIndex = -1
        Me.styleComboBox.Text = "Please Select Style"

        'Select Name Text Box
        Me.nameTextBox.Focus()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear Form Using The Menu
        clearForm()
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        'Clear Form Using The Button
        clearForm()
    End Sub

    Private Sub exitForm()

        'Exit The Program
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit The Form Using The Menu
        exitForm()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Exit The Form Using The Button
        exitForm()
    End Sub

    Private Sub calcForm()

        'Set Variables For Pricing
        Dim errorBoolean As Boolean = True
        Dim subTotal As Decimal = 0D
        Dim pizzaSize As Integer
        Dim pizzaStyle As Integer
        Dim pizzaPrice As Decimal
        Dim topPrice As Decimal = 0D
        Dim discPrice As Decimal = 0D
        Dim taxDue As Decimal = 0D
        Dim amountDue As Decimal = 0D

        'Set Constants For Rates And Taxes
        Const TOPPING_RATE_Decimal As Decimal = 0.75D
        Const DISCOUNT_COUP_Decimal As Decimal = 0.1D
        Const DISCOUNT_PREF_Decimal As Decimal = 0.15D
        Const TAX_RATE_Decimal As Decimal = 0.08D

        'Determine If All Customer Information Is Filled Out
        If Me.nameTextBox.Text = "" Then
            errorBoolean = False
        End If
        If Me.addTextBox.Text = "" Then
            errorBoolean = False
        End If
        If Me.cityTextBox.Text = "" Then
            errorBoolean = False
        End If
        If Me.stTextBox.Text = "" Then
            errorBoolean = False
        End If
        If Me.zipTextBox.Text = "" Then
            errorBoolean = False
        End If

        If errorBoolean = True Then

            Try

                'Gather Pizza Size
                pizzaSize = Me.sizeComboBox.SelectedIndex

                Try

                    'Set Printable Status
                    printBoolean = True

                    'Gather Pizza Style
                    pizzaStyle = Me.styleComboBox.SelectedIndex

                    'Set pizzaPrice Equal To Price From Array
                    pizzaPrice = Me.pizzaArray(pizzaSize, pizzaStyle).pizzaPriceDecimal

                    'Calculate Pizza Price
                    subTotal = pizzaPrice

                    'Display Pizza Price
                    Me.pizzaTextBox.Text = pizzaPrice.ToString("C")

                    'Evaluate Toppings Checkboxes
                    If Me.pepCheckBox.Checked = True Then
                        topPrice += TOPPING_RATE_Decimal
                    End If
                    If Me.onionCheckBox.Checked = True Then
                        topPrice += TOPPING_RATE_Decimal
                    End If
                    If Me.excCheckBox.Checked = True Then
                        topPrice += TOPPING_RATE_Decimal
                    End If

                    'Add Toppings Price To Subtotal
                    subTotal += topPrice

                    'Display Toppings Result
                    Me.topTextBox.Text = topPrice.ToString("C")

                    'Evaluate Discount Radio Buttons
                    With Me
                        If Me.noneRadioButton.Checked Then
                            discPrice = 0D
                        ElseIf Me.coupRadioButton.Checked Then
                            discPrice = (pizzaPrice * DISCOUNT_COUP_Decimal)
                        ElseIf Me.prefRadioButton.Checked Then
                            discPrice = (pizzaPrice * DISCOUNT_PREF_Decimal)
                        Else
                            discPrice = 0D
                        End If
                    End With

                    'Subtract Discount From Subtotal
                    subTotal -= discPrice

                    'Display Discount Result
                    Me.discTextBox.Text = discPrice.ToString("C")

                    'Calculate Sales Tax
                    taxDue = (subTotal * TAX_RATE_Decimal)

                    'Display Sales Tax Result
                    Me.taxTextBox.Text = taxDue.ToString("C")

                    'Calculate Amount Due
                    amountDue = (subTotal + taxDue)

                    'Display Amount Due Result
                    Me.dueTextBox.Text = amountDue.ToString("C")

                Catch ex As Exception
                    MessageBox.Show("You Must Select A Pizza Style", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Catch ex As Exception
                MessageBox.Show("You Must Select A Pizza Size", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("Please Fill Out All Customer Information.", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        'Calculate The Form Using The Menu
        calcForm()
    End Sub

    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click
        'Calculate The Form Using The Button
        calcForm()
    End Sub

    Private Sub printForm()

        If printBoolean = False Then
            MessageBox.Show("Please Complete All Information And Calculate Before Printing.", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf printBoolean = True Then
            Me.PrintPreviewDialog1.Document = PrintDocument1
            Me.PrintPreviewDialog1.ShowDialog()
        End If

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        'Print The Form Using The Menu
        printForm()
    End Sub

    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        'Print The Form Using The Button
        printForm()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click

        'Change The Font Of The Amount Due Box
        With FontDialog1
            .ShowDialog()
            Me.dueLabel.Font = .Font
        End With

    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click

        'Change The Background Color Of The Amount Due Box
        With Me
            With .ColorDialog1
                .ShowDialog()
                Me.dueLabel.ForeColor = .Color
            End With
        End With

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'Declare Message Variable
        Dim messageString As String

        'Set Up Message Text
        messageString = "Programmer:" & ControlChars.NewLine & "Christopher Anderson" & ControlChars.NewLine & ControlChars.NewLine & "Mama Jane's Pizza" & ControlChars.NewLine & "Price Calculation Program"

        'Display Message Box
        MessageBox.Show(messageString, "About Mama Jane's Pizza", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

        'Print Page Header
        printLineString = "MAMA JANE'S PIZZA"
        e.Graphics.DrawString(printLineString, headerFont, Brushes.Red, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        'Print Programmer Information
        printLineString = "Customer:"
        verticalPrintLocationSingle += lineHeightSingle * 4
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = Me.nameTextBox.Text
        verticalPrintLocationSingle += lineHeightSingle + 2
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        printLineString = Me.addTextBox.Text
        verticalPrintLocationSingle += lineHeightSingle
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        printLineString = Me.cityTextBox.Text & "," & Me.stTextBox.Text & " " & Me.zipTextBox.Text
        verticalPrintLocationSingle += lineHeightSingle
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        printLineString = "Order:"
        verticalPrintLocationSingle += lineHeightSingle * 2
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = Me.sizeComboBox.Text & " " & Me.styleComboBox.Text
        verticalPrintLocationSingle += lineHeightSingle + 2
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        If Me.pepCheckBox.Checked = True Then
            printLineString = " + Peppers"
            verticalPrintLocationSingle += lineHeightSingle
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 50, verticalPrintLocationSingle)
        End If

        If Me.onionCheckBox.Checked = True Then
            printLineString = " + Onions"
            verticalPrintLocationSingle += lineHeightSingle
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 50, verticalPrintLocationSingle)
        End If

        If Me.excCheckBox.Checked = True Then
            printLineString = " + Extra Cheese"
            verticalPrintLocationSingle += lineHeightSingle
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 50, verticalPrintLocationSingle)
        End If

        printLineString = "Price:"
        verticalPrintLocationSingle += lineHeightSingle * 2
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = "Subtotal:"
        verticalPrintLocationSingle += lineHeightSingle + 2
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        printLineString = Me.pizzaTextBox.Text
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 150, verticalPrintLocationSingle)

        printLineString = "Toppings:"
        verticalPrintLocationSingle += lineHeightSingle
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        printLineString = Me.topTextBox.Text
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 150, verticalPrintLocationSingle)

        printLineString = "Discount:"
        verticalPrintLocationSingle += lineHeightSingle
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        printLineString = Me.discTextBox.Text
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 150, verticalPrintLocationSingle)

        printLineString = "Sales Tax:"
        verticalPrintLocationSingle += lineHeightSingle
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 25, verticalPrintLocationSingle)

        printLineString = Me.taxTextBox.Text
        e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle + 150, verticalPrintLocationSingle)

        printLineString = "Amount Due:"
        verticalPrintLocationSingle += lineHeightSingle + 2
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Red, horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = Me.dueTextBox.Text
        e.Graphics.DrawString(printLineString, titleFont, Brushes.Red, horizontalPrintLocationSingle + 150, verticalPrintLocationSingle)

    End Sub

End Class
