#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Payload data describing an individual font in a typeface. Keep this lean as it's also used as a key!</summary>
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FFontData
	{
		/// <summary>
		/// The filename of the font to use.
		/// This variable is ignored if we have a font face asset, and is set to the .ufont file in a cooked build.
		/// </summary>
		[FieldOffset(0)]
		public FString FontFilename;
		/// <summary>Font data v3. This points to a font face asset.</summary>
		/// <summary>
		/// Legacy font data v2. This used to be where font data was stored prior to font face assets.
		/// This can be removed once we no longer support loading packages older than FEditorObjectVersion::AddedFontFaceAssets (as can UFontBulkData itself).
		/// </summary>
		/// <summary>
		/// Legacy font data v1. This used to be where font data was stored prior to font bulk data.
		/// This can be removed once we no longer support loading packages older than VER_UE4_SLATE_BULK_FONT_DATA.
		/// </summary>
		public TStructArray<byte> FontData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		
	}
	
}
#endif
#endif
