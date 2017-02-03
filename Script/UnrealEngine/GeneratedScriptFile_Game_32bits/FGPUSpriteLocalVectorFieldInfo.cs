#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FGPUSpriteLocalVectorFieldInfo
	{
		[FieldOffset(16)]
		public FTransform Transform;
		[FieldOffset(64)]
		public FRotator MinInitialRotation;
		[FieldOffset(76)]
		public FRotator MaxInitialRotation;
		[FieldOffset(88)]
		public FRotator RotationRate;
		[FieldOffset(100)]
		public float Intensity;
		[FieldOffset(104)]
		public float Tightness;
		public bool bIgnoreComponentTransform
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 1, 1); } }}
			
		}
		public bool bTileX
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 2, 2); } }}
			
		}
		public bool bTileY
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 4, 4); } }}
			
		}
		public bool bTileZ
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 8, 8); } }}
			
		}
		public bool bUseFixDT
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 16, 16); } }}
			
		}
		
	}
	
}
#endif
#endif
