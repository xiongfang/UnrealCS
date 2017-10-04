using System;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraCutSection:UMovieSceneSection
	{
		/// <summary>The camera possessable or spawnable that this movie CameraCut uses</summary>
		public FGuid CameraGuid;
		
		/// <summary>The reference frame offset for single thumbnail rendering</summary>
		public float ThumbnailReferenceOffset;
		
		
	}
	
}
