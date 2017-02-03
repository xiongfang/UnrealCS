#pragma once

namespace UnrealEngine
{
	class _UPhysicsAsset
	{
		static UClass* StaticClass(){return UPhysicsAsset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicsAsset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
