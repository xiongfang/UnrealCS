#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FMaterialEditorPromotionSettings
	{
		[FieldOffset(0)]
		public FFilePath DefaultMaterialAsset;
		[FieldOffset(16)]
		public FFilePath DefaultDiffuseTexture;
		[FieldOffset(32)]
		public FFilePath DefaultNormalTexture;
		
	}
	
}
#endif
#endif
