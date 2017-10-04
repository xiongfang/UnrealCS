using System;
namespace UnrealEngine
{
	public partial struct FMovieSceneCameraAnimSectionData
	{
		/// <summary>The camera anim to play</summary>
		public UCameraAnim CameraAnim;
		/// <summary>How fast to play back the animation.</summary>
		public float PlayRate;
		/// <summary>Scalar to control intensity of the animation.</summary>
		public float PlayScale;
		public float BlendInTime;
		public float BlendOutTime;
		public bool bLooping;
		
	}
	
}
