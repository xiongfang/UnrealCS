#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Saved editor viewport state information</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FLevelViewportInfo
	{
		/// <summary>Where the camera is positioned within the viewport.</summary>
		[FieldOffset(0)]
		public FVector CamPosition;
		/// <summary>The camera's position within the viewport.</summary>
		[FieldOffset(12)]
		public FRotator CamRotation;
		/// <summary>The zoom value  for orthographic mode.</summary>
		[FieldOffset(24)]
		public float CamOrthoZoom;
		/// <summary>Whether camera settings have been systematically changed since the last level viewport update.</summary>
		public bool CamUpdated
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
