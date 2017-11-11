' Project name:     Savings Account
' Project purpose:  Shows balance at 3 different rates over 5 years
' Created by:       Peter Gebura on 10/26/17

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        ' Exit button close when clicked

        Me.Close()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ' Declare variables

        Dim beginPrincipal As Double
        Dim principal As Double
        Dim increase As Double

        ' Assign input to variables
        Double.TryParse(principalTextBox.Text, beginPrincipal)
        balanceListBox.Items.Clear()
        balanceListBox.Items.Add("Rate     Year     Balance")

        ' Calculate and display yearly balances
        For rate As Double = 0.02 To 0.04 Step 0.01
            principal = beginPrincipal
            balanceListBox.Items.Add(rate.ToString("P0"))
            For year As Integer = 1 To 5
                increase = principal * rate
                principal += increase
                balanceListBox.Items.Add("            " & year.ToString & "         " & principal.ToString("C0"))
            Next year
        Next rate

        ' Sends focus to textbox
        principalTextBox.Focus()
        principalTextBox.SelectAll()
    End Sub

    Private Sub principalTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles principalTextBox.KeyPress
        ' Accepts only numbers and backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub principalTextBox_Enter(sender As Object, e As EventArgs) Handles principalTextBox.Enter
        ' Selects existing text when textbox receives focus

        principalTextBox.Focus()
        principalTextBox.SelectAll()
    End Sub

    Private Sub principalTextBox_TextChanged(sender As Object, e As EventArgs) Handles principalTextBox.TextChanged
        ' Clears the listbox

        balanceListBox.Items.Clear()
    End Sub
End Class
