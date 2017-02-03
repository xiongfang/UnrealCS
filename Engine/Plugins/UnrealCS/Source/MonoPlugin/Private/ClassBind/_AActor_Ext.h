// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
namespace UnrealEngine
{
	class _AActor_Ext
	{
		static void Destroy(AActor* _this)
		{
			_this->Destroy();
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AActor::Destroy", (const void*)Destroy);
		}
	};
}
