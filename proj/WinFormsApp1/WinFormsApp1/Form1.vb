﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, cbstartf1.Click
        Dim f2 As New Form2
        f2.Show()
        Me.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, cbexitf1.Click
        Me.Close()
    End Sub
End Class
