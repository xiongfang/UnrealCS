#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FBlueprintEditorPromotionSettings
	{
		[FieldOffset(0)]
		public FFilePath FirstMeshPath;
		[FieldOffset(12)]
		public FFilePath SecondMeshPath;
		[FieldOffset(24)]
		public FFilePath DefaultParticleAsset;
		
	}
	
}
#endif
#endif
