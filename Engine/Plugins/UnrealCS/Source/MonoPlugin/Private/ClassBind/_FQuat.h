// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FQuat
	{
		static FQuat Multiply(FQuat* _this,FQuat* Other)
		{
			return (*_this)*(*Other);
		}
		static FQuat MakeFromMatrix(FMatrix* Matrix)
		{
			return FQuat(*Matrix);
		}
		static FRotator Rotator(FQuat* _this)
		{
			return _this->Rotator();
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FQuat::Multiply", (const void*)Multiply);
			mono_add_internal_call("UnrealEngine.FQuat::MakeFromMatrix", (const void*)MakeFromMatrix);
			mono_add_internal_call("UnrealEngine.FQuat::Rotator", (const void*)Rotator);
		}
	};
}