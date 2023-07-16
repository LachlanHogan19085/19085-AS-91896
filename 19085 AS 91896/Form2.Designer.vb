<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        LblName = New Label()
        LblPh = New Label()
        LblAddress = New Label()
        RtxtTotal = New RichTextBox()
        BtnRestart = New Button()
        BtnQuit = New Button()
        BtnCompleteQuit = New Button()
        BtnCompleteNew = New Button()
        BtnPrint = New Button()
        BtnBack = New Button()
        RtxtPizzas = New RichTextBox()
        RtxtQty = New RichTextBox()
        lblprice = New Label()
        RtxtPrices = New RichTextBox()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tw Cen MT Condensed Extra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(2, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 28)
        Label2.TabIndex = 2
        Label2.Text = "Rotorua Dream Pizza™"' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblName.Location = New Point(2, 46)
        LblName.Name = "LblName"
        LblName.Size = New Size(131, 21)
        LblName.TabIndex = 3
        LblName.Text = "Customer Name: "' 
        ' LblPh
        ' 
        LblPh.AutoSize = True
        LblPh.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblPh.Location = New Point(2, 76)
        LblPh.Name = "LblPh"
        LblPh.Size = New Size(195, 21)
        LblPh.TabIndex = 5
        LblPh.Text = "Customer Phone Number: "' 
        ' LblAddress
        ' 
        LblAddress.AutoSize = True
        LblAddress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblAddress.Location = New Point(2, 106)
        LblAddress.Name = "LblAddress"
        LblAddress.Size = New Size(134, 21)
        LblAddress.TabIndex = 4
        LblAddress.Text = "Delivery Address: "
        LblAddress.Visible = False
        ' 
        ' RtxtTotal
        ' 
        RtxtTotal.BackColor = SystemColors.ControlLightLight
        RtxtTotal.BorderStyle = BorderStyle.None
        RtxtTotal.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        RtxtTotal.Location = New Point(291, 138)
        RtxtTotal.Name = "RtxtTotal"
        RtxtTotal.ReadOnly = True
        RtxtTotal.Size = New Size(80, 309)
        RtxtTotal.TabIndex = 6
        RtxtTotal.Text = "Total:"' 
        ' BtnRestart
        ' 
        BtnRestart.BackColor = Color.Red
        BtnRestart.Location = New Point(255, 518)
        BtnRestart.Name = "BtnRestart"
        BtnRestart.Size = New Size(55, 55)
        BtnRestart.TabIndex = 39
        BtnRestart.Text = "Restart"
        BtnRestart.UseVisualStyleBackColor = False
        ' 
        ' BtnQuit
        ' 
        BtnQuit.BackColor = Color.Red
        BtnQuit.Location = New Point(316, 518)
        BtnQuit.Name = "BtnQuit"
        BtnQuit.Size = New Size(55, 55)
        BtnQuit.TabIndex = 40
        BtnQuit.Text = "Quit"
        BtnQuit.UseVisualStyleBackColor = False
        ' 
        ' BtnCompleteQuit
        ' 
        BtnCompleteQuit.BackColor = Color.Red
        BtnCompleteQuit.Location = New Point(12, 518)
        BtnCompleteQuit.Name = "BtnCompleteQuit"
        BtnCompleteQuit.Size = New Size(83, 55)
        BtnCompleteQuit.TabIndex = 41
        BtnCompleteQuit.Text = "Complete + Quit"
        BtnCompleteQuit.UseVisualStyleBackColor = False
        ' 
        ' BtnCompleteNew
        ' 
        BtnCompleteNew.BackColor = Color.LimeGreen
        BtnCompleteNew.Location = New Point(12, 457)
        BtnCompleteNew.Name = "BtnCompleteNew"
        BtnCompleteNew.Size = New Size(83, 55)
        BtnCompleteNew.TabIndex = 42
        BtnCompleteNew.Text = "Complete + New Order"
        BtnCompleteNew.UseVisualStyleBackColor = False
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = Color.LimeGreen
        BtnPrint.Location = New Point(101, 457)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(55, 55)
        BtnPrint.TabIndex = 43
        BtnPrint.Text = "Print"
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.Red
        BtnBack.Location = New Point(101, 518)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(55, 55)
        BtnBack.TabIndex = 44
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' RtxtPizzas
        ' 
        RtxtPizzas.BackColor = SystemColors.ControlLightLight
        RtxtPizzas.BorderStyle = BorderStyle.None
        RtxtPizzas.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        RtxtPizzas.Location = New Point(12, 138)
        RtxtPizzas.Name = "RtxtPizzas"
        RtxtPizzas.ReadOnly = True
        RtxtPizzas.Size = New Size(140, 309)
        RtxtPizzas.TabIndex = 45
        RtxtPizzas.Text = "Pizzas Ordered:"' 
        ' RtxtQty
        ' 
        RtxtQty.BackColor = SystemColors.ControlLightLight
        RtxtQty.BorderStyle = BorderStyle.None
        RtxtQty.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        RtxtQty.Location = New Point(158, 138)
        RtxtQty.Name = "RtxtQty"
        RtxtQty.ReadOnly = True
        RtxtQty.Size = New Size(54, 309)
        RtxtQty.TabIndex = 46
        RtxtQty.Text = "Qty:"' 
        ' lblprice
        ' 
        lblprice.BackColor = SystemColors.ControlLightLight
        lblprice.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblprice.Location = New Point(218, 138)
        lblprice.Name = "lblprice"
        lblprice.Size = New Size(0, 0)
        lblprice.TabIndex = 48
        lblprice.Text = "Price:"' 
        ' RtxtPrices
        ' 
        RtxtPrices.BackColor = SystemColors.ControlLightLight
        RtxtPrices.BorderStyle = BorderStyle.None
        RtxtPrices.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        RtxtPrices.Location = New Point(218, 138)
        RtxtPrices.Name = "RtxtPrices"
        RtxtPrices.ReadOnly = True
        RtxtPrices.Size = New Size(67, 309)
        RtxtPrices.TabIndex = 49
        RtxtPrices.Text = "Price:"' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 585)
        Controls.Add(RtxtPrices)
        Controls.Add(lblprice)
        Controls.Add(RtxtQty)
        Controls.Add(RtxtPizzas)
        Controls.Add(BtnBack)
        Controls.Add(BtnPrint)
        Controls.Add(BtnCompleteNew)
        Controls.Add(BtnCompleteQuit)
        Controls.Add(BtnQuit)
        Controls.Add(BtnRestart)
        Controls.Add(RtxtTotal)
        Controls.Add(LblPh)
        Controls.Add(LblAddress)
        Controls.Add(LblName)
        Controls.Add(Label2)
        Name = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblPh As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents RtxtTotal As RichTextBox
    Friend WithEvents BtnRestart As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnCompleteQuit As Button
    Friend WithEvents BtnCompleteNew As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents RtxtPizzas As RichTextBox
    Friend WithEvents RtxtQty As RichTextBox
    Friend WithEvents RtxtPrice As RichTextBox
    Friend WithEvents lblprice As Label
    Friend WithEvents RtxtPrices As RichTextBox
End Class
