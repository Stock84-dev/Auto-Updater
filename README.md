#Auto Updater
Simple auto updater that can download files from GitHub and update application.

## How it works
After you start launcher it downloads Version.txt from GitHub and compares it with Version.txt in program directory.
Then form shows up to notify user. User can also view changelog which comes from downloaded Version.txt file. If user allows to update application, program downloads Update.zip file and extracts it in temporary folder.
Temporary folder must contain Instructions.txt file. In that file you can specify which file to delete, create, copy, move, extract.
Once updater is finished it launches application.

To change Instructions.txt change constructor of Instruction.

There is an example when you download project, just launch Auto Updater.exe.
