#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULightComponentBase
	{
		static readonly int LightGuid__Offset;
		public FGuid LightGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+LightGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int Brightness__Offset;
		public float Brightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Brightness__Offset, typeof(float));}
			
		}
		
		static readonly int Intensity__Offset;
		public float Intensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Intensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Intensity__Offset, false);}
			
		}
		
		static readonly int LightColor__Offset;
		public FColor LightColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+LightColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightColor__Offset, false);}
			
		}
		
		static readonly int bAffectsWorld__Offset;
		public bool bAffectsWorld
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectsWorld__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectsWorld__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CastShadows__Offset;
		public bool CastShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastShadows__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastShadows__Offset, 1,0,2,2);}
			
		}
		
		static readonly int CastStaticShadows__Offset;
		public bool CastStaticShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastStaticShadows__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastStaticShadows__Offset, 1,0,4,4);}
			
		}
		
		static readonly int CastDynamicShadows__Offset;
		public bool CastDynamicShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastDynamicShadows__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastDynamicShadows__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAffectTranslucentLighting__Offset;
		public bool bAffectTranslucentLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectTranslucentLighting__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectTranslucentLighting__Offset, 1,0,16,16);}
			
		}
		
		static readonly int IndirectLightingIntensity__Offset;
		public float IndirectLightingIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IndirectLightingIntensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IndirectLightingIntensity__Offset, false);}
			
		}
		
		static ULightComponentBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LightComponentBase");
			LightGuid__Offset=GetPropertyOffset(NativeClassPtr,"LightGuid");
			Brightness__Offset=GetPropertyOffset(NativeClassPtr,"Brightness");
			Intensity__Offset=GetPropertyOffset(NativeClassPtr,"Intensity");
			LightColor__Offset=GetPropertyOffset(NativeClassPtr,"LightColor");
			bAffectsWorld__Offset=GetPropertyOffset(NativeClassPtr,"bAffectsWorld");
			CastShadows__Offset=GetPropertyOffset(NativeClassPtr,"CastShadows");
			CastStaticShadows__Offset=GetPropertyOffset(NativeClassPtr,"CastStaticShadows");
			CastDynamicShadows__Offset=GetPropertyOffset(NativeClassPtr,"CastDynamicShadows");
			bAffectTranslucentLighting__Offset=GetPropertyOffset(NativeClassPtr,"bAffectTranslucentLighting");
			IndirectLightingIntensity__Offset=GetPropertyOffset(NativeClassPtr,"IndirectLightingIntensity");
			
		}
		
	}
	
}
#endif
#endif
