#pragma once

namespace UnrealEngine
{
	class _UParticleSpriteEmitter
	{
		static UClass* StaticClass(){return UParticleSpriteEmitter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleSpriteEmitter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
