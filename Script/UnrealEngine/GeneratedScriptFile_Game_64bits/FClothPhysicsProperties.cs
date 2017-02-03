#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FClothPhysicsProperties
	{
		[FieldOffset(0)]
		public float VerticalResistance;
		[FieldOffset(4)]
		public float HorizontalResistance;
		[FieldOffset(8)]
		public float BendResistance;
		[FieldOffset(12)]
		public float ShearResistance;
		[FieldOffset(16)]
		public float Friction;
		[FieldOffset(20)]
		public float Damping;
		[FieldOffset(24)]
		public float TetherStiffness;
		[FieldOffset(28)]
		public float TetherLimit;
		[FieldOffset(32)]
		public float Drag;
		[FieldOffset(36)]
		public float StiffnessFrequency;
		[FieldOffset(40)]
		public float GravityScale;
		[FieldOffset(44)]
		public float MassScale;
		[FieldOffset(48)]
		public float InertiaBlend;
		[FieldOffset(52)]
		public float SelfCollisionThickness;
		[FieldOffset(56)]
		public float SelfCollisionSquashScale;
		[FieldOffset(60)]
		public float SelfCollisionStiffness;
		[FieldOffset(64)]
		public float SolverFrequency;
		[FieldOffset(68)]
		public float FiberCompression;
		[FieldOffset(72)]
		public float FiberExpansion;
		[FieldOffset(76)]
		public float FiberResistance;
		
	}
	
}
#endif
#endif
