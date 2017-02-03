#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Keyframe position data for one track.  Pos(i) occurs at Time(i).  Pos.Num() always equals Time.Num().</summary>
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FAnimNotifyTrack
	{
		[FieldOffset(0)]
		public FName TrackName;
		[FieldOffset(12)]
		public FLinearColor TrackColor;
		
	}
	
}
#endif
#endif
