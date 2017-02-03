#pragma once

namespace UnrealEngine
{
	class _UMultiLineEditableText
	{
		static void SetText(UMultiLineEditableText* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			_this->SetText(InText_temp);
			
		}
		static MonoString* GetText(UMultiLineEditableText* _this)
		{
			FText ___ret = _this->GetText();
			return FStringToMonoString(___ret.ToString());
			
		}
		static UClass* StaticClass(){return UMultiLineEditableText::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMultiLineEditableText::SetText",(const void*)SetText);
			mono_add_internal_call("UnrealEngine.UMultiLineEditableText::GetText",(const void*)GetText);
			mono_add_internal_call("UnrealEngine.UMultiLineEditableText::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
