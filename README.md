# InstallDotNet
A .NET installer library. 

This project is an example of how to use the InstallDotNet library.

INSTALLER:
The implementation is simple (all has already been done in this example):
1. Import InstallDotNet.dll and KratosDesign.dll (optional, used to edit form design)
2. Install Costura.Fody from NuGet to embed all resources into one portable .exe
3. Edit the app.manifest file and change requestedExecutionLevel from asInvoker to requireAdministrator (required to edit uninstall registry dll).
4. Add a form and set it to inherit from InstallDotNet.InstallerForm
5. Edit the required fields. View the DOCS.TXT to read the docs on FileOptions
6. You're done!

UNINSTALLER:
If you want an uninstaller, create a new project and follow the same steps above, but the form should inherit from UninstallerForm
Then build the uninstaller and put it in your .zip file which the installer will download.
Set the UninstallerPath of the INSTALLER to the file name of your uninstaller file (like uninstall.exe, etc.). 

Now you have created an installer and uninstaller in .NET!
Your app is ready to go!

Contact airbrowse10@gmail.com to suggest or leave feedback about DotNetInstall.
