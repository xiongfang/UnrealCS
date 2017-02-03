#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FCurveEdTab
	{
		[FieldOffset(0)]
		public FString TabName;
		public TStructArray<FCurveEdEntry> Curves
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FCurveEdEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		[FieldOffset(32)]
		public float ViewStartInput;
		[FieldOffset(36)]
		public float ViewEndInput;
		[FieldOffset(40)]
		public float ViewStartOutput;
		[FieldOffset(44)]
		public float ViewEndOutput;
		
	}
	
}
#endif
#endif
