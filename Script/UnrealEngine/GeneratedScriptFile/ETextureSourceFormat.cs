using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ETextureSourceFormat:byte
	{
		TSF_Invalid=0,
		TSF_G8=1,
		TSF_BGRA8=2,
		TSF_BGRE8=3,
		TSF_RGBA16=4,
		TSF_RGBA16F=5,
		/// <summary>@todo: Deprecated!</summary>
		TSF_RGBA8=6,
		/// <summary>@todo: Deprecated!</summary>
		TSF_RGBE8=7,
		TSF_MAX=8,
		
	}
	
}
