#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FBranchFilter
	{
		/// <summary>Bone Name to filter *</summary>
		[FieldOffset(0)]
		public FName BoneName;
		/// <summary>Blend Depth *</summary>
		[FieldOffset(12)]
		public int BlendDepth;
		
	}
	
}
#endif
#endif
