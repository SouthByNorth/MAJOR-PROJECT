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
        Me.BTNprint = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BTNpreview = New System.Windows.Forms.Button()
        Me.BTNsave = New System.Windows.Forms.Button()
        Me.GBwselection.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNLoad
        '
        Me.BTNLoad.Location = New System.Drawing.Point(3, 3)
        Me.BTNLoad.Name = "BTNLoad"
        Me.BTNLoad.Size = New System.Drawing.Size(514, 115)
        Me.BTNLoad.TabIndex = 0
        Me.BTNLoad.Text = "Load File "
        Me.BTNLoad.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.RichTextBox1, 2)
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(523, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.RichTextBox1, 2)
        Me.RichTextBox1.Size = New System.Drawing.Size(1063, 601)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'GBwselection
        '
        Me.GBwselection.AutoSize = True
        Me.GBwselection.Controls.Add(Me.LBRemove)
        Me.GBwselection.Location = New System.Drawing.Point(3, 124)
        Me.GBwselection.Name = "GBwselection"
        Me.GBwselection.Size = New System.Drawing.Size(334, 466)
        Me.GBwselection.TabIndex = 4
        Me.GBwselection.TabStop = False
        Me.GBwselection.Text = "Word Selection"
        '
        'LBRemove
        '
        Me.LBRemove.FormattingEnabled = True
        Me.LBRemove.ItemHeight = 25
        Me.LBRemove.Location = New System.Drawing.Point(44, 57)
        Me.LBRemove.Name = "LBRemove"
        Me.LBRemove.Size = New System.Drawing.Size(284, 379)
        Me.LBRemove.TabIndex = 5
        '
        'BTNprint
        '
        Me.BTNprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNprint.Location = New System.Drawing.Point(1402, 610)
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
        'PrintDocument1
        '
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.BTNprint, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BTNsave, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.BTNpreview, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.GBwselection, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BTNLoad, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1589, 885)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'BTNpreview
        '
        Me.BTNpreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNpreview.Location = New System.Drawing.Point(1402, 767)
        Me.BTNpreview.Name = "BTNpreview"
        Me.BTNpreview.Size = New System.Drawing.Size(184, 115)
        Me.BTNpreview.TabIndex = 5
        Me.BTNpreview.Text = "Preview"
        Me.BTNpreview.UseVisualStyleBackColor = True
        '
        'BTNsave
        '
        Me.BTNsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNsave.Location = New System.Drawing.Point(3, 742)
        Me.BTNsave.Name = "BTNsave"
        Me.BTNsave.Size = New System.Drawing.Size(240, 140)
        Me.BTNsave.TabIndex = 7
        Me.BTNsave.Text = "Save"
        Me.BTNsave.UseVisualStyleBackColor = True
        '
        'Form_TeacherEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1589, 885)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form_TeacherEdit"
        Me.GBwselection.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNLoad As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GBwselection As GroupBox
    Friend WithEvents BTNprint As Button
    Friend WithEvents LBRemove As ListBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BTNsave As Button
    Friend WithEvents BTNpreview As Button
End Class
