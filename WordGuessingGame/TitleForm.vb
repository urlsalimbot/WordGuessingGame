Public Class TitleForm
    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        Dim xForm As New ExitForm
        If xForm.showDialog = DialogResult.Yes Then
            Me.Close()
        Else
            'xForm.Close()
        End If
    End Sub
End Class
