#pragma once

namespace UnrealEngine
{
	class _UHeadMountedDisplayFunctionLibrary
	{
		static void GetVRFocusState(UHeadMountedDisplayFunctionLibrary* _this,int32* bUseFocus,int32* bHasFocus)
		{
			bool bUseFocus_temp;
			bool bHasFocus_temp;
			_this->GetVRFocusState(bUseFocus_temp,bHasFocus_temp);
			*bUseFocus=bUseFocus_temp!=0;
			*bHasFocus=bHasFocus_temp!=0;
			
		}
		static int32 GetTrackingOrigin(UHeadMountedDisplayFunctionLibrary* _this)
		{
			TEnumAsByte<EHMDTrackingOrigin::Type> ___ret = _this->GetTrackingOrigin();
			return (int)___ret.GetValue();
			
		}
		static void SetTrackingOrigin(UHeadMountedDisplayFunctionLibrary* _this,int32 Origin)
		{
			_this->SetTrackingOrigin((TEnumAsByte<EHMDTrackingOrigin::Type>)Origin);
			
		}
		static float GetWorldToMetersScale(UHeadMountedDisplayFunctionLibrary* _this,UObject* WorldContext)
		{
			float ___ret = _this->GetWorldToMetersScale(WorldContext);
			return ___ret;
			
		}
		static void SetWorldToMetersScale(UHeadMountedDisplayFunctionLibrary* _this,UObject* WorldContext,float NewScale)
		{
			_this->SetWorldToMetersScale(WorldContext,NewScale);
			
		}
		static float GetScreenPercentage(UHeadMountedDisplayFunctionLibrary* _this)
		{
			float ___ret = _this->GetScreenPercentage();
			return ___ret;
			
		}
		static void SetClippingPlanes(UHeadMountedDisplayFunctionLibrary* _this,float Near,float Far)
		{
			_this->SetClippingPlanes(Near,Far);
			
		}
		static void ResetOrientationAndPosition(UHeadMountedDisplayFunctionLibrary* _this,float Yaw,int32 Options)
		{
			_this->ResetOrientationAndPosition(Yaw,(TEnumAsByte<EOrientPositionSelector::Type>)Options);
			
		}
		static void EnableLowPersistenceMode(UHeadMountedDisplayFunctionLibrary* _this,int32 bEnable)
		{
			_this->EnableLowPersistenceMode(bEnable>0?true:false);
			
		}
		static int32 IsInLowPersistenceMode(UHeadMountedDisplayFunctionLibrary* _this)
		{
			bool ___ret = _this->IsInLowPersistenceMode();
			return ___ret?1:0;
			
		}
		static void GetTrackingSensorParameters(UHeadMountedDisplayFunctionLibrary* _this,FVector* Origin,FRotator* Rotation,float* HFOV,float* VFOV,float* Distance,float* NearPlane,float* FarPlane,int32* IsActive,int32 Index)
		{
			bool IsActive_temp;
			_this->GetTrackingSensorParameters(*Origin,*Rotation,*HFOV,*VFOV,*Distance,*NearPlane,*FarPlane,IsActive_temp,Index);
			*IsActive=IsActive_temp!=0;
			
		}
		static int32 GetNumOfTrackingSensors(UHeadMountedDisplayFunctionLibrary* _this)
		{
			int32 ___ret = _this->GetNumOfTrackingSensors();
			return ___ret;
			
		}
		static int32 HasValidTrackingPosition(UHeadMountedDisplayFunctionLibrary* _this)
		{
			bool ___ret = _this->HasValidTrackingPosition();
			return ___ret?1:0;
			
		}
		static void GetOrientationAndPosition(UHeadMountedDisplayFunctionLibrary* _this,FRotator* DeviceRotation,FVector* DevicePosition)
		{
			_this->GetOrientationAndPosition(*DeviceRotation,*DevicePosition);
			
		}
		static MonoString* GetHMDDeviceName(UHeadMountedDisplayFunctionLibrary* _this)
		{
			FName ___ret = _this->GetHMDDeviceName();
			return FNameToMonoString(___ret);
			
		}
		static int32 EnableHMD(UHeadMountedDisplayFunctionLibrary* _this,int32 bEnable)
		{
			bool ___ret = _this->EnableHMD(bEnable>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 IsHeadMountedDisplayEnabled(UHeadMountedDisplayFunctionLibrary* _this)
		{
			bool ___ret = _this->IsHeadMountedDisplayEnabled();
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UHeadMountedDisplayFunctionLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::GetVRFocusState",(const void*)GetVRFocusState);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::GetTrackingOrigin",(const void*)GetTrackingOrigin);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::SetTrackingOrigin",(const void*)SetTrackingOrigin);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::GetWorldToMetersScale",(const void*)GetWorldToMetersScale);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::SetWorldToMetersScale",(const void*)SetWorldToMetersScale);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::GetScreenPercentage",(const void*)GetScreenPercentage);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::SetClippingPlanes",(const void*)SetClippingPlanes);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::ResetOrientationAndPosition",(const void*)ResetOrientationAndPosition);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::EnableLowPersistenceMode",(const void*)EnableLowPersistenceMode);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::IsInLowPersistenceMode",(const void*)IsInLowPersistenceMode);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::GetTrackingSensorParameters",(const void*)GetTrackingSensorParameters);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::GetNumOfTrackingSensors",(const void*)GetNumOfTrackingSensors);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::HasValidTrackingPosition",(const void*)HasValidTrackingPosition);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::GetOrientationAndPosition",(const void*)GetOrientationAndPosition);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::GetHMDDeviceName",(const void*)GetHMDDeviceName);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::EnableHMD",(const void*)EnableHMD);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::IsHeadMountedDisplayEnabled",(const void*)IsHeadMountedDisplayEnabled);
			mono_add_internal_call("UnrealEngine.UHeadMountedDisplayFunctionLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
