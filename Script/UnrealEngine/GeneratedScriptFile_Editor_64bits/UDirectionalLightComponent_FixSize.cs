#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A light component that has parallel rays. Will provide a uniform lighting across any affected surface (eg. The Sun). This will affect all objects in the defined light-mass importance volume.</summary>
	public partial class UDirectionalLightComponent
	{
		static readonly int bEnableLightShaftOcclusion__Offset;
		/// <summary>Whether to occlude fog and atmosphere inscattering with screenspace blurred occlusion from this light.</summary>
		public bool bEnableLightShaftOcclusion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableLightShaftOcclusion__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableLightShaftOcclusion__Offset, 1,0,1,1);}
			
		}
		
		static readonly int OcclusionMaskDarkness__Offset;
		/// <summary>Controls how dark the occlusion masking is, a value of 1 results in no darkening term.</summary>
		public float OcclusionMaskDarkness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OcclusionMaskDarkness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OcclusionMaskDarkness__Offset, false);}
			
		}
		
		static readonly int OcclusionDepthRange__Offset;
		/// <summary>Everything closer to the camera than this distance will occlude light shafts.</summary>
		public float OcclusionDepthRange
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OcclusionDepthRange__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OcclusionDepthRange__Offset, false);}
			
		}
		
		static readonly int LightShaftOverrideDirection__Offset;
		/// <summary>
		/// Can be used to make light shafts come from somewhere other than the light's actual direction.
		/// This will only be used when non-zero.  It does not have to be normalized.
		/// </summary>
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
		/// <summary>
		/// How far Cascaded Shadow Map dynamic shadows will cover for a movable light, measured from the camera.
		/// A value of 0 disables the dynamic shadow.
		/// </summary>
		public float DynamicShadowDistanceMovableLight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DynamicShadowDistanceMovableLight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DynamicShadowDistanceMovableLight__Offset, false);}
			
		}
		
		static readonly int DynamicShadowDistanceStationaryLight__Offset;
		/// <summary>
		/// How far Cascaded Shadow Map dynamic shadows will cover for a stationary light, measured from the camera.
		/// A value of 0 disables the dynamic shadow.
		/// </summary>
		public float DynamicShadowDistanceStationaryLight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DynamicShadowDistanceStationaryLight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DynamicShadowDistanceStationaryLight__Offset, false);}
			
		}
		
		static readonly int DynamicShadowCascades__Offset;
		/// <summary>
		/// Number of cascades to split the view frustum into for the whole scene dynamic shadow.
		/// More cascades result in better shadow resolution, but adds significant rendering cost.
		/// </summary>
		public int DynamicShadowCascades
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+DynamicShadowCascades__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DynamicShadowCascades__Offset, false);}
			
		}
		
		static readonly int CascadeDistributionExponent__Offset;
		/// <summary>
		/// Controls whether the cascades are distributed closer to the camera (larger exponent) or further from the camera (smaller exponent).
		/// An exponent of 1 means that cascade transitions will happen at a distance proportional to their resolution.
		/// </summary>
		public float CascadeDistributionExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CascadeDistributionExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CascadeDistributionExponent__Offset, false);}
			
		}
		
		static readonly int CascadeTransitionFraction__Offset;
		/// <summary>
		/// Proportion of the fade region between cascades.
		/// Pixels within the fade region of two cascades have their shadows blended to avoid hard transitions between quality levels.
		/// A value of zero eliminates the fade region, creating hard transitions.
		/// Higher values increase the size of the fade region, creating a more gradual transition between cascades.
		/// The value is expressed as a percentage proportion (i.e. 0.1 = 10% overlap).
		/// Ideal values are the smallest possible which still hide the transition.
		/// An increased fade region size causes an increase in shadow rendering cost.
		/// </summary>
		public float CascadeTransitionFraction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CascadeTransitionFraction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CascadeTransitionFraction__Offset, false);}
			
		}
		
		static readonly int ShadowDistanceFadeoutFraction__Offset;
		/// <summary>
		/// Controls the size of the fade out region at the far extent of the dynamic shadow's influence.
		/// This is specified as a fraction of DynamicShadowDistance.
		/// </summary>
		public float ShadowDistanceFadeoutFraction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowDistanceFadeoutFraction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowDistanceFadeoutFraction__Offset, false);}
			
		}
		
		static readonly int bUseInsetShadowsForMovableObjects__Offset;
		/// <summary>
		/// Stationary lights only: Whether to use per-object inset shadows for movable components, even though cascaded shadow maps are enabled.
		/// This allows dynamic objects to have a shadow even when they are outside of the cascaded shadow map, which is important when DynamicShadowDistanceStationaryLight is small.
		/// If DynamicShadowDistanceStationaryLight is large (currently > 8000), this will be forced off.
		/// Disabling this can reduce shadowing cost significantly with many movable objects.
		/// </summary>
		public bool bUseInsetShadowsForMovableObjects
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseInsetShadowsForMovableObjects__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseInsetShadowsForMovableObjects__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FarShadowCascadeCount__Offset;
		/// <summary>0: no DistantShadowCascades, otherwise the count of cascades between WholeSceneDynamicShadowRadius and DistantShadowDistance that are covered by distant shadow cascades.</summary>
		public int FarShadowCascadeCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+FarShadowCascadeCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FarShadowCascadeCount__Offset, false);}
			
		}
		
		static readonly int FarShadowDistance__Offset;
		/// <summary>Distance at which the far shadow cascade should end.  Far shadows will cover the range between 'Dynamic Shadow Distance' and this distance.</summary>
		public float FarShadowDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FarShadowDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FarShadowDistance__Offset, false);}
			
		}
		
		static readonly int DistanceFieldShadowDistance__Offset;
		/// <summary>Distance at which the ray traced shadow cascade should end.  Distance field shadows will cover the range between 'Dynamic Shadow Distance' this distance.</summary>
		public float DistanceFieldShadowDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFieldShadowDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceFieldShadowDistance__Offset, false);}
			
		}
		
		static readonly int LightSourceAngle__Offset;
		/// <summary>
		/// Light source angle in degrees, used for dynamic shadowing methods.
		/// Currently only Ray Traced Distance Field shadows and Capsule shadows support area shadows, and therefore make use of LightSourceAngle.
		/// </summary>
		public float LightSourceAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightSourceAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightSourceAngle__Offset, false);}
			
		}
		
		static readonly int TraceDistance__Offset;
		/// <summary>Determines how far shadows can be cast, in world units.  Larger values increase the shadowing cost.</summary>
		public float TraceDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TraceDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TraceDistance__Offset, false);}
			
		}
		
		static readonly int LightmassSettings__Offset;
		/// <summary>The Lightmass settings for this object.</summary>
		public FLightmassDirectionalLightSettings LightmassSettings
		{
			get{ CheckIsValid();return (FLightmassDirectionalLightSettings)Marshal.PtrToStructure(_this.Get()+LightmassSettings__Offset, typeof(FLightmassDirectionalLightSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmassSettings__Offset, false);}
			
		}
		
		static readonly int bCastModulatedShadows__Offset;
		/// <summary>Whether the light should cast modulated shadows from dynamic objects (mobile only).  Also requires Cast Shadows to be set to True.</summary>
		public bool bCastModulatedShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastModulatedShadows__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastModulatedShadows__Offset, 1,0,1,1);}
			
		}
		
		static readonly int ModulatedShadowColor__Offset;
		/// <summary>Color to modulate against the scene color when rendering modulated shadows. (mobile only)</summary>
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
