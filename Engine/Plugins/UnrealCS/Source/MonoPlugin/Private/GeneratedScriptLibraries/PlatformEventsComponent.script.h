#pragma once

namespace UnrealEngine
{
	class _UPlatformEventsComponent
	{
		static int32 SupportsConvertibleLaptops(UPlatformEventsComponent* _this)
		{
			bool ___ret = _this->SupportsConvertibleLaptops();
			return ___ret?1:0;
			
		}
		static int32 IsInTabletMode(UPlatformEventsComponent* _this)
		{
			bool ___ret = _this->IsInTabletMode();
			return ___ret?1:0;
			
		}
		static int32 IsInLaptopMode(UPlatformEventsComponent* _this)
		{
			bool ___ret = _this->IsInLaptopMode();
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UPlatformEventsComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPlatformEventsComponent::SupportsConvertibleLaptops",(const void*)SupportsConvertibleLaptops);
			mono_add_internal_call("UnrealEngine.UPlatformEventsComponent::IsInTabletMode",(const void*)IsInTabletMode);
			mono_add_internal_call("UnrealEngine.UPlatformEventsComponent::IsInLaptopMode",(const void*)IsInLaptopMode);
			mono_add_internal_call("UnrealEngine.UPlatformEventsComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
