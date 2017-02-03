using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EWidgetSpace:byte
	{
		/// <summary>The widget is rendered in the world as mesh, it can be occluded like any other mesh in the world.</summary>
		World=0,
		/// <summary>The widget is rendered in the screen, completely outside of the world, never occluded.</summary>
		Screen=1,
		EWidgetSpace_MAX=2,
		
	}
	
}
