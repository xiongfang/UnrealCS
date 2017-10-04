using System;
namespace UnrealEngine
{
	public partial struct FMovieSceneCameraShakeSectionData
	{
		/// <summary>Class of the camera shake to play</summary>
		public TSubclassOf<UCameraShake>  ShakeClass;
		/// <summary>Scalar that affects shake intensity</summary>
		public float PlayScale;
		public ECameraAnimPlaySpace PlaySpace;
		public FRotator UserDefinedPlaySpace;
		
	}
	
}
