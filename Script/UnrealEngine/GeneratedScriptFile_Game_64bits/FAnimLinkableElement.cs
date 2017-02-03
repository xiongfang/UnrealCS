#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FAnimLinkableElement
	{
		[FieldOffset(16)]
		public int SlotIndex;
		[FieldOffset(20)]
		public int SegmentIndex;
		[FieldOffset(24)]
		public EAnimLinkMethod LinkMethod;
		[FieldOffset(25)]
		public EAnimLinkMethod CachedLinkMethod;
		[FieldOffset(28)]
		public float SegmentBeginTime;
		[FieldOffset(32)]
		public float SegmentLength;
		[FieldOffset(36)]
		public float LinkValue;
		
	}
	
}
#endif
#endif
