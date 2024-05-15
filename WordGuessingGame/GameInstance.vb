Option Strict On

Imports System.Net.Http
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class GameInstance
    Public dirpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\WGG")
    Public Property words As New List(Of String)
    Public Property GameOver As Boolean = False
    Public Property gform As GameForm1
    Public Property guessword As String
    Public Property myattempt As Int32
    Public Property difficulty As Int32

    Public Async Sub GameInstance(gameform As GameForm1, diff As Int32)
        gform = gameform
        myattempt = 1
        difficulty = diff
        gform.ContinueBtn.Visible = Await InitGameIns().ConfigureAwait(False)
    End Sub

    Public Async Function InitGameIns() As Task(Of Boolean)
        Dim filename, filepath As String

        filename = "words.txt"
        filepath = System.IO.Path.Combine(dirpath, filename)

        If My.Computer.FileSystem.DirectoryExists(dirpath) = False Then
            System.IO.Directory.CreateDirectory(dirpath)
            GetWords(filepath)
        Else
            ReadWords(filepath)
            Return True
        End If
    End Function

    Public Sub ReadWords(filepath As String)
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
        Dim response As HttpResponseMessage = Await client.GetAsync(url).ConfigureAwait(False)
        Dim content As HttpContent = response.Content
        ' Get contents of page as a String.
        Dim result As String = Await content.ReadAsStringAsync().ConfigureAwait(False)
        Dim parts As String() = result.Split(New String() {ControlChars.Lf}, StringSplitOptions.None)

        Using write As StreamWriter = File.CreateText(filepath)
            For Each elem In parts
                If elem.Length > 2 And elem.Length < 9 Then
                    write.WriteLine(elem.ToString())
                End If
            Next
        End Using
        MessageBox.Show("Get Done")
        InitGameIns()
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

    Public Sub Checker(ans As String)
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
    End Sub

    Public Sub AttemptCounter(ans As String)
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

        If gameword.Length > difficulty Then
            Return Nothing
        End If

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

        Dim Jword As JArray = JArray.Parse(result)
        Dim firstObject As JObject = CType(Jword(0), JObject)

        'get meanings
        Dim getmeanings As JArray = CType(firstObject("meanings"), JArray)

        gform.partofspeech = getmeanings

        Return gameword
    End Function

End Class
