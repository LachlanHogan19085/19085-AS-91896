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
        RtxtPrices = New RichTextBox()
        BtnRestart = New Button()
        BtnQuit = New Button()
        BtnCompleteQuit = New Button()
        BtnCompleteNew = New Button()
        BtnPrint = New Button()
        BtnBack = New Button()
        RtxtSums = New RichTextBox()
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
        LblAddress.Text = "Delivery Address: "' 
        ' RtxtPrices
        ' 
        RtxtPrices.BorderStyle = BorderStyle.None
        RtxtPrices.Location = New Point(12, 142)
        RtxtPrices.Name = "RtxtPrices"
        RtxtPrices.Size = New Size(308, 309)
        RtxtPrices.TabIndex = 6
        RtxtPrices.Text = ""' 
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
        ' RtxtSums
        ' 
        RtxtSums.BorderStyle = BorderStyle.None
        RtxtSums.Location = New Point(316, 142)
        RtxtSums.Name = "RtxtSums"
        RtxtSums.Size = New Size(55, 309)
        RtxtSums.TabIndex = 45
        RtxtSums.Text = ""' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 585)
        Controls.Add(RtxtSums)
        Controls.Add(BtnBack)
        Controls.Add(BtnPrint)
        Controls.Add(BtnCompleteNew)
        Controls.Add(BtnCompleteQuit)
        Controls.Add(BtnQuit)
        Controls.Add(BtnRestart)
        Controls.Add(RtxtPrices)
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
    Friend WithEvents RtxtPrices As RichTextBox
    Friend WithEvents BtnRestart As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnCompleteQuit As Button
    Friend WithEvents BtnCompleteNew As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents RtxtSums As RichTextBox
End Class
