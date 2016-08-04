<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Installer
    Inherits InstallDotNet.InstallerForm

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
        'Installer
        '
        Me.AppIcon = Global.InstallNET_Demo.My.Resources.Resources.applauncher
        Me.AppName = "AppCreator"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(922, 1062)
        Me.Description = "Creates AirBrowse apps."
        Me.Developer = "AirBrowse Technologies"
        Me.FileOptions.AddRange(New String() {"run ?vcredist_x86.exe &/install &/quiet &/norestart msg:Installing%20Visual%20C++" & _
                "%20Redistributables...", "installfont ?Quicksand-Regular.otf msg:Installing%20fonts...", "createshortcut ?AppCreator2.exe name:DEEZ%20NUTS msg:Creating%20shortcuts...", "delete ?vcredist_x86.exe msg:Removing%20files...", "delete ?Quicksand-Regular.otf msg:Removing%20files..."})
        Me.InstallDirectory = "C:\"
        Me.LicenseFilePath = "https://www.gnu.org/licenses/gpl-2.0.txt"
        Me.MainApplicationFileName = "AppCreator.exe"
        Me.MaximizeBox = False
        Me.Name = "Installer"
        Me.SplashImage = Global.InstallNET_Demo.My.Resources.Resources.applauncher
        Me.TitleBarImage = Global.InstallNET_Demo.My.Resources.Resources.applauncher
        Me.UninstallerPath = "uninstall.exe"
        Me.VersionURL = "http://airbrowse.x10host.com/airbrowse/version.txt"
        Me.ZipFileURL = "https://www.dropbox.com/s/a57z116pbos04e5/AppCreator.zip?dl=1"
        Me.ResumeLayout(False)

    End Sub

End Class
