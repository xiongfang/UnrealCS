#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A light component which emits light from a single point equally in all directions.</summary>
	public partial class UPointLightComponent
	{
		static readonly int Radius__Offset;
		public float Radius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Radius__Offset, typeof(float));}
			
		}
		
		static readonly int AttenuationRadius__Offset;
		/// <summary>
		/// Bounds the light's visible influence.
		/// This clamping of the light's influence is not physically correct but very important for performance, larger lights cost more.
		/// </summary>
		public float AttenuationRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AttenuationRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttenuationRadius__Offset, false);}
			
		}
		
		static readonly int bUseInverseSquaredFalloff__Offset;
		/// <summary>
		/// Whether to use physically based inverse squared distance falloff, where AttenuationRadius is only clamping the light's contribution.
		/// Disabling inverse squared falloff can be useful when placing fill lights (don't want a super bright spot near the light).
		/// When enabled, the light's Intensity is in units of lumens, where 1700 lumens is a 100W lightbulb.
		/// When disabled, the light's Intensity is a brightness scale.
		/// </summary>
		public bool bUseInverseSquaredFalloff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseInverseSquaredFalloff__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseInverseSquaredFalloff__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LightFalloffExponent__Offset;
		/// <summary>
		/// Controls the radial falloff of the light when UseInverseSquaredFalloff is disabled.
		/// 2 is almost linear and very unrealistic and around 8 it looks reasonable.
		/// With large exponents, the light has contribution to only a small area of its influence radius but still costs the same as low exponents.
		/// </summary>
		public float LightFalloffExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightFalloffExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightFalloffExponent__Offset, false);}
			
		}
		
		static readonly int SourceRadius__Offset;
		/// <summary>
		/// Radius of light source shape.
		/// Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts.
		/// </summary>
		public float SourceRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SourceRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceRadius__Offset, false);}
			
		}
		
		static readonly int SourceLength__Offset;
		/// <summary>
		/// Length of light source shape.
		/// Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts.
		/// </summary>
		public float SourceLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SourceLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceLength__Offset, false);}
			
		}
		
		static readonly int LightmassSettings__Offset;
		/// <summary>The Lightmass settings for this object.</summary>
		public FLightmassPointLightSettings LightmassSettings
		{
			get{ CheckIsValid();return (FLightmassPointLightSettings)Marshal.PtrToStructure(_this.Get()+LightmassSettings__Offset, typeof(FLightmassPointLightSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmassSettings__Offset, false);}
			
		}
		
		static UPointLightComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PointLightComponent");
			Radius__Offset=GetPropertyOffset(NativeClassPtr,"Radius");
			AttenuationRadius__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationRadius");
			bUseInverseSquaredFalloff__Offset=GetPropertyOffset(NativeClassPtr,"bUseInverseSquaredFalloff");
			LightFalloffExponent__Offset=GetPropertyOffset(NativeClassPtr,"LightFalloffExponent");
			SourceRadius__Offset=GetPropertyOffset(NativeClassPtr,"SourceRadius");
			SourceLength__Offset=GetPropertyOffset(NativeClassPtr,"SourceLength");
			LightmassSettings__Offset=GetPropertyOffset(NativeClassPtr,"LightmassSettings");
			
		}
		
	}
	
}
#endif
#endif
