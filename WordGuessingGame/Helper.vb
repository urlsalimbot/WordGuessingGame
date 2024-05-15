Imports System.Diagnostics.Metrics
Imports System.DirectoryServices.ActiveDirectory
Module Helper

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


    Public Sub kbShowCorr(items As List(Of Button), guess As String, ans As String)

        guess = guess.ToUpper
        ans = ans.ToUpper

        Dim corrletter As New List(Of Decimal)
        Dim mispletter As New List(Of Decimal)
        Dim wrongletter As New List(Of Decimal)

        For i As Integer = 0 To guess.Length - 1
            If guess(i) = ans(i) Then
                Dim corrdeci(0) As Decimal
                corrdeci(0) = Convert.ToDecimal(System.Text.Encoding.ASCII.GetBytes(ans(i))(0))
                corrletter.Add(corrdeci(0))
            End If
        Next

        For Each letter In guess
            For Each aletter In ans
                If letter = aletter Then
                    Dim corrdeci(0) As Decimal
                    corrdeci(0) = Convert.ToDecimal(System.Text.Encoding.ASCII.GetBytes(letter)(0))
                    mispletter.Add(corrdeci(0))
                End If
            Next
        Next

        For Each letter In ans
            Dim corrdeci(0) As Decimal
            corrdeci(0) = Convert.ToDecimal(System.Text.Encoding.ASCII.GetBytes(letter)(0))
            wrongletter.Add(corrdeci(0))
        Next

        For Each elem In wrongletter
            Dim ind As Integer = elem - 64

            'items(ind).BackgroundImage = MyImage
        Next

        'Dim corrdeci(guess.Length) As Decimal
        'For i As Integer = 0 To guess.Length - 1
        'corrdeci(i) = Convert.ToDecimal(System.Text.Encoding.ASCII.GetBytes(guess)(i))
        'Next

        'Dim ansdeci(guess.Length) As Decimal
        'For i As Integer = 0 To guess.Length - 1
        'ansdeci(i) = Convert.ToDecimal(System.Text.Encoding.ASCII.GetBytes(ans)(i))
        'Next

        'Dim keyydeci(26) As Decimal
        'Dim index As Integer = 0
        'For Each item In items
        'Dim name As String = item.Name.Substring(0, 1)
        'For I As Integer = 0 To System.Text.Encoding.ASCII.GetByteCount(name) - 1
        'ci(index) = Convert.ToDecimal(System.Text.Encoding.ASCII.GetBytes(name)(I))
        'Next
        'index += 1
        'Next


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
End Module
