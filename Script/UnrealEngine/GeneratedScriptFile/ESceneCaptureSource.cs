using System;
namespace UnrealEngine
{
	public enum ESceneCaptureSource:byte
	{
		SCS_SceneColorHDR=0,
		SCS_SceneColorHDRNoAlpha=1,
		SCS_FinalColorLDR=2,
		SCS_SceneColorSceneDepth=3,
		SCS_SceneDepth=4,
		SCS_Normal=5,
		SCS_BaseColor=6,
		SCS_MAX=7,
		
	}
	
}
