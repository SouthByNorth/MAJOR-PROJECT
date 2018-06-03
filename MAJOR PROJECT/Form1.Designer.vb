<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLanding
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
        Me.BTNTeachLoad = New System.Windows.Forms.Button()
        Me.BTNStudentLoad = New System.Windows.Forms.Button()
        Me.LBLwho = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNTeachLoad
        '
        Me.BTNTeachLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!)
        Me.BTNTeachLoad.Location = New System.Drawing.Point(85, 221)
        Me.BTNTeachLoad.Name = "BTNTeachLoad"
        Me.BTNTeachLoad.Size = New System.Drawing.Size(229, 115)
        Me.BTNTeachLoad.TabIndex = 0
        Me.BTNTeachLoad.Text = "Teacher "
        Me.BTNTeachLoad.UseVisualStyleBackColor = True
        '
        'BTNStudentLoad
        '
        Me.BTNStudentLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNStudentLoad.Location = New System.Drawing.Point(555, 221)
        Me.BTNStudentLoad.Name = "BTNStudentLoad"
        Me.BTNStudentLoad.Size = New System.Drawing.Size(229, 115)
        Me.BTNStudentLoad.TabIndex = 1
        Me.BTNStudentLoad.Text = "Student"
        Me.BTNStudentLoad.UseVisualStyleBackColor = True
        '
        'LBLwho
        '
        Me.LBLwho.AutoSize = True
        Me.LBLwho.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLwho.Location = New System.Drawing.Point(296, 113)
        Me.LBLwho.Name = "LBLwho"
        Me.LBLwho.Size = New System.Drawing.Size(261, 42)
        Me.LBLwho.TabIndex = 2
        Me.LBLwho.Text = "Who Are You?"
        '
        'FormLanding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 404)
        Me.Controls.Add(Me.LBLwho)
        Me.Controls.Add(Me.BTNStudentLoad)
        Me.Controls.Add(Me.BTNTeachLoad)
        Me.Name = "FormLanding"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNTeachLoad As Button
    Friend WithEvents BTNStudentLoad As Button
    Friend WithEvents LBLwho As Label
End Class
