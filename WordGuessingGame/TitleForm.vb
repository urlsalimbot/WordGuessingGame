Imports System.DirectoryServices

Public Class TitleForm

    Public user As String
    'PROCEED TO GAME
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToggleVis(Panel1)
        ToggleVis(Panel2)
    End Sub

    'SEND TO GAMEFORM
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim gForm As New GameForm1()
        user = TextBox1.Text
        gForm.Show()
        Me.Hide()
    End Sub

    'LINK TO GITHUB REPO
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(New ProcessStartInfo("www.github.com/urlsalimbot/WordGuessingGame") With {.UseShellExecute = True})
    End Sub

    'RETURN TO MAIN MENU
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ToggleVis(Panel2)
        ToggleVis(Panel1)
    End Sub

    'EXIT FUNCTION
    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs)
        Close()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not ExitProg()
    End Sub

End Class

