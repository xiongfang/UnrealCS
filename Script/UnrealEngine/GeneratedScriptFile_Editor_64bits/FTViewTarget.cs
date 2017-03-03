#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A ViewTarget is the primary actor the camera is associated with.</summary>
	[StructLayout(LayoutKind.Explicit,Size=1328)]
	public partial struct FTViewTarget
	{
		/// <summary>Target Actor used to compute POV</summary>
		/// <summary>Computed point of view</summary>
		[FieldOffset(16)]
		public FMinimalViewInfo POV;
		/// <summary>PlayerState (used to follow same player through pawn transitions, etc., when spectating)</summary>
		
	}
	
}
#endif
#endif
