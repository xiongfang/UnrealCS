using System;
namespace UnrealEngine
{
	public partial class UPlanarReflectionComponent:USceneCaptureComponent
	{
		public UBoxComponent PreviewBox;
		
		/// <summary>Controls the strength of normals when distorting the planar reflection.</summary>
		public float NormalDistortionStrength;
		
		/// <summary>The roughness value to prefilter the planar reflection texture with, useful for hiding low resolution.  Larger values have larger GPU cost.</summary>
		public float PrefilterRoughness;
		
		/// <summary>The distance at which the prefilter roughness value will be achieved.</summary>
		public float PrefilterRoughnessDistance;
		
		/// <summary>Downsample percent, can be used to reduce GPU time rendering the planar reflection.</summary>
		public int ScreenPercentage;
		
		/// <summary>
		/// Additional FOV used when rendering to the reflection texture.
		/// This is useful when normal distortion is causing reads outside the reflection texture.
		/// Larger values increase rendering thread and GPU cost, as more objects and triangles have to be rendered into the planar reflection.
		/// </summary>
		public float ExtraFOV;
		
		public float DistanceFromPlaneFadeStart;
		
		public float DistanceFromPlaneFadeEnd;
		
		/// <summary>Receiving pixels at this distance from the reflection plane will begin to fade out the planar reflection.</summary>
		public float DistanceFromPlaneFadeoutStart;
		
		/// <summary>Receiving pixels at this distance from the reflection plane will have completely faded out the planar reflection.</summary>
		public float DistanceFromPlaneFadeoutEnd;
		
		/// <summary>Receiving pixels whose normal is at this angle from the reflection plane will begin to fade out the planar reflection.</summary>
		public float AngleFromPlaneFadeStart;
		
		/// <summary>Receiving pixels whose normal is at this angle from the reflection plane will have completely faded out the planar reflection.</summary>
		public float AngleFromPlaneFadeEnd;
		
		/// <summary>
		/// Whether to render the scene as two-sided, which can be useful to hide artifacts where normal distortion would read 'under' an object that has been clipped by the reflection plane.
		/// With this setting enabled, the backfaces of a mesh would be displayed in the clipped region instead of the background which is potentially a bright sky.
		/// Be sure to add the water plane to HiddenActors if enabling this, as the water plane will now block the reflection.
		/// </summary>
		public bool bRenderSceneTwoSided;
		
		
	}
	
}
