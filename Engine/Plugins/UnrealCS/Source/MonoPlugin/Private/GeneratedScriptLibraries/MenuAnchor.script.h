#pragma once

namespace UnrealEngine
{
	class _UMenuAnchor
	{
		static int32 HasOpenSubMenus(UMenuAnchor* _this)
		{
			bool ___ret = _this->HasOpenSubMenus();
			return ___ret?1:0;
			
		}
		static FVector2D GetMenuPosition(UMenuAnchor* _this)
		{
			FVector2D ___ret = _this->GetMenuPosition();
			return ___ret;
			
		}
		static int32 ShouldOpenDueToClick(UMenuAnchor* _this)
		{
			bool ___ret = _this->ShouldOpenDueToClick();
			return ___ret?1:0;
			
		}
		static int32 IsOpen(UMenuAnchor* _this)
		{
			bool ___ret = _this->IsOpen();
			return ___ret?1:0;
			
		}
		static void Close(UMenuAnchor* _this)
		{
			_this->Close();
			
		}
		static void Open(UMenuAnchor* _this,int32 bFocusMenu)
		{
			_this->Open(bFocusMenu>0?true:false);
			
		}
		static void ToggleOpen(UMenuAnchor* _this,int32 bFocusOnOpen)
		{
			_this->ToggleOpen(bFocusOnOpen>0?true:false);
			
		}
		static UClass* StaticClass(){return UMenuAnchor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMenuAnchor::HasOpenSubMenus",(const void*)HasOpenSubMenus);
			mono_add_internal_call("UnrealEngine.UMenuAnchor::GetMenuPosition",(const void*)GetMenuPosition);
			mono_add_internal_call("UnrealEngine.UMenuAnchor::ShouldOpenDueToClick",(const void*)ShouldOpenDueToClick);
			mono_add_internal_call("UnrealEngine.UMenuAnchor::IsOpen",(const void*)IsOpen);
			mono_add_internal_call("UnrealEngine.UMenuAnchor::Close",(const void*)Close);
			mono_add_internal_call("UnrealEngine.UMenuAnchor::Open",(const void*)Open);
			mono_add_internal_call("UnrealEngine.UMenuAnchor::ToggleOpen",(const void*)ToggleOpen);
			mono_add_internal_call("UnrealEngine.UMenuAnchor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
