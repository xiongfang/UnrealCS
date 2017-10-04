using System;
namespace UnrealEngine
{
	public partial class ASceneCaptureCube:ASceneCapture
	{
		public extern void OnInterpToggle(bool bEnable);
		public USceneCaptureComponentCube CaptureComponentCube;
		
		public UDrawFrustumComponent DrawFrustum;
		
		
	}
	
}
