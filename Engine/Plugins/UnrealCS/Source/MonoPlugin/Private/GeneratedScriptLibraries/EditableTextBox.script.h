#pragma once

namespace UnrealEngine
{
	class _UEditableTextBox
	{
		static int32 HasError(UEditableTextBox* _this)
		{
			bool ___ret = _this->HasError();
			return ___ret?1:0;
			
		}
		static void ClearError(UEditableTextBox* _this)
		{
			_this->ClearError();
			
		}
		static void SetError(UEditableTextBox* _this,MonoString* InError)
		{
			FText InError_temp=FText::FromString(MonoStringToFString(InError));
			_this->SetError(InError_temp);
			
		}
		static void SetText(UEditableTextBox* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			_this->SetText(InText_temp);
			
		}
		static MonoString* GetText(UEditableTextBox* _this)
		{
			FText ___ret = _this->GetText();
			return FStringToMonoString(___ret.ToString());
			
		}
		static UClass* StaticClass(){return UEditableTextBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEditableTextBox::HasError",(const void*)HasError);
			mono_add_internal_call("UnrealEngine.UEditableTextBox::ClearError",(const void*)ClearError);
			mono_add_internal_call("UnrealEngine.UEditableTextBox::SetError",(const void*)SetError);
			mono_add_internal_call("UnrealEngine.UEditableTextBox::SetText",(const void*)SetText);
			mono_add_internal_call("UnrealEngine.UEditableTextBox::GetText",(const void*)GetText);
			mono_add_internal_call("UnrealEngine.UEditableTextBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
