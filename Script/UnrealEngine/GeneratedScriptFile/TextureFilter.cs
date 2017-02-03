using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum TextureFilter:byte
	{
		TF_Nearest=0,
		TF_Bilinear=1,
		TF_Trilinear=2,
		/// <summary>Use setting from the Texture Group.</summary>
		TF_Default=3,
		TF_MAX=4,
		
	}
	
}
