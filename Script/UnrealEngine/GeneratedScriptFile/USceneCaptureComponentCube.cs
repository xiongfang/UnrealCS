using System;
namespace UnrealEngine
{
	public partial class USceneCaptureComponentCube:USceneCaptureComponent
	{
		/// <summary>
		/// Render the scene to the texture target immediately.
		/// This should not be used if bCaptureEveryFrame is enabled, or the scene capture will render redundantly.
		/// </summary>
		public extern void CaptureScene();
		/// <summary>Temporary render target that can be used by the editor.</summary>
		public UTextureRenderTargetCube TextureTarget;
		
		
	}
	
}
