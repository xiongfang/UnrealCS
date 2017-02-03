#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This is a mapping table between each bone in a particular skeletal mesh and the tracks of this animation set.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FAnimSetMeshLinkup
	{
		/// <summary>
		/// Mapping table. Size must be same as size of SkelMesh reference skeleton.
		/// No index should be more than the number of tracks in this AnimSet.
		/// -1 indicates no track for this bone - will use reference pose instead.
		/// </summary>
		public TStructArray<int> BoneToTrackTable
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
