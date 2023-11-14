Imports System.Formats

Public Class Form3
    Public Shared items As String

    Public Property Pass1 As String
    Public Property Pass2 As String
    Public Property Pass3 As String
    Public Property Pass4 As String
    Public Property Pass5 As String
    Public Property Pass6 As String
    Public Property Pass7 As String
    Public Property Pass10 As String
    Public Property Pass8 As String
    Public Property Pass9 As String


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl1f3.Text = Pass1
        lbl2f3.Text = Pass2
        lbl3f3.Text = Pass3
        lbl4f3.Text = Pass4
        lbl5f3.Text = Pass5
        lbl6f3.Text = Pass6
        lbl7f3.Text = Pass7
        lbl8f3.Text = Pass8
        lbl9f3.Text = Pass9



    End Sub

    Private Sub cbgoback_Click(sender As Object, e As EventArgs) Handles cbgoback.Click

        Form3.items = lbl1f3.Text

        Dim f2 As New Form2
        f2.Show()
        Me.Hide()
    End Sub
End Class