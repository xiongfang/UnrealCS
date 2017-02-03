#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This is a mapping table between bone in a particular skeletal mesh and bone of this skeleton set.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSkeletonToMeshLinkup
	{
		/// <summary>
		/// Mapping table. Size must be same as size of bone tree (not Mesh Ref Pose).
		/// No index should be more than the number of bones in this skeleton
		/// -1 indicates no match for this bone - will be ignored.
		/// </summary>
		public TStructArray<int> SkeletonToMeshTable
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>
		/// Mapping table. Size must be same as size of ref pose (not bone tree).
		/// No index should be more than the number of bones in this skeletalmesh
		/// -1 indicates no match for this bone - will be ignored.
		/// </summary>
		public TStructArray<int> MeshToSkeletonTable
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
