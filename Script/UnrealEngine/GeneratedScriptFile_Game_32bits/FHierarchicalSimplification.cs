#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=380)]
	public partial struct FHierarchicalSimplification
	{
		[FieldOffset(4)]
		public float TransitionScreenSize;
		public bool bSimplifyMesh
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(12)]
		public FMeshProxySettings ProxySetting;
		[FieldOffset(220)]
		public FMeshMergingSettings MergeSetting;
		[FieldOffset(368)]
		public float DesiredBoundRadius;
		[FieldOffset(372)]
		public float DesiredFillingPercentage;
		[FieldOffset(376)]
		public int MinNumberOfActorsToBuild;
		
	}
	
}
#endif
#endif
