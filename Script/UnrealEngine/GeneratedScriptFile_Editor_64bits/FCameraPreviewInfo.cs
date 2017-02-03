#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Preview APawn class for this track</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FCameraPreviewInfo
	{
		/// <summary>for now this is read-only. It has maintenance issue to be resolved if I enable this.</summary>
		[FieldOffset(16)]
		public FVector Location;
		[FieldOffset(28)]
		public FRotator Rotation;
		/// <summary>APawn Inst - CameraAnimInst doesn't really exist in editor *</summary>
		
	}
	
}
#endif
#endif
