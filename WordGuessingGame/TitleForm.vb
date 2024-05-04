﻿Imports System.DirectoryServices

Public Class TitleForm

    'PROCEED TO GAME
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToggleVis(Panel1)
        ToggleVis(Panel2)
    End Sub

    'LINK TO GITHUB REPO
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(New ProcessStartInfo("www.github.com/urlsalimbot/WordGuessingGame") With {.UseShellExecute = True})
    End Sub

    'RETURN TO MAIN MENU
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ToggleVis(Panel1)
        ToggleVis(Panel2)
    End Sub

    'EXIT FUNCTION
    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs)
        Close()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not ExitProg()
    End Sub
End Class

