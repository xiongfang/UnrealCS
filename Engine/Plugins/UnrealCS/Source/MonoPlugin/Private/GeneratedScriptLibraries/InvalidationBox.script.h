#pragma once

namespace UnrealEngine
{
	class _UInvalidationBox
	{
		static void SetCanCache(UInvalidationBox* _this,int32 CanCache)
		{
			_this->SetCanCache(CanCache>0?true:false);
			
		}
		static int32 GetCanCache(UInvalidationBox* _this)
		{
			bool ___ret = _this->GetCanCache();
			return ___ret?1:0;
			
		}
		static void InvalidateCache(UInvalidationBox* _this)
		{
			_this->InvalidateCache();
			
		}
		static UClass* StaticClass(){return UInvalidationBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInvalidationBox::SetCanCache",(const void*)SetCanCache);
			mono_add_internal_call("UnrealEngine.UInvalidationBox::GetCanCache",(const void*)GetCanCache);
			mono_add_internal_call("UnrealEngine.UInvalidationBox::InvalidateCache",(const void*)InvalidateCache);
			mono_add_internal_call("UnrealEngine.UInvalidationBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
