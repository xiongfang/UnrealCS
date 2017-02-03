// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#include "../MonoPluginPrivatePCH.h"
#include "../MonoDomain.h"

#if WITH_MONO

namespace Mono
{
	//static void* MonoDLLHandle;

	void LoadMonoDLL()
	{
//#if WITH_MONO_SGEN
//		const TCHAR* MonoBaseLibName = TEXT("libmonosgen");
//#else
//		const TCHAR* MonoBaseLibName = TEXT("libmonoboehm");
//#endif
//
//		FString RootMonoPath = FPaths::EngineDir() / TEXT("Binaries/ThirdParty/EMono/bin/Mac/");
//		FPlatformProcess::PushDllDirectory(*RootMonoPath);
//		MonoDLLHandle = FPlatformProcess::GetDllHandle(*FString::Printf(TEXT("%s%s-2.0.dylib"), *RootMonoPath, MonoBaseLibName));
//		FPlatformProcess::PopDllDirectory(*RootMonoPath);
	}

	void UnloadMonoDLL()
	{
		//if (nullptr != MonoDLLHandle)
		//{
		//	FPlatformProcess::FreeDllHandle(MonoDLLHandle);
		//}
	}
}


#endif