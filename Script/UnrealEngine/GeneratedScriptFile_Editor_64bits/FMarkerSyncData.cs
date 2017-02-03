#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FMarkerSyncData
	{
		/// <summary>Authored Sync markers</summary>
		public TStructArray<FAnimSyncMarker> AuthoredSyncMarkers
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FAnimSyncMarker>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
