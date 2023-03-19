Public Class Form1
    Const PIZZACOST As Decimal = 8.5
    Const GPIZZACOST As Decimal = 5
    Const DELIVERYFEE As Decimal = 3
    Dim Address(2) As String
    Dim Customerdetails(1) As String
    Dim Pizzascount(11) As Integer
    Dim Delivery As Boolean
    Private Sub Btnnext_Click(sender As Object, e As EventArgs)
        Pizzascount(0) = Val(UpdC)
    End Sub

    Private Sub Btnrestart_Click(sender As Object, e As EventArgs)
        Application.Restart()
    End Sub

    Private Sub Btnquit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub ChkDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDelivery.CheckedChanged
        Delivery = Not Delivery
        TxtStreetNumber.Enabled = Not TxtStreetNumber.Enabled
        TxtStreetName.Enabled = Not TxtStreetName.Enabled
        TxtSuburb.Enabled = Not TxtSuburb.Enabled
        TxtStreetName.Text = ""
        TxtStreetNumber.Text = ""
        TxtSuburb.Text = ""
    End Sub
End Class
