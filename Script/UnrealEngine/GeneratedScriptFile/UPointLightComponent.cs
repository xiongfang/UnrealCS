using System;
namespace UnrealEngine
{
	public partial class UPointLightComponent:ULightComponent
	{
		public extern void SetSourceLength(float NewValue);
		public extern void SetSourceRadius(float bNewValue);
		public extern void SetLightFalloffExponent(float NewLightFalloffExponent);
		public extern void SetAttenuationRadius(float NewRadius);
		public float Radius;
		
		/// <summary>
		/// Bounds the light's visible influence.
		/// This clamping of the light's influence is not physically correct but very important for performance, larger lights cost more.
		/// </summary>
		public float AttenuationRadius;
		
		/// <summary>
		/// Whether to use physically based inverse squared distance falloff, where AttenuationRadius is only clamping the light's contribution.
		/// Disabling inverse squared falloff can be useful when placing fill lights (don't want a super bright spot near the light).
		/// When enabled, the light's Intensity is in units of lumens, where 1700 lumens is a 100W lightbulb.
		/// When disabled, the light's Intensity is a brightness scale.
		/// </summary>
		public bool bUseInverseSquaredFalloff;
		
		/// <summary>
		/// Controls the radial falloff of the light when UseInverseSquaredFalloff is disabled.
		/// 2 is almost linear and very unrealistic and around 8 it looks reasonable.
		/// With large exponents, the light has contribution to only a small area of its influence radius but still costs the same as low exponents.
		/// </summary>
		public float LightFalloffExponent;
		
		/// <summary>
		/// Radius of light source shape.
		/// Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts.
		/// </summary>
		public float SourceRadius;
		
		/// <summary>
		/// Length of light source shape.
		/// Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts.
		/// </summary>
		public float SourceLength;
		
		/// <summary>The Lightmass settings for this object.</summary>
		public FLightmassPointLightSettings LightmassSettings;
		
		
	}
	
}
