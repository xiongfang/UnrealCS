#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FStaticMaterial
	{
		/// <summary>This name should be use by the gameplay to avoid error if the skeletal mesh Materials array topology change</summary>
		[FieldOffset(8)]
		public FName MaterialSlotName;
		/// <summary>This name should be use when we re-import a skeletal mesh so we can order the Materials array like it should be</summary>
		[FieldOffset(20)]
		public FName ImportedMaterialSlotName;
		/// <summary>Data used for texture streaming relative to each UV channels.</summary>
		[FieldOffset(32)]
		public FMeshUVChannelInfo UVChannelData;
		
	}
	
}
#endif
#endif
