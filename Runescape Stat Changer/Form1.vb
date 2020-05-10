Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Public Class Form1
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MsgBox("Error", MsgBoxStyle.OkOnly, Nothing)
            End
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
End Class
