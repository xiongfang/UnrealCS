using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Additional information about a selection event</summary>
	public enum ESelectInfo:byte
	{
		/// <summary>User selected via a key press</summary>
		OnKeyPress=0,
		/// <summary>User selected by navigating to the item</summary>
		OnNavigation=1,
		/// <summary>User selected by clicking on the item</summary>
		OnMouseClick=2,
		/// <summary>Selection was directly set in code</summary>
		Direct=3,
		ESelectInfo_MAX=4,
		
	}
	
}
