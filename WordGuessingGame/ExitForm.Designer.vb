<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExitForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExitForm))
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Navy
        Button1.Location = New Point(84, 95)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(59, 54)
        Button1.TabIndex = 0
        Button1.Text = "Yes"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Navy
        Button2.Location = New Point(175, 95)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(59, 54)
        Button2.TabIndex = 1
        Button2.Text = "No"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ExitForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(331, 211)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ExitForm"
        Text = "Exit?"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
