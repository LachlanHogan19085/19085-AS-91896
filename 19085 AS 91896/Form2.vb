Imports System.Security.AccessControl

Public Class Form2
    Private Sub Btnrestart_Click(sender As Object, e As EventArgs)
        Application.Restart() 'closes and reopens application
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BtnCompleteNew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCompleteQuit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)
        LblName.Text = LblName.Text & Form1.Customerdetails(0)
        LblPh.Text = LblPh.Text & Form1.Customerdetails(1)
    End Sub
End Class