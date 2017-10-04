using System;
namespace UnrealEngine
{
	/// <summary>Saved editor viewport state information</summary>
	public partial struct FLevelViewportInfo
	{
		/// <summary>Where the camera is positioned within the viewport.</summary>
		public FVector CamPosition;
		/// <summary>The camera's position within the viewport.</summary>
		public FRotator CamRotation;
		/// <summary>The zoom value  for orthographic mode.</summary>
		public float CamOrthoZoom;
		/// <summary>Whether camera settings have been systematically changed since the last level viewport update.</summary>
		public bool CamUpdated;
		
	}
	
}
