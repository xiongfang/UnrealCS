#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=88)]
	public partial struct FStringCurve
	{
		[FieldOffset(64)]
		public FString DefaultValue;
		public TStructArray<FStringCurveKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FStringCurveKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+76, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+76, false);}}}
			
		}
		[FieldOffset(4)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
