# ModuleBuilder
This tool takes the decisions-mod-skeleton and builds out a Module template

How to. 

Build this project in .net Framework 4.7.x

then run the output exe called ModuleBUilder.exe

this will ask you for a module name <enter a name> hit enter. 

this will create a folder with a solution all configured for you to code within.

IF you add in external references. add then to the Lib Folder in the main folder, then run the UpdateThirdPartyReferencesInModuleBuild.exe

this will update the module.build.xml

to make your module, run msbuild.bat from the folder inside cmd or powershell. 
