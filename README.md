## Summary ##

Frustrated that a program always open Windows Explorer instead your favorite File Manager? ;-)

Use **delegate-explorer-select** and delegate selects to any other File Manager.

I wrote this small exe because [IDEA](http://www.jetbrains.com/idea/)'s **Show in Explorer** opens Windows Explorer instead my favorite File Manager [Directory Opus](http://www.gpsoft.com.au/). But you can use it with any program, to any file manager as long they use shellexecute with _explorer /select,[file/dir]_

## Download ##

[delegate-explorer-select-1.0.zip](../../releases/download/1.0/delegate-explorer-select-1.0.zip)
MD5: 4c433a5e4157175ed89c90ae79de919c

## Installation ##

No extra installation required<sup>1</sup>. Just extract content of zip into working directory (for IDEA this is _[IDEA\_INSTALL\_PATH]\bin_).

<sup>1) needs .NET Framework 4.0</sup>

## Configuration ##

Default config delegates to _C:\Program Files\GPSoftware\Directory Opus\dopusrt.exe_.
Edit _explorer.exe.config_ to change to an alternative File Manager. Argument _{0}_ will be replaces with _[file/dir]_.

## Behind the scenes ##

To select a file, programs call shellexecute _explorer_ with _/select_ argument. _explorer.exe_ can be executed without full path since the location of the file is in your PATH variable. Copying _explorer.exe_ from _delegate-explorer-select_ into working directory intercept this shellexecute, because working directory has higher priority than files from PATH variable. So _explorer.exe_ from working directory is called instead of the one, found in your PATH variable.

## External links ###
Issue at jetbrains [IDEA-105050](https://youtrack.jetbrains.com/issue/IDEA-105050)

## License ##

Copyright 2013 Minas Manthos

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
