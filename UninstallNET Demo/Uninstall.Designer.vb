<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uninstall
    Inherits InstallDotNet.UninstallForm

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
        Me.SuspendLayout()
        '
        'Uninstall
        '
        Me.AppName = "AppCreator"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.InstallDirectory = "C:\"
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 200)
        Me.MinimizeBox = False
        Me.Name = "Uninstall"
        Me.Text = "Uninstall"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
