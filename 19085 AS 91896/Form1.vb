Imports System.ComponentModel.DataAnnotations
Imports System.Net.Mail
Imports System.Reflection.Metadata
Imports System.Reflection.Metadata.Ecma335
Imports System.Threading
Imports System.Transactions
Imports System.Xml.Schema
Imports Microsoft.Win32.SafeHandles

Public Class Form1
    'defining constants for prices
    Public Const PIZZACOST As Decimal = 8.5 'regular pizza price
    Public Const GPIZZACOST As Decimal = 5 ' extra price of a gourmet pizza
    Public Const DELIVERYFEE As Decimal = 3 'fee for a delivery
    Public Const FLAVOURAMOUNT As Integer = 11 'amount of different pizza flavours there are (used to display pizzas)
    'defining variables and strings for program
    Public Address(2) As String 'array for adress details
    Public Customerdetails(1) As String 'array for name and phone number
    Public Pizzascount(2, 11) As String ' array for number of pizzas ordered
    Public Delivery As Boolean ' boolean for whether or not the order is a delivery
    Public Totalcost As Decimal 'total price of all costs
    Dim completepizzas As Boolean 'checks if an order is valid and has at least one pizza ordered
    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        Application.Restart() 'closes and reopens application
    End Sub

    Private Sub Btnquit_Click(sender As Object, e As EventArgs) Handles Btnquit.Click
        End ' closes application
    End Sub

    Private Sub ChkDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDelivery.CheckedChanged
        Delivery = Not Delivery 'reverses value of delivery variable
        Total() 'runs total function
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
        'code that runs if the order is a delivery
        Dim phoneclean As String
        If TxtName.Text.Trim = "" Or IsNumeric(TxtName.Text) Then ' checks for a valid name
            MessageBox.Show("please enter a valid name") 'error message if an invalid name is detected
        Else
            phoneclean = MtbPhone.Text.Replace("(", "") 'replaces left bracket with placeholder number
            phoneclean = phoneclean.Replace("-", "") 'replaces hyphen with placeholder number
            phoneclean = phoneclean.Replace(")", "") 'replaces right bracket with placeholder number
            phoneclean = phoneclean.Replace(" ", "") 'replaces space with placeholder number
            If phoneclean = "" Or IsNumeric(phoneclean) = False Or phoneclean.Length < 1 Then 'checks for a valid phone number
                MessageBox.Show("please enter a valid phone number in numeric form") 'error message if an invalid phone number is detected
            Else
                'updates details in the array when next is clicked and valid inputs are detected
                Customerdetails(0) = TxtName.Text
                Customerdetails(1) = MtbPhone.Text
                'updates ammount of pizzas
                Pizzascount(2, 0) = UpdC.Value
                Pizzascount(2, 1) = UpdHc.Value
                Pizzascount(2, 2) = UpdB.Value
                Pizzascount(2, 3) = UpdH.Value
                Pizzascount(2, 4) = UpdP.Value
                Pizzascount(2, 5) = UpdV.Value
                Pizzascount(2, 6) = UpdM.Value
                Pizzascount(2, 7) = UpdIc.Value
                Pizzascount(2, 8) = UpdIh.Value
                Pizzascount(2, 9) = UpdIp.Value
                Pizzascount(2, 10) = UpdIv.Value
                Pizzascount(2, 11) = UpdIm.Value
                For pizzas = 0 To 11 'loop to check pizzas
                    If Pizzascount(2, pizzas) > 0 Then ' checks if there is at least one pizza ordered
                        completepizzas = True ' if so then updates variable to mark an pizza order as complete
                    End If
                Next
                If completepizzas = False Then ' checks if a pizza has been ordered
                    MessageBox.Show("please enter at least one pizza") ' if not then shows the corresponding error message
                Else
                    If Delivery = True Then 'only runs if delivery is selected
                        If TxtStreetName.Text.Trim = "" Or IsNumeric(TxtStreetName.Text) Then ' checks for a valid street name
                            MessageBox.Show("please enter a valid street name") 'error message if an invalid street name is detected
                        ElseIf TxtStreetNumber.Text.Trim = "" Or IsNumeric(TxtStreetNumber.Text) = False Or Val(TxtStreetNumber.Text) < 1 Then 'checks for a valid street number
                            MessageBox.Show("please enter a valid street number in numeric form") 'error message if an invalid street number is detected

                        ElseIf TxtSuburb.Text.Trim = "" Or IsNumeric(TxtSuburb.Text) Then ' checks for a valid suburb name
                            MessageBox.Show("please enter a valid suburb name") 'error message if an invalid suburb is detected
                        Else
                            'updates the address deatils when valid iputs have been typed and next is clicked
                            Address(0) = TxtStreetName.Text
                            Address(1) = TxtStreetNumber.Text
                            Address(2) = TxtSuburb.Text
                            Form2.Show() ' loads next form if the order is complete
                            Me.Hide() ' hides form 1
                        End If
                    Else
                        Form2.Show() ' loads next form if the order is complete
                        Me.Hide() ' hides form 1
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Gourmet As Decimal = PIZZACOST + GPIZZACOST 'defines variable to store the total cost of a gourmet pizza
        'updates names of pizzas upon load
        Pizzascount(0, 0) = "Cheese"
        Pizzascount(0, 1) = "Ham and Cheese"
        Pizzascount(0, 2) = "Beef and Onion"
        Pizzascount(0, 3) = "Hawaiian"
        Pizzascount(0, 4) = "Pepperoni"
        Pizzascount(0, 5) = "Vegetarian"
        Pizzascount(0, 6) = "Meatlovers"
        Pizzascount(0, 7) = "Italian Cheese"
        Pizzascount(0, 8) = "Italian Hawaiian"
        Pizzascount(0, 9) = "Italian Pepperoni"
        Pizzascount(0, 10) = "Italian Vegetarian"
        Pizzascount(0, 11) = "Italian Meatlovers"
        'updates prices of pizza upon load
        For x = 0 To 6
            Pizzascount(1, x) = PIZZACOST
        Next
        For x = 7 To 11
            Pizzascount(1, x) = Gourmet
        Next
        ' updates prices of pizzas upon form load and formats the as currency
        LblRegular.Text = PIZZACOST.ToString("C")
        LblGourmet.Text = Gourmet.ToString("C")
        Total()
    End Sub

    Private Sub AnyPizza_ValueChanged(sender As Object, e As EventArgs) Handles UpdC.ValueChanged, UpdHc.ValueChanged, UpdB.ValueChanged, UpdH.ValueChanged, UpdP.ValueChanged, UpdV.ValueChanged, UpdM.ValueChanged, UpdIc.ValueChanged, UpdIh.ValueChanged, UpdIp.ValueChanged, UpdIv.ValueChanged, UpdIm.ValueChanged
        Total() 'runs total if any regualar pizza ammounts are changed
    End Sub
    Private Sub Total()
        Totalcost = 0 'resets total cost
        If Delivery = True Then 'checks if delivery is true
            Totalcost = Totalcost + DELIVERYFEE ' adds delivery fee to totalcost
        End If
        Totalcost = Totalcost + (UpdC.Value + UpdHc.Value + UpdB.Value + UpdH.Value + UpdP.Value + UpdV.Value + UpdM.Value) * PIZZACOST 'adds cost of all regular pizzas
        Totalcost = Totalcost + (UpdIc.Value + UpdIh.Value + UpdIp.Value + UpdIv.Value + UpdIm.Value) * (PIZZACOST + GPIZZACOST) ' adds cost of all gourmet pizzas
        LblTotal.Text = Totalcost.ToString("C") 'updates total label
    End Sub
    Private Sub txtphone_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MtbPhone.KeyPress, MtbPhone.KeyPress
        ' only allows numbers to be typed into text box
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
    End Sub
    Private Sub txtstreetnumber_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStreetNumber.KeyPress
        ' only allows numbers to be typed into text box
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True 'enables input to go through
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
    End Sub
End Class
