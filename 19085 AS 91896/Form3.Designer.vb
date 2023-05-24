<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        PrintDocument1 = New Printing.PrintDocument()
        PrintDialog1 = New PrintDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Rtxtprintpreview = New RichTextBox()
        BtnQuit = New Button()
        BtnRestart = New Button()
        BtnBack = New Button()
        Label2 = New Label()
        PageSetupDialog1 = New PageSetupDialog()
        btnpagesetup = New Button()
        btnpreview = New Button()
        btnprint = New Button()
        SuspendLayout()
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Rtxtprintpreview
        ' 
        Rtxtprintpreview.BorderStyle = BorderStyle.None
        Rtxtprintpreview.Location = New Point(12, 49)
        Rtxtprintpreview.Name = "Rtxtprintpreview"
        Rtxtprintpreview.Size = New Size(246, 385)
        Rtxtprintpreview.TabIndex = 0
        Rtxtprintpreview.Text = "test"' 
        ' BtnQuit
        ' 
        BtnQuit.BackColor = Color.Red
        BtnQuit.Location = New Point(135, 501)
        BtnQuit.Name = "BtnQuit"
        BtnQuit.Size = New Size(55, 55)
        BtnQuit.TabIndex = 41
        BtnQuit.Text = "Quit"
        BtnQuit.UseVisualStyleBackColor = False
        ' 
        ' BtnRestart
        ' 
        BtnRestart.BackColor = Color.Red
        BtnRestart.Location = New Point(74, 501)
        BtnRestart.Name = "BtnRestart"
        BtnRestart.Size = New Size(55, 55)
        BtnRestart.TabIndex = 42
        BtnRestart.Text = "Restart"
        BtnRestart.UseVisualStyleBackColor = False
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.Red
        BtnBack.Location = New Point(12, 501)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(55, 55)
        BtnBack.TabIndex = 45
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tw Cen MT Condensed Extra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(1, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 28)
        Label2.TabIndex = 47
        Label2.Text = "Rotorua Dream Pizza™"' 
        ' btnpagesetup
        ' 
        btnpagesetup.BackColor = Color.LimeGreen
        btnpagesetup.Location = New Point(12, 440)
        btnpagesetup.Name = "btnpagesetup"
        btnpagesetup.Size = New Size(55, 55)
        btnpagesetup.TabIndex = 50
        btnpagesetup.Text = "Page Setup"
        btnpagesetup.UseVisualStyleBackColor = False
        ' 
        ' btnpreview
        ' 
        btnpreview.BackColor = Color.LimeGreen
        btnpreview.Location = New Point(73, 440)
        btnpreview.Name = "btnpreview"
        btnpreview.Size = New Size(56, 55)
        btnpreview.TabIndex = 51
        btnpreview.Text = "Preview"
        btnpreview.UseVisualStyleBackColor = False
        ' 
        ' btnprint
        ' 
        btnprint.BackColor = Color.LimeGreen
        btnprint.Location = New Point(135, 440)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(55, 55)
        btnprint.TabIndex = 52
        btnprint.Text = "Print"
        btnprint.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(270, 568)
        Controls.Add(btnprint)
        Controls.Add(btnpreview)
        Controls.Add(btnpagesetup)
        Controls.Add(Label2)
        Controls.Add(BtnBack)
        Controls.Add(BtnRestart)
        Controls.Add(BtnQuit)
        Controls.Add(Rtxtprintpreview)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Rtxtprintpreview As RichTextBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnRestart As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents btnpagesetup As Button
    Friend WithEvents btnpreview As Button
    Friend WithEvents btnprint As Button
End Class
