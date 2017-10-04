using System;
namespace UnrealEngine
{
	/// <summary>Helper struct for creating sub tracks supported by this track</summary>
	public partial struct FSupportedSubTrackInfo
	{
		/// <summary>The sub track class which is supported by this track</summary>
		public TSubclassOf<UInterpTrack>  SupportedClass;
		/// <summary>The name of the subtrack</summary>
		public FString SubTrackName;
		/// <summary>Index into the any subtrack group this subtrack belongs to (can be -1 for no group)</summary>
		public int GroupIndex;
		
	}
	
}
