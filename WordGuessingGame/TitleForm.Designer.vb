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
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button5 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        TextBox2 = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.CornflowerBlue
        Button1.Location = New Point(25, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 39)
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
        LinkLabel1.Location = New Point(10, 360)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(116, 30)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Repository"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Navy
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.CornflowerBlue
        Button3.Location = New Point(42, 96)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 32)
        Button3.TabIndex = 9
        Button3.Text = "Exit Game"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.CornflowerBlue
        Button2.Location = New Point(42, 58)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 32)
        Button2.TabIndex = 8
        Button2.Text = "Options"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Navy
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.CornflowerBlue
        TextBox1.Location = New Point(37, 16)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter Username"
        TextBox1.Size = New Size(170, 25)
        TextBox1.TabIndex = 11
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.MidnightBlue
        Button4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.CornflowerBlue
        Button4.Location = New Point(48, 54)
        Button4.Name = "Button4"
        Button4.Size = New Size(148, 49)
        Button4.TabIndex = 7
        Button4.Text = "Confirm"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.MidnightBlue
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.CornflowerBlue
        Button5.Location = New Point(48, 109)
        Button5.Name = "Button5"
        Button5.Size = New Size(148, 30)
        Button5.TabIndex = 12
        Button5.Text = "Cancel"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button4)
        Panel1.Enabled = False
        Panel1.Location = New Point(298, 244)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(242, 159)
        Panel1.TabIndex = 12
        Panel1.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button3)
        Panel2.Location = New Point(320, 236)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 182)
        Panel2.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(10, 144)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(259, 159)
        TextBox2.TabIndex = 14
        ' 
        ' TitleForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(899, 494)
        Controls.Add(TextBox2)
        Controls.Add(LinkLabel1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "TitleForm"
        RightToLeft = RightToLeft.No
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox

End Class
