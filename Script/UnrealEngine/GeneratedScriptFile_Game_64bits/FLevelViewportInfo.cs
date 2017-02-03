#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FLevelViewportInfo
	{
		[FieldOffset(0)]
		public FVector CamPosition;
		[FieldOffset(12)]
		public FRotator CamRotation;
		[FieldOffset(24)]
		public float CamOrthoZoom;
		public bool CamUpdated
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
