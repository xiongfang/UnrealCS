#pragma once

namespace UnrealEngine
{
	class _UBorder
	{
		static void SetDesiredSizeScale(UBorder* _this,FVector2D* InScale)
		{
			_this->SetDesiredSizeScale(*InScale);
			
		}
		static UMaterialInstanceDynamic* GetDynamicMaterial(UBorder* _this)
		{
			UMaterialInstanceDynamic* ___ret = _this->GetDynamicMaterial();
			return ___ret;
			
		}
		static void SetBrushFromMaterial(UBorder* _this,UMaterialInterface* Material)
		{
			_this->SetBrushFromMaterial(Material);
			
		}
		static void SetBrushFromTexture(UBorder* _this,UTexture2D* Texture)
		{
			_this->SetBrushFromTexture(Texture);
			
		}
		static void SetBrushFromAsset(UBorder* _this,USlateBrushAsset* Asset)
		{
			_this->SetBrushFromAsset(Asset);
			
		}
		static void SetBrush(UBorder* _this,FSlateBrush* InBrush)
		{
			_this->SetBrush(*InBrush);
			
		}
		static void SetBrushColor(UBorder* _this,FLinearColor* InBrushColor)
		{
			_this->SetBrushColor(*InBrushColor);
			
		}
		static void SetVerticalAlignment(UBorder* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UBorder* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetPadding(UBorder* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static void SetContentColorAndOpacity(UBorder* _this,FLinearColor* InContentColorAndOpacity)
		{
			_this->SetContentColorAndOpacity(*InContentColorAndOpacity);
			
		}
		static UClass* StaticClass(){return UBorder::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBorder::SetDesiredSizeScale",(const void*)SetDesiredSizeScale);
			mono_add_internal_call("UnrealEngine.UBorder::GetDynamicMaterial",(const void*)GetDynamicMaterial);
			mono_add_internal_call("UnrealEngine.UBorder::SetBrushFromMaterial",(const void*)SetBrushFromMaterial);
			mono_add_internal_call("UnrealEngine.UBorder::SetBrushFromTexture",(const void*)SetBrushFromTexture);
			mono_add_internal_call("UnrealEngine.UBorder::SetBrushFromAsset",(const void*)SetBrushFromAsset);
			mono_add_internal_call("UnrealEngine.UBorder::SetBrush",(const void*)SetBrush);
			mono_add_internal_call("UnrealEngine.UBorder::SetBrushColor",(const void*)SetBrushColor);
			mono_add_internal_call("UnrealEngine.UBorder::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UBorder::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UBorder::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UBorder::SetContentColorAndOpacity",(const void*)SetContentColorAndOpacity);
			mono_add_internal_call("UnrealEngine.UBorder::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
