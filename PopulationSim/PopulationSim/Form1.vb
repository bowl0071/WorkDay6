Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim pop As Double = 7000000000
        Dim curyear As Integer = 2012

        Do While (pop > 6000000)
            pop = pop / 2
            curyear = curyear - 50
        Loop


        MessageBox.Show("The year is " & curyear, "Year")

    End Sub
End Class
