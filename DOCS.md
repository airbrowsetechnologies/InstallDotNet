#Documentation for InstallDotNet - being edited ATM, return later

###Design

- **BackColor** sets form backcolor
- **TitleBarColor** sets color of the main button and the titlebar
- **TitleBarImage** sets the icon displayed on the titlebar.
- **AppIcon** sets the icon of the app
- **SplashImage** sets the main image of the app displayed on the welcome and finished pages.


###Special file options (specified in the FileOptions property of the Installer).

#####STATEMENTS: the whole line of code to execute

- NOTE: Statements are split by spaces (don't enter a space unless you mean to)
  - To enter a space into a parameter, use "%20"
  - *Ex: name:My%20Cool%20App will compile as My Cool App*

#####COMMANDS:
Commands are always the first word in the statement

run (used to install dependencies like .NET framework, etc.)
	Parameter: file
	Parameter: args
	Parameter: async (enter async at the end of the statement to make the process run asyncronously)
createshortcut (used to create shortcuts for an executable)
	Parameter: file
	Parameter: name
	NOTE: shortcuts will automatically be created for the MainApplicationFileName, only use this for secondary apps
installfont (used to install font files)
	Parameter: file
delete (deletes a file after install, useful after calling "run" (above) on a file)
	Parameter: file


#####PARAMETERS:
	file: the path of the file inside the install directory
		set by prefix ?
		ex: delete ?myfile.exe 
	args:
		set by prefix &
		ex: run ?myfile.exe &argument1 &argument2
		NOTE: args do not change %20 to a space character, as %20 could be part of a URL argument
	name:
		set by prefix name:
		ex. createshortcut ?myfile.exe name:My%20App 
	msg: the message displayed on the installer progress
		set by prefix msg:
		ex: installfont ?myfont.otf msg:Installing%20fonts...
		CAN BE USED WITH ANY COMMAND


Example:
	
	run ?dotNetFramework4.exe &argument1 msg:Installing%20.NET%20Framework...
	delete ?dotNetFramework4.exe
	installfont ?open%20sans.ttf msg:Installing%20fonts...
	delete ?open%20sans.ttf
	createshortcut ?mySecondaryApp.exe name:My%20Second%20App msg:Creating%20shortcuts...
	run ?readme.txt async	

	Line by line explanation:
		1. runs the file called "dotNetFramework4.exe" (which could be an installer for the framework)
		2. deletes the file "dotNetFramework4.exe" now that it has been installed.
		3. installs the font from the file "open sans.ttf"
		4. deletes "open sans.ttf"
		5. creates a shortcut for "mySecondaryApp.exe" called "My Second App"
		6. launches a "readme.txt" file. Note the "async" at the end allows the application to exit.
			Note how Line 1 has no "async" because it needs to wait until the app has installed before it can delete it.



Contact airbrowse10@gmail.com to suggest or leave feedback about DotNetInstall.
