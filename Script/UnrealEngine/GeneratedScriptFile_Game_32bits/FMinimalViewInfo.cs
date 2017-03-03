#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1264)]
	public partial struct FMinimalViewInfo
	{
		[FieldOffset(0)]
		public FVector Location;
		[FieldOffset(12)]
		public FRotator Rotation;
		[FieldOffset(24)]
		public float FOV;
		[FieldOffset(28)]
		public float OrthoWidth;
		[FieldOffset(32)]
		public float OrthoNearClipPlane;
		[FieldOffset(36)]
		public float OrthoFarClipPlane;
		[FieldOffset(40)]
		public float AspectRatio;
		public bool bConstrainAspectRatio
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 44, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 44, 1, 0, 1, 1); } }}
			
		}
		public bool bUseFieldOfViewForLOD
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 44, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 44, 1, 0, 2, 2); } }}
			
		}
		[FieldOffset(48)]
		public ECameraProjectionMode ProjectionMode;
		[FieldOffset(52)]
		public float PostProcessBlendWeight;
		[FieldOffset(64)]
		public FPostProcessSettings PostProcessSettings;
		[FieldOffset(1248)]
		public FVector2D OffCenterProjectionOffset;
		
	}
	
}
#endif
#endif
