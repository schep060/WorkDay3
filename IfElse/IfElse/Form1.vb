Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        ' Modify the program such that it does not crash 
        ' if the user types incorrect input

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text
        Dim result As String

        If IsNumeric(st1) And IsNumeric(st2) Then
            num1 = CDbl(st1)
            num2 = CDbl(st2)
            If num1 > num2 Then
                result = "The larger number is " & num1
            ElseIf num2 > num1 Then
                result = "The larger number is " & num2
            Else
                result = "They are equal"
            End If
        Else
            MessageBox.Show("Input invalid")
        End If
        txtResult.Text = result
    End Sub

End Class
