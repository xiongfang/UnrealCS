using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Note: Check UMaterialInstance::Serialize if changed!</summary>
	public enum EMaterialShadingModel:byte
	{
		MSM_Unlit=0,
		MSM_DefaultLit=1,
		MSM_Subsurface=2,
		MSM_PreintegratedSkin=3,
		MSM_ClearCoat=4,
		MSM_SubsurfaceProfile=5,
		MSM_TwoSidedFoliage=6,
		MSM_Hair=7,
		MSM_Cloth=8,
		MSM_Eye=9,
		MSM_MAX=10,
		
	}
	
}
