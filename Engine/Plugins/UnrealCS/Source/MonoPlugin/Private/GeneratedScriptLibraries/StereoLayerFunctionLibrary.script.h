#pragma once

namespace UnrealEngine
{
	class _UStereoLayerFunctionLibrary
	{
		static void EnableAutoLoadingSplashScreen(UStereoLayerFunctionLibrary* _this,int32 InAutoShowEnabled)
		{
			_this->EnableAutoLoadingSplashScreen(InAutoShowEnabled>0?true:false);
			
		}
		static void HideSplashScreen(UStereoLayerFunctionLibrary* _this)
		{
			_this->HideSplashScreen();
			
		}
		static void ShowSplashScreen(UStereoLayerFunctionLibrary* _this)
		{
			_this->ShowSplashScreen();
			
		}
		static void SetSplashScreen(UStereoLayerFunctionLibrary* _this,UTexture* Texture,FVector2D* Scale,FVector2D* Offset,int32 bShowLoadingMovie,int32 bShowOnSet)
		{
			_this->SetSplashScreen(Texture,*Scale,*Offset,bShowLoadingMovie>0?true:false,bShowOnSet>0?true:false);
			
		}
		static UClass* StaticClass(){return UStereoLayerFunctionLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UStereoLayerFunctionLibrary::EnableAutoLoadingSplashScreen",(const void*)EnableAutoLoadingSplashScreen);
			mono_add_internal_call("UnrealEngine.UStereoLayerFunctionLibrary::HideSplashScreen",(const void*)HideSplashScreen);
			mono_add_internal_call("UnrealEngine.UStereoLayerFunctionLibrary::ShowSplashScreen",(const void*)ShowSplashScreen);
			mono_add_internal_call("UnrealEngine.UStereoLayerFunctionLibrary::SetSplashScreen",(const void*)SetSplashScreen);
			mono_add_internal_call("UnrealEngine.UStereoLayerFunctionLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
