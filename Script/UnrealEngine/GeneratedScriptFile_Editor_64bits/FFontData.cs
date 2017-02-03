#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Payload data describing an individual font in a typeface.</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FFontData
	{
		/// <summary>The filename of the font to use - this may not always exist on disk, as we may have previously loaded and cached the font data inside an asset</summary>
		[FieldOffset(0)]
		public FString FontFilename;
		/// <summary>The data associated with the font</summary>
		/// <summary>The hinting algorithm to use with the font</summary>
		[FieldOffset(24)]
		public EFontHinting Hinting;
		/// <summary>The data associated with the font - this should always be filled in providing the source font filename is valid</summary>
		public TStructArray<byte> FontData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
