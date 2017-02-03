using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Note: This is mirrored in Lightmass, be sure to update the blend mode structure and logic there if this changes. // Note: Check UMaterialInstance::Serialize if changed!!</summary>
	public enum EBlendMode:byte
	{
		BLEND_Opaque=0,
		BLEND_Masked=1,
		BLEND_Translucent=2,
		BLEND_Additive=3,
		BLEND_Modulate=4,
		BLEND_AlphaComposite=5,
		BLEND_MAX=6,
		
	}
	
}
