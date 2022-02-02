Public Class Form1

    Private myPerson As New allPeople.otherPeople.People

    Private Sub btnShowPerson_Click(sender As Object, e As EventArgs) Handles btnShowPerson.Click
        myPerson.firstName = txtBoxFirstName.Text
        myPerson.lastName = txtBoxLastName.Text
        MsgBox(myPerson.ToString())
    End Sub
End Class
