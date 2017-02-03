#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=84)]
	public partial struct FIntegralCurve
	{
		public TStructArray<FIntegralKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FIntegralKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+64, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+64, false);}}}
			
		}
		[FieldOffset(76)]
		public int DefaultValue;
		public bool bUseDefaultValueBeforeFirstKey
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 80, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 80, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(4)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
