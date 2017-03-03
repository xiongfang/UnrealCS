#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A curve of events</summary>
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FMovieSceneEventSectionData
	{
		/// <summary>Sorted array of key times</summary>
		public TStructArray<float> KeyTimes
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>Array of values that correspond to each key time</summary>
		public TStructArray<FEventPayload> KeyValues
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FEventPayload>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
