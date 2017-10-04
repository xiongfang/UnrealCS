using System;
namespace UnrealEngine
{
	public partial class UMovieSceneSkeletalAnimationSection:UMovieSceneSection
	{
		public FMovieSceneSkeletalAnimationParams Params;
		
		public UAnimSequence AnimSequence;
		
		public UAnimSequenceBase Animation;
		
		public float StartOffset;
		
		public float EndOffset;
		
		public float PlayRate;
		
		public bool bReverse;
		
		public FName SlotName;
		
		
	}
	
}
