WHAT IS THIS

This is the C # script plug-in built for Unreal Engine 4, you can use the C# language and a little blueprint, to develop the game, without any C++ 
code. It's perfect collaboration with the blueprint. It now supports Windows, Mac, Andriod platform, iOS platform is also being planned.

HOW TO USE

1. Installation.


Just download from the Marketplace. And then use Launcher to create your project.


2. Usage


For Windows users:


Double click the project file to open the unreal editor. Click on file - > Open Project menu item. Then the C # script project will open, you can find a default class named TestClass, compile it, and then go to editor, you can find some plug-in generated the blueprint named TestClass. This class inherits from UActorComponent. Add this component to an Actor. Run game.


For Mac users:


Open the Project menu by clicking. Will create a template project in your project directory, using Microsoft Visual Studio Core to compile.It is 
Recommended developmented in the Windows , and then packaged in MAC.


3. Pack
age

for pack game, you need some other settings.
Open the editor settings panel, go to the "package" page. Add the following directory to the "additional non-asset directory to package" field.


Scripts/Engineassemblies 
Scripts/framework

Scripts/Gameassemblies 


Then you can pack your game.


LICENCE

The plug-in is copyright (c) ÐÜ·½ (xg_55). All rights reserved. Support email: xg_55@126.com.

Git repository:


Mono Class Libraries and The Mono.Cecil are distributed under the MIT License,
Are copyright the (c) authors. For details see http://github.com/mono/mono and
 Https://github.com/jbevain/cecil.