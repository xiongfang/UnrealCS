#if WITH_GAME
#if PLATFORM_64BITS
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
		
		static UExponentialHeightFogComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ExponentialHeightFogComponent");
			FogDensity__Offset=GetPropertyOffset(NativeClassPtr,"FogDensity");
			FogInscatteringColor__Offset=GetPropertyOffset(NativeClassPtr,"FogInscatteringColor");
			DirectionalInscatteringExponent__Offset=GetPropertyOffset(NativeClassPtr,"DirectionalInscatteringExponent");
			DirectionalInscatteringStartDistance__Offset=GetPropertyOffset(NativeClassPtr,"DirectionalInscatteringStartDistance");
			DirectionalInscatteringColor__Offset=GetPropertyOffset(NativeClassPtr,"DirectionalInscatteringColor");
			FogHeightFalloff__Offset=GetPropertyOffset(NativeClassPtr,"FogHeightFalloff");
			FogMaxOpacity__Offset=GetPropertyOffset(NativeClassPtr,"FogMaxOpacity");
			StartDistance__Offset=GetPropertyOffset(NativeClassPtr,"StartDistance");
			
		}
		
	}
	
}
#endif
#endif
