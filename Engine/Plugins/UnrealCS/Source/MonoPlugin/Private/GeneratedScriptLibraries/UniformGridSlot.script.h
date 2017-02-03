#pragma once

namespace UnrealEngine
{
	class _UUniformGridSlot
	{
		static void SetVerticalAlignment(UUniformGridSlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UUniformGridSlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetColumn(UUniformGridSlot* _this,int32 InColumn)
		{
			_this->SetColumn(InColumn);
			
		}
		static void SetRow(UUniformGridSlot* _this,int32 InRow)
		{
			_this->SetRow(InRow);
			
		}
		static UClass* StaticClass(){return UUniformGridSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UUniformGridSlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UUniformGridSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UUniformGridSlot::SetColumn",(const void*)SetColumn);
			mono_add_internal_call("UnrealEngine.UUniformGridSlot::SetRow",(const void*)SetRow);
			mono_add_internal_call("UnrealEngine.UUniformGridSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
