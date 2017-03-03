#pragma once

namespace UnrealEngine
{
	class _UDragDropOperation
	{
		static UClass* StaticClass(){return UDragDropOperation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDragDropOperation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
