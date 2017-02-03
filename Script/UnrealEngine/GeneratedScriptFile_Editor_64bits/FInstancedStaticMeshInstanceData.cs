#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FInstancedStaticMeshInstanceData
	{
		[FieldOffset(0)]
		public FMatrix Transform;
		/// <summary>Legacy, this is now stored in FMeshMapBuildData.  Still serialized for backwards compatibility.</summary>
		[FieldOffset(64)]
		public FVector2D LightmapUVBias;
		/// <summary>Legacy, this is now stored in FMeshMapBuildData.  Still serialized for backwards compatibility.</summary>
		[FieldOffset(72)]
		public FVector2D ShadowmapUVBias;
		
	}
	
}
#endif
#endif
