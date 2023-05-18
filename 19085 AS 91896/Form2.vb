Imports System.Security.AccessControl

Public Class Form2
    Dim grandtotal As Decimal
    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
        Application.Restart() 'closes and reopens application
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        End
    End Sub

    Private Sub BtnCompleteNew_Click(sender As Object, e As EventArgs) Handles BtnCompleteNew.Click
        Application.Restart() ' same a restart but 
    End Sub

    Private Sub BtnCompleteQuit_Click(sender As Object, e As EventArgs) Handles BtnCompleteQuit.Click
        End
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Form1.Show() 'goes back and shows form1
        Me.Close() ' closes form2
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblName.Text = LblName.Text & Form1.Customerdetails(0) ' adds customer name
        LblPh.Text = LblPh.Text & Form1.Customerdetails(1) 'adds customer phone number
        If Form1.Delivery = True Then ' checks if the order is a delivery
            LblAddress.Visible = True
            LblAddress.Text = LblAddress.Text & Form1.Address(1) & " " & Form1.Address(0) & ", " & Form1.Address(2) ' if it is a delivery it shows and formats the adress
        End If
        Dim tempprice As Decimal 'temporary variable in order to display price
        For x = 0 To Form1.FLAVOURAMOUNT 'loops for ammout of different pizza flavours
            If Form1.Pizzascount(2, x) > 0 Then ' only runs the display code for one flavour if at least of of said flavour was ordered
                tempprice = Form1.Pizzascount(1, x) 'update temporrary variable
                RtxtPizzas.Text = RtxtPizzas.Text & vbCrLf & Form1.Pizzascount(0, x) ' displays the pizza flavours
                RtxtPrices.Text = RtxtPrices.Text & vbCrLf & tempprice.ToString("C") ' displays the pizza prices   
                RtxtQty.Text = RtxtQty.Text & vbCrLf & Form1.Pizzascount(2, x) ' displays the pizza quantities
                RtxtTotal.Text = RtxtTotal.Text & vbCrLf & (Form1.Pizzascount(1, x) * Form1.Pizzascount(2, x)).ToString("C") ' displays the pizza subtotals
            End If
        Next
        If Form1.Delivery = True Then ' checks if the order is a delivery
            RtxtPizzas.Text = RtxtPizzas.Text & vbCrLf & vbCrLf & "Delivery Charge" 'shows the delivery charge
            RtxtPrices.Text = RtxtPrices.Text & vbCrLf & vbCrLf & Form1.DELIVERYFEE.ToString("C") ' shows the cost
            RtxtTotal.Text = RtxtTotal.Text & vbCrLf & vbCrLf & Form1.DELIVERYFEE.ToString("C") ' showsthe total cost
        End If
        RtxtTotal.Text = RtxtTotal.Text & vbCrLf & vbCrLf & Form1.LblTotal.Text ' displays the pizza grand total
        RtxtPizzas.Text = RtxtPizzas.Text & vbCrLf & vbCrLf & "Grand Total:" ' displays the grand total
    End Sub
End Class