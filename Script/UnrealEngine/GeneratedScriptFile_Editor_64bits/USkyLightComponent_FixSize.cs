#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USkyLightComponent
	{
		static readonly int SourceType__Offset;
		/// <summary>Indicates where to get the light contribution from.</summary>
		public ESkyLightSourceType SourceType
		{
			get{ CheckIsValid();return (ESkyLightSourceType)Marshal.PtrToStructure(_this.Get()+SourceType__Offset, typeof(ESkyLightSourceType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceType__Offset, false);}
			
		}
		
		static readonly int Cubemap__Offset;
		/// <summary>Cubemap to use for sky lighting if SourceType is set to SLS_SpecifiedCubemap.</summary>
		public UTextureCube Cubemap
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Cubemap__Offset); if (v == IntPtr.Zero)return null; UTextureCube retValue = new UTextureCube(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Cubemap__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Cubemap__Offset, value._this.Get()); }
			
		}
		
		static readonly int SourceCubemapAngle__Offset;
		/// <summary>Angle to rotate the source cubemap when SourceType is set to SLS_SpecifiedCubemap.</summary>
		public float SourceCubemapAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SourceCubemapAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceCubemapAngle__Offset, false);}
			
		}
		
		static readonly int CubemapResolution__Offset;
		/// <summary>Maximum resolution for the very top processed cubemap mip. Must be a power of 2.</summary>
		public int CubemapResolution
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CubemapResolution__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CubemapResolution__Offset, false);}
			
		}
		
		static readonly int SkyDistanceThreshold__Offset;
		/// <summary>
		/// Distance from the sky light at which any geometry should be treated as part of the sky.
		/// This is also used by reflection captures, so update reflection captures to see the impact.
		/// </summary>
		public float SkyDistanceThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SkyDistanceThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SkyDistanceThreshold__Offset, false);}
			
		}
		
		static readonly int bLowerHemisphereIsBlack__Offset;
		/// <summary>
		/// Whether all distant lighting from the lower hemisphere should be set to LowerHemisphereColor.
		/// Enabling this is accurate when lighting a scene on a planet where the ground blocks the sky,
		/// However disabling it can be useful to approximate skylight bounce lighting (eg Movable light).
		/// </summary>
		public bool bLowerHemisphereIsBlack
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLowerHemisphereIsBlack__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLowerHemisphereIsBlack__Offset, 1,0,1,255);}
			
		}
		
		static readonly int LowerHemisphereColor__Offset;
		public FLinearColor LowerHemisphereColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+LowerHemisphereColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LowerHemisphereColor__Offset, false);}
			
		}
		
		static readonly int OcclusionMaxDistance__Offset;
		/// <summary>
		/// Max distance that the occlusion of one point will affect another.
		/// Higher values increase the cost of Distance Field AO exponentially.
		/// </summary>
		public float OcclusionMaxDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OcclusionMaxDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OcclusionMaxDistance__Offset, false);}
			
		}
		
		static readonly int Contrast__Offset;
		/// <summary>Contrast S-curve applied to the computed AO.  A value of 0 means no contrast increase, 1 is a significant contrast increase.</summary>
		public float Contrast
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Contrast__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Contrast__Offset, false);}
			
		}
		
		static readonly int MinOcclusion__Offset;
		/// <summary>Controls the darkest that a fully occluded area can get.</summary>
		public float MinOcclusion
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinOcclusion__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinOcclusion__Offset, false);}
			
		}
		
		static readonly int OcclusionTint__Offset;
		/// <summary>Tint color on occluded areas, artistic control.</summary>
		public FColor OcclusionTint
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+OcclusionTint__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OcclusionTint__Offset, false);}
			
		}
		
		static readonly int BlendDestinationCubemap__Offset;
		public UTextureCube BlendDestinationCubemap
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BlendDestinationCubemap__Offset); if (v == IntPtr.Zero)return null; UTextureCube retValue = new UTextureCube(); retValue._this = v; return retValue; }
			
		}
		
		static USkyLightComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkyLightComponent");
			SourceType__Offset=GetPropertyOffset(NativeClassPtr,"SourceType");
			Cubemap__Offset=GetPropertyOffset(NativeClassPtr,"Cubemap");
			SourceCubemapAngle__Offset=GetPropertyOffset(NativeClassPtr,"SourceCubemapAngle");
			CubemapResolution__Offset=GetPropertyOffset(NativeClassPtr,"CubemapResolution");
			SkyDistanceThreshold__Offset=GetPropertyOffset(NativeClassPtr,"SkyDistanceThreshold");
			bLowerHemisphereIsBlack__Offset=GetPropertyOffset(NativeClassPtr,"bLowerHemisphereIsBlack");
			LowerHemisphereColor__Offset=GetPropertyOffset(NativeClassPtr,"LowerHemisphereColor");
			OcclusionMaxDistance__Offset=GetPropertyOffset(NativeClassPtr,"OcclusionMaxDistance");
			Contrast__Offset=GetPropertyOffset(NativeClassPtr,"Contrast");
			MinOcclusion__Offset=GetPropertyOffset(NativeClassPtr,"MinOcclusion");
			OcclusionTint__Offset=GetPropertyOffset(NativeClassPtr,"OcclusionTint");
			BlendDestinationCubemap__Offset=GetPropertyOffset(NativeClassPtr,"BlendDestinationCubemap");
			
		}
		
	}
	
}
#endif
#endif
