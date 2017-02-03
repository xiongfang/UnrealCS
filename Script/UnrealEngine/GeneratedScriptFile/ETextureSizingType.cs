using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ETextureSizingType:byte
	{
		TextureSizingType_UseSingleTextureSize=0,
		TextureSizingType_UseAutomaticBiasedSizes=1,
		TextureSizingType_UseManualOverrideTextureSize=2,
		TextureSizingType_UseSimplygonAutomaticSizing=3,
		TextureSizingType_MAX=4,
		
	}
	
}
