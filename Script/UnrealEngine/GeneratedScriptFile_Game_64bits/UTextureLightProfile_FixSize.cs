#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTextureLightProfile
	{
		static readonly int Brightness__Offset;
		public float Brightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Brightness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Brightness__Offset, false);}
			
		}
		
		static readonly int TextureMultiplier__Offset;
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
