#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UExponentialHeightFogComponent
	{
		static readonly int FogDensity__Offset;
		public float FogDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FogDensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogDensity__Offset, false);}
			
		}
		
		static readonly int FogInscatteringColor__Offset;
		public FLinearColor FogInscatteringColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+FogInscatteringColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogInscatteringColor__Offset, false);}
			
		}
		
		static readonly int InscatteringColorCubemap__Offset;
		public UTextureCube InscatteringColorCubemap
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InscatteringColorCubemap__Offset); if (v == IntPtr.Zero)return null; UTextureCube retValue = new UTextureCube(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + InscatteringColorCubemap__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + InscatteringColorCubemap__Offset, value._this.Get()); }
			
		}
		
		static readonly int InscatteringTextureTint__Offset;
		public FLinearColor InscatteringTextureTint
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+InscatteringTextureTint__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InscatteringTextureTint__Offset, false);}
			
		}
		
		static readonly int FullyDirectionalInscatteringColorDistance__Offset;
		public float FullyDirectionalInscatteringColorDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FullyDirectionalInscatteringColorDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FullyDirectionalInscatteringColorDistance__Offset, false);}
			
		}
		
		static readonly int NonDirectionalInscatteringColorDistance__Offset;
		public float NonDirectionalInscatteringColorDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NonDirectionalInscatteringColorDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NonDirectionalInscatteringColorDistance__Offset, false);}
			
		}
		
		static readonly int DirectionalInscatteringExponent__Offset;
		public float DirectionalInscatteringExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DirectionalInscatteringExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DirectionalInscatteringExponent__Offset, false);}
			
		}
		
		static readonly int DirectionalInscatteringStartDistance__Offset;
		public float DirectionalInscatteringStartDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DirectionalInscatteringStartDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DirectionalInscatteringStartDistance__Offset, false);}
			
		}
		
		static readonly int DirectionalInscatteringColor__Offset;
		public FLinearColor DirectionalInscatteringColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+DirectionalInscatteringColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DirectionalInscatteringColor__Offset, false);}
			
		}
		
		static readonly int FogHeightFalloff__Offset;
		public float FogHeightFalloff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FogHeightFalloff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogHeightFalloff__Offset, false);}
			
		}
		
		static readonly int FogMaxOpacity__Offset;
		public float FogMaxOpacity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FogMaxOpacity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogMaxOpacity__Offset, false);}
			
		}
		
		static readonly int StartDistance__Offset;
		public float StartDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartDistance__Offset, false);}
			
		}
		
		static readonly int FogCutoffDistance__Offset;
		public float FogCutoffDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FogCutoffDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogCutoffDistance__Offset, false);}
			
		}
		
		static UExponentialHeightFogComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ExponentialHeightFogComponent");
			FogDensity__Offset=GetPropertyOffset(NativeClassPtr,"FogDensity");
			FogInscatteringColor__Offset=GetPropertyOffset(NativeClassPtr,"FogInscatteringColor");
			InscatteringColorCubemap__Offset=GetPropertyOffset(NativeClassPtr,"InscatteringColorCubemap");
			InscatteringTextureTint__Offset=GetPropertyOffset(NativeClassPtr,"InscatteringTextureTint");
			FullyDirectionalInscatteringColorDistance__Offset=GetPropertyOffset(NativeClassPtr,"FullyDirectionalInscatteringColorDistance");
			NonDirectionalInscatteringColorDistance__Offset=GetPropertyOffset(NativeClassPtr,"NonDirectionalInscatteringColorDistance");
			DirectionalInscatteringExponent__Offset=GetPropertyOffset(NativeClassPtr,"DirectionalInscatteringExponent");
			DirectionalInscatteringStartDistance__Offset=GetPropertyOffset(NativeClassPtr,"DirectionalInscatteringStartDistance");
			DirectionalInscatteringColor__Offset=GetPropertyOffset(NativeClassPtr,"DirectionalInscatteringColor");
			FogHeightFalloff__Offset=GetPropertyOffset(NativeClassPtr,"FogHeightFalloff");
			FogMaxOpacity__Offset=GetPropertyOffset(NativeClassPtr,"FogMaxOpacity");
			StartDistance__Offset=GetPropertyOffset(NativeClassPtr,"StartDistance");
			FogCutoffDistance__Offset=GetPropertyOffset(NativeClassPtr,"FogCutoffDistance");
			
		}
		
	}
	
}
#endif
#endif
