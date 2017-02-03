// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FRotator
	{
		static FVector Vector(FRotator* _this)
		{
			return _this->Vector();
		}
		static FQuat Quaternion(FRotator* _this)
		{
			return _this->Quaternion();
		}
		static FVector RotateVector(FRotator* _this, FVector V)
		{
			return _this->RotateVector(V);
		}
		static FVector UnrotateVector(FRotator* _this, FVector V)
		{
			return _this->UnrotateVector(V);
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FRotator::Vector", (const void*)Vector);
			mono_add_internal_call("UnrealEngine.FRotator::Quaternion", (const void*)Quaternion);
			mono_add_internal_call("UnrealEngine.FRotator::RotateVector", (const void*)RotateVector);
			mono_add_internal_call("UnrealEngine.FRotator::UnrotateVector", (const void*)UnrotateVector);
		}
	};
}