<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_StudentWord
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
        Me.BtnFilePick = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BTNSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnFilePick
        '
        Me.BtnFilePick.Location = New System.Drawing.Point(12, 23)
        Me.BtnFilePick.Name = "BtnFilePick"
        Me.BtnFilePick.Size = New System.Drawing.Size(286, 117)
        Me.BtnFilePick.TabIndex = 0
        Me.BtnFilePick.Text = "Pick a File!"
        Me.BtnFilePick.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(12, 163)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(298, 504)
        Me.ListBox1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(340, 23)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(734, 540)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'BTNSubmit
        '
        Me.BTNSubmit.Location = New System.Drawing.Point(932, 579)
        Me.BTNSubmit.Name = "BTNSubmit"
        Me.BTNSubmit.Size = New System.Drawing.Size(142, 117)
        Me.BTNSubmit.TabIndex = 3
        Me.BTNSubmit.Text = "Sumbit!"
        Me.BTNSubmit.UseVisualStyleBackColor = True
        '
        'Form_StudentWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 708)
        Me.Controls.Add(Me.BTNSubmit)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnFilePick)
        Me.Name = "Form_StudentWord"
        Me.Text = "Form_StudentWord"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFilePick As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BTNSubmit As Button
End Class
