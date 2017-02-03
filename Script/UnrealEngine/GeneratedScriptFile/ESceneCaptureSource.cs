using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESceneCaptureSource:byte
	{
		SCS_SceneColorHDR=0,
		SCS_FinalColorLDR=1,
		SCS_SceneColorSceneDepth=2,
		SCS_SceneDepth=3,
		SCS_Normal=4,
		SCS_BaseColor=5,
		SCS_MAX=6,
		
	}
	
}
