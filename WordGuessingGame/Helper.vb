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
End Module
