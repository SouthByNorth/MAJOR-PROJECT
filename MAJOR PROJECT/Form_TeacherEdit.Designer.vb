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
        Me.BTNLoad = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GBwselection = New System.Windows.Forms.GroupBox()
        Me.LBRemove = New System.Windows.Forms.ListBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.BTNpreview = New System.Windows.Forms.Button()
        Me.BTNprint = New System.Windows.Forms.Button()
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
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(636, 669)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 242)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GBwselection
        '
        Me.GBwselection.Controls.Add(Me.LBRemove)
        Me.GBwselection.Controls.Add(Me.RadioButton4)
        Me.GBwselection.Controls.Add(Me.RadioButton3)
        Me.GBwselection.Controls.Add(Me.RadioButton2)
        Me.GBwselection.Controls.Add(Me.RadioButton1)
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
        Me.LBRemove.Location = New System.Drawing.Point(256, 117)
        Me.LBRemove.Name = "LBRemove"
        Me.LBRemove.Size = New System.Drawing.Size(238, 304)
        Me.LBRemove.TabIndex = 5
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(29, 205)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(29, 170)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(29, 135)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(29, 100)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GB
        '
        Me.GB.Location = New System.Drawing.Point(53, 669)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(527, 242)
        Me.GB.TabIndex = 4
        Me.GB.TabStop = False
        Me.GB.Text = "GroupBox2"
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
        'Form_TeacherEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 947)
        Me.Controls.Add(Me.BTNprint)
        Me.Controls.Add(Me.BTNpreview)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBwselection)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BTNLoad)
        Me.Name = "Form_TeacherEdit"
        Me.GBwselection.ResumeLayout(False)
        Me.GBwselection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNLoad As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GBwselection As GroupBox
    Friend WithEvents GB As GroupBox
    Friend WithEvents BTNpreview As Button
    Friend WithEvents BTNprint As Button
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents LBRemove As ListBox
End Class
