Imports System.Drawing.Printing
Public Class Form3
    Dim printstring As String 'variable to hold the text of the summary
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        End
    End Sub

    Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
        Application.Restart()
    End Sub

    Private Sub Form3_show(sender As Object, e As EventArgs) Handles MyBase.Shown
        printstring = "Name: " & Form1.Customerdetails(0) & vbCrLf & "Phone number: " & Form1.Customerdetails(1) & vbCrLf ' displays customer details
        If Form1.Delivery = True Then ' checks if delivery
            printstring = printstring & "Address: " & Form1.Address(1) & " " & Form1.Address(0) & ", " & Form1.Address(2) & vbCrLf 'dispays delivery details if order is delivery
        End If
        printstring = printstring & vbCrLf 'goes down one line
        For x = 0 To Form1.FLAVOURAMOUNT 'loops for ammout of different pizza flavours
            If Form1.Pizzascount(2, x) > 0 Then ' only runs the display code for one flavour if at least of of said flavour was ordered
                Form2.tempprice = Form1.Pizzascount(1, x) 'update temporrary variable
                printstring = printstring & Form1.Pizzascount(2, x) & " x " & Form1.Pizzascount(0, x) & " at " & Form2.tempprice.ToString("C") & " ea. = " & (Form1.Pizzascount(1, x) * Form1.Pizzascount(2, x)).ToString("C") & vbCrLf ' displays the pizza flavours
            End If
        Next
        If Form1.Delivery = True Then ' checks if the order is a delivery
            printstring = printstring & "Delivery Charge of " & Form1.DELIVERYFEE.ToString("C") & vbCrLf 'displays delivery charge if order is delivery
        End If
        printstring = printstring & vbCrLf & "Grand Total: " & Form1.LblTotal.Text 'displays grand total
        Rtxtprintpreview.Text = printstring ' updates text box
    End Sub

    Private Sub btnpagesetup_Click(sender As Object, e As EventArgs) Handles btnpagesetup.Click
        'allows user to choose the format of the page
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub btnpreview_Click(sender As Object, e As EventArgs) Handles btnpreview.Click
        'allows user to see a preview of the print
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnprint_Click_1(sender As Object, e As EventArgs) Handles btnprint.Click
        'allows the user to print the summary
        PageSetupDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(Rtxtprintpreview.Text, Rtxtprintpreview.Font, Brushes.Black, 100, 100) 'draws the text into the print system
    End Sub
End Class