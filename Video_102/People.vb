Namespace allPeople

End Namespace

Namespace allPeople.otherPeople
    Public Class People
        Public Property firstName As String
        Public Property lastName As String

        Public Overrides Function ToString() As String
            Return firstName & " " & lastName
        End Function
    End Class
End Namespace

Namespace allPeople.Friends
    Public Class People
        Public Property firstName As String
        Public Property lastName As String
        Public Property yearsFriends As Integer

        Public Overrides Function ToString() As String
            Return firstName & " " & lastName & " " & yearsFriends
        End Function
    End Class
End Namespace


