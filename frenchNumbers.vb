' Program Name: French Numbers
'Developer: Maria Jackson
'Date: Feb 11, 2023
'Purpose: This program prompts user to select between numbers 1-5
'         Once clicked, the French translation of the number is displayed
'         The user can exit the program via the Exit btn at any time
Public Class frmNumbers
    Private Sub frmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' form loads without min and max buttons in caption of window
        MinimizeBox = False
        MaximizeBox = False

    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' on click, calls Close() to close program window
        Close()
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        ' on click, displays French translation of 1
        lblFrench.Visible = True
        lblFrench.Text = "un"

    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        ' on click, displays French translation of 2
        lblFrench.Visible = True
        lblFrench.Text = "deux"

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        'on click, displays French translation of 3
        lblFrench.Visible = True
        lblFrench.Text = "trois"

    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        'on click, displays French translation of 4
        lblFrench.Visible = True
        lblFrench.Text = "quatre"

    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        'on click, displays French translation of 5
        lblFrench.Visible = True
        lblFrench.Text = "cinq"

    End Sub
End Class
