#pragma once

namespace UnrealEngine
{
	class _UAsyncTaskDownloadImage
	{
		static UAsyncTaskDownloadImage* DownloadImage(UAsyncTaskDownloadImage* _this,MonoString* URL)
		{
			FString URL_temp=MonoStringToFString(URL);
			UAsyncTaskDownloadImage* ___ret = _this->DownloadImage(URL_temp);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UAsyncTaskDownloadImage::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAsyncTaskDownloadImage::DownloadImage",(const void*)DownloadImage);
			mono_add_internal_call("UnrealEngine.UAsyncTaskDownloadImage::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
