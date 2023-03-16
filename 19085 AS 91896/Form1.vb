Public Class Form1
    Const PIZZACOST As Decimal = 8.5
    Const GPIZZACOST As Decimal = 5
    Const DELIVERYFEE As Decimal = 3
    Dim Address(2) As String
    Dim Customerdetails(1) As String
    Dim Pizzascount(11) As Integer
    Dim Delivery As Boolean

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDelivery.CheckedChanged, ChkDelivery.CheckedChanged, ChkDelivery.CheckedChanged
        Delivery = Not Delivery
        TxtStreetNumber.Enabled = Not TxtStreetNumber.Enabled
    End Sub
End Class
