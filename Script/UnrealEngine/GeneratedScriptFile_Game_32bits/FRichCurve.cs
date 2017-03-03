#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=84)]
	public partial struct FRichCurve
	{
		[FieldOffset(64)]
		public ERichCurveExtrapolation PreInfinityExtrap;
		[FieldOffset(65)]
		public ERichCurveExtrapolation PostInfinityExtrap;
		[FieldOffset(68)]
		public float DefaultValue;
		public TStructArray<FRichCurveKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FRichCurveKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+72, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+72, false);}}}
			
		}
		[FieldOffset(4)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
