#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the particle editor build promotion tests</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FParticleEditorPromotionSettings
	{
		/// <summary>Default particle asset to use for tests</summary>
		[FieldOffset(0)]
		public FFilePath DefaultParticleAsset;
		
	}
	
}
#endif
#endif
