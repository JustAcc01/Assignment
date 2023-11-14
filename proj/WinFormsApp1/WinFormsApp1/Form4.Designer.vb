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
        lblcarescape = New Label()
        road = New PictureBox()
        CType(road, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblcarescape
        ' 
        lblcarescape.AutoSize = True
        lblcarescape.Font = New Font("Segoe UI", 28.223999F, FontStyle.Bold, GraphicsUnit.Point)
        lblcarescape.Location = New Point(226, 315)
        lblcarescape.Name = "lblcarescape"
        lblcarescape.Size = New Size(336, 66)
        lblcarescape.TabIndex = 0
        lblcarescape.Text = "Car Escape :>"
        ' 
        ' road
        ' 
        road.Image = CType(resources.GetObject("road.Image"), Image)
        road.Location = New Point(157, 12)
        road.Name = "road"
        road.Size = New Size(441, 274)
        road.TabIndex = 20
        road.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(road)
        Controls.Add(lblcarescape)
        ForeColor = SystemColors.ControlLightLight
        Name = "Form4"
        Text = "Car Escape"
        CType(road, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblcarescape As Label
    Friend WithEvents road As PictureBox
End Class
