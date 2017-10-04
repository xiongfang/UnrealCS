using System;
namespace UnrealEngine
{
	public partial class UPhysicsConstraintTemplate:UObject
	{
		public FConstraintInstance DefaultInstance;
		
		/// <summary>When no profile is selected, use these settings. Only needed in editor as we serialize it into DefaultInstance on save</summary>
		public FConstraintProfileProperties DefaultProfile;
		
		public FName JointName;
		
		public FName ConstraintBone1;
		
		public FName ConstraintBone2;
		
		public FVector Pos1;
		
		public FVector PriAxis1;
		
		public FVector SecAxis1;
		
		public FVector Pos2;
		
		public FVector PriAxis2;
		
		public FVector SecAxis2;
		
		public bool bEnableProjection;
		
		public float ProjectionLinearTolerance;
		
		public float ProjectionAngularTolerance;
		
		public ELinearConstraintMotion LinearXMotion;
		
		public ELinearConstraintMotion LinearYMotion;
		
		public ELinearConstraintMotion LinearZMotion;
		
		public float LinearLimitSize;
		
		public bool bLinearLimitSoft;
		
		public float LinearLimitStiffness;
		
		public float LinearLimitDamping;
		
		public bool bLinearBreakable;
		
		public float LinearBreakThreshold;
		
		public EAngularConstraintMotion AngularSwing1Motion;
		
		public EAngularConstraintMotion AngularSwing2Motion;
		
		public EAngularConstraintMotion AngularTwistMotion;
		
		public bool bSwingLimitSoft;
		
		public bool bTwistLimitSoft;
		
		public float Swing1LimitAngle;
		
		public float Swing2LimitAngle;
		
		public float TwistLimitAngle;
		
		public float SwingLimitStiffness;
		
		public float SwingLimitDamping;
		
		public float TwistLimitStiffness;
		
		public float TwistLimitDamping;
		
		public bool bAngularBreakable;
		
		public float AngularBreakThreshold;
		
		
	}
	
}
