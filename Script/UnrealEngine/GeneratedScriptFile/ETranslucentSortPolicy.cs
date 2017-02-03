using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates available options for the translucency sort policy.</summary>
	public enum ETranslucentSortPolicy:byte
	{
		/// <summary>Sort based on distance from camera centerpoint to bounding sphere centerpoint. (Default, best for 3D games.)</summary>
		SortByDistance=0,
		/// <summary>Sort based on the post-projection Z distance to the camera.</summary>
		SortByProjectedZ=1,
		/// <summary>Sort based on the projection onto a fixed axis. (Best for 2D games.)</summary>
		SortAlongAxis=2,
		ETranslucentSortPolicy_MAX=3,
		
	}
	
}
