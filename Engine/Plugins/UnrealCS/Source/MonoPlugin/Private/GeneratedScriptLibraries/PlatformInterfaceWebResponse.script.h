#pragma once

namespace UnrealEngine
{
	class _UPlatformInterfaceWebResponse
	{
		static MonoString* GetHeaderValue(UPlatformInterfaceWebResponse* _this,MonoString* HeaderName)
		{
			FString HeaderName_temp=MonoStringToFString(HeaderName);
			FString ___ret = _this->GetHeaderValue(HeaderName_temp);
			return FStringToMonoString(___ret);
			
		}
		static void GetHeader(UPlatformInterfaceWebResponse* _this,int32 HeaderIndex,MonoString** Header,MonoString** Value)
		{
			FString Header_temp;
			FString Value_temp;
			_this->GetHeader(HeaderIndex,Header_temp,Value_temp);
			*Header=FStringToMonoString(Header_temp);
			*Value=FStringToMonoString(Value_temp);
			
		}
		static int32 GetNumHeaders(UPlatformInterfaceWebResponse* _this)
		{
			int32 ___ret = _this->GetNumHeaders();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UPlatformInterfaceWebResponse::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPlatformInterfaceWebResponse::GetHeaderValue",(const void*)GetHeaderValue);
			mono_add_internal_call("UnrealEngine.UPlatformInterfaceWebResponse::GetHeader",(const void*)GetHeader);
			mono_add_internal_call("UnrealEngine.UPlatformInterfaceWebResponse::GetNumHeaders",(const void*)GetNumHeaders);
			mono_add_internal_call("UnrealEngine.UPlatformInterfaceWebResponse::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
