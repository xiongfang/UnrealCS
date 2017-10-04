using System;
namespace UnrealEngine
{
	public partial struct FMinimalViewInfo
	{
		/// <summary>Location</summary>
		public FVector Location;
		/// <summary>Rotation</summary>
		public FRotator Rotation;
		/// <summary>The field of view (in degrees) in perspective mode (ignored in Orthographic mode)</summary>
		public float FOV;
		/// <summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
		public float OrthoWidth;
		/// <summary>The near plane distance of the orthographic view (in world units)</summary>
		public float OrthoNearClipPlane;
		/// <summary>The far plane distance of the orthographic view (in world units)</summary>
		public float OrthoFarClipPlane;
		/// <summary>Aspect Ratio (Width/Height); ignored unless bConstrainAspectRatio is true</summary>
		public float AspectRatio;
		/// <summary>If bConstrainAspectRatio is true, black bars will be added if the destination view has a different aspect ratio than this camera requested.</summary>
		public bool bConstrainAspectRatio;
		/// <summary>If true, account for the field of view angle when computing which level of detail to use for meshes.</summary>
		public bool bUseFieldOfViewForLOD;
		/// <summary>The type of camera</summary>
		public ECameraProjectionMode ProjectionMode;
		/// <summary>Indicates if PostProcessSettings should be applied.</summary>
		public float PostProcessBlendWeight;
		/// <summary>Post-process settings to use if PostProcessBlendWeight is non-zero.</summary>
		public FPostProcessSettings PostProcessSettings;
		/// <summary>Off-axis / off-center projection offset as proportion of screen dimensions</summary>
		public FVector2D OffCenterProjectionOffset;
		
	}
	
}
