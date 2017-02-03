#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// now exposed a part of properties based on 3DS Max plug-in
	/// property names are also changed into 3DS Max plug-in's one
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FClothPhysicsProperties
	{
		/// <summary>vertical stiffness of the cloth in the range [0, 1].   usually set to 1.0</summary>
		[FieldOffset(0)]
		public float VerticalResistance;
		/// <summary>Horizontal stiffness of the cloth in the range [0, 1].  usually set to 1.0</summary>
		[FieldOffset(4)]
		public float HorizontalResistance;
		/// <summary>Bending stiffness of the cloth in the range [0, 1].</summary>
		[FieldOffset(8)]
		public float BendResistance;
		/// <summary>Shearing stiffness of the cloth in the range [0, 1].</summary>
		[FieldOffset(12)]
		public float ShearResistance;
		/// <summary>Friction coefficient in the range[0, 1]</summary>
		[FieldOffset(16)]
		public float Friction;
		/// <summary>Spring damping of the cloth in the range[0, 1]</summary>
		[FieldOffset(20)]
		public float Damping;
		/// <summary>Tether stiffness of the cloth in the range[0, 1].  Equivalent to 1.0-Relax in autodesk plugin.</summary>
		[FieldOffset(24)]
		public float TetherStiffness;
		/// <summary>Tether Limit, corresponds to 1.0+StretchLimit parameter on Autodesk plugin.</summary>
		[FieldOffset(28)]
		public float TetherLimit;
		/// <summary>Drag coefficient n the range [0, 1]</summary>
		[FieldOffset(32)]
		public float Drag;
		/// <summary>Frequency for stiffness</summary>
		[FieldOffset(36)]
		public float StiffnessFrequency;
		/// <summary>Gravity multiplier for this cloth.  Also called Density in Autodesk plugin.</summary>
		[FieldOffset(40)]
		public float GravityScale;
		/// <summary>A mass scaling that is applied to the cloth.   Corresponds to 100X the MotionAdaptation parameter in autodesk plugin.</summary>
		[FieldOffset(44)]
		public float MassScale;
		/// <summary>Amount of inertia that is kept when using local space simulation. Internal name is inertia scale</summary>
		[FieldOffset(48)]
		public float InertiaBlend;
		/// <summary>Minimal amount of distance particles will keep of each other.</summary>
		[FieldOffset(52)]
		public float SelfCollisionThickness;
		/// <summary>unclear what this actually does.</summary>
		[FieldOffset(56)]
		public float SelfCollisionSquashScale;
		/// <summary>Self collision stiffness.  0 off, 1 for on.</summary>
		[FieldOffset(60)]
		public float SelfCollisionStiffness;
		/// <summary>A computation parameter for the Solver.   Along with frame rate this probably specifies the number of solver iterations</summary>
		[FieldOffset(64)]
		public float SolverFrequency;
		/// <summary>Lower (compression) Limit of SoftZone (relative to rest length).  Applied for all fiber types.  If both compression and expansion are 1.0 then there is no deadzone.</summary>
		[FieldOffset(68)]
		public float FiberCompression;
		/// <summary>Upper (expansion) Limit of SoftZone (relative to rest length).  Applied to all fiber types.   Also referred to as "stretch" range by apex internally.</summary>
		[FieldOffset(72)]
		public float FiberExpansion;
		/// <summary>Resistance Multiplier that's applied to within SoftZone amount for all fiber types.  0.0 for a complete deadzone (no force).  At 1.0 the spring response within the softzone is as stiff it is elsewhere.  This parameter also known as scale by Apex internally.</summary>
		[FieldOffset(76)]
		public float FiberResistance;
		
	}
	
}
#endif
#endif
