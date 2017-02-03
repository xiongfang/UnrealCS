#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used to create fogging effects such as clouds.</summary>
	public partial class UAtmosphericFogComponent
	{
		static readonly int SunMultiplier__Offset;
		/// <summary>Global scattering factor.</summary>
		public float SunMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SunMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SunMultiplier__Offset, false);}
			
		}
		
		static readonly int FogMultiplier__Offset;
		/// <summary>Scattering factor on object.</summary>
		public float FogMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FogMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogMultiplier__Offset, false);}
			
		}
		
		static readonly int DensityMultiplier__Offset;
		/// <summary>Fog density control factor.</summary>
		public float DensityMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DensityMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DensityMultiplier__Offset, false);}
			
		}
		
		static readonly int DensityOffset__Offset;
		/// <summary>Fog density offset to control opacity [-1.f ~ 1.f].</summary>
		public float DensityOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DensityOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DensityOffset__Offset, false);}
			
		}
		
		static readonly int DistanceScale__Offset;
		/// <summary>Distance scale.</summary>
		public float DistanceScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceScale__Offset, false);}
			
		}
		
		static readonly int AltitudeScale__Offset;
		/// <summary>Altitude scale (only Z scale).</summary>
		public float AltitudeScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AltitudeScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AltitudeScale__Offset, false);}
			
		}
		
		static readonly int DistanceOffset__Offset;
		/// <summary>Distance offset, in km (to handle large distance)</summary>
		public float DistanceOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceOffset__Offset, false);}
			
		}
		
		static readonly int GroundOffset__Offset;
		/// <summary>Ground offset.</summary>
		public float GroundOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GroundOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroundOffset__Offset, false);}
			
		}
		
		static readonly int StartDistance__Offset;
		/// <summary>Start Distance.</summary>
		public float StartDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartDistance__Offset, false);}
			
		}
		
		static readonly int SunDiscScale__Offset;
		/// <summary>Distance offset, in km (to handle large distance)</summary>
		public float SunDiscScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SunDiscScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SunDiscScale__Offset, false);}
			
		}
		
		static readonly int DefaultBrightness__Offset;
		/// <summary>Default light brightness. Used when there is no sunlight placed in the level. Unit is lumens</summary>
		public float DefaultBrightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultBrightness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultBrightness__Offset, false);}
			
		}
		
		static readonly int DefaultLightColor__Offset;
		/// <summary>Default light color. Used when there is no sunlight placed in the level.</summary>
		public FColor DefaultLightColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+DefaultLightColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultLightColor__Offset, false);}
			
		}
		
		static readonly int bDisableSunDisk__Offset;
		/// <summary>Disable Sun Disk rendering.</summary>
		public bool bDisableSunDisk
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableSunDisk__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableSunDisk__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDisableGroundScattering__Offset;
		/// <summary>Disable Color scattering from ground.</summary>
		public bool bDisableGroundScattering
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableGroundScattering__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableGroundScattering__Offset, 1,0,2,2);}
			
		}
		
		static readonly int PrecomputeParams__Offset;
		public FAtmospherePrecomputeParameters PrecomputeParams
		{
			get{ CheckIsValid();return (FAtmospherePrecomputeParameters)Marshal.PtrToStructure(_this.Get()+PrecomputeParams__Offset, typeof(FAtmospherePrecomputeParameters));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrecomputeParams__Offset, false);}
			
		}
		
		static readonly int TransmittanceTexture__Offset;
		public UTexture2D TransmittanceTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TransmittanceTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int IrradianceTexture__Offset;
		public UTexture2D IrradianceTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + IrradianceTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static UAtmosphericFogComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AtmosphericFogComponent");
			SunMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"SunMultiplier");
			FogMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"FogMultiplier");
			DensityMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"DensityMultiplier");
			DensityOffset__Offset=GetPropertyOffset(NativeClassPtr,"DensityOffset");
			DistanceScale__Offset=GetPropertyOffset(NativeClassPtr,"DistanceScale");
			AltitudeScale__Offset=GetPropertyOffset(NativeClassPtr,"AltitudeScale");
			DistanceOffset__Offset=GetPropertyOffset(NativeClassPtr,"DistanceOffset");
			GroundOffset__Offset=GetPropertyOffset(NativeClassPtr,"GroundOffset");
			StartDistance__Offset=GetPropertyOffset(NativeClassPtr,"StartDistance");
			SunDiscScale__Offset=GetPropertyOffset(NativeClassPtr,"SunDiscScale");
			DefaultBrightness__Offset=GetPropertyOffset(NativeClassPtr,"DefaultBrightness");
			DefaultLightColor__Offset=GetPropertyOffset(NativeClassPtr,"DefaultLightColor");
			bDisableSunDisk__Offset=GetPropertyOffset(NativeClassPtr,"bDisableSunDisk");
			bDisableGroundScattering__Offset=GetPropertyOffset(NativeClassPtr,"bDisableGroundScattering");
			PrecomputeParams__Offset=GetPropertyOffset(NativeClassPtr,"PrecomputeParams");
			TransmittanceTexture__Offset=GetPropertyOffset(NativeClassPtr,"TransmittanceTexture");
			IrradianceTexture__Offset=GetPropertyOffset(NativeClassPtr,"IrradianceTexture");
			
		}
		
	}
	
}
#endif
#endif
