#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FNameCurve
	{
		public TStructArray<FNameCurveKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FNameCurveKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+88, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+88, false);}}}
			
		}
		[FieldOffset(8)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
