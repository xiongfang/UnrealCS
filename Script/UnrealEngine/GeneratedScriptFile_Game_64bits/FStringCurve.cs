#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=120)]
	public partial struct FStringCurve
	{
		[FieldOffset(88)]
		public FString DefaultValue;
		public TStructArray<FStringCurveKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FStringCurveKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+104, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+104, false);}}}
			
		}
		[FieldOffset(8)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
