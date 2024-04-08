Public Class TitleForm
    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        Dim xForm As New ExitForm
        If xForm.showDialog = DialogResult.Yes Then
            Me.Close()
        Else
            'xForm.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
    End Sub

    Private Sub TitleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Links.Add(0, 12, "www.github.com/urlsalimbot/WordGuessingGame")
    End Sub

    'DONE
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(New ProcessStartInfo(e.Link.LinkData.ToString()) With {.UseShellExecute = True})
    End Sub

End Class

