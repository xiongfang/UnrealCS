using System;
namespace UnrealEngine
{
	public partial class USceneCaptureComponent2D:USceneCaptureComponent
	{
		/// <summary>
		/// Render the scene to the texture target immediately.
		/// This should not be used if bCaptureEveryFrame is enabled, or the scene capture will render redundantly.
		/// </summary>
		public extern void CaptureScene();
		public ECameraProjectionMode ProjectionType;
		
		/// <summary>Camera field of view (in degrees).</summary>
		public float FOVAngle;
		
		/// <summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
		public float OrthoWidth;
		
		/// <summary>Output render target of the scene capture that can be read in materals.</summary>
		public UTextureRenderTarget2D TextureTarget;
		
		public ESceneCaptureSource CaptureSource;
		
		/// <summary>When enabled, the scene capture will composite into the render target instead of overwriting its contents.</summary>
		public ESceneCaptureCompositeMode CompositeMode;
		
		public FPostProcessSettings PostProcessSettings;
		
		/// <summary>Range (0.0, 1.0) where 0 indicates no effect, 1 indicates full effect.</summary>
		public float PostProcessBlendWeight;
		
		/// <summary>Whether a custom projection matrix will be used during rendering. Use with caution. Does not currently affect culling</summary>
		public bool bUseCustomProjectionMatrix;
		
		/// <summary>The custom projection matrix to use</summary>
		public FMatrix CustomProjectionMatrix;
		
		/// <summary>
		/// Enables a clip plane while rendering the scene capture which is useful for portals.
		/// The global clip plane must be enabled in the renderer project settings for this to work.
		/// </summary>
		public bool bEnableClipPlane;
		
		/// <summary>Base position for the clip plane, can be any position on the plane.</summary>
		public FVector ClipPlaneBase;
		
		/// <summary>Normal for the plane.</summary>
		public FVector ClipPlaneNormal;
		
		
	}
	
}
