#pragma once

namespace UnrealEngine
{
	class _UInterpTrackSound
	{
		static UClass* StaticClass(){return UInterpTrackSound::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackSound::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
