using System;
namespace UnrealEngine
{
	public partial struct FMovieSceneSkeletalAnimationParams
	{
		/// <summary>The animation this section plays</summary>
		public UAnimSequenceBase Animation;
		/// <summary>The offset into the beginning of the animation clip</summary>
		public float StartOffset;
		/// <summary>The offset into the end of the animation clip</summary>
		public float EndOffset;
		/// <summary>The playback rate of the animation clip</summary>
		public float PlayRate;
		/// <summary>Reverse the playback of the animation clip</summary>
		public bool bReverse;
		/// <summary>The slot name to use for the animation</summary>
		public FName SlotName;
		/// <summary>The weight curve for this animation section</summary>
		public FRichCurve Weight;
		
	}
	
}
