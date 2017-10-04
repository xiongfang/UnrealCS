using System;
namespace UnrealEngine
{
	/// <summary>
	/// Debug property display functionality to interact with this, use "display", "displayall", "displayclear"
	/// @see UGameViewportClient
	/// @see FDebugDisplayProperty
	/// @see DrawStatsHUD
	/// </summary>
	public partial struct FDebugDisplayProperty
	{
		/// <summary>the object whose property to display. If this is a class, all objects of that class are drawn.</summary>
		public UObject Obj;
		/// <summary>if Obj is a class and WithinClass is not nullptr, further limit the display to objects that have an Outer of WithinClass</summary>
		public TSubclassOf<UObject>  WithinClass;
		
	}
	
}
