#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Definition for a typeface (a family of fonts)</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FTypeface
	{
		/// <summary>The fonts contained within this family</summary>
		public TStructArray<FTypefaceEntry> Fonts
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTypefaceEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
