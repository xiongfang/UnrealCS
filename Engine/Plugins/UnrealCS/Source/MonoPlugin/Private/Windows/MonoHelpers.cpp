// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#include "../MonoPluginPrivatePCH.h"
#include "../MonoDomain.h"

#if WITH_MONO

namespace Mono
{
	static void* MonoDLLHandle = nullptr;

	void LoadMonoDLL()
	{
#if WITH_MONO_SGEN
		const TCHAR* MonoBaseLibName = TEXT("monosgen");
#else
		const TCHAR* MonoBaseLibName = TEXT("mono");
#endif

#if PLATFORM_64BITS
		FString RootMonoPath = FPaths::EngineDir() / TEXT("Binaries/ThirdParty/EMono/bin/Win64/");
#else
		FString RootMonoPath = FPaths::EngineDir() / TEXT("Binaries/ThirdParty/EMono/bin/Win32/");
#endif
		FPlatformProcess::PushDllDirectory(*RootMonoPath);
		MonoDLLHandle = FPlatformProcess::GetDllHandle(*FString::Printf(TEXT("%s%s-2.0.dll"), *RootMonoPath, MonoBaseLibName));
		check(nullptr != MonoDLLHandle);
		FPlatformProcess::PopDllDirectory(*RootMonoPath);
	}

	void UnloadMonoDLL()
	{
		if (nullptr != MonoDLLHandle)
		{
			FPlatformProcess::FreeDllHandle(MonoDLLHandle);
		}
	}
}


#endif