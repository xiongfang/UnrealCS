#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FCompositeSubFont
	{
		[FieldOffset(0)]
		public FTypeface Typeface;
		public TStructArray<FInt32Range> CharacterRanges
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FInt32Range>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		[FieldOffset(32)]
		public float ScalingFactor;
		
	}
	
}
#endif
#endif
