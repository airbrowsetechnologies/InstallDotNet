# InstallDotNet
A .NET installer library. 

This project is an example of how to use the InstallDotNet library.

###Installer:
The implementation is simple (all has already been done in this example):

1. Import InstallDotNet.dll and KratosDesign.dll (optional, used to edit form design)
2. Install Costura.Fody from NuGet to embed all resources into one portable .exe
3. Edit the app.manifest file and change requestedExecutionLevel from asInvoker to requireAdministrator (required to edit uninstall registry dll).
4. **Build your uninstaller first. Then put the uninstaller in the zip file which your installer will download from.**
5. Add a form and set it to inherit from InstallDotNet.InstallerForm
6. Edit the required fields. View the DOCS.TXT to read the docs on FileOptions
7. You're done!

###Uninstaller:

1. Create a new project
2. Follow the same steps (1-3) from the installer.
3. Add a form and set it to inherit from InstallDotNet.UninstallerForm
4. Edit the required fields.
5. Build the uninstaller and put it in your .zip file of your app which the installer will download.
6. Set the UninstallerPath of the INSTALLER to the file name of your uninstaller file (like uninstall.exe, etc.). 

Now you have created an installer and uninstaller in .NET!
Your app is ready to go!

Contact airbrowse10@gmail.com to suggest or leave feedback about DotNetInstall.
