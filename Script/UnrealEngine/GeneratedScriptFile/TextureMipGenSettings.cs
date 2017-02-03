using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum TextureMipGenSettings:byte
	{
		/// <summary>Default for the "texture".</summary>
		TMGS_FromTextureGroup=0,
		/// <summary>2x2 average, default for the "texture group".</summary>
		TMGS_SimpleAverage=1,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen0=2,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen1=3,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen2=4,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen3=5,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen4=6,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen5=7,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen6=8,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen7=9,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen8=10,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen9=11,
		/// <summary>8x8 with sharpening: 0=no sharpening but better quality which is softer, 1=little, 5=medium, 10=extreme.</summary>
		TMGS_Sharpen10=12,
		TMGS_NoMipmaps=13,
		/// <summary>Do not touch existing mip chain as it contains generated data.</summary>
		TMGS_LeaveExistingMips=14,
		/// <summary>Blur further (useful for image based reflections).</summary>
		TMGS_Blur1=15,
		TMGS_Blur2=16,
		TMGS_Blur3=17,
		TMGS_Blur4=18,
		TMGS_Blur5=19,
		TMGS_MAX=20,
		
	}
	
}
