using System;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraShakeSection:UMovieSceneSection
	{
		public FMovieSceneCameraShakeSectionData ShakeData;
		
		public TSubclassOf<UCameraShake>  ShakeClass;
		
		public float PlayScale;
		
		public ECameraAnimPlaySpace PlaySpace;
		
		public FRotator UserDefinedPlaySpace;
		
		
	}
	
}
