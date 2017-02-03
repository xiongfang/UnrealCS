#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=380)]
	public partial struct FHierarchicalSimplification
	{
		/// <summary>The screen radius an mesh object should reach before swapping to the LOD actor, once one of parent displays, it won't draw any of children.</summary>
		[FieldOffset(4)]
		public float TransitionScreenSize;
		/// <summary>
		/// If this is true, it will simplify mesh but it is slower.
		/// If false, it will just merge actors but not simplify using the lower LOD if exists.
		/// For example if you build LOD 1, it will use LOD 1 of the mesh to merge actors if exists.
		/// If you merge material, it will reduce drawcalls.
		/// </summary>
		public bool bSimplifyMesh
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Simplification Setting if bSimplifyMesh is true</summary>
		[FieldOffset(12)]
		public FMeshProxySettings ProxySetting;
		/// <summary>Merge Mesh Setting if bSimplifyMesh is false</summary>
		[FieldOffset(220)]
		public FMeshMergingSettings MergeSetting;
		/// <summary>Desired Bounding Radius for clustering - this is not guaranteed but used to calculate filling factor for auto clustering</summary>
		[FieldOffset(368)]
		public float DesiredBoundRadius;
		/// <summary>Desired Filling Percentage for clustering - this is not guaranteed but used to calculate filling factor  for auto clustering</summary>
		[FieldOffset(372)]
		public float DesiredFillingPercentage;
		/// <summary>Min number of actors to build LODActor</summary>
		[FieldOffset(376)]
		public int MinNumberOfActorsToBuild;
		
	}
	
}
#endif
#endif
