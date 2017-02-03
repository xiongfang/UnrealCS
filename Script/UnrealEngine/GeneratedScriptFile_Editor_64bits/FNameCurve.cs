#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Implements a curve of FNames.</summary>
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FNameCurve
	{
		/// <summary>Sorted array of keys</summary>
		public TStructArray<FNameCurveKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FNameCurveKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+88, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+88, false);}}}
			
		}
		/// <summary>Map of which key handles go to which indices.</summary>
		[FieldOffset(8)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
