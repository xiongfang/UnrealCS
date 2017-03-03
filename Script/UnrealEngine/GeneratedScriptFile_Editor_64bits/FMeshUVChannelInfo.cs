#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The world size for each texcoord mapping. Used by the texture streaming.</summary>
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FMeshUVChannelInfo
	{
		public bool bInitialized
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether this values was set manually or is auto generated.</summary>
		public bool bOverrideDensities
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// The UV density in the mesh, before any transform scaling, in world unit per UV.
		/// This value represents the length taken to cover a full UV unit.
		/// </summary>
		[FieldOffset(4)]
		public float LocalUVDensities;
		
	}
	
}
#endif
#endif
