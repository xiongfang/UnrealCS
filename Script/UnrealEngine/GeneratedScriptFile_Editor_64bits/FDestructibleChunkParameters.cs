#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Per-chunk authoring data.</summary>
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FDestructibleChunkParameters
	{
		/// <summary>
		/// Defines the chunk to be environmentally supported, if the appropriate NxDestructibleParametersFlag flags
		/// are set in NxDestructibleParameters.
		/// Default = false.
		/// </summary>
		public bool bIsSupportChunk
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// Defines the chunk to be unfractureable.  If this is true, then none of its children will be fractureable.
		/// Default = false.
		/// </summary>
		public bool bDoNotFracture
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// Defines the chunk to be undamageable.  This means this chunk will not fracture, but its children might.
		/// Default = false.
		/// </summary>
		public bool bDoNotDamage
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// Defines the chunk to be uncrumbleable.  This means this chunk will not be broken down into fluid mesh particles
		/// no matter how much damage it takes.  Note: this only applies to chunks with no children.  For a chunk with
		/// children, then:
		/// 1) The chunk may be broken down into its children, and then its children may be crumbled, if the doNotCrumble flag
		/// is not set on them.
		/// 2) If the Destructible module's chunk depth offset LOD may be set such that this chunk effectively has no children.
		/// In this case, the doNotCrumble flag will apply to it.
		/// Default = false.
		/// </summary>
		public bool bDoNotCrumble
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
