Public Class Leaderboard
    Public WithEvents tForm As TitleForm

    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim leaderboard As List(Of Player)
        leaderboard = LoadLB()
        If leaderboard IsNot Nothing Then
            For Each elem In leaderboard
                LBGridView.Rows.Add(elem._name, elem._score, elem._gamesplayed, elem._dateplayed)
            Next

        Else
            Me.Close()
            MessageBox.Show("No History yet.")
        End If
    End Sub

    Public Sub New(_titleform As TitleForm)
        ' This call is required by the designer.
        InitializeComponent()
        tForm = _titleform
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LBGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LBGridView.CellContentClick
        LBGridView.ClearSelection()
    End Sub

End Class