using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMouseCursor:byte
	{
		/// <summary>Causes no mouse cursor to be visible.</summary>
		None=0,
		/// <summary>Default cursor (arrow).</summary>
		Default=1,
		/// <summary>Text edit beam.</summary>
		TextEditBeam=2,
		/// <summary>Resize horizontal.</summary>
		ResizeLeftRight=3,
		/// <summary>Resize vertical.</summary>
		ResizeUpDown=4,
		/// <summary>Resize diagonal.</summary>
		ResizeSouthEast=5,
		/// <summary>Resize other diagonal.</summary>
		ResizeSouthWest=6,
		/// <summary>MoveItem.</summary>
		CardinalCross=7,
		/// <summary>Target Cross.</summary>
		Crosshairs=8,
		/// <summary>Hand cursor.</summary>
		Hand=9,
		/// <summary>Grab Hand cursor.</summary>
		GrabHand=10,
		/// <summary>Grab Hand cursor closed.</summary>
		GrabHandClosed=11,
		/// <summary>a circle with a diagonal line through it.</summary>
		SlashedCircle=12,
		/// <summary>Eye-dropper cursor for picking colors.</summary>
		EyeDropper=13,
		EMouseCursor_MAX=14,
		
	}
	
}
