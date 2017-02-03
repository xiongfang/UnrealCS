#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the material editor build promotion tests</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FMaterialEditorPromotionSettings
	{
		/// <summary>Default material asset to apply to static meshes *</summary>
		[FieldOffset(0)]
		public FFilePath DefaultMaterialAsset;
		/// <summary>Default material asset to apply to static meshes *</summary>
		[FieldOffset(16)]
		public FFilePath DefaultDiffuseTexture;
		/// <summary>Default material asset to apply to static meshes *</summary>
		[FieldOffset(32)]
		public FFilePath DefaultNormalTexture;
		
	}
	
}
#endif
#endif
