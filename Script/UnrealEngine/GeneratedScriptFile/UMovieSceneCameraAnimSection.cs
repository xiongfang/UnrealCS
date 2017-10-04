using System;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraAnimSection:UMovieSceneSection
	{
		public FMovieSceneCameraAnimSectionData AnimData;
		
		/// <summary>Deprecated members</summary>
		public UCameraAnim CameraAnim;
		
		public float PlayRate;
		
		public float PlayScale;
		
		public float BlendInTime;
		
		public float BlendOutTime;
		
		public bool bLooping;
		
		
	}
	
}
