#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDirectionalLightComponent
	{
		static readonly int bEnableLightShaftOcclusion__Offset;
		public bool bEnableLightShaftOcclusion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableLightShaftOcclusion__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableLightShaftOcclusion__Offset, 1,0,1,1);}
			
		}
		
		static readonly int OcclusionMaskDarkness__Offset;
		public float OcclusionMaskDarkness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OcclusionMaskDarkness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OcclusionMaskDarkness__Offset, false);}
			
		}
		
		static readonly int OcclusionDepthRange__Offset;
		public float OcclusionDepthRange
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OcclusionDepthRange__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OcclusionDepthRange__Offset, false);}
			
		}
		
		static readonly int LightShaftOverrideDirection__Offset;
		public FVector LightShaftOverrideDirection
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LightShaftOverrideDirection__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightShaftOverrideDirection__Offset, false);}
			
		}
		
		static readonly int WholeSceneDynamicShadowRadius__Offset;
		public float WholeSceneDynamicShadowRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WholeSceneDynamicShadowRadius__Offset, typeof(float));}
			
		}
		
		static readonly int DynamicShadowDistanceMovableLight__Offset;
		public float DynamicShadowDistanceMovableLight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DynamicShadowDistanceMovableLight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DynamicShadowDistanceMovableLight__Offset, false);}
			
		}
		
		static readonly int DynamicShadowDistanceStationaryLight__Offset;
		public float DynamicShadowDistanceStationaryLight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DynamicShadowDistanceStationaryLight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DynamicShadowDistanceStationaryLight__Offset, false);}
			
		}
		
		static readonly int DynamicShadowCascades__Offset;
		public int DynamicShadowCascades
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+DynamicShadowCascades__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DynamicShadowCascades__Offset, false);}
			
		}
		
		static readonly int CascadeDistributionExponent__Offset;
		public float CascadeDistributionExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CascadeDistributionExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CascadeDistributionExponent__Offset, false);}
			
		}
		
		static readonly int CascadeTransitionFraction__Offset;
		public float CascadeTransitionFraction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CascadeTransitionFraction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CascadeTransitionFraction__Offset, false);}
			
		}
		
		static readonly int ShadowDistanceFadeoutFraction__Offset;
		public float ShadowDistanceFadeoutFraction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowDistanceFadeoutFraction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowDistanceFadeoutFraction__Offset, false);}
			
		}
		
		static readonly int bUseInsetShadowsForMovableObjects__Offset;
		public bool bUseInsetShadowsForMovableObjects
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseInsetShadowsForMovableObjects__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseInsetShadowsForMovableObjects__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FarShadowCascadeCount__Offset;
		public int FarShadowCascadeCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+FarShadowCascadeCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FarShadowCascadeCount__Offset, false);}
			
		}
		
		static readonly int FarShadowDistance__Offset;
		public float FarShadowDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FarShadowDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FarShadowDistance__Offset, false);}
			
		}
		
		static readonly int DistanceFieldShadowDistance__Offset;
		public float DistanceFieldShadowDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFieldShadowDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceFieldShadowDistance__Offset, false);}
			
		}
		
		static readonly int LightSourceAngle__Offset;
		public float LightSourceAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightSourceAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightSourceAngle__Offset, false);}
			
		}
		
		static readonly int TraceDistance__Offset;
		public float TraceDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TraceDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TraceDistance__Offset, false);}
			
		}
		
		static readonly int LightmassSettings__Offset;
		public FLightmassDirectionalLightSettings LightmassSettings
		{
			get{ CheckIsValid();return (FLightmassDirectionalLightSettings)Marshal.PtrToStructure(_this.Get()+LightmassSettings__Offset, typeof(FLightmassDirectionalLightSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmassSettings__Offset, false);}
			
		}
		
		static readonly int bCastModulatedShadows__Offset;
		public bool bCastModulatedShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastModulatedShadows__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastModulatedShadows__Offset, 1,0,1,1);}
			
		}
		
		static readonly int ModulatedShadowColor__Offset;
		public FColor ModulatedShadowColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+ModulatedShadowColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ModulatedShadowColor__Offset, false);}
			
		}
		
		static readonly int bUsedAsAtmosphereSunLight__Offset;
		public bool bUsedAsAtmosphereSunLight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedAsAtmosphereSunLight__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedAsAtmosphereSunLight__Offset, 1,0,1,1);}
			
		}
		
		static UDirectionalLightComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DirectionalLightComponent");
			bEnableLightShaftOcclusion__Offset=GetPropertyOffset(NativeClassPtr,"bEnableLightShaftOcclusion");
			OcclusionMaskDarkness__Offset=GetPropertyOffset(NativeClassPtr,"OcclusionMaskDarkness");
			OcclusionDepthRange__Offset=GetPropertyOffset(NativeClassPtr,"OcclusionDepthRange");
			LightShaftOverrideDirection__Offset=GetPropertyOffset(NativeClassPtr,"LightShaftOverrideDirection");
			WholeSceneDynamicShadowRadius__Offset=GetPropertyOffset(NativeClassPtr,"WholeSceneDynamicShadowRadius");
			DynamicShadowDistanceMovableLight__Offset=GetPropertyOffset(NativeClassPtr,"DynamicShadowDistanceMovableLight");
			DynamicShadowDistanceStationaryLight__Offset=GetPropertyOffset(NativeClassPtr,"DynamicShadowDistanceStationaryLight");
			DynamicShadowCascades__Offset=GetPropertyOffset(NativeClassPtr,"DynamicShadowCascades");
			CascadeDistributionExponent__Offset=GetPropertyOffset(NativeClassPtr,"CascadeDistributionExponent");
			CascadeTransitionFraction__Offset=GetPropertyOffset(NativeClassPtr,"CascadeTransitionFraction");
			ShadowDistanceFadeoutFraction__Offset=GetPropertyOffset(NativeClassPtr,"ShadowDistanceFadeoutFraction");
			bUseInsetShadowsForMovableObjects__Offset=GetPropertyOffset(NativeClassPtr,"bUseInsetShadowsForMovableObjects");
			FarShadowCascadeCount__Offset=GetPropertyOffset(NativeClassPtr,"FarShadowCascadeCount");
			FarShadowDistance__Offset=GetPropertyOffset(NativeClassPtr,"FarShadowDistance");
			DistanceFieldShadowDistance__Offset=GetPropertyOffset(NativeClassPtr,"DistanceFieldShadowDistance");
			LightSourceAngle__Offset=GetPropertyOffset(NativeClassPtr,"LightSourceAngle");
			TraceDistance__Offset=GetPropertyOffset(NativeClassPtr,"TraceDistance");
			LightmassSettings__Offset=GetPropertyOffset(NativeClassPtr,"LightmassSettings");
			bCastModulatedShadows__Offset=GetPropertyOffset(NativeClassPtr,"bCastModulatedShadows");
			ModulatedShadowColor__Offset=GetPropertyOffset(NativeClassPtr,"ModulatedShadowColor");
			bUsedAsAtmosphereSunLight__Offset=GetPropertyOffset(NativeClassPtr,"bUsedAsAtmosphereSunLight");
			
		}
		
	}
	
}
#endif
#endif
