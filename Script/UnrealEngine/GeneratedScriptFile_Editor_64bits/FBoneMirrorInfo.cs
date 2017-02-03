#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FBoneMirrorInfo
	{
		/// <summary>The bone to mirror.</summary>
		[FieldOffset(0)]
		public int SourceIndex;
		/// <summary>Axis the bone is mirrored across.</summary>
		[FieldOffset(4)]
		public EAxis BoneFlipAxis;
		
	}
	
}
#endif
#endif
