#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicsConstraintTemplate
	{
		static readonly int DefaultInstance__Offset;
		public FConstraintInstance DefaultInstance
		{
			get{ CheckIsValid();return (FConstraintInstance)Marshal.PtrToStructure(_this.Get()+DefaultInstance__Offset, typeof(FConstraintInstance));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultInstance__Offset, false);}
			
		}
		
		static readonly int ProfileHandles__Offset;
		/// <summary>Handles to the constraint profiles applicable to this constraint</summary>
		public TStructArray<FPhysicsConstraintProfileHandle> ProfileHandles
		{
			get{ CheckIsValid();return new TStructArray<FPhysicsConstraintProfileHandle>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ProfileHandles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ProfileHandles__Offset, false);}
			
		}
		
		static readonly int DefaultProfile__Offset;
		/// <summary>When no profile is selected, use these settings. Only needed in editor as we serialize it into DefaultInstance on save</summary>
		public FConstraintProfileProperties DefaultProfile
		{
			get{ CheckIsValid();return (FConstraintProfileProperties)Marshal.PtrToStructure(_this.Get()+DefaultProfile__Offset, typeof(FConstraintProfileProperties));}
			
		}
		
		static readonly int JointName__Offset;
		public FName JointName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+JointName__Offset, typeof(FName));}
			
		}
		
		static readonly int ConstraintBone1__Offset;
		public FName ConstraintBone1
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ConstraintBone1__Offset, typeof(FName));}
			
		}
		
		static readonly int ConstraintBone2__Offset;
		public FName ConstraintBone2
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ConstraintBone2__Offset, typeof(FName));}
			
		}
		
		static readonly int Pos1__Offset;
		public FVector Pos1
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Pos1__Offset, typeof(FVector));}
			
		}
		
		static readonly int PriAxis1__Offset;
		public FVector PriAxis1
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PriAxis1__Offset, typeof(FVector));}
			
		}
		
		static readonly int SecAxis1__Offset;
		public FVector SecAxis1
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+SecAxis1__Offset, typeof(FVector));}
			
		}
		
		static readonly int Pos2__Offset;
		public FVector Pos2
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Pos2__Offset, typeof(FVector));}
			
		}
		
		static readonly int PriAxis2__Offset;
		public FVector PriAxis2
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PriAxis2__Offset, typeof(FVector));}
			
		}
		
		static readonly int SecAxis2__Offset;
		public FVector SecAxis2
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+SecAxis2__Offset, typeof(FVector));}
			
		}
		
		static readonly int bEnableProjection__Offset;
		public bool bEnableProjection
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableProjection__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int ProjectionLinearTolerance__Offset;
		public float ProjectionLinearTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ProjectionLinearTolerance__Offset, typeof(float));}
			
		}
		
		static readonly int ProjectionAngularTolerance__Offset;
		public float ProjectionAngularTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ProjectionAngularTolerance__Offset, typeof(float));}
			
		}
		
		static readonly int LinearXMotion__Offset;
		public ELinearConstraintMotion LinearXMotion
		{
			get{ CheckIsValid();return (ELinearConstraintMotion)Marshal.PtrToStructure(_this.Get()+LinearXMotion__Offset, typeof(ELinearConstraintMotion));}
			
		}
		
		static readonly int LinearYMotion__Offset;
		public ELinearConstraintMotion LinearYMotion
		{
			get{ CheckIsValid();return (ELinearConstraintMotion)Marshal.PtrToStructure(_this.Get()+LinearYMotion__Offset, typeof(ELinearConstraintMotion));}
			
		}
		
		static readonly int LinearZMotion__Offset;
		public ELinearConstraintMotion LinearZMotion
		{
			get{ CheckIsValid();return (ELinearConstraintMotion)Marshal.PtrToStructure(_this.Get()+LinearZMotion__Offset, typeof(ELinearConstraintMotion));}
			
		}
		
		static readonly int LinearLimitSize__Offset;
		public float LinearLimitSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinearLimitSize__Offset, typeof(float));}
			
		}
		
		static readonly int bLinearLimitSoft__Offset;
		public bool bLinearLimitSoft
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLinearLimitSoft__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int LinearLimitStiffness__Offset;
		public float LinearLimitStiffness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinearLimitStiffness__Offset, typeof(float));}
			
		}
		
		static readonly int LinearLimitDamping__Offset;
		public float LinearLimitDamping
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinearLimitDamping__Offset, typeof(float));}
			
		}
		
		static readonly int bLinearBreakable__Offset;
		public bool bLinearBreakable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLinearBreakable__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int LinearBreakThreshold__Offset;
		public float LinearBreakThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinearBreakThreshold__Offset, typeof(float));}
			
		}
		
		static readonly int AngularSwing1Motion__Offset;
		public EAngularConstraintMotion AngularSwing1Motion
		{
			get{ CheckIsValid();return (EAngularConstraintMotion)Marshal.PtrToStructure(_this.Get()+AngularSwing1Motion__Offset, typeof(EAngularConstraintMotion));}
			
		}
		
		static readonly int AngularSwing2Motion__Offset;
		public EAngularConstraintMotion AngularSwing2Motion
		{
			get{ CheckIsValid();return (EAngularConstraintMotion)Marshal.PtrToStructure(_this.Get()+AngularSwing2Motion__Offset, typeof(EAngularConstraintMotion));}
			
		}
		
		static readonly int AngularTwistMotion__Offset;
		public EAngularConstraintMotion AngularTwistMotion
		{
			get{ CheckIsValid();return (EAngularConstraintMotion)Marshal.PtrToStructure(_this.Get()+AngularTwistMotion__Offset, typeof(EAngularConstraintMotion));}
			
		}
		
		static readonly int bSwingLimitSoft__Offset;
		public bool bSwingLimitSoft
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSwingLimitSoft__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bTwistLimitSoft__Offset;
		public bool bTwistLimitSoft
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTwistLimitSoft__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int Swing1LimitAngle__Offset;
		public float Swing1LimitAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Swing1LimitAngle__Offset, typeof(float));}
			
		}
		
		static readonly int Swing2LimitAngle__Offset;
		public float Swing2LimitAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Swing2LimitAngle__Offset, typeof(float));}
			
		}
		
		static readonly int TwistLimitAngle__Offset;
		public float TwistLimitAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TwistLimitAngle__Offset, typeof(float));}
			
		}
		
		static readonly int SwingLimitStiffness__Offset;
		public float SwingLimitStiffness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SwingLimitStiffness__Offset, typeof(float));}
			
		}
		
		static readonly int SwingLimitDamping__Offset;
		public float SwingLimitDamping
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SwingLimitDamping__Offset, typeof(float));}
			
		}
		
		static readonly int TwistLimitStiffness__Offset;
		public float TwistLimitStiffness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TwistLimitStiffness__Offset, typeof(float));}
			
		}
		
		static readonly int TwistLimitDamping__Offset;
		public float TwistLimitDamping
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TwistLimitDamping__Offset, typeof(float));}
			
		}
		
		static readonly int bAngularBreakable__Offset;
		public bool bAngularBreakable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAngularBreakable__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int AngularBreakThreshold__Offset;
		public float AngularBreakThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngularBreakThreshold__Offset, typeof(float));}
			
		}
		
		static UPhysicsConstraintTemplate()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsConstraintTemplate");
			DefaultInstance__Offset=GetPropertyOffset(NativeClassPtr,"DefaultInstance");
			ProfileHandles__Offset=GetPropertyOffset(NativeClassPtr,"ProfileHandles");
			DefaultProfile__Offset=GetPropertyOffset(NativeClassPtr,"DefaultProfile");
			JointName__Offset=GetPropertyOffset(NativeClassPtr,"JointName");
			ConstraintBone1__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintBone1");
			ConstraintBone2__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintBone2");
			Pos1__Offset=GetPropertyOffset(NativeClassPtr,"Pos1");
			PriAxis1__Offset=GetPropertyOffset(NativeClassPtr,"PriAxis1");
			SecAxis1__Offset=GetPropertyOffset(NativeClassPtr,"SecAxis1");
			Pos2__Offset=GetPropertyOffset(NativeClassPtr,"Pos2");
			PriAxis2__Offset=GetPropertyOffset(NativeClassPtr,"PriAxis2");
			SecAxis2__Offset=GetPropertyOffset(NativeClassPtr,"SecAxis2");
			bEnableProjection__Offset=GetPropertyOffset(NativeClassPtr,"bEnableProjection");
			ProjectionLinearTolerance__Offset=GetPropertyOffset(NativeClassPtr,"ProjectionLinearTolerance");
			ProjectionAngularTolerance__Offset=GetPropertyOffset(NativeClassPtr,"ProjectionAngularTolerance");
			LinearXMotion__Offset=GetPropertyOffset(NativeClassPtr,"LinearXMotion");
			LinearYMotion__Offset=GetPropertyOffset(NativeClassPtr,"LinearYMotion");
			LinearZMotion__Offset=GetPropertyOffset(NativeClassPtr,"LinearZMotion");
			LinearLimitSize__Offset=GetPropertyOffset(NativeClassPtr,"LinearLimitSize");
			bLinearLimitSoft__Offset=GetPropertyOffset(NativeClassPtr,"bLinearLimitSoft");
			LinearLimitStiffness__Offset=GetPropertyOffset(NativeClassPtr,"LinearLimitStiffness");
			LinearLimitDamping__Offset=GetPropertyOffset(NativeClassPtr,"LinearLimitDamping");
			bLinearBreakable__Offset=GetPropertyOffset(NativeClassPtr,"bLinearBreakable");
			LinearBreakThreshold__Offset=GetPropertyOffset(NativeClassPtr,"LinearBreakThreshold");
			AngularSwing1Motion__Offset=GetPropertyOffset(NativeClassPtr,"AngularSwing1Motion");
			AngularSwing2Motion__Offset=GetPropertyOffset(NativeClassPtr,"AngularSwing2Motion");
			AngularTwistMotion__Offset=GetPropertyOffset(NativeClassPtr,"AngularTwistMotion");
			bSwingLimitSoft__Offset=GetPropertyOffset(NativeClassPtr,"bSwingLimitSoft");
			bTwistLimitSoft__Offset=GetPropertyOffset(NativeClassPtr,"bTwistLimitSoft");
			Swing1LimitAngle__Offset=GetPropertyOffset(NativeClassPtr,"Swing1LimitAngle");
			Swing2LimitAngle__Offset=GetPropertyOffset(NativeClassPtr,"Swing2LimitAngle");
			TwistLimitAngle__Offset=GetPropertyOffset(NativeClassPtr,"TwistLimitAngle");
			SwingLimitStiffness__Offset=GetPropertyOffset(NativeClassPtr,"SwingLimitStiffness");
			SwingLimitDamping__Offset=GetPropertyOffset(NativeClassPtr,"SwingLimitDamping");
			TwistLimitStiffness__Offset=GetPropertyOffset(NativeClassPtr,"TwistLimitStiffness");
			TwistLimitDamping__Offset=GetPropertyOffset(NativeClassPtr,"TwistLimitDamping");
			bAngularBreakable__Offset=GetPropertyOffset(NativeClassPtr,"bAngularBreakable");
			AngularBreakThreshold__Offset=GetPropertyOffset(NativeClassPtr,"AngularBreakThreshold");
			
		}
		
	}
	
}
#endif
#endif
