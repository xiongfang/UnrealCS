#pragma once

namespace UnrealEngine
{
	class _USizeBox
	{
		static void ClearMaxAspectRatio(USizeBox* _this)
		{
			_this->ClearMaxAspectRatio();
			
		}
		static void SetMaxAspectRatio(USizeBox* _this,float InMaxAspectRatio)
		{
			_this->SetMaxAspectRatio(InMaxAspectRatio);
			
		}
		static void ClearMaxDesiredHeight(USizeBox* _this)
		{
			_this->ClearMaxDesiredHeight();
			
		}
		static void SetMaxDesiredHeight(USizeBox* _this,float InMaxDesiredHeight)
		{
			_this->SetMaxDesiredHeight(InMaxDesiredHeight);
			
		}
		static void ClearMaxDesiredWidth(USizeBox* _this)
		{
			_this->ClearMaxDesiredWidth();
			
		}
		static void SetMaxDesiredWidth(USizeBox* _this,float InMaxDesiredWidth)
		{
			_this->SetMaxDesiredWidth(InMaxDesiredWidth);
			
		}
		static void ClearMinDesiredHeight(USizeBox* _this)
		{
			_this->ClearMinDesiredHeight();
			
		}
		static void SetMinDesiredHeight(USizeBox* _this,float InMinDesiredHeight)
		{
			_this->SetMinDesiredHeight(InMinDesiredHeight);
			
		}
		static void ClearMinDesiredWidth(USizeBox* _this)
		{
			_this->ClearMinDesiredWidth();
			
		}
		static void SetMinDesiredWidth(USizeBox* _this,float InMinDesiredWidth)
		{
			_this->SetMinDesiredWidth(InMinDesiredWidth);
			
		}
		static void ClearHeightOverride(USizeBox* _this)
		{
			_this->ClearHeightOverride();
			
		}
		static void SetHeightOverride(USizeBox* _this,float InHeightOverride)
		{
			_this->SetHeightOverride(InHeightOverride);
			
		}
		static void ClearWidthOverride(USizeBox* _this)
		{
			_this->ClearWidthOverride();
			
		}
		static void SetWidthOverride(USizeBox* _this,float InWidthOverride)
		{
			_this->SetWidthOverride(InWidthOverride);
			
		}
		static UClass* StaticClass(){return USizeBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USizeBox::ClearMaxAspectRatio",(const void*)ClearMaxAspectRatio);
			mono_add_internal_call("UnrealEngine.USizeBox::SetMaxAspectRatio",(const void*)SetMaxAspectRatio);
			mono_add_internal_call("UnrealEngine.USizeBox::ClearMaxDesiredHeight",(const void*)ClearMaxDesiredHeight);
			mono_add_internal_call("UnrealEngine.USizeBox::SetMaxDesiredHeight",(const void*)SetMaxDesiredHeight);
			mono_add_internal_call("UnrealEngine.USizeBox::ClearMaxDesiredWidth",(const void*)ClearMaxDesiredWidth);
			mono_add_internal_call("UnrealEngine.USizeBox::SetMaxDesiredWidth",(const void*)SetMaxDesiredWidth);
			mono_add_internal_call("UnrealEngine.USizeBox::ClearMinDesiredHeight",(const void*)ClearMinDesiredHeight);
			mono_add_internal_call("UnrealEngine.USizeBox::SetMinDesiredHeight",(const void*)SetMinDesiredHeight);
			mono_add_internal_call("UnrealEngine.USizeBox::ClearMinDesiredWidth",(const void*)ClearMinDesiredWidth);
			mono_add_internal_call("UnrealEngine.USizeBox::SetMinDesiredWidth",(const void*)SetMinDesiredWidth);
			mono_add_internal_call("UnrealEngine.USizeBox::ClearHeightOverride",(const void*)ClearHeightOverride);
			mono_add_internal_call("UnrealEngine.USizeBox::SetHeightOverride",(const void*)SetHeightOverride);
			mono_add_internal_call("UnrealEngine.USizeBox::ClearWidthOverride",(const void*)ClearWidthOverride);
			mono_add_internal_call("UnrealEngine.USizeBox::SetWidthOverride",(const void*)SetWidthOverride);
			mono_add_internal_call("UnrealEngine.USizeBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
