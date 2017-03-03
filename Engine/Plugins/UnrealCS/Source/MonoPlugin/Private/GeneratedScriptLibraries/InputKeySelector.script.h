#pragma once

namespace UnrealEngine
{
	class _UInputKeySelector
	{
		static int32 GetIsSelectingKey(UInputKeySelector* _this)
		{
			bool ___ret = _this->GetIsSelectingKey();
			return ___ret?1:0;
			
		}
		static void SetAllowModifierKeys(UInputKeySelector* _this,int32 bInAllowModifierKeys)
		{
			_this->SetAllowModifierKeys(bInAllowModifierKeys>0?true:false);
			
		}
		static void SetKeySelectionText(UInputKeySelector* _this,MonoString* InKeySelectionText)
		{
			FText InKeySelectionText_temp=FText::FromString(MonoStringToFString(InKeySelectionText));
			_this->SetKeySelectionText(InKeySelectionText_temp);
			
		}
		static void SetSelectedKey(UInputKeySelector* _this,FInputChord* InSelectedKey)
		{
			_this->SetSelectedKey(*InSelectedKey);
			
		}
		static UClass* StaticClass(){return UInputKeySelector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputKeySelector::GetIsSelectingKey",(const void*)GetIsSelectingKey);
			mono_add_internal_call("UnrealEngine.UInputKeySelector::SetAllowModifierKeys",(const void*)SetAllowModifierKeys);
			mono_add_internal_call("UnrealEngine.UInputKeySelector::SetKeySelectionText",(const void*)SetKeySelectionText);
			mono_add_internal_call("UnrealEngine.UInputKeySelector::SetSelectedKey",(const void*)SetSelectedKey);
			mono_add_internal_call("UnrealEngine.UInputKeySelector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
