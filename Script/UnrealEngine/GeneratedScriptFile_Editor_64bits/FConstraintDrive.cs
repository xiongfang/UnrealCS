#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FConstraintDrive
	{
		/// <summary>The spring strength of the drive. Force proportional to the position error.</summary>
		[FieldOffset(0)]
		public float Stiffness;
		/// <summary>The damping strength of the drive. Force proportional to the velocity error.</summary>
		[FieldOffset(4)]
		public float Damping;
		/// <summary>The force limit of the drive.</summary>
		[FieldOffset(8)]
		public float MaxForce;
		/// <summary>Enables/Disables position drive (orientation if using angular drive)</summary>
		public bool bEnablePositionDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Enables/Disables velocity drive (angular velocity if using angular drive)</summary>
		public bool bEnableVelocityDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 2, 2); } }}
			
		}
		
	}
	
}
#endif
#endif
