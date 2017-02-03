#pragma once

namespace UnrealEngine
{
	class _UExpandableArea
	{
		static void SetIsExpanded(UExpandableArea* _this,int32 IsExpanded)
		{
			_this->SetIsExpanded(IsExpanded>0?true:false);
			
		}
		static int32 GetIsExpanded(UExpandableArea* _this)
		{
			bool ___ret = _this->GetIsExpanded();
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UExpandableArea::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UExpandableArea::SetIsExpanded",(const void*)SetIsExpanded);
			mono_add_internal_call("UnrealEngine.UExpandableArea::GetIsExpanded",(const void*)GetIsExpanded);
			mono_add_internal_call("UnrealEngine.UExpandableArea::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
