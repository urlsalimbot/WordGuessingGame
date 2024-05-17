<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leaderboard))
        Label1 = New Label()
        LBGridView = New DataGridView()
        username = New DataGridViewTextBoxColumn()
        Score = New DataGridViewTextBoxColumn()
        GamesPlayed = New DataGridViewTextBoxColumn()
        DatePlayed = New DataGridViewTextBoxColumn()
        CType(LBGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Upheaval TT (BRK)", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Azure
        Label1.Location = New Point(133, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 29)
        Label1.TabIndex = 0
        Label1.Text = "LEADERBOARD"
        ' 
        ' LBGridView
        ' 
        LBGridView.AllowUserToAddRows = False
        LBGridView.AllowUserToDeleteRows = False
        LBGridView.AllowUserToResizeColumns = False
        LBGridView.AllowUserToResizeRows = False
        LBGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        LBGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        LBGridView.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Transparent
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        LBGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        LBGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LBGridView.Columns.AddRange(New DataGridViewColumn() {username, Score, GamesPlayed, DatePlayed})
        LBGridView.EditMode = DataGridViewEditMode.EditOnF2
        LBGridView.Location = New Point(26, 41)
        LBGridView.Name = "LBGridView"
        LBGridView.ReadOnly = True
        LBGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.BackColor = Color.Transparent
        LBGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        LBGridView.RowTemplate.Height = 25
        LBGridView.Size = New Size(442, 509)
        LBGridView.TabIndex = 1
        ' 
        ' username
        ' 
        username.HeaderText = "Name"
        username.Name = "username"
        username.ReadOnly = True
        username.Width = 64
        ' 
        ' Score
        ' 
        Score.HeaderText = "Score"
        Score.Name = "Score"
        Score.ReadOnly = True
        Score.Width = 61
        ' 
        ' GamesPlayed
        ' 
        GamesPlayed.HeaderText = "No. of Games"
        GamesPlayed.Name = "GamesPlayed"
        GamesPlayed.ReadOnly = True
        GamesPlayed.Width = 104
        ' 
        ' DatePlayed
        ' 
        DatePlayed.HeaderText = "Date"
        DatePlayed.Name = "DatePlayed"
        DatePlayed.ReadOnly = True
        DatePlayed.Width = 56
        ' 
        ' Leaderboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(503, 579)
        Controls.Add(LBGridView)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Leaderboard"
        StartPosition = FormStartPosition.CenterScreen
        CType(LBGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBGridView As DataGridView
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents Score As DataGridViewTextBoxColumn
    Friend WithEvents GamesPlayed As DataGridViewTextBoxColumn
    Friend WithEvents DatePlayed As DataGridViewTextBoxColumn
End Class
