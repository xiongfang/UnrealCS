#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FCurveEdTab
	{
		[FieldOffset(0)]
		public FString TabName;
		public TStructArray<FCurveEdEntry> Curves
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FCurveEdEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+12, false);}}}
			
		}
		[FieldOffset(24)]
		public float ViewStartInput;
		[FieldOffset(28)]
		public float ViewEndInput;
		[FieldOffset(32)]
		public float ViewStartOutput;
		[FieldOffset(36)]
		public float ViewEndOutput;
		
	}
	
}
#endif
#endif
