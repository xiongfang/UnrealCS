#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UShadowMapTexture2D
	{
		static readonly int ShadowmapFlags__Offset;
		public EShadowMapFlags ShadowmapFlags
		{
			get{ CheckIsValid();return (EShadowMapFlags)Marshal.PtrToStructure(_this.Get()+ShadowmapFlags__Offset, typeof(EShadowMapFlags));}
			
		}
		
		static UShadowMapTexture2D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ShadowMapTexture2D");
			ShadowmapFlags__Offset=GetPropertyOffset(NativeClassPtr,"ShadowmapFlags");
			
		}
		
	}
	
}
#endif
#endif
