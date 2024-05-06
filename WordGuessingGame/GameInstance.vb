Option Strict Off

Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Net.Cache
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq
Imports System.Runtime.CompilerServices



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

        Dim url As String = "https://raw.githubusercontent.com/lorenbrichter/Words/master/Words/en.txt"
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

    Public Async Sub MainGameLoop()
        'MessageBox.Show(gform.textboxes(0).Name)
        If myattempt = 1 Then
            While guessword = Nothing
                guessword = Await WordPicker()
            End While
            gform.MainInptBox.MaxLength = guessword.Length
        End If
        gform.SuspendLayout()
        gameDisp(gform.textboxes, guessword, myattempt, gform.Size.Width)
        gform.ResumeLayout()
        gform.PerformLayout()
        'MessageBox.Show(guessword)
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

        If ans = guessword Then
            myattempt = 3
            MessageBox.Show("Answer Correct, You Won!")
        End If

        If myattempt = 3 Then
            gform.SuspendLayout()
            clearDisp(gform.textboxes)
            gform.ResumeLayout()
            gform.PerformLayout()
            myattempt = 0
            guessword = ""
        End If
        myattempt += 1
        MainGameLoop()
    End Sub

    Public Async Function WordPicker() As Task(Of String)
        Dim rnd = New Random()
        Dim gameword = words(rnd.Next(0, words.Count))
        Dim url As String = "https://api.dictionaryapi.dev/api/v2/entries/en/" + gameword
        Dim client As HttpClient = New HttpClient()
        Dim response As HttpResponseMessage

        response = Await client.GetAsync(url)

        If response.StatusCode <> HttpStatusCode.OK Then
            Return Nothing
        End If

        Dim content As HttpContent = response.Content
        ' Get contents of page as a String.
        Dim result As String = Await content.ReadAsStringAsync()

        Dim Jword As Newtonsoft.Json.Linq.JArray = Newtonsoft.Json.Linq.JArray.Parse(result)
        Dim firstObject As JObject = Jword(0)
        'get meanings
        Dim getmeanings As JArray = firstObject("meanings")
        Dim getpart As JObject = getmeanings(0)
        Dim getDefs As JArray = getpart("definitions")
        Dim getdef2 As JObject = getDefs(0)

        gform.Partbox.Text = getpart("partOfSpeech").ToString()
        gform.definitionBox.Text = getdef2("definition").ToString()

        Return gameword
    End Function

End Class
