#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FPhysicalAnimationData
	{
		[FieldOffset(0)]
		public FName BodyName;
		public bool bIsLocalSimulation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(12)]
		public float OrientationStrength;
		[FieldOffset(16)]
		public float AngularVelocityStrength;
		[FieldOffset(20)]
		public float PositionStrength;
		[FieldOffset(24)]
		public float VelocityStrength;
		[FieldOffset(28)]
		public float MaxLinearForce;
		[FieldOffset(32)]
		public float MaxAngularForce;
		
	}
	
}
#endif
#endif
