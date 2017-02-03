#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FAssetEditorOrbitCameraPosition
	{
		/// <summary>Whether or not this has been set to a valid value</summary>
		public bool bIsSet
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>The position to orbit the camera around</summary>
		[FieldOffset(4)]
		public FVector CamOrbitPoint;
		/// <summary>The distance of the camera from the orbit point</summary>
		[FieldOffset(16)]
		public FVector CamOrbitZoom;
		/// <summary>The rotation to apply around the orbit point</summary>
		[FieldOffset(28)]
		public FRotator CamOrbitRotation;
		
	}
	
}
#endif
#endif
