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

    Public Sub gameDisp(items As List(Of TextBox), word As String)

    End Sub

End Module
