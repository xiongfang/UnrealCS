using System;
namespace UnrealEngine
{
	/// <summary>struct with all the settings we want in USubsurfaceProfile, separate to make it easer to pass this data around in the engine.</summary>
	public partial struct FSubsurfaceProfileStruct
	{
		/// <summary>in world/unreal units (cm)</summary>
		public float ScatterRadius;
		/// <summary>
		/// Specifies the how much of the diffuse light gets into the material,
		/// can be seen as a per-channel mix factor between the original image,
		/// and the SSS-filtered image (called "strength" in SeparableSSS, default there: 0.48, 0.41, 0.28)
		/// </summary>
		public FLinearColor SubsurfaceColor;
		/// <summary>
		/// defines the per-channel falloff of the gradients
		/// produced by the subsurface scattering events, can be used to fine tune the color of the gradients
		/// (called "falloff" in SeparableSSS, default there: 1, 0.37, 0.3)
		/// </summary>
		public FLinearColor FalloffColor;
		
	}
	
}
