#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FCompositeFont
	{
		[FieldOffset(0)]
		public FTypeface DefaultTypeface;
		public TStructArray<FCompositeSubFont> SubTypefaces
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FCompositeSubFont>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+12, false);}}}
			
		}
		
	}
	
}
#endif
#endif
