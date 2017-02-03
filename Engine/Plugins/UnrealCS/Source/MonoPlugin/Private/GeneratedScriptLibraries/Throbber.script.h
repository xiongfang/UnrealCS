#pragma once

namespace UnrealEngine
{
	class _UThrobber
	{
		static void SetAnimateOpacity(UThrobber* _this,int32 bInAnimateOpacity)
		{
			_this->SetAnimateOpacity(bInAnimateOpacity>0?true:false);
			
		}
		static void SetAnimateVertically(UThrobber* _this,int32 bInAnimateVertically)
		{
			_this->SetAnimateVertically(bInAnimateVertically>0?true:false);
			
		}
		static void SetAnimateHorizontally(UThrobber* _this,int32 bInAnimateHorizontally)
		{
			_this->SetAnimateHorizontally(bInAnimateHorizontally>0?true:false);
			
		}
		static void SetNumberOfPieces(UThrobber* _this,int32 InNumberOfPieces)
		{
			_this->SetNumberOfPieces(InNumberOfPieces);
			
		}
		static UClass* StaticClass(){return UThrobber::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UThrobber::SetAnimateOpacity",(const void*)SetAnimateOpacity);
			mono_add_internal_call("UnrealEngine.UThrobber::SetAnimateVertically",(const void*)SetAnimateVertically);
			mono_add_internal_call("UnrealEngine.UThrobber::SetAnimateHorizontally",(const void*)SetAnimateHorizontally);
			mono_add_internal_call("UnrealEngine.UThrobber::SetNumberOfPieces",(const void*)SetNumberOfPieces);
			mono_add_internal_call("UnrealEngine.UThrobber::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
