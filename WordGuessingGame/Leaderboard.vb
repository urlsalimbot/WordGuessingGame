Imports Newtonsoft.Json

Public Class Leaderboard
    Public Property dirpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\WGG")
    Public Property filename As String = "\leaderboard.json"
    Public Property filepath As String = System.IO.Path.Combine(dirpath, filename)



    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(dirpath) Then

        Else
            System.IO.Directory.CreateDirectory(dirpath)

            If System.IO.File.Exists(filepath) Then

            Else
                System.IO.File.Create(filepath)

            End If

        End If
    End Sub
End Class