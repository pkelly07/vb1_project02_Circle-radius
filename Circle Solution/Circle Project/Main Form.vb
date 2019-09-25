' Name:         Circle Project
' Purpose:      Calculate and display the circle's area.
' Programmer:   <your name> on <current date>

Public Class frmMain

    Dim strAlertText As String

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' Calculate and display the circle's area.

        Const dblPI As Double = 3.14159

        Dim txtRadiusRawValue As String = txtRadius.Text

        Dim dblRadius As Double
        Dim dblArea As Double

        Double.TryParse(txtRadiusRawValue, dblRadius)

        If (dblRadius = 0) Then

            strAlertText = "Please enter a valid number in the Radius field"
            MsgBox(strAlertText)
            txtRadius.Text = ""
            lblArea.Text = ""
            txtRadius.Select()

        Else

            dblArea = dblPI * dblRadius ^ 2
            lblArea.Text = dblArea.ToString("N2")

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

End Class
