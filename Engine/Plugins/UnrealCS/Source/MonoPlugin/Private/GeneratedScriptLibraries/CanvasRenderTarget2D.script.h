#pragma once

namespace UnrealEngine
{
	class _UCanvasRenderTarget2D
	{
		static void GetSize(UCanvasRenderTarget2D* _this,int32* Width,int32* Height)
		{
			_this->GetSize(*Width,*Height);
			
		}
		static UCanvasRenderTarget2D* CreateCanvasRenderTarget2D(UCanvasRenderTarget2D* _this,UObject* WorldContextObject,TSubclassOf<UCanvasRenderTarget2D>  CanvasRenderTarget2DClass,int32 Width,int32 Height)
		{
			UCanvasRenderTarget2D* ___ret = _this->CreateCanvasRenderTarget2D(WorldContextObject,CanvasRenderTarget2DClass,Width,Height);
			return ___ret;
			
		}
		static void UpdateResource(UCanvasRenderTarget2D* _this)
		{
			_this->UpdateResource();
			
		}
		static UClass* StaticClass(){return UCanvasRenderTarget2D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCanvasRenderTarget2D::GetSize",(const void*)GetSize);
			mono_add_internal_call("UnrealEngine.UCanvasRenderTarget2D::CreateCanvasRenderTarget2D",(const void*)CreateCanvasRenderTarget2D);
			mono_add_internal_call("UnrealEngine.UCanvasRenderTarget2D::UpdateResource",(const void*)UpdateResource);
			mono_add_internal_call("UnrealEngine.UCanvasRenderTarget2D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
