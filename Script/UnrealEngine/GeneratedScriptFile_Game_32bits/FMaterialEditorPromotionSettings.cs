#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FMaterialEditorPromotionSettings
	{
		[FieldOffset(0)]
		public FFilePath DefaultMaterialAsset;
		[FieldOffset(12)]
		public FFilePath DefaultDiffuseTexture;
		[FieldOffset(24)]
		public FFilePath DefaultNormalTexture;
		
	}
	
}
#endif
#endif
