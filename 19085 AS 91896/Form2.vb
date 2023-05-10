Imports System.Security.AccessControl

Public Class Form2
    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
        Application.Restart() 'closes and reopens application
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        End
    End Sub

    Private Sub BtnCompleteNew_Click(sender As Object, e As EventArgs) Handles BtnCompleteNew.Click

    End Sub

    Private Sub BtnCompleteQuit_Click(sender As Object, e As EventArgs) Handles BtnCompleteQuit.Click
        End
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Form1.Show()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblName.Text = LblName.Text & Form1.Customerdetails(0)
        LblPh.Text = LblPh.Text & Form1.Customerdetails(1)
        If Form1.Delivery = True Then
            LblAddress.Text = LblAddress.Text & Form1.Address(1) & " " & Form1.Address(0) & ", " & Form1.Address(2)
        End If
    End Sub
End Class