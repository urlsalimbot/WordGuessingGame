Module Helper

    Public Sub ToggleVis(item As Control)
        item.Enabled = Not item.Enabled
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

    Public Sub Checker(items As List(Of Button))
        For Each elem In items
            If elem.Name = ("Q" + "Btn") Then
                elem.Visible = False
            End If
        Next
    End Sub

    Public Sub gameDisp(items As List(Of TextBox), word As String, attempt As Int32)
        For i As Int16 = 0 To word.Length - 1
            Dim tempbox As TextBox
            tempbox = items(i + ((attempt - 1) * word.Length))
            tempbox.Location = New Size((180 + (tempbox.Size.Width + 15) * (i)), (36 + (tempbox.Size.Height + 20) * (attempt - 1)))
            tempbox.Visible = True
        Next
    End Sub

    Public Sub clearDisp(items As List(Of TextBox), used As Int32)
        For i As Int32 = 0 To used - 1
            ToggleVis(items(i))
        Next
    End Sub
End Module
