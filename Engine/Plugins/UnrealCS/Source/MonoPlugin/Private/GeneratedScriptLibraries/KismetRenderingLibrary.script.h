#pragma once

namespace UnrealEngine
{
	class _UKismetRenderingLibrary
	{
		static void EndDrawCanvasToRenderTarget(UKismetRenderingLibrary* _this,UObject* WorldContextObject,FDrawToRenderTargetContext* Context)
		{
			_this->EndDrawCanvasToRenderTarget(WorldContextObject,*Context);
			
		}
		static void BeginDrawCanvasToRenderTarget(UKismetRenderingLibrary* _this,UObject* WorldContextObject,UTextureRenderTarget2D* TextureRenderTarget,UCanvas** Canvas,FVector2D* Size,FDrawToRenderTargetContext* Context)
		{
			_this->BeginDrawCanvasToRenderTarget(WorldContextObject,TextureRenderTarget,*Canvas,*Size,*Context);
			
		}
		static void ExportTexture2D(UKismetRenderingLibrary* _this,UObject* WorldContextObject,UTexture2D* Texture,MonoString* FilePath,MonoString* FileName)
		{
			FString FilePath_temp=MonoStringToFString(FilePath);
			FString FileName_temp=MonoStringToFString(FileName);
			_this->ExportTexture2D(WorldContextObject,Texture,FilePath_temp,FileName_temp);
			
		}
		static void ExportRenderTarget(UKismetRenderingLibrary* _this,UObject* WorldContextObject,UTextureRenderTarget2D* TextureRenderTarget,MonoString* FilePath,MonoString* FileName)
		{
			FString FilePath_temp=MonoStringToFString(FilePath);
			FString FileName_temp=MonoStringToFString(FileName);
			_this->ExportRenderTarget(WorldContextObject,TextureRenderTarget,FilePath_temp,FileName_temp);
			
		}
		static void DrawMaterialToRenderTarget(UKismetRenderingLibrary* _this,UObject* WorldContextObject,UTextureRenderTarget2D* TextureRenderTarget,UMaterialInterface* Material)
		{
			_this->DrawMaterialToRenderTarget(WorldContextObject,TextureRenderTarget,Material);
			
		}
		static UTextureRenderTarget2D* CreateRenderTarget2D(UKismetRenderingLibrary* _this,UObject* WorldContextObject,int32 Width,int32 Height)
		{
			UTextureRenderTarget2D* ___ret = _this->CreateRenderTarget2D(WorldContextObject,Width,Height);
			return ___ret;
			
		}
		static void ClearRenderTarget2D(UKismetRenderingLibrary* _this,UObject* WorldContextObject,UTextureRenderTarget2D* TextureRenderTarget,FLinearColor* ClearColor)
		{
			_this->ClearRenderTarget2D(WorldContextObject,TextureRenderTarget,*ClearColor);
			
		}
		static UClass* StaticClass(){return UKismetRenderingLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetRenderingLibrary::EndDrawCanvasToRenderTarget",(const void*)EndDrawCanvasToRenderTarget);
			mono_add_internal_call("UnrealEngine.UKismetRenderingLibrary::BeginDrawCanvasToRenderTarget",(const void*)BeginDrawCanvasToRenderTarget);
			mono_add_internal_call("UnrealEngine.UKismetRenderingLibrary::ExportTexture2D",(const void*)ExportTexture2D);
			mono_add_internal_call("UnrealEngine.UKismetRenderingLibrary::ExportRenderTarget",(const void*)ExportRenderTarget);
			mono_add_internal_call("UnrealEngine.UKismetRenderingLibrary::DrawMaterialToRenderTarget",(const void*)DrawMaterialToRenderTarget);
			mono_add_internal_call("UnrealEngine.UKismetRenderingLibrary::CreateRenderTarget2D",(const void*)CreateRenderTarget2D);
			mono_add_internal_call("UnrealEngine.UKismetRenderingLibrary::ClearRenderTarget2D",(const void*)ClearRenderTarget2D);
			mono_add_internal_call("UnrealEngine.UKismetRenderingLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
