# UnrealCS

# WHAT IS THIS

This is the C # script plug-in built for Unreal Engine 4, you can use the C# language and a little blueprint, to develop the game, without any C++ 
code. It's perfect collaboration with the blueprint. It now supports Windows, Mac, Andriod platform, iOS platform is also being planned.

# Supported Platforms

- Windows 64 bit
- Windows 32 bit
- Mac
- Android

ios is on the way.

# Tutorials & documentation

- [Wiki](https://github.com/xiongfang/UnrealCS/wiki)
- [Forum](http://www.unrealcs.com)

# Building

## for the  launcher version ue4 

Just download the unrealcs plugin from  the unreal marketplace
The forum will also release pre compiled versions of the plugin.[forum link..](http://www.unrealcs.com/read.php?tid=1)

## for the git source code ue4

Just copy the Engine/Plugins/UnrealCS directory to your plugins directory,then regenerate your unreal engine project file

## build the plugin for launcher version ue4 yourself

use compile command like this:

"D:\Program Files\Epic Games\4.13\Engine\Build\BatchFiles\RunUAT.bat" BuildPlugin -Plugin=E:\UnrealCS\UnrealCS.uplugin -Package=E:\Package -Rocket

# LICENCE

- Licensed under the MIT license

- see [LICENSE](https://github.com/xiongfang/UnrealCS/blob/master/LICENSE) for details


Mono Class Libraries and The Mono.Cecil are distributed under the MIT License,
Are copyright the (c) authors. For details see http://github.com/mono/mono and
 Https://github.com/jbevain/cecil.
