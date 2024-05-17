Imports System.DirectoryServices

Public Class TitleForm

    Public user As String
    Public difficulty As Integer = 4
    'PROCEED TO GAME
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToggleVis(Panel1)
        ToggleVis(Panel2)
    End Sub

    'SEND TO GAMEFORM
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Username cannot be empty.")
        Else
            Dim gForm As New GameForm1()
            user = TextBox1.Text
            TextBox1.Text = ""
            gForm.Show()
            Button1_Click(sender, e)
            Me.Hide()
        End If
    End Sub

    'LINK TO GITHUB REPO
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(New ProcessStartInfo("www.github.com/urlsalimbot/WordGuessingGame") With {.UseShellExecute = True})
    End Sub

    'RETURN TO MAIN MENU
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button1_Click(sender, e)
    End Sub

    'EXIT FUNCTION
    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs)
        Close
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not ExitProg()
    End Sub

    Private Sub Easyrd_CheckedChanged(sender As Object, e As EventArgs) Handles Easyrd.CheckedChanged
        difficulty = 4
    End Sub

    Private Sub Medrd_CheckedChanged(sender As Object, e As EventArgs) Handles Medrd.CheckedChanged
        difficulty = 6
    End Sub

    Private Sub Hardrd_CheckedChanged(sender As Object, e As EventArgs) Handles Hardrd.CheckedChanged
        difficulty = 8
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ToggleVis(Panel3)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class

