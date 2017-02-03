#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FBlueprintEditorPromotionSettings
	{
		[FieldOffset(0)]
		public FFilePath FirstMeshPath;
		[FieldOffset(16)]
		public FFilePath SecondMeshPath;
		[FieldOffset(32)]
		public FFilePath DefaultParticleAsset;
		
	}
	
}
#endif
#endif
