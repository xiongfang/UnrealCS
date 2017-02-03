#pragma once

namespace UnrealEngine
{
	class _UMultiLineEditableTextBox
	{
		static void SetError(UMultiLineEditableTextBox* _this,MonoString* InError)
		{
			FText InError_temp=FText::FromString(MonoStringToFString(InError));
			_this->SetError(InError_temp);
			
		}
		static void SetText(UMultiLineEditableTextBox* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			_this->SetText(InText_temp);
			
		}
		static MonoString* GetText(UMultiLineEditableTextBox* _this)
		{
			FText ___ret = _this->GetText();
			return FStringToMonoString(___ret.ToString());
			
		}
		static UClass* StaticClass(){return UMultiLineEditableTextBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMultiLineEditableTextBox::SetError",(const void*)SetError);
			mono_add_internal_call("UnrealEngine.UMultiLineEditableTextBox::SetText",(const void*)SetText);
			mono_add_internal_call("UnrealEngine.UMultiLineEditableTextBox::GetText",(const void*)GetText);
			mono_add_internal_call("UnrealEngine.UMultiLineEditableTextBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
