#pragma once

namespace UnrealEngine
{
	class _UNavigationPath
	{
		static int32 IsStringPulled(UNavigationPath* _this)
		{
			bool ___ret = _this->IsStringPulled();
			return ___ret?1:0;
			
		}
		static int32 IsValid(UNavigationPath* _this)
		{
			bool ___ret = _this->IsValid();
			return ___ret?1:0;
			
		}
		static int32 IsPartial(UNavigationPath* _this)
		{
			bool ___ret = _this->IsPartial();
			return ___ret?1:0;
			
		}
		static float GetPathCost(UNavigationPath* _this)
		{
			float ___ret = _this->GetPathCost();
			return ___ret;
			
		}
		static float GetPathLength(UNavigationPath* _this)
		{
			float ___ret = _this->GetPathLength();
			return ___ret;
			
		}
		static void EnableRecalculationOnInvalidation(UNavigationPath* _this,int32 DoRecalculation)
		{
			_this->EnableRecalculationOnInvalidation((TEnumAsByte<ENavigationOptionFlag::Type>)DoRecalculation);
			
		}
		static void EnableDebugDrawing(UNavigationPath* _this,int32 bShouldDrawDebugData,FLinearColor* PathColor)
		{
			_this->EnableDebugDrawing(bShouldDrawDebugData>0?true:false,*PathColor);
			
		}
		static MonoString* GetDebugString(UNavigationPath* _this)
		{
			FString ___ret = _this->GetDebugString();
			return FStringToMonoString(___ret);
			
		}
		static UClass* StaticClass(){return UNavigationPath::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavigationPath::IsStringPulled",(const void*)IsStringPulled);
			mono_add_internal_call("UnrealEngine.UNavigationPath::IsValid",(const void*)IsValid);
			mono_add_internal_call("UnrealEngine.UNavigationPath::IsPartial",(const void*)IsPartial);
			mono_add_internal_call("UnrealEngine.UNavigationPath::GetPathCost",(const void*)GetPathCost);
			mono_add_internal_call("UnrealEngine.UNavigationPath::GetPathLength",(const void*)GetPathLength);
			mono_add_internal_call("UnrealEngine.UNavigationPath::EnableRecalculationOnInvalidation",(const void*)EnableRecalculationOnInvalidation);
			mono_add_internal_call("UnrealEngine.UNavigationPath::EnableDebugDrawing",(const void*)EnableDebugDrawing);
			mono_add_internal_call("UnrealEngine.UNavigationPath::GetDebugString",(const void*)GetDebugString);
			mono_add_internal_call("UnrealEngine.UNavigationPath::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
