Imports Newtonsoft.Json

Module Helper

    Public Property dirpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\WGG")
    Public Property filename As String = "leaderboard.json"
    Public Property filepath As String = System.IO.Path.Combine(dirpath, filename)
    Public Property leaderboard As New List(Of Player)

    Public Sub ToggleVis(item As Control)
        item.Visible = Not item.Visible
    End Sub

    Function ExitProg() As Boolean
        Dim xForm As New ExitForm
        If xForm.ShowDialog = DialogResult.Yes Then
            Return True
        Else
            'xForm.Close()
            Return False
        End If
    End Function

    Public Sub gameDisp(items As List(Of TextBox), word As String, attempt As Int32, wsize As Int32)
        Dim anchor As Int32
        anchor = (wsize - (items(0).Size.Width + 15) * word.Length) / 2
        For i As Int16 = 0 To word.Length - 1
            Dim tempbox As TextBox
            tempbox = items(i + ((attempt - 1) * word.Length))
            tempbox.Location = New Size((anchor + (tempbox.Size.Width + 15) * (i)), (36 + (tempbox.Size.Height + 20) * (attempt - 1)))
            tempbox.Visible = True
        Next
    End Sub

    Public Sub clearDisp(items As List(Of TextBox))
        For Each item In items
            item.Visible = False
            item.Text = ""
            item.BackColor = SystemColors.Window
        Next
    End Sub

    Public Sub kbReset(items As List(Of Button), images As Dictionary(Of Integer, Object))

        For i As Integer = 0 To 25
            items(i).BackgroundImage = images.Item(i + 65)
        Next

    End Sub

    Public Sub kbShowWrong(items As List(Of Button), ans As String, images As Dictionary(Of Integer, Object))

        Dim wrongletter As New List(Of Decimal)

        For Each letter In ans
            Dim corrdeci(0) As Decimal
            corrdeci(0) = Convert.ToDecimal(System.Text.Encoding.ASCII.GetBytes(letter)(0))
            wrongletter.Add(corrdeci(0))
        Next

        For Each elem In wrongletter
            If images.ContainsKey(elem) Then
                items(elem - 65).BackgroundImage = images.Item(elem)
            End If
        Next
    End Sub

    Public Sub kbShowMiss(items As List(Of Button), guess As String, ans As String, images As Dictionary(Of Integer, Object))

        Dim mispletter As New List(Of Decimal)

        For Each letter In guess
            For Each aletter In ans
                If letter = aletter Then
                    Dim corrdeci(0) As Decimal
                    corrdeci(0) = Convert.ToDecimal(System.Text.Encoding.ASCII.GetBytes(letter)(0))
                    mispletter.Add(corrdeci(0))
                End If
            Next
        Next

        For Each elem In mispletter
            If images.ContainsKey(elem) Then
                items(elem - 65).BackgroundImage = images.Item(elem)
            End If
        Next
    End Sub

    Public Sub kbShowCorr(items As List(Of Button), guess As String, ans As String, images As Dictionary(Of Integer, Object))

        Dim corrletter As New List(Of Decimal)

        For i As Integer = 0 To guess.Length - 1
            If guess(i) = ans(i) Then
                Dim corrdeci(0) As Decimal
                corrdeci(0) = Convert.ToDecimal(System.Text.Encoding.ASCII.GetBytes(ans(i))(0))
                corrletter.Add(corrdeci(0))
            End If
        Next

        For Each elem In corrletter
            If images.ContainsKey(elem) Then
                items(elem - 65).BackgroundImage = images.Item(elem)
            End If
        Next
    End Sub


    Public Sub dispText(items As List(Of TextBox), display As String, range As Int32, len As Int32)
        For index As Int32 = 0 To len - 1
            Dim tempbox As TextBox = items(index + ((range - 1) * len))
            If index < display.Length Then
                tempbox.Text = display(index)
            Else
                tempbox.Text = ""
            End If
        Next
    End Sub

    Public Function LoadLB() As List(Of Player)
        If My.Computer.FileSystem.DirectoryExists(dirpath) And System.IO.File.Exists(filepath) Then

            Dim file As String = IO.File.ReadAllText(filepath)
            If file = Nothing Then
                Return Nothing
            End If
            Dim res As New List(Of Player)
            res = JsonConvert.DeserializeObject(Of List(Of Player))(file)
            leaderboard = res

        Else
            System.IO.Directory.CreateDirectory(dirpath)
            System.IO.File.Create(filepath)
        End If
        Return leaderboard
    End Function

    Public Sub SerializeLB(ByRef lastplayer As Player)
        If My.Computer.FileSystem.DirectoryExists(dirpath) Then
            If System.IO.File.Exists(filepath) Then
                LoadLB()
                leaderboard.Add(lastplayer)
                Dim save As String = JsonConvert.SerializeObject(leaderboard)
                Dim file As IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(filepath, False)
                file.WriteLine(save)
                file.Close()

            End If
        End If
    End Sub


End Module
