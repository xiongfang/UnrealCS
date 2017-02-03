#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Stores info on the type of motor that will be used for a given bone</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FPhysicalAnimationData
	{
		/// <summary>The body we will be driving. We specifically hide this from users since they provide the body name and bodies below in the component API.</summary>
		[FieldOffset(0)]
		public FName BodyName;
		/// <summary>Whether the drive targets are in world space or local</summary>
		public bool bIsLocalSimulation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		/// <summary>The strength used to correct orientation error</summary>
		[FieldOffset(16)]
		public float OrientationStrength;
		/// <summary>The strength used to correct angular velocity error</summary>
		[FieldOffset(20)]
		public float AngularVelocityStrength;
		/// <summary>The strength used to correct linear position error. Only used for non-local simulation</summary>
		[FieldOffset(24)]
		public float PositionStrength;
		/// <summary>The strength used to correct linear velocity error. Only used for non-local simulation</summary>
		[FieldOffset(28)]
		public float VelocityStrength;
		/// <summary>The max force used to correct linear errors</summary>
		[FieldOffset(32)]
		public float MaxLinearForce;
		/// <summary>The max force used to correct angular errors</summary>
		[FieldOffset(36)]
		public float MaxAngularForce;
		
	}
	
}
#endif
#endif
