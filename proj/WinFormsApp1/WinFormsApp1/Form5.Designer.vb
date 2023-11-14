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
        Outside = New PictureBox()
        lblquestionmark = New Label()
        CType(Outside, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Outside
        ' 
        Outside.Image = CType(resources.GetObject("Outside.Image"), Image)
        Outside.Location = New Point(172, 12)
        Outside.Name = "Outside"
        Outside.Size = New Size(441, 274)
        Outside.TabIndex = 20
        Outside.TabStop = False
        ' 
        ' lblquestionmark
        ' 
        lblquestionmark.AutoSize = True
        lblquestionmark.Font = New Font("Segoe UI", 28.223999F, FontStyle.Bold, GraphicsUnit.Point)
        lblquestionmark.Location = New Point(347, 311)
        lblquestionmark.Name = "lblquestionmark"
        lblquestionmark.Size = New Size(91, 66)
        lblquestionmark.TabIndex = 21
        lblquestionmark.Text = "???"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(lblquestionmark)
        Controls.Add(Outside)
        ForeColor = SystemColors.ControlLightLight
        Name = "Form5"
        Text = "Escape"
        CType(Outside, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Outside As PictureBox
    Friend WithEvents lblquestionmark As Label
End Class
