#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Information for one toggle in the track.</summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FToggleTrackKey
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(4)]
		public ETrackToggleAction ToggleAction;
		
	}
	
}
#endif
#endif
