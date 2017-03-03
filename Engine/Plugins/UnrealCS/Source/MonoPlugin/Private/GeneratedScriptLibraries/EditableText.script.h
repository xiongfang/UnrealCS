#pragma once

namespace UnrealEngine
{
	class _UEditableText
	{
		static void SetIsReadOnly(UEditableText* _this,int32 InbIsReadyOnly)
		{
			_this->SetIsReadOnly(InbIsReadyOnly>0?true:false);
			
		}
		static void SetHintText(UEditableText* _this,MonoString* InHintText)
		{
			FText InHintText_temp=FText::FromString(MonoStringToFString(InHintText));
			_this->SetHintText(InHintText_temp);
			
		}
		static void SetIsPassword(UEditableText* _this,int32 InbIsPassword)
		{
			_this->SetIsPassword(InbIsPassword>0?true:false);
			
		}
		static void SetText(UEditableText* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			_this->SetText(InText_temp);
			
		}
		static MonoString* GetText(UEditableText* _this)
		{
			FText ___ret = _this->GetText();
			return FStringToMonoString(___ret.ToString());
			
		}
		static UClass* StaticClass(){return UEditableText::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEditableText::SetIsReadOnly",(const void*)SetIsReadOnly);
			mono_add_internal_call("UnrealEngine.UEditableText::SetHintText",(const void*)SetHintText);
			mono_add_internal_call("UnrealEngine.UEditableText::SetIsPassword",(const void*)SetIsPassword);
			mono_add_internal_call("UnrealEngine.UEditableText::SetText",(const void*)SetText);
			mono_add_internal_call("UnrealEngine.UEditableText::GetText",(const void*)GetText);
			mono_add_internal_call("UnrealEngine.UEditableText::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
