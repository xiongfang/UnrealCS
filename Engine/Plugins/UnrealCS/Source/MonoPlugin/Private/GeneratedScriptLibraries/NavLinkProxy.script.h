#pragma once

namespace UnrealEngine
{
	class _ANavLinkProxy
	{
		static int32 HasMovingAgents(ANavLinkProxy* _this)
		{
			bool ___ret = _this->HasMovingAgents();
			return ___ret?1:0;
			
		}
		static void SetSmartLinkEnabled(ANavLinkProxy* _this,int32 bEnabled)
		{
			_this->SetSmartLinkEnabled(bEnabled>0?true:false);
			
		}
		static int32 IsSmartLinkEnabled(ANavLinkProxy* _this)
		{
			bool ___ret = _this->IsSmartLinkEnabled();
			return ___ret?1:0;
			
		}
		static void ResumePathFollowing(ANavLinkProxy* _this,AActor* Agent)
		{
			_this->ResumePathFollowing(Agent);
			
		}
		static UClass* StaticClass(){return ANavLinkProxy::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ANavLinkProxy::HasMovingAgents",(const void*)HasMovingAgents);
			mono_add_internal_call("UnrealEngine.ANavLinkProxy::SetSmartLinkEnabled",(const void*)SetSmartLinkEnabled);
			mono_add_internal_call("UnrealEngine.ANavLinkProxy::IsSmartLinkEnabled",(const void*)IsSmartLinkEnabled);
			mono_add_internal_call("UnrealEngine.ANavLinkProxy::ResumePathFollowing",(const void*)ResumePathFollowing);
			mono_add_internal_call("UnrealEngine.ANavLinkProxy::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
