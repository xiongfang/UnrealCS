#pragma once

namespace UnrealEngine
{
	class _UCircularThrobber
	{
		static void SetRadius(UCircularThrobber* _this,float InRadius)
		{
			_this->SetRadius(InRadius);
			
		}
		static void SetPeriod(UCircularThrobber* _this,float InPeriod)
		{
			_this->SetPeriod(InPeriod);
			
		}
		static void SetNumberOfPieces(UCircularThrobber* _this,int32 InNumberOfPieces)
		{
			_this->SetNumberOfPieces(InNumberOfPieces);
			
		}
		static UClass* StaticClass(){return UCircularThrobber::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCircularThrobber::SetRadius",(const void*)SetRadius);
			mono_add_internal_call("UnrealEngine.UCircularThrobber::SetPeriod",(const void*)SetPeriod);
			mono_add_internal_call("UnrealEngine.UCircularThrobber::SetNumberOfPieces",(const void*)SetNumberOfPieces);
			mono_add_internal_call("UnrealEngine.UCircularThrobber::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
