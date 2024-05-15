Imports System.Diagnostics.Eventing.Reader
Imports Newtonsoft.Json.Linq

Public Class GameForm1
    Public Property buttons As New List(Of Button)
    Public Property textboxes As New List(Of TextBox)
    Public Property redpic As New Dictionary(Of String, Object)
    Public Property greenpic As New Dictionary(Of String, Object)
    Public Property yellpic As New Dictionary(Of String, Object)
    Public Property normpic As New Dictionary(Of String, Object)
    Public partofspeech As JArray
    Public definition As JArray
    Public hintcount As Int16 = 1
    Public defcount As Int16 = 1

    Dim gInstance As GameInstance = New GameInstance

    Private Sub GameForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = TitleForm.user
        Me.Focus()
        InitGameForm()
        gInstance.GameInstance(Me, TitleForm.difficulty)
    End Sub

    'Return to mainform
    Private Sub GameForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not ExitProg()
        If Not e.Cancel Then
            gInstance = Nothing
            TitleForm.Show()
        End If
    End Sub

    Private Sub InitGameForm()
        redpic.Add("A", My.Resources.RED01)
        redpic.Add("B", My.Resources.RED02)
        redpic.Add("C", My.Resources.RED03)
        redpic.Add("D", My.Resources.RED04)
        redpic.Add("E", My.Resources.RED05)
        redpic.Add("F", My.Resources.RED06)
        redpic.Add("G", My.Resources.RED07)
        redpic.Add("H", My.Resources.RED08)
        redpic.Add("I", My.Resources.RED09)
        redpic.Add("J", My.Resources.RED10)
        redpic.Add("K", My.Resources.RED11)
        redpic.Add("L", My.Resources.RED12)
        redpic.Add("M", My.Resources.RED13)
        redpic.Add("N", My.Resources.RED14)
        redpic.Add("O", My.Resources.RED15)
        redpic.Add("P", My.Resources.RED16)
        redpic.Add("Q", My.Resources.RED17)
        redpic.Add("R", My.Resources.RED18)
        redpic.Add("S", My.Resources.RED19)
        redpic.Add("T", My.Resources.RED20)
        redpic.Add("U", My.Resources.RED21)
        redpic.Add("V", My.Resources.RED22)
        redpic.Add("W", My.Resources.RED23)
        redpic.Add("X", My.Resources.RED24)
        redpic.Add("Y", My.Resources.RED25)
        redpic.Add("Z", My.Resources.RED26)
        greenpic.Add("A", My.Resources.GREEN01)
        greenpic.Add("B", My.Resources.GREEN02)
        greenpic.Add("C", My.Resources.GREEN03)
        greenpic.Add("D", My.Resources.GREEN04)
        greenpic.Add("E", My.Resources.GREEN05)
        greenpic.Add("F", My.Resources.GREEN06)
        greenpic.Add("G", My.Resources.GREEN07)
        greenpic.Add("H", My.Resources.GREEN08)
        greenpic.Add("I", My.Resources.GREEN09)
        greenpic.Add("J", My.Resources.GREEN10)
        greenpic.Add("K", My.Resources.GREEN11)
        greenpic.Add("L", My.Resources.GREEN12)
        greenpic.Add("M", My.Resources.GREEN13)
        greenpic.Add("N", My.Resources.GREEN14)
        greenpic.Add("O", My.Resources.GREEN15)
        greenpic.Add("P", My.Resources.GREEN16)
        greenpic.Add("Q", My.Resources.GREEN17)
        greenpic.Add("R", My.Resources.GREEN18)
        greenpic.Add("S", My.Resources.GREEN19)
        greenpic.Add("T", My.Resources.GREEN20)
        greenpic.Add("U", My.Resources.GREEN21)
        greenpic.Add("V", My.Resources.GREEN22)
        greenpic.Add("W", My.Resources.GREEN23)
        greenpic.Add("X", My.Resources.GREEN24)
        greenpic.Add("Y", My.Resources.GREEN25)
        greenpic.Add("Z", My.Resources.GREEN26)
        yellpic.Add("A", My.Resources.YELLOW01)
        yellpic.Add("B", My.Resources.YELLOW02)
        yellpic.Add("C", My.Resources.YELLOW03)
        yellpic.Add("D", My.Resources.YELLOW04)
        yellpic.Add("E", My.Resources.YELLOW05)
        yellpic.Add("F", My.Resources.YELLOW06)
        yellpic.Add("G", My.Resources.YELLOW07)
        yellpic.Add("H", My.Resources.YELLOW08)
        yellpic.Add("I", My.Resources.YELLOW09)
        yellpic.Add("J", My.Resources.YELLOW10)
        yellpic.Add("K", My.Resources.YELLOW11)
        yellpic.Add("L", My.Resources.YELLOW12)
        yellpic.Add("M", My.Resources.YELLOW13)
        yellpic.Add("N", My.Resources.YELLOW14)
        yellpic.Add("O", My.Resources.YELLOW15)
        yellpic.Add("P", My.Resources.YELLOW16)
        yellpic.Add("Q", My.Resources.YELLOW17)
        yellpic.Add("R", My.Resources.YELLOW18)
        yellpic.Add("S", My.Resources.YELLOW19)
        yellpic.Add("T", My.Resources.YELLOW20)
        yellpic.Add("U", My.Resources.YELLOW21)
        yellpic.Add("V", My.Resources.YELLOW22)
        yellpic.Add("W", My.Resources.YELLOW23)
        yellpic.Add("X", My.Resources.YELLOW24)
        yellpic.Add("Y", My.Resources.YELLOW25)
        yellpic.Add("Z", My.Resources.YELLOW26)
        normpic.Add("A", My.Resources.NORM01)
        normpic.Add("B", My.Resources.NORM02)
        normpic.Add("C", My.Resources.NORM03)
        normpic.Add("D", My.Resources.NORM04)
        normpic.Add("E", My.Resources.NORM05)
        normpic.Add("F", My.Resources.NORM06)
        normpic.Add("G", My.Resources.NORM07)
        normpic.Add("H", My.Resources.NORM08)
        normpic.Add("I", My.Resources.NORM09)
        normpic.Add("J", My.Resources.NORM10)
        normpic.Add("K", My.Resources.NORM11)
        normpic.Add("L", My.Resources.NORM12)
        normpic.Add("M", My.Resources.NORM13)
        normpic.Add("N", My.Resources.NORM14)
        normpic.Add("O", My.Resources.NORM15)
        normpic.Add("P", My.Resources.NORM16)
        normpic.Add("Q", My.Resources.NORM17)
        normpic.Add("R", My.Resources.NORM18)
        normpic.Add("S", My.Resources.NORM19)
        normpic.Add("T", My.Resources.NORM20)
        normpic.Add("U", My.Resources.NORM21)
        normpic.Add("V", My.Resources.NORM22)
        normpic.Add("W", My.Resources.NORM23)
        normpic.Add("X", My.Resources.NORM24)
        normpic.Add("Y", My.Resources.NORM25)
        normpic.Add("Z", My.Resources.NORM26)
        buttons.Add(ABtn)
        buttons.Add(BBtn)
        buttons.Add(CBtn)
        buttons.Add(DBtn)
        buttons.Add(EBtn)
        buttons.Add(FBtn)
        buttons.Add(GBtn)
        buttons.Add(HBtn)
        buttons.Add(IBtn)
        buttons.Add(JBtn)
        buttons.Add(KBtn)
        buttons.Add(LBtn)
        buttons.Add(MBtn)
        buttons.Add(NBtn)
        buttons.Add(OBtn)
        buttons.Add(PBtn)
        buttons.Add(QBtn)
        buttons.Add(RBtn)
        buttons.Add(SBtn)
        buttons.Add(TBtn)
        buttons.Add(UBtn)
        buttons.Add(VBtn)
        buttons.Add(WBtn)
        buttons.Add(XBtn)
        buttons.Add(YBtn)
        textboxes.Add(TextBox1)
        textboxes.Add(TextBox2)
        textboxes.Add(TextBox3)
        textboxes.Add(TextBox4)
        textboxes.Add(TextBox5)
        textboxes.Add(TextBox6)
        textboxes.Add(TextBox7)
        textboxes.Add(TextBox8)
        textboxes.Add(TextBox9)
        textboxes.Add(TextBox10)
        textboxes.Add(TextBox11)
        textboxes.Add(TextBox12)
        textboxes.Add(TextBox13)
        textboxes.Add(TextBox14)
        textboxes.Add(TextBox15)
        textboxes.Add(TextBox16)
        textboxes.Add(TextBox17)
        textboxes.Add(TextBox18)
        textboxes.Add(TextBox19)
        textboxes.Add(TextBox20)
        textboxes.Add(TextBox21)
        textboxes.Add(TextBox22)
        textboxes.Add(TextBox23)
        textboxes.Add(TextBox24)
        textboxes.Add(TextBox25)
    End Sub

    'FOCUS TEXTBox
    Private Sub MainInptBox_Leave(sender As Object, e As EventArgs) Handles MainInptBox.Leave
        MainInptBox.Focus()
        MainInptBox.Select(MainInptBox.Text.Length, 0)
    End Sub

    'BACKSPACE
    Private Sub Button27_Click(sender As Object, e As EventArgs)
        If MainInptBox.Text <> "" Then
            MainInptBox.Text = MainInptBox.Text.Remove(MainInptBox.Text.Length - 1)
        End If
        MainInptBox_Leave(sender, e)
    End Sub

    'START OF ONSCREEN KEYBOARD'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles QBtn.Click
        MainInptBox.Text += "q"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles WBtn.Click
        MainInptBox.Text += "w"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles EBtn.Click
        MainInptBox.Text += "e"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles RBtn.Click
        MainInptBox.Text += "r"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles TBtn.Click
        MainInptBox.Text += "t"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles YBtn.Click
        MainInptBox.Text += "y"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles UBtn.Click
        MainInptBox.Text += "u"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles IBtn.Click
        MainInptBox.Text += "i"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles OBtn.Click
        MainInptBox.Text += "o"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles PBtn.Click
        MainInptBox.Text += "p"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles ABtn.Click
        MainInptBox.Text += "a"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles SBtn.Click
        MainInptBox.Text += "s"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles DBtn.Click
        MainInptBox.Text += "d"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles FBtn.Click
        MainInptBox.Text += "f"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles GBtn.Click
        MainInptBox.Text += "g"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles HBtn.Click
        MainInptBox.Text += "h"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles JBtn.Click
        MainInptBox.Text += "j"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles KBtn.Click
        MainInptBox.Text += "k"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles LBtn.Click
        MainInptBox.Text += "l"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles ZBtn.Click
        MainInptBox.Text += "z"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles XBtn.Click
        MainInptBox.Text += "x"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles CBtn.Click
        MainInptBox.Text += "c"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles VBtn.Click
        MainInptBox.Text += "v"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles BBtn.Click
        MainInptBox.Text += "b"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles NBtn.Click
        MainInptBox.Text += "n"
        MainInptBox_Leave(sender, e)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles MBtn.Click
        MainInptBox.Text += "m"
        MainInptBox_Leave(sender, e)
    End Sub
    'END OF ONSCREEN KEYBOARD

    Private Sub MainInptBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MainInptBox.KeyDown
        If gInstance.guessword <> Nothing Then
            If e.KeyCode = Keys.Enter And MainInptBox.Text.Length = gInstance.guessword.Length Then
                gInstance.Checker(MainInptBox.Text)
                gInstance.AttemptCounter(MainInptBox.Text)
                kbShowCorr(buttons, gInstance.guessword, MainInptBox.Text)
                MainInptBox.Text = ""
                hintcount = 1
                defcount = 1
            End If
        End If
    End Sub

    Private Sub Hint_Click(sender As Object, e As EventArgs) Handles Hint.Click
        'MessageBox.Show(partofspeech.Count)
        'MessageBox.Show(partofspeech(0)("definitions").Count)
        Dim hintdepth As Int16 = partofspeech.Count
        Dim defdepth As Int16 = partofspeech(hintcount - 1)("definitions").Count

        Partbox.Text = partofspeech(hintcount - 1)("partOfSpeech")

        definitionBox.Text = partofspeech(hintcount - 1)("definitions")(defcount - 1)("definition")



        If (defcount Mod defdepth = 0) Then
            hintcount = (hintcount + 1) Mod hintdepth
            If hintcount = 0 Then
                hintcount = 1
            End If
            defcount = 1
        End If

        If (defcount Mod defdepth <> 0) Then
            defcount += 1
        End If

    End Sub

    'Display Ans in individual textboxes
    Private Sub MainInptBox_TextChanged(sender As Object, e As EventArgs) Handles MainInptBox.TextChanged
        If gInstance.guessword <> Nothing Then
            dispText(textboxes, MainInptBox.Text, gInstance.myattempt, gInstance.guessword.Length)
        End If
    End Sub

    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles EnterBtn.Click
        MainInptBox_KeyDown(sender, New KeyEventArgs(Keys.Enter))
    End Sub

    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click
        gInstance.MainGameLoop()
        Panel1.Visible = True
        KeyboardPanel.Visible = True
        MainInptBox.Focus()
        ContinueBtn.Visible = False
    End Sub

    Private Sub BackSpcButton_Click(sender As Object, e As EventArgs) Handles BackSpcButton.Click
        If MainInptBox.Text <> "" Then
            MainInptBox.Text = MainInptBox.Text.Substring(0, MainInptBox.Text.Length - 1)
            MainInptBox_Leave(sender, e)
        End If
    End Sub
End Class
