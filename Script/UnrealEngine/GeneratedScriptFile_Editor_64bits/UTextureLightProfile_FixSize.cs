#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTextureLightProfile
	{
		static readonly int Brightness__Offset;
		/// <summary>Light brightness in Lumens, imported from IES profile, <= 0 if the profile is used for masking only. Use with InverseSquareFalloff.</summary>
		public float Brightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Brightness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Brightness__Offset, false);}
			
		}
		
		static readonly int TextureMultiplier__Offset;
		/// <summary>Multiplier to map texture value to result to integrate over the sphere to 1.0f</summary>
		public float TextureMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TextureMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextureMultiplier__Offset, false);}
			
		}
		
		static UTextureLightProfile()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextureLightProfile");
			Brightness__Offset=GetPropertyOffset(NativeClassPtr,"Brightness");
			TextureMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"TextureMultiplier");
			
		}
		
	}
	
}
#endif
#endif
