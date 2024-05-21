Option Strict On

Imports System.Net.Http
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class GameInstance
    'SAVE LOCATION
    Public Property dirpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\WGG")

    'CONTROL
    Public Property words As New List(Of String)
    Public Property GameOver As Boolean = False

    Public Property gform As GameForm1

    'USER PROPERTIES
    Public Property difficulty As Integer
    Public Property myattempt As Integer
    Public Property games As Integer = 0
    Public Property win As Boolean = False

    'EVENTS
    Private Property readwordlist As Boolean
    Private Property guessword As String

    Public Event ReadFin(e As Boolean)
    Public Event WordPicked(e As String)

    Public Property ReadWordslist As Boolean
        Set(value As Boolean)
            readwordlist = value
            RaiseEvent ReadFin(readwordlist)
        End Set
        Get
            Return readwordlist
        End Get
    End Property
    Public Property PickedWord As String
        Set(value As String)
            guessword = value
            If guessword <> Nothing Then
                RaiseEvent WordPicked(guessword)
            End If
        End Set
        Get
            Return guessword
        End Get
    End Property

    'CONSTRUCTOR
    Public Sub New(ByRef gameform As GameForm1, diff As Integer)

        gform = gameform
        myattempt = 1
        difficulty = diff
        InitGameIns()

    End Sub

    Public Sub gInstance_GetWordslist(e As Boolean) Handles Me.ReadFin
        gform.ContinueBtn.Visible = e
    End Sub

    'PREPARE WORDS
    Public Async Sub InitGameIns()

        Dim filename, filepath As String

        filename = "words.txt"
        filepath = System.IO.Path.Combine(dirpath, filename)

        If My.Computer.FileSystem.DirectoryExists(dirpath) And IO.File.Exists(filepath) Then
            ReadWords(filepath)
            ReadWordslist = True
        Else
            System.IO.Directory.CreateDirectory(dirpath)
            ReadWordslist = Await GetWords(filepath)

        End If

    End Sub

    'READWORDS
    Public Sub ReadWords(filepath As String)
        Using read As StreamReader = File.OpenText(filepath)
            While read.ReadLine <> ""
                words.Add(read.ReadLine)
            End While
        End Using
    End Sub

    'WEBREQUEST TO GETWORDS AND STORE THEM
    Public Async Function GetWords(filepath As String) As Task(Of Boolean)
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
                If elem.Length > 2 And elem.Length < 9 Then
                    write.WriteLine(elem.ToString())
                End If
            Next

        End Using
        'MessageBox.Show("Get Done")
        ReadWords(filepath)
        Return True
    End Function

    'MainGameLoop
    Public Async Sub MainGameLoop()

        If myattempt = 1 Then
            While guessword = Nothing
                PickedWord = Await WordPicker()
            End While
        End If

        gform.SuspendLayout()
        gameDisp(gform.textboxes, PickedWord, myattempt, gform.Size.Width)
        gform.ResumeLayout()

    End Sub

    'Exit Game and Save stats
    Public Sub ExitGame()

        Dim player As New Player(gform.username)
        Dim score As Integer
        Select Case difficulty
            Case 6
                score = 500 * games * 2
            Case 8
                score = 500 * games * 3
            Case Else
                score = 500 * games
        End Select
        player._score = score
        player._gamesplayed = games
        player._dateplayed = DateTime.Now

        SerializeLB(player)

    End Sub

    'Checker 
    Public Sub Checker(ans As String)
        Dim index As Integer

        For i As Integer = 0 To guessword.Length - 1

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

            myattempt = 5
            win = True
            MessageBox.Show("Answer Correct, You Won!")

        End If

    End Sub

    Public Sub AttemptCounter(ans As String)

        If myattempt > 4 Then

            gform.SuspendLayout()

            If Not win Then
                MessageBox.Show("Sorry, The correct answer is " & guessword)

            End If

            clearDisp(gform.textboxes)
            kbReset(gform.Buttons, gform.normpic)
            gform.ResumeLayout()

            myattempt = 0
            games += 1
            win = False
            guessword = ""

        End If

        myattempt += 1
        MainGameLoop()

    End Sub

    Public Async Function WordPicker() As Task(Of String)

        Dim rnd = New Random()
        Dim gameword = words(rnd.Next(0, words.Count))

        If (gameword.Length < (difficulty - 2)) Or (gameword.Length > (difficulty + 1)) Then
            Return Nothing
        End If

        Dim url As String = "https://api.dictionaryapi.dev/api/v2/entries/en/" + gameword
        Dim client As HttpClient = New HttpClient()
        Dim response As HttpResponseMessage = Await client.GetAsync(url)

        If response.StatusCode <> HttpStatusCode.OK Then
            Return Nothing
        End If

        Dim content As HttpContent = response.Content

        'Get contents of page as a String.
        Dim result As String = Await content.ReadAsStringAsync()

        Dim Jword As JArray = JArray.Parse(result)
        Dim firstObject As JObject = CType(Jword(0), JObject)

        'Get Meanings
        Dim getmeanings As JArray = CType(firstObject("meanings"), JArray)

        gform.partofspeech = getmeanings

        Return gameword
    End Function

End Class
