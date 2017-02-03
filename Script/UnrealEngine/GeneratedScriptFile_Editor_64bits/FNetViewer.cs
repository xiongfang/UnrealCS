#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>stores information on a viewer that actors need to be checked against for relevancy</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FNetViewer
	{
		/// <summary>The "controlling net object" associated with this view (typically player controller)</summary>
		/// <summary>The actor that is being directly viewed, usually a pawn.  Could also be the net actor of consequence</summary>
		/// <summary>Where the viewer is looking from</summary>
		[FieldOffset(24)]
		public FVector ViewLocation;
		/// <summary>Direction the viewer is looking</summary>
		[FieldOffset(36)]
		public FVector ViewDir;
		
	}
	
}
#endif
#endif
