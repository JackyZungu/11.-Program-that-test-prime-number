Imports System.Runtime.CompilerServices

Public Class Form1

    Private Sub btnCheck_Click(ByVal sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim num As Integer

        num = Val(txtNumber.Text)

        ' check if it an even number
        If num Mod 2 = 0 Then
            txtResult.Text = " It is an even number "
        Else
            txtResult.Text = "It is an odd number"
        End If
        Dim P As Boolean = True
        Dim i As Integer
        For i = 2 To num / 2
            If num Mod i = 0 Then
                P = False
                Exit For
            End If

        Next
        If P AndAlso num > 1 Then
            txtResult.Text = "It is also a prime number"
        End If
    End Sub

    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged
        txtResult.Enabled = False
    End Sub

    Private Sub btnCheckP_Click(sender As Object, e As EventArgs) Handles btnCheckP.Click

    End Sub
End Class
