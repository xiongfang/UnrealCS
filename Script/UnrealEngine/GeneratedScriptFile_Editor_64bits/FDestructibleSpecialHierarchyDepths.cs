#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Special hierarchy depths for various behaviors.</summary>
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FDestructibleSpecialHierarchyDepths
	{
		/// <summary>
		/// The chunk hierarchy depth at which to create a support graph.  Higher depth levels give more detailed support,
		/// but will give a higher computational load.  Chunks below the support depth will never be supported.
		/// </summary>
		[FieldOffset(0)]
		public int SupportDepth;
		/// <summary>The chunks will not be broken free below this depth.</summary>
		[FieldOffset(4)]
		public int MinimumFractureDepth;
		/// <summary>
		/// Enables debris at a specific depth level.
		/// @see DebrisDepth
		/// </summary>
		public bool bEnableDebris
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		/// <summary>The hierarchy depth at which chunks are considered to be "debris."</summary>
		[FieldOffset(12)]
		public int DebrisDepth;
		/// <summary>
		/// The chunk hierarchy depth up to which chunks will always be processed.  These chunks are considered
		/// to be essential either for gameplay or visually.
		/// The minimum value is 0, meaning the level 0 chunk is always considered essential.
		/// Default value is 0.
		/// </summary>
		[FieldOffset(16)]
		public int EssentialDepth;
		
	}
	
}
#endif
#endif
