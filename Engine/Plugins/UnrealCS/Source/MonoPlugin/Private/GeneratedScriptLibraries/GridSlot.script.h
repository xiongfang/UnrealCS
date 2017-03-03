#pragma once

namespace UnrealEngine
{
	class _UGridSlot
	{
		static void SetVerticalAlignment(UGridSlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UGridSlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetLayer(UGridSlot* _this,int32 InLayer)
		{
			_this->SetLayer(InLayer);
			
		}
		static void SetColumnSpan(UGridSlot* _this,int32 InColumnSpan)
		{
			_this->SetColumnSpan(InColumnSpan);
			
		}
		static void SetColumn(UGridSlot* _this,int32 InColumn)
		{
			_this->SetColumn(InColumn);
			
		}
		static void SetRowSpan(UGridSlot* _this,int32 InRowSpan)
		{
			_this->SetRowSpan(InRowSpan);
			
		}
		static void SetRow(UGridSlot* _this,int32 InRow)
		{
			_this->SetRow(InRow);
			
		}
		static void SetPadding(UGridSlot* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UGridSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UGridSlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UGridSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UGridSlot::SetLayer",(const void*)SetLayer);
			mono_add_internal_call("UnrealEngine.UGridSlot::SetColumnSpan",(const void*)SetColumnSpan);
			mono_add_internal_call("UnrealEngine.UGridSlot::SetColumn",(const void*)SetColumn);
			mono_add_internal_call("UnrealEngine.UGridSlot::SetRowSpan",(const void*)SetRowSpan);
			mono_add_internal_call("UnrealEngine.UGridSlot::SetRow",(const void*)SetRow);
			mono_add_internal_call("UnrealEngine.UGridSlot::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UGridSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
