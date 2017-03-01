Option Strict On

'Project:       Unit 4 VB Auto Center
'Date:          June 30, 2007
'Programmer:    Christopher M. Anderson
'Description:   Form to calculate price of car, based on Sale Price, Trade-In, and Options.

Public Class vbForm4

    'Declare Constants
    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const STEREO_PRICE_Decimal As Decimal = 425.76D
    Const INTERIOR_PRICE_Decimal As Decimal = 987.41D
    Const NAV_PRICE_Decimal As Decimal = 1741.23D
    Const STANDARD_PRICE_Decimal As Decimal = 0D
    Const PEARLIZED_PRICE_Decimal As Decimal = 345.72D
    Const CUSTOM_PRICE_Decimal As Decimal = 599.99D

    Private Sub vbForm4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load Form And Focus On Sales Price Text Box

        With Me.saleTextBox
            .Focus()
            .Select()
        End With

    End Sub

    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click
        'Calculate And Display Current Amounts And Total Due

        Dim saleDecimal, accDecimal, subDecimal, taxDecimal, totalDecimal, tradeDecimal, dueDecimal As Decimal
        Dim saleString, tradeString As String
        With Me

            'Calculate Accessories
            If .stereoCheckBox.Checked Then
                accDecimal = STEREO_PRICE_Decimal
            End If
            If .interiorCheckBox.Checked Then
                accDecimal += INTERIOR_PRICE_Decimal
            End If
            If .navCheckBox.Checked Then
                accDecimal += NAV_PRICE_Decimal
            End If

            'Calculate Finish
            If .standardRadioButton.Checked Then
                accDecimal += STANDARD_PRICE_Decimal
            ElseIf .pearlizedRadioButton.Checked Then
                accDecimal += PEARLIZED_PRICE_Decimal
            ElseIf .customRadioButton.Checked Then
                accDecimal += CUSTOM_PRICE_Decimal
            End If

            Try
                'Get Sale Price
                saleString = .saleTextBox.Text.Replace("$", "")
                saleDecimal = Decimal.Parse(saleString)

                'Calculate Subtotal
                subDecimal = saleDecimal + accDecimal

                'Calculate Sales Tax
                taxDecimal = subDecimal * TAX_RATE_Decimal

                'Calculate Total
                totalDecimal = subDecimal + taxDecimal

                'Get Trade In Allowance
                If .tradeTextBox.Text = "" Then
                    tradeDecimal = 0
                Else
                    tradeString = .tradeTextBox.Text.Replace("$", "")
                    tradeDecimal = Decimal.Parse(tradeString)
                End If

                'Calculate Amount Due
                dueDecimal = totalDecimal - tradeDecimal

                'Display Data
                .saleTextBox.Text = saleDecimal.ToString("C")
                .accTextBox.Text = accDecimal.ToString("C")
                .subTextBox.Text = subDecimal.ToString("C")
                .taxTextBox.Text = taxDecimal.ToString("C")
                .totalTextBox.Text = totalDecimal.ToString("C")
                .tradeTextBox.Text = tradeDecimal.ToString("C")
                .dueTextBox.Text = dueDecimal.ToString("C")

            Catch saleException As FormatException
                MessageBox.Show("Please enter the Sales Price amount.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With .saleTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try

        End With

    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        'Clear all previous entries

        With Me
            .accTextBox.Clear()
            .subTextBox.Clear()
            .taxTextBox.Clear()
            .totalTextBox.Clear()
            .tradeTextBox.Clear()
            .dueTextBox.Clear()
            .stereoCheckBox.Checked = False
            .interiorCheckBox.Checked = False
            .navCheckBox.Checked = False
            .standardRadioButton.Checked = True
            With .saleTextBox
                .Clear()
                .Focus()
            End With
        End With

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Close the program

        Me.Close()
    End Sub

End Class
