<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TeacherEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_TeacherEdit))
        Me.BTNLoad = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GBwselection = New System.Windows.Forms.GroupBox()
        Me.LBRemove = New System.Windows.Forms.ListBox()
        Me.BTNpreview = New System.Windows.Forms.Button()
        Me.BTNprint = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GBwselection.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNLoad
        '
        Me.BTNLoad.Location = New System.Drawing.Point(53, 42)
        Me.BTNLoad.Name = "BTNLoad"
        Me.BTNLoad.Size = New System.Drawing.Size(514, 115)
        Me.BTNLoad.TabIndex = 0
        Me.BTNLoad.Text = "Load File "
        Me.BTNLoad.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(590, 22)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(795, 601)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'GBwselection
        '
        Me.GBwselection.Controls.Add(Me.LBRemove)
        Me.GBwselection.Location = New System.Drawing.Point(53, 181)
        Me.GBwselection.Name = "GBwselection"
        Me.GBwselection.Size = New System.Drawing.Size(514, 442)
        Me.GBwselection.TabIndex = 4
        Me.GBwselection.TabStop = False
        Me.GBwselection.Text = "Word Selection"
        '
        'LBRemove
        '
        Me.LBRemove.FormattingEnabled = True
        Me.LBRemove.ItemHeight = 25
        Me.LBRemove.Location = New System.Drawing.Point(212, 19)
        Me.LBRemove.Name = "LBRemove"
        Me.LBRemove.Size = New System.Drawing.Size(284, 379)
        Me.LBRemove.TabIndex = 5
        '
        'BTNpreview
        '
        Me.BTNpreview.Location = New System.Drawing.Point(1219, 669)
        Me.BTNpreview.Name = "BTNpreview"
        Me.BTNpreview.Size = New System.Drawing.Size(184, 115)
        Me.BTNpreview.TabIndex = 5
        Me.BTNpreview.Text = "Preview"
        Me.BTNpreview.UseVisualStyleBackColor = True
        '
        'BTNprint
        '
        Me.BTNprint.Location = New System.Drawing.Point(1219, 805)
        Me.BTNprint.Name = "BTNprint"
        Me.BTNprint.Size = New System.Drawing.Size(184, 115)
        Me.BTNprint.TabIndex = 6
        Me.BTNprint.Text = "Print"
        Me.BTNprint.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form_TeacherEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 947)
        Me.Controls.Add(Me.BTNprint)
        Me.Controls.Add(Me.BTNpreview)
        Me.Controls.Add(Me.GBwselection)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BTNLoad)
        Me.Name = "Form_TeacherEdit"
        Me.GBwselection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNLoad As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GBwselection As GroupBox
    Friend WithEvents BTNpreview As Button
    Friend WithEvents BTNprint As Button
    Friend WithEvents LBRemove As ListBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
