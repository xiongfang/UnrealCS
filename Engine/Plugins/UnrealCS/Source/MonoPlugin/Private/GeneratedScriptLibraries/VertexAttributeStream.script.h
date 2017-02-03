#pragma once

namespace UnrealEngine
{
	class _UVertexAttributeStream
	{
		static UClass* StaticClass(){return UVertexAttributeStream::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVertexAttributeStream::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
