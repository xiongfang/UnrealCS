#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A small structure holding data for grouping subtracks. (For UI drawing purposes)</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FSubTrackGroup
	{
		/// <summary>Name of the subtrack  group</summary>
		[FieldOffset(0)]
		public FString GroupName;
		/// <summary>Indices to tracks in the parent track subtrack array.</summary>
		public TStructArray<int> TrackIndices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>If this group is collapsed</summary>
		public bool bIsCollapsed
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If this group is selected</summary>
		public bool bIsSelected
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 2, 2); } }}
			
		}
		
	}
	
}
#endif
#endif
