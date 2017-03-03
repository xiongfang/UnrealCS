#pragma once

namespace UnrealEngine
{
	class _ADocumentationActor
	{
		static UClass* StaticClass(){return ADocumentationActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ADocumentationActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
