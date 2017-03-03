#pragma once

namespace UnrealEngine
{
	class _UCanvasPanelSlot
	{
		static void SetMaximum(UCanvasPanelSlot* _this,FVector2D* InMaximumAnchors)
		{
			_this->SetMaximum(*InMaximumAnchors);
			
		}
		static void SetMinimum(UCanvasPanelSlot* _this,FVector2D* InMinimumAnchors)
		{
			_this->SetMinimum(*InMinimumAnchors);
			
		}
		static int32 GetZOrder(UCanvasPanelSlot* _this)
		{
			int32 ___ret = _this->GetZOrder();
			return ___ret;
			
		}
		static void SetZOrder(UCanvasPanelSlot* _this,int32 InZOrder)
		{
			_this->SetZOrder(InZOrder);
			
		}
		static int32 GetAutoSize(UCanvasPanelSlot* _this)
		{
			bool ___ret = _this->GetAutoSize();
			return ___ret?1:0;
			
		}
		static void SetAutoSize(UCanvasPanelSlot* _this,int32 InbAutoSize)
		{
			_this->SetAutoSize(InbAutoSize>0?true:false);
			
		}
		static FVector2D GetAlignment(UCanvasPanelSlot* _this)
		{
			FVector2D ___ret = _this->GetAlignment();
			return ___ret;
			
		}
		static void SetAlignment(UCanvasPanelSlot* _this,FVector2D* InAlignment)
		{
			_this->SetAlignment(*InAlignment);
			
		}
		static FAnchors GetAnchors(UCanvasPanelSlot* _this)
		{
			FAnchors ___ret = _this->GetAnchors();
			return ___ret;
			
		}
		static void SetAnchors(UCanvasPanelSlot* _this,FAnchors* InAnchors)
		{
			_this->SetAnchors(*InAnchors);
			
		}
		static FMargin GetOffsets(UCanvasPanelSlot* _this)
		{
			FMargin ___ret = _this->GetOffsets();
			return ___ret;
			
		}
		static void SetOffsets(UCanvasPanelSlot* _this,FMargin* InOffset)
		{
			_this->SetOffsets(*InOffset);
			
		}
		static FVector2D GetSize(UCanvasPanelSlot* _this)
		{
			FVector2D ___ret = _this->GetSize();
			return ___ret;
			
		}
		static void SetSize(UCanvasPanelSlot* _this,FVector2D* InSize)
		{
			_this->SetSize(*InSize);
			
		}
		static FVector2D GetPosition(UCanvasPanelSlot* _this)
		{
			FVector2D ___ret = _this->GetPosition();
			return ___ret;
			
		}
		static void SetPosition(UCanvasPanelSlot* _this,FVector2D* InPosition)
		{
			_this->SetPosition(*InPosition);
			
		}
		static FAnchorData GetLayout(UCanvasPanelSlot* _this)
		{
			FAnchorData ___ret = _this->GetLayout();
			return ___ret;
			
		}
		static void SetLayout(UCanvasPanelSlot* _this,FAnchorData* InLayoutData)
		{
			_this->SetLayout(*InLayoutData);
			
		}
		static UClass* StaticClass(){return UCanvasPanelSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetMaximum",(const void*)SetMaximum);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetMinimum",(const void*)SetMinimum);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::GetZOrder",(const void*)GetZOrder);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetZOrder",(const void*)SetZOrder);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::GetAutoSize",(const void*)GetAutoSize);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetAutoSize",(const void*)SetAutoSize);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::GetAlignment",(const void*)GetAlignment);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetAlignment",(const void*)SetAlignment);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::GetAnchors",(const void*)GetAnchors);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetAnchors",(const void*)SetAnchors);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::GetOffsets",(const void*)GetOffsets);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetOffsets",(const void*)SetOffsets);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::GetSize",(const void*)GetSize);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetSize",(const void*)SetSize);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::GetPosition",(const void*)GetPosition);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetPosition",(const void*)SetPosition);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::GetLayout",(const void*)GetLayout);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::SetLayout",(const void*)SetLayout);
			mono_add_internal_call("UnrealEngine.UCanvasPanelSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
