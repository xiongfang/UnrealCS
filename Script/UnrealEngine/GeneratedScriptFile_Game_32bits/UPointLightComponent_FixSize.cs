#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPointLightComponent
	{
		static readonly int Radius__Offset;
		public float Radius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Radius__Offset, typeof(float));}
			
		}
		
		static readonly int AttenuationRadius__Offset;
		public float AttenuationRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AttenuationRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttenuationRadius__Offset, false);}
			
		}
		
		static readonly int bUseInverseSquaredFalloff__Offset;
		public bool bUseInverseSquaredFalloff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseInverseSquaredFalloff__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseInverseSquaredFalloff__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LightFalloffExponent__Offset;
		public float LightFalloffExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightFalloffExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightFalloffExponent__Offset, false);}
			
		}
		
		static readonly int SourceRadius__Offset;
		public float SourceRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SourceRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceRadius__Offset, false);}
			
		}
		
		static readonly int SourceLength__Offset;
		public float SourceLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SourceLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceLength__Offset, false);}
			
		}
		
		static readonly int LightmassSettings__Offset;
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
