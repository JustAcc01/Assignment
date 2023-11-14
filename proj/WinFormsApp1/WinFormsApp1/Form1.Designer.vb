<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        cbstartf1 = New Button()
        cbexitf1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbstartf1
        ' 
        cbstartf1.BackColor = Color.Black
        cbstartf1.Font = New Font("Segoe UI", 17.855999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cbstartf1.ForeColor = SystemColors.ControlLightLight
        cbstartf1.Location = New Point(296, 178)
        cbstartf1.Name = "cbstartf1"
        cbstartf1.Size = New Size(166, 63)
        cbstartf1.TabIndex = 0
        cbstartf1.Text = "Start"
        cbstartf1.UseVisualStyleBackColor = False
        ' 
        ' cbexitf1
        ' 
        cbexitf1.BackColor = Color.Black
        cbexitf1.Font = New Font("Segoe UI", 13.8239994F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cbexitf1.ForeColor = SystemColors.ControlLightLight
        cbexitf1.Location = New Point(322, 262)
        cbexitf1.Name = "cbexitf1"
        cbexitf1.Size = New Size(115, 45)
        cbexitf1.TabIndex = 1
        cbexitf1.Text = "Exit"
        cbexitf1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 24.192F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(226, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 52)
        Label1.TabIndex = 2
        Label1.Text = "The Escape!!!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(77, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(112, 259)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Black
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(583, 74)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(130, 259)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(796, 448)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(cbexitf1)
        Controls.Add(cbstartf1)
        Name = "Form1"
        Text = "The Escape (Main menu)"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbstartf1 As Button
    Friend WithEvents cbexitf1 As Button
End Class
