#pragma once

namespace UnrealEngine
{
	class _UKismetGuidLibrary
	{
		static void Parse_StringToGuid(UKismetGuidLibrary* _this,MonoString* GuidString,FGuid* OutGuid,int32* Success)
		{
			FString GuidString_temp=MonoStringToFString(GuidString);
			bool Success_temp;
			_this->Parse_StringToGuid(GuidString_temp,*OutGuid,Success_temp);
			*Success=Success_temp!=0;
			
		}
		static MonoString* Conv_GuidToString(UKismetGuidLibrary* _this,FGuid* InGuid)
		{
			FString ___ret = _this->Conv_GuidToString(*InGuid);
			return FStringToMonoString(___ret);
			
		}
		static FGuid NewGuid(UKismetGuidLibrary* _this)
		{
			FGuid ___ret = _this->NewGuid();
			return ___ret;
			
		}
		static void Invalidate_Guid(UKismetGuidLibrary* _this,FGuid* InGuid)
		{
			_this->Invalidate_Guid(*InGuid);
			
		}
		static int32 IsValid_Guid(UKismetGuidLibrary* _this,FGuid* InGuid)
		{
			bool ___ret = _this->IsValid_Guid(*InGuid);
			return ___ret?1:0;
			
		}
		static int32 NotEqual_GuidGuid(UKismetGuidLibrary* _this,FGuid* A,FGuid* B)
		{
			bool ___ret = _this->NotEqual_GuidGuid(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_GuidGuid(UKismetGuidLibrary* _this,FGuid* A,FGuid* B)
		{
			bool ___ret = _this->EqualEqual_GuidGuid(*A,*B);
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UKismetGuidLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetGuidLibrary::Parse_StringToGuid",(const void*)Parse_StringToGuid);
			mono_add_internal_call("UnrealEngine.UKismetGuidLibrary::Conv_GuidToString",(const void*)Conv_GuidToString);
			mono_add_internal_call("UnrealEngine.UKismetGuidLibrary::NewGuid",(const void*)NewGuid);
			mono_add_internal_call("UnrealEngine.UKismetGuidLibrary::Invalidate_Guid",(const void*)Invalidate_Guid);
			mono_add_internal_call("UnrealEngine.UKismetGuidLibrary::IsValid_Guid",(const void*)IsValid_Guid);
			mono_add_internal_call("UnrealEngine.UKismetGuidLibrary::NotEqual_GuidGuid",(const void*)NotEqual_GuidGuid);
			mono_add_internal_call("UnrealEngine.UKismetGuidLibrary::EqualEqual_GuidGuid",(const void*)EqualEqual_GuidGuid);
			mono_add_internal_call("UnrealEngine.UKismetGuidLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
