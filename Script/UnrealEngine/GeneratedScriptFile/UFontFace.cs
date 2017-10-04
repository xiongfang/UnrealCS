using System;
namespace UnrealEngine
{
	public partial class UFontFace:UObject
	{
		/// <summary>The filename of the font face we were created from. This may not always exist on disk, as we may have previously loaded and cached the font data inside this asset.</summary>
		public FString SourceFilename;
		
		
	}
	
}
