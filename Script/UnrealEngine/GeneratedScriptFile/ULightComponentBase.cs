using System;
namespace UnrealEngine
{
	public partial class ULightComponentBase:USceneComponent
	{
		/// <summary>Gets the light color as a linear color</summary>
		public extern FLinearColor GetLightColor();
		/// <summary>Sets whether this light casts shadows</summary>
		public extern void SetCastShadows(bool bNewValue);
		/// <summary>
		/// GUID used to associate a light component with precomputed shadowing information across levels.
		/// The GUID changes whenever the light position changes.
		/// </summary>
		public FGuid LightGuid;
		
		public float Brightness;
		
		/// <summary>
		/// Total energy that the light emits.
		/// For point/spot lights with inverse squared falloff, this is in units of lumens.  1700 lumens corresponds to a 100W lightbulb.
		/// For other lights, this is just a brightness multiplier.
		/// </summary>
		public float Intensity;
		
		/// <summary>
		/// Filter color of the light.
		/// Note that this can change the light's effective intensity.
		/// </summary>
		public FColor LightColor;
		
		/// <summary>
		/// Whether the light can affect the world, or whether it is disabled.
		/// A disabled light will not contribute to the scene in any way.  This setting cannot be changed at runtime and unbuilds lighting when changed.
		/// Setting this to false has the same effect as deleting the light, so it is useful for non-destructive experiments.
		/// </summary>
		public bool bAffectsWorld;
		
		/// <summary>Whether the light should cast any shadows.</summary>
		public bool CastShadows;
		
		/// <summary>Whether the light should cast shadows from static objects.  Also requires Cast Shadows to be set to True.</summary>
		public bool CastStaticShadows;
		
		/// <summary>Whether the light should cast shadows from dynamic objects.  Also requires Cast Shadows to be set to True.</summary>
		public bool CastDynamicShadows;
		
		/// <summary>Whether the light affects translucency or not.  Disabling this can save GPU time when there are many small lights.</summary>
		public bool bAffectTranslucentLighting;
		
		/// <summary>
		/// Scales the indirect lighting contribution from this light.
		/// A value of 0 disables any GI from this light. Default is 1.
		/// </summary>
		public float IndirectLightingIntensity;
		
		/// <summary>Sprite for static light in the editor.</summary>
		public UTexture2D StaticEditorTexture;
		
		/// <summary>Sprite scaling for static light in the editor.</summary>
		public float StaticEditorTextureScale;
		
		/// <summary>Sprite for dynamic light in the editor.</summary>
		public UTexture2D DynamicEditorTexture;
		
		/// <summary>Sprite scaling for dynamic light in the editor.</summary>
		public float DynamicEditorTextureScale;
		
		
	}
	
}
