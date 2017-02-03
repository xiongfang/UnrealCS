#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Temporary array for tracking 'solo' emitter mode.
	/// Entry will be true if emitter was enabled
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FLODSoloTrack
	{
		public TStructArray<byte> SoloEnableSetting
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
