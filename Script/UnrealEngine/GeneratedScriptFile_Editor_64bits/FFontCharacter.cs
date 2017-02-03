#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This struct is serialized using native serialization so any changes to it require a package version bump.</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FFontCharacter
	{
		[FieldOffset(0)]
		public int StartU;
		[FieldOffset(4)]
		public int StartV;
		[FieldOffset(8)]
		public int USize;
		[FieldOffset(12)]
		public int VSize;
		[FieldOffset(16)]
		public byte TextureIndex;
		[FieldOffset(20)]
		public int VerticalOffset;
		
	}
	
}
#endif
#endif
