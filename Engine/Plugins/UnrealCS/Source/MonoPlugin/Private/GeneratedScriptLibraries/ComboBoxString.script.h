#pragma once

namespace UnrealEngine
{
	class _UComboBoxString
	{
		static int32 GetOptionCount(UComboBoxString* _this)
		{
			int32 ___ret = _this->GetOptionCount();
			return ___ret;
			
		}
		static MonoString* GetSelectedOption(UComboBoxString* _this)
		{
			FString ___ret = _this->GetSelectedOption();
			return FStringToMonoString(___ret);
			
		}
		static void SetSelectedOption(UComboBoxString* _this,MonoString* Option)
		{
			FString Option_temp=MonoStringToFString(Option);
			_this->SetSelectedOption(Option_temp);
			
		}
		static void RefreshOptions(UComboBoxString* _this)
		{
			_this->RefreshOptions();
			
		}
		static void ClearSelection(UComboBoxString* _this)
		{
			_this->ClearSelection();
			
		}
		static void ClearOptions(UComboBoxString* _this)
		{
			_this->ClearOptions();
			
		}
		static MonoString* GetOptionAtIndex(UComboBoxString* _this,int32 Index)
		{
			FString ___ret = _this->GetOptionAtIndex(Index);
			return FStringToMonoString(___ret);
			
		}
		static int32 FindOptionIndex(UComboBoxString* _this,MonoString* Option)
		{
			FString Option_temp=MonoStringToFString(Option);
			int32 ___ret = _this->FindOptionIndex(Option_temp);
			return ___ret;
			
		}
		static int32 RemoveOption(UComboBoxString* _this,MonoString* Option)
		{
			FString Option_temp=MonoStringToFString(Option);
			bool ___ret = _this->RemoveOption(Option_temp);
			return ___ret?1:0;
			
		}
		static void AddOption(UComboBoxString* _this,MonoString* Option)
		{
			FString Option_temp=MonoStringToFString(Option);
			_this->AddOption(Option_temp);
			
		}
		static UClass* StaticClass(){return UComboBoxString::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UComboBoxString::GetOptionCount",(const void*)GetOptionCount);
			mono_add_internal_call("UnrealEngine.UComboBoxString::GetSelectedOption",(const void*)GetSelectedOption);
			mono_add_internal_call("UnrealEngine.UComboBoxString::SetSelectedOption",(const void*)SetSelectedOption);
			mono_add_internal_call("UnrealEngine.UComboBoxString::RefreshOptions",(const void*)RefreshOptions);
			mono_add_internal_call("UnrealEngine.UComboBoxString::ClearSelection",(const void*)ClearSelection);
			mono_add_internal_call("UnrealEngine.UComboBoxString::ClearOptions",(const void*)ClearOptions);
			mono_add_internal_call("UnrealEngine.UComboBoxString::GetOptionAtIndex",(const void*)GetOptionAtIndex);
			mono_add_internal_call("UnrealEngine.UComboBoxString::FindOptionIndex",(const void*)FindOptionIndex);
			mono_add_internal_call("UnrealEngine.UComboBoxString::RemoveOption",(const void*)RemoveOption);
			mono_add_internal_call("UnrealEngine.UComboBoxString::AddOption",(const void*)AddOption);
			mono_add_internal_call("UnrealEngine.UComboBoxString::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
