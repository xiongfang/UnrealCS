#pragma once

namespace UnrealEngine
{
	class _UPanelWidget
	{
		static void ClearChildren(UPanelWidget* _this)
		{
			_this->ClearChildren();
			
		}
		static int32 HasAnyChildren(UPanelWidget* _this)
		{
			bool ___ret = _this->HasAnyChildren();
			return ___ret?1:0;
			
		}
		static int32 RemoveChild(UPanelWidget* _this,UWidget* Content)
		{
			bool ___ret = _this->RemoveChild(Content);
			return ___ret?1:0;
			
		}
		static UPanelSlot* AddChild(UPanelWidget* _this,UWidget* Content)
		{
			UPanelSlot* ___ret = _this->AddChild(Content);
			return ___ret;
			
		}
		static int32 RemoveChildAt(UPanelWidget* _this,int32 Index)
		{
			bool ___ret = _this->RemoveChildAt(Index);
			return ___ret?1:0;
			
		}
		static int32 HasChild(UPanelWidget* _this,UWidget* Content)
		{
			bool ___ret = _this->HasChild(Content);
			return ___ret?1:0;
			
		}
		static int32 GetChildIndex(UPanelWidget* _this,UWidget* Content)
		{
			int32 ___ret = _this->GetChildIndex(Content);
			return ___ret;
			
		}
		static UWidget* GetChildAt(UPanelWidget* _this,int32 Index)
		{
			UWidget* ___ret = _this->GetChildAt(Index);
			return ___ret;
			
		}
		static int32 GetChildrenCount(UPanelWidget* _this)
		{
			int32 ___ret = _this->GetChildrenCount();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UPanelWidget::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPanelWidget::ClearChildren",(const void*)ClearChildren);
			mono_add_internal_call("UnrealEngine.UPanelWidget::HasAnyChildren",(const void*)HasAnyChildren);
			mono_add_internal_call("UnrealEngine.UPanelWidget::RemoveChild",(const void*)RemoveChild);
			mono_add_internal_call("UnrealEngine.UPanelWidget::AddChild",(const void*)AddChild);
			mono_add_internal_call("UnrealEngine.UPanelWidget::RemoveChildAt",(const void*)RemoveChildAt);
			mono_add_internal_call("UnrealEngine.UPanelWidget::HasChild",(const void*)HasChild);
			mono_add_internal_call("UnrealEngine.UPanelWidget::GetChildIndex",(const void*)GetChildIndex);
			mono_add_internal_call("UnrealEngine.UPanelWidget::GetChildAt",(const void*)GetChildAt);
			mono_add_internal_call("UnrealEngine.UPanelWidget::GetChildrenCount",(const void*)GetChildrenCount);
			mono_add_internal_call("UnrealEngine.UPanelWidget::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
