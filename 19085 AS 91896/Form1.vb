﻿Imports System.ComponentModel.DataAnnotations
Imports System.Threading
Imports System.Transactions
Imports System.Xml.Schema

Public Class Form1
    'defining constants for prices
    Const PIZZACOST As Decimal = 8.5 'regular pizza price
    Const GPIZZACOST As Decimal = 5 ' extra price of a gourmet pizza
    Const DELIVERYFEE As Decimal = 3 'fee for a delivery
    'defining variables and strings for program
    Dim Address(2) As String 'array for adress details
    Dim Customerdetails(1) As String 'array for name and phone number
    Dim Pizzascount(11) As Integer ' array for number of pizzas ordered
    Dim Delivery As Boolean ' boolean for whether or not the order is a delivery
    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        Application.Restart() 'closes and reopens application
    End Sub

    Private Sub Btnquit_Click(sender As Object, e As EventArgs) Handles Btnquit.Click
        End ' closes application
    End Sub

    Private Sub ChkDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDelivery.CheckedChanged
        Delivery = Not Delivery 'reverses value of delivery variable
        'reverses whether or Not the text boxes are enabled
        TxtStreetNumber.Enabled = Not TxtStreetNumber.Enabled
        TxtStreetName.Enabled = Not TxtStreetName.Enabled
        TxtSuburb.Enabled = Not TxtSuburb.Enabled
        ' resets text so text isnt inputted when delivery box is unchecked
        TxtStreetName.Text = ""
        TxtStreetNumber.Text = ""
        TxtSuburb.Text = ""
    End Sub

    Private Sub Btnnext_Click(sender As Object, e As EventArgs) Handles Btnnext.Click
        If Delivery = True Then 'only runs if delivery is selected
            If TxtStreetNumber.Text.Trim = "" Or IsNumeric(TxtStreetNumber.Text) = False Or TxtStreetNumber.Text < 1 Then 'checks for a valid street number
                MessageBox.Show("please enter a valid street number in numeric form") 'error message if an invalid street number is detected
            ElseIf TxtStreetName.Text.Trim = "" Or IsNumeric(TxtStreetName.Text) Then ' checks for a valid street name
                MessageBox.Show("please enter a valid street name") 'error message if an invalid street name is detected
            ElseIf TxtSuburb.Text.Trim = "" Or IsNumeric(TxtSuburb.Text) Then ' checks for a valid suburb name
                MessageBox.Show("please enter a valid suburb name") 'error message if an invalid suburb is detected
            Else
                'updates the address deatils when valid iputs have been typed and next is clicked
                Address(0) = TxtStreetName.Text
                Address(1) = TxtStreetNumber.Text
                Address(2) = TxtSuburb.Text
            End If
        End If





        'updates the value of the ammount of pizzas ordered
        Pizzascount(0) = UpdC.Value
        Pizzascount(1) = UpdHc.Value
        Pizzascount(2) = UpdB.Value
        Pizzascount(3) = UpdH.Value
        Pizzascount(4) = UpdP.Value
        Pizzascount(5) = UpdV.Value
        Pizzascount(6) = UpdM.Value
        Pizzascount(7) = UpdIc.Value
        Pizzascount(8) = UpdIh.Value
        Pizzascount(9) = UpdIp.Value
        Pizzascount(10) = UpdIv.Value
        Pizzascount(11) = UpdIm.Value

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Gourmet As Decimal = PIZZACOST + GPIZZACOST
        LblRegular.Text = PIZZACOST.ToString("C")
        LblGourmet.Text = Gourmet.ToString("C")
    End Sub
End Class
