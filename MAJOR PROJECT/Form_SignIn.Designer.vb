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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBusername = New System.Windows.Forms.TextBox()
        Me.TBpassword = New System.Windows.Forms.TextBox()
        Me.BTNcheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserName "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TBusername
        '
        Me.TBusername.Location = New System.Drawing.Point(209, 73)
        Me.TBusername.Name = "TBusername"
        Me.TBusername.Size = New System.Drawing.Size(338, 31)
        Me.TBusername.TabIndex = 2
        '
        'TBpassword
        '
        Me.TBpassword.Location = New System.Drawing.Point(209, 149)
        Me.TBpassword.Name = "TBpassword"
        Me.TBpassword.Size = New System.Drawing.Size(338, 31)
        Me.TBpassword.TabIndex = 3
        '
        'BTNcheck
        '
        Me.BTNcheck.Location = New System.Drawing.Point(226, 214)
        Me.BTNcheck.Name = "BTNcheck"
        Me.BTNcheck.Size = New System.Drawing.Size(141, 53)
        Me.BTNcheck.TabIndex = 4
        Me.BTNcheck.Text = "Sign In "
        Me.BTNcheck.UseVisualStyleBackColor = True
        '
        'Form_SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 293)
        Me.Controls.Add(Me.BTNcheck)
        Me.Controls.Add(Me.TBpassword)
        Me.Controls.Add(Me.TBusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_SignIn"
        Me.Text = "Sign In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBusername As TextBox
    Friend WithEvents TBpassword As TextBox
    Friend WithEvents BTNcheck As Button
End Class
