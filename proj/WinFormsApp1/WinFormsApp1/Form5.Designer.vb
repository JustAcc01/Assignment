<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        basement = New PictureBox()
        Label1 = New Label()
        CType(basement, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' basement
        ' 
        basement.Image = CType(resources.GetObject("basement.Image"), Image)
        basement.Location = New Point(172, 12)
        basement.Name = "basement"
        basement.Size = New Size(441, 274)
        basement.TabIndex = 20
        basement.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.223999F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(347, 311)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 66)
        Label1.TabIndex = 21
        Label1.Text = "???"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(basement)
        ForeColor = SystemColors.ControlLightLight
        Name = "Form5"
        Text = "Escape"
        CType(basement, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents basement As PictureBox
    Friend WithEvents Label1 As Label
End Class
