#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct to hold information about the "base" object the character is standing on.</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FBasedMovementInfo
	{
		/// <summary>Component we are based on</summary>
		/// <summary>Bone name on component, for skeletal meshes. NAME_None if not a skeletal mesh or if bone is invalid.</summary>
		[FieldOffset(8)]
		public FName BoneName;
		/// <summary>Location relative to MovementBase. Only valid if HasRelativeLocation() is true.</summary>
		[FieldOffset(20)]
		public FVector_NetQuantize100 Location;
		/// <summary>Rotation: relative to MovementBase if HasRelativeRotation() is true, absolute otherwise.</summary>
		[FieldOffset(32)]
		public FRotator Rotation;
		/// <summary>Whether the server says that there is a base. On clients, the component may not have resolved yet.</summary>
		public bool bServerHasBaseComponent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 44, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 44, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether rotation is relative to the base or absolute. It can only be relative if location is also relative.</summary>
		public bool bRelativeRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 45, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 45, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether there is a velocity on the server. Used for forcing replication when velocity goes to zero.</summary>
		public bool bServerHasVelocity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 46, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 46, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
