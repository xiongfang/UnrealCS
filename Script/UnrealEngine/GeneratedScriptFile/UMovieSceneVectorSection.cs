using System;
namespace UnrealEngine
{
	public partial class UMovieSceneVectorSection:UMovieSceneSection
	{
		/// <summary>Vector t</summary>
		public FRichCurve Curves;
		
		/// <summary>How many curves are actually used</summary>
		public int ChannelsUsed;
		
		
	}
	
}
