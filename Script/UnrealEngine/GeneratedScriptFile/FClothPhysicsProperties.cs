using System;
namespace UnrealEngine
{
	/// <summary>
	/// now exposed a part of properties based on 3DS Max plug-in
	/// property names are also changed into 3DS Max plug-in's one
	/// </summary>
	public partial struct FClothPhysicsProperties
	{
		/// <summary>vertical stiffness of the cloth in the range [0, 1].   usually set to 1.0</summary>
		public float VerticalResistance;
		/// <summary>Horizontal stiffness of the cloth in the range [0, 1].  usually set to 1.0</summary>
		public float HorizontalResistance;
		/// <summary>Bending stiffness of the cloth in the range [0, 1].</summary>
		public float BendResistance;
		/// <summary>Shearing stiffness of the cloth in the range [0, 1].</summary>
		public float ShearResistance;
		/// <summary>Friction coefficient in the range[0, 1]</summary>
		public float Friction;
		/// <summary>Spring damping of the cloth in the range[0, 1]</summary>
		public float Damping;
		/// <summary>Tether stiffness of the cloth in the range[0, 1].  Equivalent to 1.0-Relax in autodesk plugin.</summary>
		public float TetherStiffness;
		/// <summary>Tether Limit, corresponds to 1.0+StretchLimit parameter on Autodesk plugin.</summary>
		public float TetherLimit;
		/// <summary>Drag coefficient n the range [0, 1]</summary>
		public float Drag;
		/// <summary>Frequency for stiffness</summary>
		public float StiffnessFrequency;
		/// <summary>Gravity multiplier for this cloth.  Also called Density in Autodesk plugin.</summary>
		public float GravityScale;
		/// <summary>A mass scaling that is applied to the cloth.   Corresponds to 100X the MotionAdaptation parameter in autodesk plugin.</summary>
		public float MassScale;
		/// <summary>Amount of inertia that is kept when using local space simulation. Internal name is inertia scale</summary>
		public float InertiaBlend;
		/// <summary>Minimal amount of distance particles will keep of each other.</summary>
		public float SelfCollisionThickness;
		/// <summary>unclear what this actually does.</summary>
		public float SelfCollisionSquashScale;
		/// <summary>Self collision stiffness.  0 off, 1 for on.</summary>
		public float SelfCollisionStiffness;
		/// <summary>A computation parameter for the Solver.   Along with frame rate this probably specifies the number of solver iterations</summary>
		public float SolverFrequency;
		/// <summary>Lower (compression) Limit of SoftZone (relative to rest length).  Applied for all fiber types.  If both compression and expansion are 1.0 then there is no deadzone.</summary>
		public float FiberCompression;
		/// <summary>Upper (expansion) Limit of SoftZone (relative to rest length).  Applied to all fiber types.   Also referred to as "stretch" range by apex internally.</summary>
		public float FiberExpansion;
		/// <summary>Resistance Multiplier that's applied to within SoftZone amount for all fiber types.  0.0 for a complete deadzone (no force).  At 1.0 the spring response within the softzone is as stiff it is elsewhere.  This parameter also known as scale by Apex internally.</summary>
		public float FiberResistance;
		
	}
	
}
