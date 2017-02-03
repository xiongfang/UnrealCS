#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureBase
	{
		static readonly int Texture__Offset;
		public UTexture Texture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Texture__Offset); if (v == IntPtr.Zero)return null; UTexture retValue = new UTexture(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Texture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Texture__Offset, value._this.Get()); }
			
		}
		
		static readonly int SamplerType__Offset;
		public EMaterialSamplerType SamplerType
		{
			get{ CheckIsValid();return (EMaterialSamplerType)Marshal.PtrToStructure(_this.Get()+SamplerType__Offset, typeof(EMaterialSamplerType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SamplerType__Offset, false);}
			
		}
		
		static readonly int IsDefaultMeshpaintTexture__Offset;
		public bool IsDefaultMeshpaintTexture
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsDefaultMeshpaintTexture__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsDefaultMeshpaintTexture__Offset, 1,0,1,1);}
			
		}
		
		static UMaterialExpressionTextureBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionTextureBase");
			Texture__Offset=GetPropertyOffset(NativeClassPtr,"Texture");
			SamplerType__Offset=GetPropertyOffset(NativeClassPtr,"SamplerType");
			IsDefaultMeshpaintTexture__Offset=GetPropertyOffset(NativeClassPtr,"IsDefaultMeshpaintTexture");
			
		}
		
	}
	
}
#endif
#endif
