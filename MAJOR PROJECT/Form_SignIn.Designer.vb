<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SignIn
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
        Me.TBusername = New System.Windows.Forms.TextBox()
        Me.TBpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNcheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBusername
        '
        Me.TBusername.Location = New System.Drawing.Point(285, 105)
        Me.TBusername.Name = "TBusername"
        Me.TBusername.Size = New System.Drawing.Size(337, 31)
        Me.TBusername.TabIndex = 0
        '
        'TBpassword
        '
        Me.TBpassword.Location = New System.Drawing.Point(285, 186)
        Me.TBpassword.Name = "TBpassword"
        Me.TBpassword.Size = New System.Drawing.Size(337, 31)
        Me.TBpassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'BTNcheck
        '
        Me.BTNcheck.Location = New System.Drawing.Point(182, 284)
        Me.BTNcheck.Name = "BTNcheck"
        Me.BTNcheck.Size = New System.Drawing.Size(286, 89)
        Me.BTNcheck.TabIndex = 4
        Me.BTNcheck.Text = "Sign In "
        Me.BTNcheck.UseVisualStyleBackColor = True
        '
        'Form_SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 385)
        Me.Controls.Add(Me.BTNcheck)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBpassword)
        Me.Controls.Add(Me.TBusername)
        Me.Name = "Form_SignIn"
        Me.Text = "Sign In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBusername As TextBox
    Friend WithEvents TBpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNcheck As Button
End Class
