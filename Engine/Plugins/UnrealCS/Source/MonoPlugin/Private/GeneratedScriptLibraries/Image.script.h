#pragma once

namespace UnrealEngine
{
	class _UImage
	{
		static UMaterialInstanceDynamic* GetDynamicMaterial(UImage* _this)
		{
			UMaterialInstanceDynamic* ___ret = _this->GetDynamicMaterial();
			return ___ret;
			
		}
		static void SetBrushFromMaterial(UImage* _this,UMaterialInterface* Material)
		{
			_this->SetBrushFromMaterial(Material);
			
		}
		static void SetBrushFromTexture(UImage* _this,UTexture2D* Texture,int32 bMatchSize)
		{
			_this->SetBrushFromTexture(Texture,bMatchSize>0?true:false);
			
		}
		static void SetBrushFromAsset(UImage* _this,USlateBrushAsset* Asset)
		{
			_this->SetBrushFromAsset(Asset);
			
		}
		static void SetBrush(UImage* _this,FSlateBrush* InBrush)
		{
			_this->SetBrush(*InBrush);
			
		}
		static void SetOpacity(UImage* _this,float InOpacity)
		{
			_this->SetOpacity(InOpacity);
			
		}
		static void SetColorAndOpacity(UImage* _this,FLinearColor* InColorAndOpacity)
		{
			_this->SetColorAndOpacity(*InColorAndOpacity);
			
		}
		static UClass* StaticClass(){return UImage::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UImage::GetDynamicMaterial",(const void*)GetDynamicMaterial);
			mono_add_internal_call("UnrealEngine.UImage::SetBrushFromMaterial",(const void*)SetBrushFromMaterial);
			mono_add_internal_call("UnrealEngine.UImage::SetBrushFromTexture",(const void*)SetBrushFromTexture);
			mono_add_internal_call("UnrealEngine.UImage::SetBrushFromAsset",(const void*)SetBrushFromAsset);
			mono_add_internal_call("UnrealEngine.UImage::SetBrush",(const void*)SetBrush);
			mono_add_internal_call("UnrealEngine.UImage::SetOpacity",(const void*)SetOpacity);
			mono_add_internal_call("UnrealEngine.UImage::SetColorAndOpacity",(const void*)SetColorAndOpacity);
			mono_add_internal_call("UnrealEngine.UImage::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
