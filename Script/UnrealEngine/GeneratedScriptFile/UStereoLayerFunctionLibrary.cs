using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UStereoLayerFunctionLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EnableAutoLoadingSplashScreen(IntPtr _this,int InAutoShowEnabled);
/// <summary>
/// Enables/disables splash screen to be automatically shown when LoadMap is called.
/// @param       bAutoShowEnabled        (in)    True, if automatic showing of splash screens is enabled when map is being loaded.
/// </summary>
public static void EnableAutoLoadingSplashScreen(bool InAutoShowEnabled)
{
	EnableAutoLoadingSplashScreen(IntPtr.Zero,InAutoShowEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void HideSplashScreen(IntPtr _this);
/// <summary>Hide the splash screen and return to normal display.</summary>
public static void HideSplashScreen()
{
	HideSplashScreen(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowSplashScreen(IntPtr _this);
/// <summary>Show the splash screen and override the VR display</summary>
public static void ShowSplashScreen()
{
	ShowSplashScreen(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSplashScreen(IntPtr _this,IntPtr Texture,ref FVector2D Scale,ref FVector2D Offset,int bShowLoadingMovie,int bShowOnSet);
/// <summary>
/// Set splash screen attributes
/// @param Texture                        (in) A texture to be used for the splash. B8R8G8A8 format.
/// @param Scale                          (in) Scale of the texture.
/// @param Offset                         (in) Position from which to start rendering the texture.
/// @param ShowLoadingMovie       (in) Whether the splash screen presents loading movies.
/// </summary>
public static void SetSplashScreen(UTexture Texture,FVector2D Scale=default(FVector2D),FVector2D Offset=default(FVector2D),bool bShowLoadingMovie=false,bool bShowOnSet=false)
{
	SetSplashScreen(IntPtr.Zero,Texture,ref Scale,ref Offset,bShowLoadingMovie?1:0,bShowOnSet?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
