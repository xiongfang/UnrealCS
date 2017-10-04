using System;
namespace UnrealEngine
{
	public partial class UStereoLayerFunctionLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>
		/// Enables/disables splash screen to be automatically shown when LoadMap is called.
		/// @param       bAutoShowEnabled        (in)    True, if automatic showing of splash screens is enabled when map is being loaded.
		/// </summary>
		public extern static void EnableAutoLoadingSplashScreen(bool InAutoShowEnabled);
		/// <summary>Hide the splash screen and return to normal display.</summary>
		public extern static void HideSplashScreen();
		/// <summary>Show the splash screen and override the VR display</summary>
		public extern static void ShowSplashScreen();
		/// <summary>
		/// Set splash screen attributes
		/// @param Texture                        (in) A texture to be used for the splash. B8R8G8A8 format.
		/// @param Scale                          (in) Scale of the texture.
		/// @param Offset                         (in) Position from which to start rendering the texture.
		/// @param ShowLoadingMovie       (in) Whether the splash screen presents loading movies.
		/// </summary>
		public extern static void SetSplashScreen(UTexture Texture,FVector2D Scale=default(FVector2D),FVector2D Offset=default(FVector2D),bool bShowLoadingMovie=false,bool bShowOnSet=false);
		
	}
	
}
