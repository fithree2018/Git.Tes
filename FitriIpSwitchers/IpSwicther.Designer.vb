Namespace FitriKHCode
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class IpSwicther
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
            Me.BtnSwicth = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'BtnSwicth
            '
            Me.BtnSwicth.Location = New System.Drawing.Point(89, 40)
            Me.BtnSwicth.Name = "BtnSwicth"
            Me.BtnSwicth.Size = New System.Drawing.Size(118, 50)
            Me.BtnSwicth.TabIndex = 0
            Me.BtnSwicth.Text = "Swicth"
            Me.BtnSwicth.UseVisualStyleBackColor = True
            '
            'IpSwicther
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 127)
            Me.Controls.Add(Me.BtnSwicth)
            Me.Name = "IpSwicther"
            Me.Text = "IpSwicther"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents BtnSwicth As System.Windows.Forms.Button
    End Class
End Namespace

