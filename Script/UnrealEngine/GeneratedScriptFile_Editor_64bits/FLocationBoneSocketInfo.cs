#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FLocationBoneSocketInfo
	{
		/// <summary>The name of the bone/socket on the skeletal mesh</summary>
		[FieldOffset(0)]
		public FName BoneSocketName;
		/// <summary>The offset from the bone/socket to use</summary>
		[FieldOffset(12)]
		public FVector Offset;
		
	}
	
}
#endif
#endif
