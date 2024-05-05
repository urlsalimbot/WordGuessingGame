Option Strict On

Imports System.Net.Http
Imports System.IO
Imports System.Text


Public Class GameInstance
    Public dirpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\WGG")
    Public Property words As New List(Of String)
    Public Property GameOver As Boolean = False
    Public Property gform As GameForm1
    Public Property guessword As String
    Public Property myattempt As Int32

    Public Sub GameInstance(gameform As GameForm1)
        gform = gameform
        myattempt = 1
        InitGameIns()
        MainGameLoop()
    End Sub

    Public Async Sub InitGameIns()
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
        MessageBox.Show("Get Done")
    End Sub

    Public Sub MainGameLoop()
        'MessageBox.Show(gform.textboxes(0).Name)
        If myattempt = 1 Then
            guessword = WordPicker()
            gform.MainInptBox.MaxLength = guessword.Length
        End If
        gform.SuspendLayout()
        gameDisp(gform.textboxes, guessword, myattempt)
        gform.ResumeLayout()
        gform.PerformLayout()
        MessageBox.Show(guessword)
    End Sub

    Public Sub Logic(ans As String)
        Dim index As Int32
        For i As Int32 = 0 To guessword.Length - 1
            index = (i + (myattempt - 1) * guessword.Length)
            If ans(i) = guessword(i) Then
                gform.textboxes(index).BackColor = Color.Green
            Else
                gform.textboxes(index).BackColor = Color.Red
                For Each letter In guessword
                    If ans(i) = letter Then
                        gform.textboxes(index).BackColor = Color.Yellow
                    End If
                Next
            End If
        Next
        If myattempt = 3 Then
            gform.SuspendLayout()
            clearDisp(gform.textboxes)
            gform.ResumeLayout()
            gform.PerformLayout()
            myattempt = 0
        End If
        myattempt += 1
        MainGameLoop()
    End Sub

    Public Function WordPicker() As String
        Dim rnd = New Random()
        Dim gameword = words(rnd.Next(0, words.Count))
        Return gameword
    End Function

End Class
