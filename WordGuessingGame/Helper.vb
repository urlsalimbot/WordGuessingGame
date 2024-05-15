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
