<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TitleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        Button3 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        Button5 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(6, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 39)
        Button1.TabIndex = 7
        Button1.Text = "Start Game"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel1.Location = New Point(45, 296)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(85, 21)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Repository"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(22, 105)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 32)
        Button3.TabIndex = 9
        Button3.Text = "Exit Game"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 56F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(21, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(758, 100)
        Label1.TabIndex = 5
        Label1.Text = "Word Guessing Game"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(22, 67)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 32)
        Button2.TabIndex = 8
        Button2.Text = "Options"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Location = New Point(9, 8)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(163, 144)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(6, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(170, 32)
        TextBox1.TabIndex = 11
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox1)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Enabled = False
        GroupBox2.Location = New Point(313, 183)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(182, 156)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Visible = False
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(17, 115)
        Button5.Name = "Button5"
        Button5.Size = New Size(148, 30)
        Button5.TabIndex = 12
        Button5.Text = "Cancel"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(17, 60)
        Button4.Name = "Button4"
        Button4.Size = New Size(148, 49)
        Button4.TabIndex = 7
        Button4.Text = "Enter Username"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TitleForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 402)
        Controls.Add(LinkLabel1)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "TitleForm"
        RightToLeft = RightToLeft.No
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

End Class
