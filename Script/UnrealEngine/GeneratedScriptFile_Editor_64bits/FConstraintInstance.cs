#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Container for a physics representation of an object.</summary>
	[StructLayout(LayoutKind.Explicit,Size=688)]
	public partial struct FConstraintInstance
	{
		/// <summary>Name of bone that this joint is associated with.</summary>
		[FieldOffset(20)]
		public FName JointName;
		/// <summary>
		/// Name of first bone (body) that this constraint is connecting.
		/// This will be the 'child' bone in a PhysicsAsset.
		/// </summary>
		[FieldOffset(32)]
		public FName ConstraintBone1;
		/// <summary>
		/// Name of second bone (body) that this constraint is connecting.
		/// This will be the 'parent' bone in a PhysicsAset.
		/// </summary>
		[FieldOffset(44)]
		public FName ConstraintBone2;
		/// <summary>Location of constraint in Body1 reference frame.</summary>
		[FieldOffset(56)]
		public FVector Pos1;
		/// <summary>Primary (twist) axis in Body1 reference frame.</summary>
		[FieldOffset(68)]
		public FVector PriAxis1;
		/// <summary>Seconday axis in Body1 reference frame. Orthogonal to PriAxis1.</summary>
		[FieldOffset(80)]
		public FVector SecAxis1;
		/// <summary>Location of constraint in Body2 reference frame.</summary>
		[FieldOffset(92)]
		public FVector Pos2;
		/// <summary>Primary (twist) axis in Body2 reference frame.</summary>
		[FieldOffset(104)]
		public FVector PriAxis2;
		/// <summary>Seconday axis in Body2 reference frame. Orthogonal to PriAxis2.</summary>
		[FieldOffset(116)]
		public FVector SecAxis2;
		/// <summary>
		/// Specifies the angular offset between the two frames of reference. By default limit goes from (-Angle, +Angle)
		/// This allows you to bias the limit for swing1 swing2 and twist.
		/// </summary>
		[FieldOffset(128)]
		public FRotator AngularRotationOffset;
		/// <summary>If true, linear limits scale using the absolute min of the 3d scale of the owning component</summary>
		public bool bScaleLinearLimits
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 140, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 140, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Constraint Data (properties easily swapped at runtime based on different constraint profiles)</summary>
		[FieldOffset(148)]
		public FConstraintProfileProperties ProfileInstance;
		public bool bDisableCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 496, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 496, 1, 0, 1, 1); } }}
			
		}
		public bool bEnableProjection
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 496, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 496, 1, 0, 2, 2); } }}
			
		}
		[FieldOffset(500)]
		public float ProjectionLinearTolerance;
		[FieldOffset(504)]
		public float ProjectionAngularTolerance;
		[FieldOffset(508)]
		public ELinearConstraintMotion LinearXMotion;
		[FieldOffset(509)]
		public ELinearConstraintMotion LinearYMotion;
		[FieldOffset(510)]
		public ELinearConstraintMotion LinearZMotion;
		[FieldOffset(512)]
		public float LinearLimitSize;
		public bool bLinearLimitSoft
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 516, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 516, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(520)]
		public float LinearLimitStiffness;
		[FieldOffset(524)]
		public float LinearLimitDamping;
		public bool bLinearBreakable
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 528, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 528, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(532)]
		public float LinearBreakThreshold;
		[FieldOffset(536)]
		public EAngularConstraintMotion AngularSwing1Motion;
		[FieldOffset(537)]
		public EAngularConstraintMotion AngularTwistMotion;
		[FieldOffset(538)]
		public EAngularConstraintMotion AngularSwing2Motion;
		public bool bSwingLimitSoft
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 540, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 540, 1, 0, 1, 1); } }}
			
		}
		public bool bTwistLimitSoft
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 540, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 540, 1, 0, 2, 2); } }}
			
		}
		[FieldOffset(544)]
		public float Swing1LimitAngle;
		[FieldOffset(548)]
		public float TwistLimitAngle;
		[FieldOffset(552)]
		public float Swing2LimitAngle;
		[FieldOffset(556)]
		public float SwingLimitStiffness;
		[FieldOffset(560)]
		public float SwingLimitDamping;
		[FieldOffset(564)]
		public float TwistLimitStiffness;
		[FieldOffset(568)]
		public float TwistLimitDamping;
		public bool bAngularBreakable
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 572, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 572, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(576)]
		public float AngularBreakThreshold;
		public bool bLinearXPositionDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 580, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 580, 1, 0, 1, 1); } }}
			
		}
		public bool bLinearXVelocityDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 580, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 580, 1, 0, 2, 2); } }}
			
		}
		public bool bLinearYPositionDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 580, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 580, 1, 0, 4, 4); } }}
			
		}
		public bool bLinearYVelocityDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 580, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 580, 1, 0, 8, 8); } }}
			
		}
		public bool bLinearZPositionDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 580, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 580, 1, 0, 16, 16); } }}
			
		}
		public bool bLinearZVelocityDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 580, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 580, 1, 0, 32, 32); } }}
			
		}
		public bool bLinearPositionDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 580, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 580, 1, 0, 64, 64); } }}
			
		}
		public bool bLinearVelocityDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 580, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 580, 1, 0, 128, 128); } }}
			
		}
		[FieldOffset(584)]
		public FVector LinearPositionTarget;
		[FieldOffset(596)]
		public FVector LinearVelocityTarget;
		[FieldOffset(608)]
		public float LinearDriveSpring;
		[FieldOffset(612)]
		public float LinearDriveDamping;
		[FieldOffset(616)]
		public float LinearDriveForceLimit;
		public bool bSwingPositionDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 620, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 620, 1, 0, 1, 1); } }}
			
		}
		public bool bSwingVelocityDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 620, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 620, 1, 0, 2, 2); } }}
			
		}
		public bool bTwistPositionDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 620, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 620, 1, 0, 4, 4); } }}
			
		}
		public bool bTwistVelocityDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 620, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 620, 1, 0, 8, 8); } }}
			
		}
		public bool bAngularSlerpDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 620, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 620, 1, 0, 16, 16); } }}
			
		}
		public bool bAngularOrientationDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 620, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 620, 1, 0, 32, 32); } }}
			
		}
		public bool bEnableSwingDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 620, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 620, 1, 0, 64, 64); } }}
			
		}
		public bool bEnableTwistDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 620, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 620, 1, 0, 128, 128); } }}
			
		}
		public bool bAngularVelocityDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 621, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 621, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(624)]
		public FQuat AngularPositionTarget;
		[FieldOffset(640)]
		public EAngularDriveMode AngularDriveMode;
		[FieldOffset(644)]
		public FRotator AngularOrientationTarget;
		[FieldOffset(656)]
		public FVector AngularVelocityTarget;
		/// <summary>Revolutions per second</summary>
		[FieldOffset(668)]
		public float AngularDriveSpring;
		[FieldOffset(672)]
		public float AngularDriveDamping;
		[FieldOffset(676)]
		public float AngularDriveForceLimit;
		
	}
	
}
#endif
#endif
