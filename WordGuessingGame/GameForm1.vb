Imports System.Diagnostics.Eventing.Reader
Imports Newtonsoft.Json.Linq

Public Class GameForm1

    'USERNAME
    Public Property username As String

    'GRAPHICS
    Public Property Buttons As New List(Of Button)
    Public Property textboxes As New List(Of TextBox)
    Public Property redpic As New Dictionary(Of Integer, Object)
    Public Property greenpic As New Dictionary(Of Integer, Object)
    Public Property yellowpic As New Dictionary(Of Integer, Object)
    Public Property normpic As New Dictionary(Of Integer, Object)

    'CONTROL
    Private gword As String
    Public partofspeech As JArray
    Public definition As JArray
    Public hintcount As Integer = 1
    Public defcount As Integer = 1



    Public WithEvents gInstance As GameInstance

    Private Sub GameForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username = TitleForm.user
        Me.Focus()
        InitGameForm()
        gInstance = New GameInstance(Me, TitleForm.difficulty)
    End Sub

    'Return to mainform
    Private Sub GameForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not ExitProg()
        If Not e.Cancel Then
            gInstance.ExitGame()
            gInstance = Nothing
            TitleForm.Show()
        End If
    End Sub


	'Event catcher for pickedword
    Public Sub PickedWordSet(ByVal e As String) Handles gInstance.WordPicked
        gword = e
        MainInptBox.Text = ""
        MainInptBox.MaxLength = gword.Length
    End Sub

    Private Sub InitGameForm()
        redpic.Add(65, My.Resources.RED01)
        redpic.Add(66, My.Resources.RED02)
        redpic.Add(67, My.Resources.RED03)
        redpic.Add(68, My.Resources.RED04)
        redpic.Add(69, My.Resources.RED05)
        redpic.Add(70, My.Resources.RED06)
        redpic.Add(71, My.Resources.RED07)
        redpic.Add(72, My.Resources.RED08)
        redpic.Add(73, My.Resources.RED09)
        redpic.Add(74, My.Resources.RED10)
        redpic.Add(75, My.Resources.RED11)
        redpic.Add(76, My.Resources.RED12)
        redpic.Add(77, My.Resources.RED13)
        redpic.Add(78, My.Resources.RED14)
        redpic.Add(79, My.Resources.RED15)
        redpic.Add(80, My.Resources.RED16)
        redpic.Add(81, My.Resources.RED17)
        redpic.Add(82, My.Resources.RED18)
        redpic.Add(83, My.Resources.RED19)
        redpic.Add(84, My.Resources.RED20)
        redpic.Add(85, My.Resources.RED21)
        redpic.Add(86, My.Resources.RED22)
        redpic.Add(87, My.Resources.RED23)
        redpic.Add(88, My.Resources.RED24)
        redpic.Add(89, My.Resources.RED25)
        redpic.Add(90, My.Resources.RED26)
        greenpic.Add(65, My.Resources.GREEN01)
        greenpic.Add(66, My.Resources.GREEN02)
        greenpic.Add(67, My.Resources.GREEN03)
        greenpic.Add(68, My.Resources.GREEN04)
        greenpic.Add(69, My.Resources.GREEN05)
        greenpic.Add(70, My.Resources.GREEN06)
        greenpic.Add(71, My.Resources.GREEN07)
        greenpic.Add(72, My.Resources.GREEN08)
        greenpic.Add(73, My.Resources.GREEN09)
        greenpic.Add(74, My.Resources.GREEN10)
        greenpic.Add(75, My.Resources.GREEN11)
        greenpic.Add(76, My.Resources.GREEN12)
        greenpic.Add(77, My.Resources.GREEN13)
        greenpic.Add(78, My.Resources.GREEN14)
        greenpic.Add(79, My.Resources.GREEN15)
        greenpic.Add(80, My.Resources.GREEN16)
        greenpic.Add(81, My.Resources.GREEN17)
        greenpic.Add(82, My.Resources.GREEN18)
        greenpic.Add(83, My.Resources.GREEN19)
        greenpic.Add(84, My.Resources.GREEN20)
        greenpic.Add(85, My.Resources.GREEN21)
        greenpic.Add(86, My.Resources.GREEN22)
        greenpic.Add(87, My.Resources.GREEN23)
        greenpic.Add(88, My.Resources.GREEN24)
        greenpic.Add(89, My.Resources.GREEN25)
        greenpic.Add(90, My.Resources.GREEN26)
        normpic.Add(65, My.Resources.NORM01)
        normpic.Add(66, My.Resources.NORM02)
        normpic.Add(67, My.Resources.NORM03)
        normpic.Add(68, My.Resources.NORM04)
        normpic.Add(69, My.Resources.NORM05)
        normpic.Add(70, My.Resources.NORM06)
        normpic.Add(71, My.Resources.NORM07)
        normpic.Add(72, My.Resources.NORM08)
        normpic.Add(73, My.Resources.NORM09)
        normpic.Add(74, My.Resources.NORM10)
        normpic.Add(75, My.Resources.NORM11)
        normpic.Add(76, My.Resources.NORM12)
        normpic.Add(77, My.Resources.NORM13)
        normpic.Add(78, My.Resources.NORM14)
        normpic.Add(79, My.Resources.NORM15)
        normpic.Add(80, My.Resources.NORM16)
        normpic.Add(81, My.Resources.NORM17)
        normpic.Add(82, My.Resources.NORM18)
        normpic.Add(83, My.Resources.NORM19)
        normpic.Add(84, My.Resources.NORM20)
        normpic.Add(85, My.Resources.NORM21)
        normpic.Add(86, My.Resources.NORM22)
        normpic.Add(87, My.Resources.NORM23)
        normpic.Add(88, My.Resources.NORM24)
        normpic.Add(89, My.Resources.NORM25)
        normpic.Add(90, My.Resources.NORM26)
        yellowpic.Add(65, My.Resources.YELLOW01)
        yellowpic.Add(66, My.Resources.YELLOW02)
        yellowpic.Add(67, My.Resources.YELLOW03)
        yellowpic.Add(68, My.Resources.YELLOW04)
        yellowpic.Add(69, My.Resources.YELLOW05)
        yellowpic.Add(70, My.Resources.YELLOW06)
        yellowpic.Add(71, My.Resources.YELLOW07)
        yellowpic.Add(72, My.Resources.YELLOW08)
        yellowpic.Add(73, My.Resources.YELLOW09)
        yellowpic.Add(74, My.Resources.YELLOW10)
        yellowpic.Add(75, My.Resources.YELLOW11)
        yellowpic.Add(76, My.Resources.YELLOW12)
        yellowpic.Add(77, My.Resources.YELLOW13)
        yellowpic.Add(78, My.Resources.YELLOW14)
        yellowpic.Add(79, My.Resources.YELLOW15)
        yellowpic.Add(80, My.Resources.YELLOW16)
        yellowpic.Add(81, My.Resources.YELLOW17)
        yellowpic.Add(82, My.Resources.YELLOW18)
        yellowpic.Add(83, My.Resources.YELLOW19)
        yellowpic.Add(84, My.Resources.YELLOW20)
        yellowpic.Add(85, My.Resources.YELLOW21)
        yellowpic.Add(86, My.Resources.YELLOW22)
        yellowpic.Add(87, My.Resources.YELLOW23)
        yellowpic.Add(88, My.Resources.YELLOW24)
        yellowpic.Add(89, My.Resources.YELLOW25)
        yellowpic.Add(90, My.Resources.YELLOW26)
        Buttons.Add(ABtn)
        Buttons.Add(BBtn)
        Buttons.Add(CBtn)
        Buttons.Add(DBtn)
        Buttons.Add(EBtn)
        Buttons.Add(FBtn)
        Buttons.Add(GBtn)
        Buttons.Add(HBtn)
        Buttons.Add(IBtn)
        Buttons.Add(JBtn)
        Buttons.Add(KBtn)
        Buttons.Add(LBtn)
        Buttons.Add(MBtn)
        Buttons.Add(NBtn)
        Buttons.Add(OBtn)
        Buttons.Add(PBtn)
        Buttons.Add(QBtn)
        Buttons.Add(RBtn)
        Buttons.Add(SBtn)
        Buttons.Add(TBtn)
        Buttons.Add(UBtn)
        Buttons.Add(VBtn)
        Buttons.Add(WBtn)
        Buttons.Add(XBtn)
        Buttons.Add(YBtn)
        Buttons.Add(ZBtn)
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
        textboxes.Add(TextBox26)
        textboxes.Add(TextBox27)
        textboxes.Add(TextBox28)
        textboxes.Add(TextBox29)
        textboxes.Add(TextBox30)
        textboxes.Add(TextBox31)
        textboxes.Add(TextBox32)
        textboxes.Add(TextBox33)
        textboxes.Add(TextBox34)
        textboxes.Add(TextBox35)
        textboxes.Add(TextBox36)
        textboxes.Add(TextBox37)
        textboxes.Add(TextBox38)
        textboxes.Add(TextBox39)
        textboxes.Add(TextBox40)
        textboxes.Add(TextBox41)
        textboxes.Add(TextBox42)
        textboxes.Add(TextBox43)
        textboxes.Add(TextBox44)
        textboxes.Add(TextBox45)
        textboxes.Add(TextBox46)
        textboxes.Add(TextBox47)
        textboxes.Add(TextBox48)
        textboxes.Add(TextBox49)
        textboxes.Add(TextBox50)
    End Sub

    'FOCUS TEXTBox
    Private Sub MainInptBox_Leave(sender As Object, e As EventArgs) Handles MainInptBox.Leave
        MainInptBox.Focus()
        If gword <> Nothing Then
            If MainInptBox.Text.Length > gword.Length Then
                MainInptBox.Text = MainInptBox.Text.Substring(0, gword.Length)
            End If
        End If
        MainInptBox.Select(MainInptBox.Text.Length, 0)
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

	'Entering user answer
    Private Sub MainInptBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MainInptBox.KeyDown
        If gword <> Nothing Then
            If e.KeyCode = Keys.Enter And MainInptBox.Text.Length = gword.Length Then
                kbShowWrong(Buttons, MainInptBox.Text.ToUpper, redpic)
                kbShowMiss(Buttons, gword.ToUpper, MainInptBox.Text.ToUpper, yellowpic)
                kbShowCorr(Buttons, gword.ToUpper, MainInptBox.Text.ToUpper, greenpic)
                gInstance.Checker(MainInptBox.Text)
                gInstance.AttemptCounter(MainInptBox.Text)

                MainInptBox.Text = ""
                hintcount = 1
                defcount = 1
            End If
        End If
    End Sub

    Private Sub Hint_Click(sender As Object, e As EventArgs) Handles Hint.Click
        'MessageBox.Show(partofspeech.Count)
        'MessageBox.Show(partofspeech(0)("definitions").Count)
        If partofspeech IsNot Nothing Then
            Dim hintdepth As Int16 = partofspeech.Count
            Dim defdepth As Int16 = partofspeech(hintcount - 1)("definitions").Count

            Partbox.Text = partofspeech(hintcount - 1)("partOfSpeech")
            definitionBox.Text = partofspeech(hintcount - 1)("definitions")(defcount - 1)("definition")

            If defcount = defdepth Then
                If hintcount = hintdepth Then
                    hintcount = 1
                ElseIf hintcount < hintdepth Then
                    hintcount += 1
                End If
                defcount = 1
            Else
                defcount += 1
            End If
        End If
    End Sub

    'Display Ans in individual textboxes
    Private Sub MainInptBox_TextChanged(sender As Object, e As EventArgs) Handles MainInptBox.TextChanged
        If gword <> Nothing Then
            dispText(textboxes, MainInptBox.Text, gInstance.myattempt, gword.Length)
        End If
    End Sub

	'binding onscreen enter key to maininputbox
    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles EnterBtn.Click
        MainInptBox_KeyDown(sender, New KeyEventArgs(Keys.Enter))
    End Sub

	'Buffer Screen Button
    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click
        gInstance.MainGameLoop()
        Panel1.Visible = True
        KeyboardPanel.Visible = True
        MainInptBox.Focus()
        ContinueBtn.Visible = False
    End Sub

	'onscreen backspace key
    Private Sub BackSpcButton_Click(sender As Object, e As EventArgs) Handles BackSpcButton.Click
        If MainInptBox.Text <> "" Then
            MainInptBox.Text = MainInptBox.Text.Substring(0, MainInptBox.Text.Length - 1)
            MainInptBox_Leave(sender, e)
        End If
    End Sub
End Class
