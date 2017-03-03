#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FSkeletalMaterial
	{
		public bool bEnableShadowCasting
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 1, 255); } }}
			
		}
		public bool bRecomputeTangent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(8)]
		public FName MaterialSlotName;
		[FieldOffset(16)]
		public FMeshUVChannelInfo UVChannelData;
		
	}
	
}
#endif
#endif
