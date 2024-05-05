Public Class GameForm1
    Public Property buttons As New List(Of Button)

    Private Sub GameForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = TitleForm.user
        Me.Focus()
        MainInptBox.Focus()
        'MessageBox.Show(Button1.Name)
        Init()
    End Sub

    'Return to mainform
    Private Sub GameForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not ExitProg()
        If Not e.Cancel Then
            TitleForm.Show()
        End If
    End Sub

    Private Sub Init()
        buttons.Add(QBtn)
        buttons.Add(WBtn)
        buttons.Add(EBtn)
        buttons.Add(RBtn)
        buttons.Add(TBtn)
        buttons.Add(YBtn)
        buttons.Add(UBtn)
        buttons.Add(IBtn)
        buttons.Add(OBtn)
        buttons.Add(PBtn)
        buttons.Add(ABtn)
        buttons.Add(SBtn)
        buttons.Add(DBtn)
        buttons.Add(FBtn)
        buttons.Add(GBtn)
        buttons.Add(HBtn)
        buttons.Add(JBtn)
        buttons.Add(KBtn)
        buttons.Add(LBtn)
        buttons.Add(ZBtn)
        buttons.Add(XBtn)
        buttons.Add(CBtn)
        buttons.Add(VBtn)
        buttons.Add(BBtn)
        buttons.Add(NBtn)
        buttons.Add(MBtn)
    End Sub

    'FOCUS TEXTBox
    Private Sub MainInptBox_Leave(sender As Object, e As EventArgs) Handles MainInptBox.Leave
        MainInptBox.Focus()
        MainInptBox.Select(MainInptBox.Text.Length, 0)
    End Sub

    'BACKSPACE
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
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

    Private Sub MainInptBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MainInptBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Checker(buttons)
        End If
    End Sub

    'END OF ONSCREEN KEYBOARD


End Class
