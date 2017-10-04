using System;
namespace UnrealEngine
{
	public partial class UAtmosphericFogComponent:USceneComponent
	{
		/// <summary>Set PrecomputeParams, only valid in Editor mode</summary>
		public extern void SetPrecomputeParams(float DensityHeight,int MaxScatteringOrder,int InscatterAltitudeSampleNum);
		/// <summary>Set DisableGroundScattering</summary>
		public extern void DisableGroundScattering(bool NewGroundScattering);
		/// <summary>Set DisableSunDisk</summary>
		public extern void DisableSunDisk(bool NewSunDisk);
		/// <summary>Set DistanceOffset</summary>
		public extern void SetDistanceOffset(float NewDistanceOffset);
		/// <summary>Set StartDistance</summary>
		public extern void SetStartDistance(float NewStartDistance);
		/// <summary>Set AltitudeScale</summary>
		public extern void SetAltitudeScale(float NewAltitudeScale);
		/// <summary>Set DistanceScale</summary>
		public extern void SetDistanceScale(float NewDistanceScale);
		/// <summary>Set DensityOffset</summary>
		public extern void SetDensityOffset(float NewDensityOffset);
		/// <summary>Set DensityMultiplier</summary>
		public extern void SetDensityMultiplier(float NewDensityMultiplier);
		/// <summary>Set FogMultiplier</summary>
		public extern void SetFogMultiplier(float NewFogMultiplier);
		/// <summary>Set SunMultiplier</summary>
		public extern void SetSunMultiplier(float NewSunMultiplier);
		/// <summary>Set color of the light</summary>
		public extern void SetDefaultLightColor(FLinearColor NewLightColor);
		/// <summary>Set brightness of the light</summary>
		public extern void SetDefaultBrightness(float NewBrightness);
		/// <summary>Global scattering factor.</summary>
		public float SunMultiplier;
		
		/// <summary>Scattering factor on object.</summary>
		public float FogMultiplier;
		
		/// <summary>Fog density control factor.</summary>
		public float DensityMultiplier;
		
		/// <summary>Fog density offset to control opacity [-1.f ~ 1.f].</summary>
		public float DensityOffset;
		
		/// <summary>Distance scale.</summary>
		public float DistanceScale;
		
		/// <summary>Altitude scale (only Z scale).</summary>
		public float AltitudeScale;
		
		/// <summary>Distance offset, in km (to handle large distance)</summary>
		public float DistanceOffset;
		
		/// <summary>Ground offset.</summary>
		public float GroundOffset;
		
		/// <summary>Start Distance.</summary>
		public float StartDistance;
		
		/// <summary>Distance offset, in km (to handle large distance)</summary>
		public float SunDiscScale;
		
		/// <summary>Default light brightness. Used when there is no sunlight placed in the level. Unit is lumens</summary>
		public float DefaultBrightness;
		
		/// <summary>Default light color. Used when there is no sunlight placed in the level.</summary>
		public FColor DefaultLightColor;
		
		/// <summary>Disable Sun Disk rendering.</summary>
		public bool bDisableSunDisk;
		
		/// <summary>Disable Color scattering from ground.</summary>
		public bool bDisableGroundScattering;
		
		public FAtmospherePrecomputeParameters PrecomputeParams;
		
		public UTexture2D TransmittanceTexture;
		
		public UTexture2D IrradianceTexture;
		
		
	}
	
}
