#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Properties of representation of an 'agent' (or Pawn) used by AI navigation/pathfinding.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FNavAgentProperties
	{
		/// <summary>Radius of the capsule used for navigation/pathfinding.</summary>
		[FieldOffset(4)]
		public float AgentRadius;
		/// <summary>Total height of the capsule used for navigation/pathfinding.</summary>
		[FieldOffset(8)]
		public float AgentHeight;
		/// <summary>Step height to use, or -1 for default value from navdata's config.</summary>
		[FieldOffset(12)]
		public float AgentStepHeight;
		/// <summary>Scale factor to apply to height of bounds when searching for navmesh to project to when nav walking</summary>
		[FieldOffset(16)]
		public float NavWalkingSearchHeightScale;
		/// <summary>Type of navigation data used by agent, null means "any"</summary>
		/// <summary>If true, this Pawn is capable of crouching.</summary>
		public bool bCanCrouch
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If true, this Pawn is capable of jumping.</summary>
		public bool bCanJump
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		/// <summary>If true, this Pawn is capable of walking or moving on the ground.</summary>
		public bool bCanWalk
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 4, 4); } }}
			
		}
		/// <summary>If true, this Pawn is capable of swimming or moving through fluid volumes.</summary>
		public bool bCanSwim
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 8, 8); } }}
			
		}
		/// <summary>If true, this Pawn is capable of flying.</summary>
		public bool bCanFly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 16, 16); } }}
			
		}
		
	}
	
}
#endif
#endif
