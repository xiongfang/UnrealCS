#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Group of Root Motion Sources that are applied</summary>
	[StructLayout(LayoutKind.Explicit,Size=256)]
	public partial struct FRootMotionSourceGroup
	{
		/// <summary>Whether this group has additive root motion sources</summary>
		public bool bHasAdditiveSources
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 232, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 232, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether this group has override root motion sources</summary>
		public bool bHasOverrideSources
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 233, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 233, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// Saved off pre-additive-applied Velocity, used for being able to reliably add/remove additive
		/// velocity from currently computed Velocity (otherwise we would be removing additive velocity
		/// that no longer exists, like if you run into a wall and your Velocity becomes 0 - subtracting
		/// the velocity that we added heading into the wall last tick would make you go backwards. With
		/// this method we override that resulting Velocity due to obstructions
		/// </summary>
		[FieldOffset(236)]
		public FVector_NetQuantize10 LastPreAdditiveVelocity;
		/// <summary>
		/// True when we had additive velocity applied last tick, checked to know if we should restore
		/// LastPreAdditiveVelocity before a Velocity computation
		/// </summary>
		public bool bIsAdditiveVelocityApplied
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 248, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 248, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Aggregate Settings of the last group of accumulated sources</summary>
		[FieldOffset(249)]
		public FRootMotionSourceSettings LastAccumulatedSettings;
		
	}
	
}
#endif
#endif
