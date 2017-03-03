#pragma once

namespace UnrealEngine
{
	class _UStaticMeshSocket
	{
		static UClass* StaticClass(){return UStaticMeshSocket::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UStaticMeshSocket::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
