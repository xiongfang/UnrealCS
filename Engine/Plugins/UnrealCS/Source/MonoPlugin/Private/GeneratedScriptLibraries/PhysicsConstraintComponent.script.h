#pragma once

namespace UnrealEngine
{
	class _UPhysicsConstraintComponent
	{
		static void GetConstraintForce(UPhysicsConstraintComponent* _this,FVector* OutLinearForce,FVector* OutAngularForce)
		{
			_this->GetConstraintForce(*OutLinearForce,*OutAngularForce);
			
		}
		static void SetDisableCollision(UPhysicsConstraintComponent* _this,int32 bDisableCollision)
		{
			_this->SetDisableCollision(bDisableCollision>0?true:false);
			
		}
		static void SetConstraintReferenceOrientation(UPhysicsConstraintComponent* _this,int32 Frame,FVector* PriAxis,FVector* SecAxis)
		{
			_this->SetConstraintReferenceOrientation((TEnumAsByte<EConstraintFrame::Type>)Frame,*PriAxis,*SecAxis);
			
		}
		static void SetConstraintReferencePosition(UPhysicsConstraintComponent* _this,int32 Frame,FVector* RefPosition)
		{
			_this->SetConstraintReferencePosition((TEnumAsByte<EConstraintFrame::Type>)Frame,*RefPosition);
			
		}
		static void SetConstraintReferenceFrame(UPhysicsConstraintComponent* _this,int32 Frame,FTransform* RefFrame)
		{
			_this->SetConstraintReferenceFrame((TEnumAsByte<EConstraintFrame::Type>)Frame,*RefFrame);
			
		}
		static float GetCurrentSwing2(UPhysicsConstraintComponent* _this)
		{
			float ___ret = _this->GetCurrentSwing2();
			return ___ret;
			
		}
		static float GetCurrentSwing1(UPhysicsConstraintComponent* _this)
		{
			float ___ret = _this->GetCurrentSwing1();
			return ___ret;
			
		}
		static float GetCurrentTwist(UPhysicsConstraintComponent* _this)
		{
			float ___ret = _this->GetCurrentTwist();
			return ___ret;
			
		}
		static void SetAngularTwistLimit(UPhysicsConstraintComponent* _this,int32 ConstraintType,float TwistLimitAngle)
		{
			_this->SetAngularTwistLimit((TEnumAsByte<EAngularConstraintMotion>)ConstraintType,TwistLimitAngle);
			
		}
		static void SetAngularSwing2Limit(UPhysicsConstraintComponent* _this,int32 MotionType,float Swing2LimitAngle)
		{
			_this->SetAngularSwing2Limit((TEnumAsByte<EAngularConstraintMotion>)MotionType,Swing2LimitAngle);
			
		}
		static void SetAngularSwing1Limit(UPhysicsConstraintComponent* _this,int32 MotionType,float Swing1LimitAngle)
		{
			_this->SetAngularSwing1Limit((TEnumAsByte<EAngularConstraintMotion>)MotionType,Swing1LimitAngle);
			
		}
		static void SetLinearZLimit(UPhysicsConstraintComponent* _this,int32 ConstraintType,float LimitSize)
		{
			_this->SetLinearZLimit((TEnumAsByte<ELinearConstraintMotion>)ConstraintType,LimitSize);
			
		}
		static void SetLinearYLimit(UPhysicsConstraintComponent* _this,int32 ConstraintType,float LimitSize)
		{
			_this->SetLinearYLimit((TEnumAsByte<ELinearConstraintMotion>)ConstraintType,LimitSize);
			
		}
		static void SetLinearXLimit(UPhysicsConstraintComponent* _this,int32 ConstraintType,float LimitSize)
		{
			_this->SetLinearXLimit((TEnumAsByte<ELinearConstraintMotion>)ConstraintType,LimitSize);
			
		}
		static void SetAngularDriveParams(UPhysicsConstraintComponent* _this,float PositionStrength,float VelocityStrength,float InForceLimit)
		{
			_this->SetAngularDriveParams(PositionStrength,VelocityStrength,InForceLimit);
			
		}
		static void SetAngularVelocityTarget(UPhysicsConstraintComponent* _this,FVector* InVelTarget)
		{
			_this->SetAngularVelocityTarget(*InVelTarget);
			
		}
		static void SetAngularOrientationTarget(UPhysicsConstraintComponent* _this,FRotator* InPosTarget)
		{
			_this->SetAngularOrientationTarget(*InPosTarget);
			
		}
		static void SetLinearDriveParams(UPhysicsConstraintComponent* _this,float PositionStrength,float VelocityStrength,float InForceLimit)
		{
			_this->SetLinearDriveParams(PositionStrength,VelocityStrength,InForceLimit);
			
		}
		static void SetLinearVelocityTarget(UPhysicsConstraintComponent* _this,FVector* InVelTarget)
		{
			_this->SetLinearVelocityTarget(*InVelTarget);
			
		}
		static void SetLinearPositionTarget(UPhysicsConstraintComponent* _this,FVector* InPosTarget)
		{
			_this->SetLinearPositionTarget(*InPosTarget);
			
		}
		static void SetAngularDriveMode(UPhysicsConstraintComponent* _this,int32 DriveMode)
		{
			_this->SetAngularDriveMode((TEnumAsByte<EAngularDriveMode::Type>)DriveMode);
			
		}
		static void SetAngularVelocityDriveSLERP(UPhysicsConstraintComponent* _this,int32 bEnableSLERP)
		{
			_this->SetAngularVelocityDriveSLERP(bEnableSLERP>0?true:false);
			
		}
		static void SetAngularVelocityDriveTwistAndSwing(UPhysicsConstraintComponent* _this,int32 bEnableTwistDrive,int32 bEnableSwingDrive)
		{
			_this->SetAngularVelocityDriveTwistAndSwing(bEnableTwistDrive>0?true:false,bEnableSwingDrive>0?true:false);
			
		}
		static void SetOrientationDriveSLERP(UPhysicsConstraintComponent* _this,int32 bEnableSLERP)
		{
			_this->SetOrientationDriveSLERP(bEnableSLERP>0?true:false);
			
		}
		static void SetOrientationDriveTwistAndSwing(UPhysicsConstraintComponent* _this,int32 bEnableTwistDrive,int32 bEnableSwingDrive)
		{
			_this->SetOrientationDriveTwistAndSwing(bEnableTwistDrive>0?true:false,bEnableSwingDrive>0?true:false);
			
		}
		static void SetLinearVelocityDrive(UPhysicsConstraintComponent* _this,int32 bEnableDriveX,int32 bEnableDriveY,int32 bEnableDriveZ)
		{
			_this->SetLinearVelocityDrive(bEnableDriveX>0?true:false,bEnableDriveY>0?true:false,bEnableDriveZ>0?true:false);
			
		}
		static void SetLinearPositionDrive(UPhysicsConstraintComponent* _this,int32 bEnableDriveX,int32 bEnableDriveY,int32 bEnableDriveZ)
		{
			_this->SetLinearPositionDrive(bEnableDriveX>0?true:false,bEnableDriveY>0?true:false,bEnableDriveZ>0?true:false);
			
		}
		static void BreakConstraint(UPhysicsConstraintComponent* _this)
		{
			_this->BreakConstraint();
			
		}
		static void SetConstrainedComponents(UPhysicsConstraintComponent* _this,UPrimitiveComponent* Component1,MonoString* BoneName1,UPrimitiveComponent* Component2,MonoString* BoneName2)
		{
			FName BoneName1_temp=MonoStringToFName(BoneName1);
			FName BoneName2_temp=MonoStringToFName(BoneName2);
			_this->SetConstrainedComponents(Component1,BoneName1_temp,Component2,BoneName2_temp);
			
		}
		static UClass* StaticClass(){return UPhysicsConstraintComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::GetConstraintForce",(const void*)GetConstraintForce);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetDisableCollision",(const void*)SetDisableCollision);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetConstraintReferenceOrientation",(const void*)SetConstraintReferenceOrientation);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetConstraintReferencePosition",(const void*)SetConstraintReferencePosition);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetConstraintReferenceFrame",(const void*)SetConstraintReferenceFrame);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::GetCurrentSwing2",(const void*)GetCurrentSwing2);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::GetCurrentSwing1",(const void*)GetCurrentSwing1);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::GetCurrentTwist",(const void*)GetCurrentTwist);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetAngularTwistLimit",(const void*)SetAngularTwistLimit);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetAngularSwing2Limit",(const void*)SetAngularSwing2Limit);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetAngularSwing1Limit",(const void*)SetAngularSwing1Limit);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetLinearZLimit",(const void*)SetLinearZLimit);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetLinearYLimit",(const void*)SetLinearYLimit);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetLinearXLimit",(const void*)SetLinearXLimit);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetAngularDriveParams",(const void*)SetAngularDriveParams);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetAngularVelocityTarget",(const void*)SetAngularVelocityTarget);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetAngularOrientationTarget",(const void*)SetAngularOrientationTarget);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetLinearDriveParams",(const void*)SetLinearDriveParams);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetLinearVelocityTarget",(const void*)SetLinearVelocityTarget);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetLinearPositionTarget",(const void*)SetLinearPositionTarget);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetAngularDriveMode",(const void*)SetAngularDriveMode);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetAngularVelocityDriveSLERP",(const void*)SetAngularVelocityDriveSLERP);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetAngularVelocityDriveTwistAndSwing",(const void*)SetAngularVelocityDriveTwistAndSwing);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetOrientationDriveSLERP",(const void*)SetOrientationDriveSLERP);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetOrientationDriveTwistAndSwing",(const void*)SetOrientationDriveTwistAndSwing);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetLinearVelocityDrive",(const void*)SetLinearVelocityDrive);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetLinearPositionDrive",(const void*)SetLinearPositionDrive);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::BreakConstraint",(const void*)BreakConstraint);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::SetConstrainedComponents",(const void*)SetConstrainedComponents);
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
