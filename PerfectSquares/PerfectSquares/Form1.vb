Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        lstResult.Items.Clear()
        Dim persq As Integer = 1
        Do While persq < 100
            lstResult.Items.Add("Number is " & persq)
            persq = (persq + 1) ^ 2
        Loop

    End Sub
End Class
