#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Replicated data when playing a root motion montage.</summary>
	[StructLayout(LayoutKind.Explicit,Size=352)]
	public partial struct FRepRootMotionMontage
	{
		/// <summary>Whether this has useful/active data.</summary>
		public bool bIsActive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>AnimMontage providing Root Motion</summary>
		/// <summary>Track position of Montage</summary>
		[FieldOffset(16)]
		public float Position;
		/// <summary>Location</summary>
		[FieldOffset(20)]
		public FVector_NetQuantize100 Location;
		/// <summary>Rotation</summary>
		[FieldOffset(32)]
		public FRotator Rotation;
		/// <summary>Movement Relative to Base</summary>
		/// <summary>Bone on the MovementBase, if a skeletal mesh.</summary>
		[FieldOffset(56)]
		public FName MovementBaseBoneName;
		/// <summary>Additional replicated flag, if MovementBase can't be resolved on the client. So we don't use wrong data.</summary>
		public bool bRelativePosition
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 68, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 68, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether rotation is relative or absolute.</summary>
		public bool bRelativeRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 69, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 69, 1, 0, 1, 255); } }}
			
		}
		/// <summary>State of Root Motion Sources on Authority</summary>
		[FieldOffset(72)]
		public FRootMotionSourceGroup AuthoritativeRootMotion;
		/// <summary>Acceleration</summary>
		[FieldOffset(328)]
		public FVector_NetQuantize10 Acceleration;
		/// <summary>Velocity</summary>
		[FieldOffset(340)]
		public FVector_NetQuantize10 LinearVelocity;
		
	}
	
}
#endif
#endif
