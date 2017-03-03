#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLight
	{
		static readonly int bUseInverseSquaredFalloff__Offset;
		/// <summary>Whether to use physically based inverse squared falloff from the light.  If unchecked, the LightExponent distribution will be used instead.</summary>
		public bool bUseInverseSquaredFalloff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseInverseSquaredFalloff__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseInverseSquaredFalloff__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bAffectsTranslucency__Offset;
		/// <summary>
		/// Whether lights from this module should affect translucency.
		/// Use with caution.  Modules enabling this should only make a few particle lights at most, and the smaller they are, the less they will cost.
		/// </summary>
		public bool bAffectsTranslucency
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectsTranslucency__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectsTranslucency__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bPreviewLightRadius__Offset;
		/// <summary>
		/// Will draw wireframe spheres to preview the light radius if enabled.
		/// Note: this is intended for previewing and the value will not be saved, it will always revert to disabled.
		/// </summary>
		public bool bPreviewLightRadius
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPreviewLightRadius__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPreviewLightRadius__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SpawnFraction__Offset;
		/// <summary>Fraction of particles in this emitter to create lights on.</summary>
		public float SpawnFraction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpawnFraction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpawnFraction__Offset, false);}
			
		}
		
		static readonly int ColorScaleOverLife__Offset;
		/// <summary>Scale that is applied to the particle's color to calculate the light's color, and can be setup as a curve over the particle's lifetime.</summary>
		public FRawDistributionVector ColorScaleOverLife
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+ColorScaleOverLife__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorScaleOverLife__Offset, false);}
			
		}
		
		static readonly int BrightnessOverLife__Offset;
		/// <summary>Brightness scale for the light, which can be setup as a curve over the particle's lifetime.</summary>
		public FRawDistributionFloat BrightnessOverLife
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+BrightnessOverLife__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrightnessOverLife__Offset, false);}
			
		}
		
		static readonly int RadiusScale__Offset;
		/// <summary>Scales the particle's radius, to calculate the light's radius.</summary>
		public FRawDistributionFloat RadiusScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+RadiusScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RadiusScale__Offset, false);}
			
		}
		
		static readonly int LightExponent__Offset;
		/// <summary>Provides the light's exponent when inverse squared falloff is disabled.</summary>
		public FRawDistributionFloat LightExponent
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+LightExponent__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightExponent__Offset, false);}
			
		}
		
		static readonly int LightingChannels__Offset;
		/// <summary>
		/// Channels that this light should affect.
		/// Only affect high quality lights
		/// These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
		/// </summary>
		public FLightingChannels LightingChannels
		{
			get{ CheckIsValid();return (FLightingChannels)Marshal.PtrToStructure(_this.Get()+LightingChannels__Offset, typeof(FLightingChannels));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightingChannels__Offset, false);}
			
		}
		
		static readonly int bHighQualityLights__Offset;
		public bool bHighQualityLights
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHighQualityLights__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHighQualityLights__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bShadowCastingLights__Offset;
		public bool bShadowCastingLights
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShadowCastingLights__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShadowCastingLights__Offset, 1,0,1,255);}
			
		}
		
		static UParticleModuleLight()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLight");
			bUseInverseSquaredFalloff__Offset=GetPropertyOffset(NativeClassPtr,"bUseInverseSquaredFalloff");
			bAffectsTranslucency__Offset=GetPropertyOffset(NativeClassPtr,"bAffectsTranslucency");
			bPreviewLightRadius__Offset=GetPropertyOffset(NativeClassPtr,"bPreviewLightRadius");
			SpawnFraction__Offset=GetPropertyOffset(NativeClassPtr,"SpawnFraction");
			ColorScaleOverLife__Offset=GetPropertyOffset(NativeClassPtr,"ColorScaleOverLife");
			BrightnessOverLife__Offset=GetPropertyOffset(NativeClassPtr,"BrightnessOverLife");
			RadiusScale__Offset=GetPropertyOffset(NativeClassPtr,"RadiusScale");
			LightExponent__Offset=GetPropertyOffset(NativeClassPtr,"LightExponent");
			LightingChannels__Offset=GetPropertyOffset(NativeClassPtr,"LightingChannels");
			bHighQualityLights__Offset=GetPropertyOffset(NativeClassPtr,"bHighQualityLights");
			bShadowCastingLights__Offset=GetPropertyOffset(NativeClassPtr,"bShadowCastingLights");
			
		}
		
	}
	
}
#endif
#endif
