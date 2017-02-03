#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A line of subtitle text and the time at which it should be displayed.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSubtitleCue
	{
		/// <summary>The text to appear in the subtitle.</summary>
		[FieldOffset(0)]
		public FText Text;
		/// <summary>The time at which the subtitle is to be displayed, in seconds relative to the beginning of the line.</summary>
		[FieldOffset(24)]
		public float Time;
		
	}
	
}
#endif
#endif
