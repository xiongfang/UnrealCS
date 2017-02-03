#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Data about the floor for walking movement, used by CharacterMovementComponent.</summary>
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FFindFloorResult
	{
		/// <summary>
		/// True if there was a blocking hit in the floor test that was NOT in initial penetration.
		/// The HitResult can give more info about other circumstances.
		/// </summary>
		public bool bBlockingHit
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>True if the hit found a valid walkable floor.</summary>
		public bool bWalkableFloor
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		/// <summary>True if the hit found a valid walkable floor using a line trace (rather than a sweep test, which happens when the sweep test fails to yield a walkable surface).</summary>
		public bool bLineTrace
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 4, 4); } }}
			
		}
		/// <summary>The distance to the floor, computed from the swept capsule trace.</summary>
		[FieldOffset(4)]
		public float FloorDist;
		/// <summary>The distance to the floor, computed from the trace. Only valid if bLineTrace is true.</summary>
		[FieldOffset(8)]
		public float LineDist;
		/// <summary>Hit result of the test that found a floor. Includes more specific data about the point of impact and surface normal at that point.</summary>
		[FieldOffset(12)]
		public FHitResult HitResult;
		
	}
	
}
#endif
#endif
