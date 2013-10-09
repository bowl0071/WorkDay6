Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        lstResult.Items.Clear()
        Dim persq As Integer = 1
        Do While persq < 11
            lstResult.Items.Add("Number is " & persq ^ 2)
            persq = (persq + 1)
        Loop

    End Sub
End Class
