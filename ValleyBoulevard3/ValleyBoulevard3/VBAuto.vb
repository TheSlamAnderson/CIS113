'Project:       VB Auto Sales Commission Form
'Date:          June 24, 2007
'Programmer:    Christopher Anderson
'Description:   This projects inputs sales information and calculates the commission for that sale.

Public Class VBAutoForm

    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click
        'Calculate The Salesperson's Commission

        Dim priceDecimal, costDecimal, valueDecimal As Decimal

        With Me
            Try
                'Convert Selling Price To Decimal Value
                priceDecimal = Decimal.Parse(.priceTextBox.Text)
                Try
                    'Convert Cost Value To Decimal Value
                    costDecimal = Decimal.Parse(.costTextBox.Text)

                    'Calculate Value Of Commission
                    valueDecimal = 0.2 * (priceDecimal - costDecimal)

                    'Format And Display Answer
                    .valueTextBox.Text = valueDecimal.ToString("C")

                Catch costException As FormatException
                    'Handle A Cost Exception
                    MessageBox.Show("Cost must be number.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    With .costTextBox
                        .Focus()
                        .SelectAll()
                    End With
                End Try

            Catch priceException As FormatException
                'Handle A Price Exception
                MessageBox.Show("Price must be number.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With .priceTextBox
                    .Focus()
                    .SelectAll()
                End With

            Catch anException As Exception
                'Handle Any Other Exception
                MessageBox.Show("Error: " & anException.Message)
            End Try
        End With
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        'Clear Previous Data From The Form Input Boxes

        With Me
            .priceTextBox.Clear()
            .costTextBox.Clear()
            .valueTextBox.Clear()
            With .salesTextBox
                .Clear()
                .Focus()
            End With
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Exit The Program

        Me.Close()
    End Sub
End Class