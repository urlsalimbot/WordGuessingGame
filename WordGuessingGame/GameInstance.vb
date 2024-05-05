Option Strict On

Imports System.Net.Http
Imports System.IO
Imports System.Text


Public Class GameInstance
    Public dirpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\WGG")
    Dim words As New List(Of String)
    Dim GameOver As Boolean = False

    Public Sub GameInstance()
        ' Create new Task.
        ' ... Use AddressOf to reference a method.
        Dim init As Task = New Task(AddressOf init)
        ' Start the task.
        init.Start()
    End Sub

    Public Sub Init()
        Dim filename, filepath As String

        filename = "words.txt"
        filepath = System.IO.Path.Combine(dirpath, filename)

        If My.Computer.FileSystem.DirectoryExists(dirpath) = False Then
            System.IO.Directory.CreateDirectory(dirpath)
            GetWords(filepath)
        Else
            ReadWords(filepath)
        End If
    End Sub

    Public Async Sub ReadWords(filepath As String)
        Using read As StreamReader = File.OpenText(filepath)
            While read.ReadLine <> ""
                words.Add(read.ReadLine)
            End While
        End Using
    End Sub

    Public Async Sub GetWords(filepath As String)

        Dim url As String = "https://www.mit.edu/~ecprice/wordlist.10000"
        ' Use HttpClient in Using-statement.
        ' ... Use GetAsync to get the page data.
        Dim client As HttpClient = New HttpClient()
        Dim response As HttpResponseMessage = Await client.GetAsync(url)
        Dim content As HttpContent = response.Content
        ' Get contents of page as a String.
        Dim result As String = Await content.ReadAsStringAsync()
        Dim parts As String() = result.Split(New String() {ControlChars.Lf}, StringSplitOptions.None)

        Using write As StreamWriter = File.CreateText(filepath)
            For Each elem In parts
                If elem.Length > 3 And elem.Length < 9 Then
                    words.Add(elem.ToString())
                    write.WriteLine(elem.ToString())
                End If
            Next
        End Using
    End Sub

    Public Async Sub MainLoop()
        While GameOver = False

            Dim guessword = WordPicker()



            userans = Await GameForm1.MainInptBox.

        End While
    End Sub

    Public Function WordPicker() As String
        Dim rnd = New Random()
        Dim gameword = words(rnd.Next(0, List1.Count))
        Return gameword
    End Function

End Class
