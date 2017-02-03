#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the blueprint editor build promotion tests</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FBlueprintEditorPromotionSettings
	{
		/// <summary>The starting mesh for the blueprint *</summary>
		[FieldOffset(0)]
		public FFilePath FirstMeshPath;
		/// <summary>The mesh to set on the blueprint after the delay *</summary>
		[FieldOffset(16)]
		public FFilePath SecondMeshPath;
		/// <summary>Default particle asset to use for tests</summary>
		[FieldOffset(32)]
		public FFilePath DefaultParticleAsset;
		
	}
	
}
#endif
#endif
