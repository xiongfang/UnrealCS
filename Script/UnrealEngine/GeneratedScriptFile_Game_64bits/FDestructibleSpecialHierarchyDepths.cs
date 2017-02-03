#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FDestructibleSpecialHierarchyDepths
	{
		[FieldOffset(0)]
		public int SupportDepth;
		[FieldOffset(4)]
		public int MinimumFractureDepth;
		public bool bEnableDebris
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(12)]
		public int DebrisDepth;
		[FieldOffset(16)]
		public int EssentialDepth;
		
	}
	
}
#endif
#endif
