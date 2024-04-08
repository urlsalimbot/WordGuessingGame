Public Class TitleForm
    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs)
        Dim xForm As New ExitForm
        If xForm.ShowDialog = DialogResult.Yes Then
            Close()
        Else
            'xForm.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToggleVis(GroupBox1)
        ToggleVis(GroupBox2)
    End Sub

    'DONE
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start(New ProcessStartInfo("www.github.com/urlsalimbot/WordGuessingGame") With {.UseShellExecute = True})
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ToggleVis(GroupBox1)
        ToggleVis(GroupBox2)
    End Sub
End Class

