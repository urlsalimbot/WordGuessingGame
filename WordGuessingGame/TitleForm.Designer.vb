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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TitleForm))
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        Button3 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button5 = New Button()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.CornflowerBlue
        Button1.Location = New Point(11, 29)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 52)
        Button1.TabIndex = 7
        Button1.Text = "Start Game"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.ForeColor = SystemColors.Control
        LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel1.Location = New Point(12, 480)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(148, 38)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Repository"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Navy
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.CornflowerBlue
        Button3.Location = New Point(31, 136)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(133, 43)
        Button3.TabIndex = 9
        Button3.Text = "Exit Game"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.CornflowerBlue
        Button2.Location = New Point(31, 86)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(133, 43)
        Button2.TabIndex = 8
        Button2.Text = "Options"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Location = New Point(642, 295)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(186, 192)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Navy
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.CornflowerBlue
        TextBox1.Location = New Point(7, 29)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(194, 32)
        TextBox1.TabIndex = 11
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.MidnightBlue
        Button4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.CornflowerBlue
        Button4.Location = New Point(19, 80)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(169, 65)
        Button4.TabIndex = 7
        Button4.Text = "Enter Username"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.MidnightBlue
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.CornflowerBlue
        Button5.Location = New Point(19, 153)
        Button5.Margin = New Padding(3, 4, 3, 4)
        Button5.Name = "Button5"
        Button5.Size = New Size(169, 40)
        Button5.TabIndex = 12
        Button5.Text = "Cancel"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.BackgroundImageLayout = ImageLayout.None
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Enabled = False
        GroupBox2.ForeColor = Color.Coral
        GroupBox2.Location = New Point(365, 247)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(208, 208)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Visible = False
        ' 
        ' TitleForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(993, 536)
        Controls.Add(LinkLabel1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox2 As GroupBox

End Class
