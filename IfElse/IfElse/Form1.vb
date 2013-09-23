Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largernum As Double

        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then
            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)

            If (num1 > num2) Then
                largernum = num1
                txtResult.Text = "The larger number is " & num1
            ElseIf (num1 < num2) Then
                largernum = num2
                txtResult.Text = "The larger number is " & num2
            Else
                txtResult.Text = "They are equal"
            End If
        Else
            MessageBox.Show("Error: please type a number")
        End If

    End Sub
End Class
