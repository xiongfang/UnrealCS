#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=52)]
	public partial struct FBranchingPoint
	{
		[FieldOffset(36)]
		public FName EventName;
		[FieldOffset(44)]
		public float DisplayTime;
		[FieldOffset(48)]
		public float TriggerTimeOffset;
		[FieldOffset(8)]
		public int SlotIndex;
		[FieldOffset(12)]
		public int SegmentIndex;
		[FieldOffset(16)]
		public EAnimLinkMethod LinkMethod;
		[FieldOffset(17)]
		public EAnimLinkMethod CachedLinkMethod;
		[FieldOffset(20)]
		public float SegmentBeginTime;
		[FieldOffset(24)]
		public float SegmentLength;
		[FieldOffset(28)]
		public float LinkValue;
		
	}
	
}
#endif
#endif
