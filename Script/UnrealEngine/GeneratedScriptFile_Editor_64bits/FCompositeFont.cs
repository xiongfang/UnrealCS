#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FCompositeFont
	{
		/// <summary>The default typeface that will be used when not overridden by a sub-typeface</summary>
		[FieldOffset(0)]
		public FTypeface DefaultTypeface;
		/// <summary>Sub-typefaces to use for a specific set of characters</summary>
		public TStructArray<FCompositeSubFont> SubTypefaces
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FCompositeSubFont>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
