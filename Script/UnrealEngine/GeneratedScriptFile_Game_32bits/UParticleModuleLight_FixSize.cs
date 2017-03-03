#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLight
	{
		static readonly int bUseInverseSquaredFalloff__Offset;
		public bool bUseInverseSquaredFalloff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseInverseSquaredFalloff__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseInverseSquaredFalloff__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bAffectsTranslucency__Offset;
		public bool bAffectsTranslucency
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectsTranslucency__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectsTranslucency__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bPreviewLightRadius__Offset;
		public bool bPreviewLightRadius
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPreviewLightRadius__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPreviewLightRadius__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SpawnFraction__Offset;
		public float SpawnFraction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpawnFraction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpawnFraction__Offset, false);}
			
		}
		
		static readonly int ColorScaleOverLife__Offset;
		public FRawDistributionVector ColorScaleOverLife
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+ColorScaleOverLife__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorScaleOverLife__Offset, false);}
			
		}
		
		static readonly int BrightnessOverLife__Offset;
		public FRawDistributionFloat BrightnessOverLife
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+BrightnessOverLife__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrightnessOverLife__Offset, false);}
			
		}
		
		static readonly int RadiusScale__Offset;
		public FRawDistributionFloat RadiusScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+RadiusScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RadiusScale__Offset, false);}
			
		}
		
		static readonly int LightExponent__Offset;
		public FRawDistributionFloat LightExponent
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+LightExponent__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightExponent__Offset, false);}
			
		}
		
		static readonly int LightingChannels__Offset;
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
