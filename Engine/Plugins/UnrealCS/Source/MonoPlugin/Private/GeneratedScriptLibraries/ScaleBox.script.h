#pragma once

namespace UnrealEngine
{
	class _UScaleBox
	{
		static void SetIgnoreInheritedScale(UScaleBox* _this,int32 bInIgnoreInheritedScale)
		{
			_this->SetIgnoreInheritedScale(bInIgnoreInheritedScale>0?true:false);
			
		}
		static void SetUserSpecifiedScale(UScaleBox* _this,float InUserSpecifiedScale)
		{
			_this->SetUserSpecifiedScale(InUserSpecifiedScale);
			
		}
		static void SetStretchDirection(UScaleBox* _this,int32 InStretchDirection)
		{
			_this->SetStretchDirection((TEnumAsByte<EStretchDirection::Type>)InStretchDirection);
			
		}
		static void SetStretch(UScaleBox* _this,int32 InStretch)
		{
			_this->SetStretch((TEnumAsByte<EStretch::Type>)InStretch);
			
		}
		static UClass* StaticClass(){return UScaleBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UScaleBox::SetIgnoreInheritedScale",(const void*)SetIgnoreInheritedScale);
			mono_add_internal_call("UnrealEngine.UScaleBox::SetUserSpecifiedScale",(const void*)SetUserSpecifiedScale);
			mono_add_internal_call("UnrealEngine.UScaleBox::SetStretchDirection",(const void*)SetStretchDirection);
			mono_add_internal_call("UnrealEngine.UScaleBox::SetStretch",(const void*)SetStretch);
			mono_add_internal_call("UnrealEngine.UScaleBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
