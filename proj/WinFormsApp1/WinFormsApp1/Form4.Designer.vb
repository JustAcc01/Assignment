<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        basement = New PictureBox()
        CType(basement, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.223999F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(226, 315)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 66)
        Label1.TabIndex = 0
        Label1.Text = "Car Escape :>"
        ' 
        ' basement
        ' 
        basement.Image = CType(resources.GetObject("basement.Image"), Image)
        basement.Location = New Point(157, 12)
        basement.Name = "basement"
        basement.Size = New Size(441, 274)
        basement.TabIndex = 20
        basement.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(basement)
        Controls.Add(Label1)
        ForeColor = SystemColors.ControlLightLight
        Name = "Form4"
        Text = "Car Escape"
        CType(basement, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents basement As PictureBox
End Class
