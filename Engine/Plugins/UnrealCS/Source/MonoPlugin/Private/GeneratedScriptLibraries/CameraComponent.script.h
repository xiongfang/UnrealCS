#pragma once

namespace UnrealEngine
{
	class _UCameraComponent
	{
		static void GetCameraView(UCameraComponent* _this,float DeltaTime,FMinimalViewInfo* DesiredView)
		{
			_this->GetCameraView(DeltaTime,*DesiredView);
			
		}
		static void SetPostProcessBlendWeight(UCameraComponent* _this,float InPostProcessBlendWeight)
		{
			_this->SetPostProcessBlendWeight(InPostProcessBlendWeight);
			
		}
		static void SetProjectionMode(UCameraComponent* _this,int32 InProjectionMode)
		{
			_this->SetProjectionMode((TEnumAsByte<ECameraProjectionMode::Type>)InProjectionMode);
			
		}
		static void SetUseFieldOfViewForLOD(UCameraComponent* _this,int32 bInUseFieldOfViewForLOD)
		{
			_this->SetUseFieldOfViewForLOD(bInUseFieldOfViewForLOD>0?true:false);
			
		}
		static void SetConstraintAspectRatio(UCameraComponent* _this,int32 bInConstrainAspectRatio)
		{
			_this->SetConstraintAspectRatio(bInConstrainAspectRatio>0?true:false);
			
		}
		static void SetAspectRatio(UCameraComponent* _this,float InAspectRatio)
		{
			_this->SetAspectRatio(InAspectRatio);
			
		}
		static void SetOrthoFarClipPlane(UCameraComponent* _this,float InOrthoFarClipPlane)
		{
			_this->SetOrthoFarClipPlane(InOrthoFarClipPlane);
			
		}
		static void SetOrthoNearClipPlane(UCameraComponent* _this,float InOrthoNearClipPlane)
		{
			_this->SetOrthoNearClipPlane(InOrthoNearClipPlane);
			
		}
		static void SetOrthoWidth(UCameraComponent* _this,float InOrthoWidth)
		{
			_this->SetOrthoWidth(InOrthoWidth);
			
		}
		static void SetFieldOfView(UCameraComponent* _this,float InFieldOfView)
		{
			_this->SetFieldOfView(InFieldOfView);
			
		}
		static UClass* StaticClass(){return UCameraComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCameraComponent::GetCameraView",(const void*)GetCameraView);
			mono_add_internal_call("UnrealEngine.UCameraComponent::SetPostProcessBlendWeight",(const void*)SetPostProcessBlendWeight);
			mono_add_internal_call("UnrealEngine.UCameraComponent::SetProjectionMode",(const void*)SetProjectionMode);
			mono_add_internal_call("UnrealEngine.UCameraComponent::SetUseFieldOfViewForLOD",(const void*)SetUseFieldOfViewForLOD);
			mono_add_internal_call("UnrealEngine.UCameraComponent::SetConstraintAspectRatio",(const void*)SetConstraintAspectRatio);
			mono_add_internal_call("UnrealEngine.UCameraComponent::SetAspectRatio",(const void*)SetAspectRatio);
			mono_add_internal_call("UnrealEngine.UCameraComponent::SetOrthoFarClipPlane",(const void*)SetOrthoFarClipPlane);
			mono_add_internal_call("UnrealEngine.UCameraComponent::SetOrthoNearClipPlane",(const void*)SetOrthoNearClipPlane);
			mono_add_internal_call("UnrealEngine.UCameraComponent::SetOrthoWidth",(const void*)SetOrthoWidth);
			mono_add_internal_call("UnrealEngine.UCameraComponent::SetFieldOfView",(const void*)SetFieldOfView);
			mono_add_internal_call("UnrealEngine.UCameraComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
