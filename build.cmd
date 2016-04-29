"C:\Program Files (x86)\msbuild\14.0\Bin\msbuild.exe" /p:Configuration=Release
chocolatey pack QuikPak\choco\quikpak.nuspec
del QuikPak\bin\Release\*.xml
del QuikPak\bin\Release\*.pdb
