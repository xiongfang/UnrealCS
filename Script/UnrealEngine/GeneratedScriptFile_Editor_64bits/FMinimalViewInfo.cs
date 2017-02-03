#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1296)]
	public partial struct FMinimalViewInfo
	{
		/// <summary>Location</summary>
		[FieldOffset(0)]
		public FVector Location;
		/// <summary>Rotation</summary>
		[FieldOffset(12)]
		public FRotator Rotation;
		/// <summary>The field of view (in degrees) in perspective mode (ignored in Orthographic mode)</summary>
		[FieldOffset(24)]
		public float FOV;
		/// <summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
		[FieldOffset(28)]
		public float OrthoWidth;
		/// <summary>The near plane distance of the orthographic view (in world units)</summary>
		[FieldOffset(32)]
		public float OrthoNearClipPlane;
		/// <summary>The far plane distance of the orthographic view (in world units)</summary>
		[FieldOffset(36)]
		public float OrthoFarClipPlane;
		/// <summary>Aspect Ratio (Width/Height); ignored unless bConstrainAspectRatio is true</summary>
		[FieldOffset(40)]
		public float AspectRatio;
		/// <summary>If bConstrainAspectRatio is true, black bars will be added if the destination view has a different aspect ratio than this camera requested.</summary>
		public bool bConstrainAspectRatio
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 44, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 44, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If true, account for the field of view angle when computing which level of detail to use for meshes.</summary>
		public bool bUseFieldOfViewForLOD
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 44, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 44, 1, 0, 2, 2); } }}
			
		}
		/// <summary>The type of camera</summary>
		[FieldOffset(48)]
		public ECameraProjectionMode ProjectionMode;
		/// <summary>Indicates if PostProcessSettings should be applied.</summary>
		[FieldOffset(52)]
		public float PostProcessBlendWeight;
		/// <summary>Post-process settings to use if PostProcessBlendWeight is non-zero.</summary>
		[FieldOffset(64)]
		public FPostProcessSettings PostProcessSettings;
		/// <summary>Off-axis / off-center projection offset as proportion of screen dimensions</summary>
		[FieldOffset(1280)]
		public FVector2D OffCenterProjectionOffset;
		
	}
	
}
#endif
#endif
