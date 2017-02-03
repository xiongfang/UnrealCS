// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FVector
	{
		static FVector RotateAngleAxis(FVector* _this, float AngleDeg, FVector Axis)
		{
			return _this->RotateAngleAxis(AngleDeg, Axis);
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FVector::RotateAngleAxis", (const void*)RotateAngleAxis);
		}
	};
}