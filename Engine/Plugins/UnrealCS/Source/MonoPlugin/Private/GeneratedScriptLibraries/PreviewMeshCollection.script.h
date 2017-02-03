#pragma once

namespace UnrealEngine
{
	class _UPreviewMeshCollection
	{
		static UClass* StaticClass(){return UPreviewMeshCollection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPreviewMeshCollection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
