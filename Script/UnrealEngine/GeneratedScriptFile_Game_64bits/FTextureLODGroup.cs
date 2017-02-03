#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FTextureLODGroup
	{
		[FieldOffset(0)]
		public TextureGroup Group;
		[FieldOffset(12)]
		public int LODBias;
		[FieldOffset(20)]
		public int NumStreamedMips;
		[FieldOffset(24)]
		public TextureMipGenSettings MipGenSettings;
		[FieldOffset(28)]
		public int MinLODSize;
		[FieldOffset(32)]
		public int MaxLODSize;
		[FieldOffset(40)]
		public FName MinMagFilter;
		[FieldOffset(48)]
		public FName MipFilter;
		
	}
	
}
#endif
#endif
