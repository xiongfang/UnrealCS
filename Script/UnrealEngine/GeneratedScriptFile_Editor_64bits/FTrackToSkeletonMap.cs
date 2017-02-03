#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>@note We have a plan to support skeletal hierarchy. When that happens, we'd like to keep skeleton indexing.</summary>
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FTrackToSkeletonMap
	{
		/// <summary>Index of Skeleton.BoneTree this Track belongs to.</summary>
		[FieldOffset(0)]
		public int BoneTreeIndex;
		
	}
	
}
#endif
#endif
