#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=76)]
	public partial struct FNameCurve
	{
		public TStructArray<FNameCurveKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FNameCurveKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+64, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+64, false);}}}
			
		}
		[FieldOffset(4)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
