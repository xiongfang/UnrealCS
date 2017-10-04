using System;
namespace UnrealEngine
{
	/// <summary>Payload data describing an individual font in a typeface. Keep this lean as it's also used as a key!</summary>
	public partial struct FFontData
	{
		/// <summary>
		/// The filename of the font to use.
		/// This variable is ignored if we have a font face asset, and is set to the .ufont file in a cooked build.
		/// </summary>
		public FString FontFilename;
		/// <summary>Font data v3. This points to a font face asset.</summary>
		public UObject FontFaceAsset;
		/// <summary>
		/// Legacy font data v2. This used to be where font data was stored prior to font face assets.
		/// This can be removed once we no longer support loading packages older than FEditorObjectVersion::AddedFontFaceAssets (as can UFontBulkData itself).
		/// </summary>
		public UFontBulkData BulkDataPtr;
		
	}
	
}
