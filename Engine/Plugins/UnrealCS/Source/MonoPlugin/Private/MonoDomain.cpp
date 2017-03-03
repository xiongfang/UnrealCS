// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#if WITH_MONO
#include "MonoDomain.h"
#include "MonoPluginPrivatePCH.h"

#include "MonoScriptClass.h"
#include "MonoScriptBindHelper.h"
#include "ClassBind/MonoExtFunctionBinds.h"
#include "IPluginManager.h"

#if PLATFORM_IOS
#include "ios_predefine.h"
#endif

namespace UnrealEngine
{
	extern void MonoBindFunctions();
}


static TArray<FString> MonoPreloadSearchPaths;

static MonoAssembly* assembly_preload_hook(MonoAssemblyName *aname, char **assemblies_path, void* user_data)
{
	const char *name = mono_assembly_name_get_name(aname);
	const char *culture = mono_assembly_name_get_culture(aname);
	auto AsmName = FString(ANSI_TO_TCHAR(name));
	auto AsmCulture = FString(ANSI_TO_TCHAR(culture));

	//加上后缀名
	if (!AsmName.EndsWith(TEXT(".dll"), ESearchCase::IgnoreCase))
	{
		AsmName = AsmName + TEXT(".dll");
	}
    else
    {
        name = TCHAR_TO_ANSI(*(AsmName.LeftChop(4)));
    }

    {
//        // Check if we already have the assembly in memory
//        char path2 [1024];
//        snprintf (path2, sizeof (path2), "%s", name);
//        // strip off the extension
//        char *dot = strrchr (path2, '.');
//        if (strncmp (dot, ".dll", 4) == 0)
//            *dot = 0;
        //MonoAssemblyName *aname2 = mono_assembly_name_new (path2);
        MonoAssembly* assembly = mono_assembly_loaded (aname);
        //mono_assembly_name_free (aname2);
        if (assembly)
        {
            UE_LOG(LogMono, Log, TEXT("return loaded asm '%s'."), *name);
            return assembly;
        }
    }
	for (int i = 0; i < MonoPreloadSearchPaths.Num(); i++)
	{
		FString LoadPath = MonoPreloadSearchPaths[i];

		if (AsmName == "UnrealEngine.dll")
		{
#if WITH_EDITOR
#if PLATFORM_64BITS
			LoadPath = FPaths::Combine(*LoadPath, TEXT("Editor_64bits"));
#else
			LoadPath = FPaths::Combine(*LoadPath, TEXT("Editor_32bits"));
#endif
#else
#if PLATFORM_64BITS
			LoadPath = FPaths::Combine(*LoadPath, TEXT("Game_64bits"));
#else
			LoadPath = FPaths::Combine(*LoadPath, TEXT("Game_32bits"));
#endif
#endif
		}
        
        //转为绝对路径
        
        auto AsmPath = FPaths::Combine(*LoadPath, *AsmName);
		if (!FPaths::FileExists(AsmPath))
		{
			AsmPath = FPaths::Combine(*LoadPath, *AsmCulture, *AsmName);
			if (!FPaths::FileExists(AsmPath))
			{
				continue;
			}
		}

        FString AbsoluteAssemblyPath = IFileManager::Get().ConvertToAbsolutePathForExternalAppForRead(*AsmPath);
        
		UE_LOG(LogMono, Log, TEXT("Found assembly %s %s at path '%s'."),ANSI_TO_TCHAR(name), *AsmName, *AsmPath);

		MonoImageOpenStatus status;
		MonoAssembly *loaded_asm = nullptr;
		//Editor环境下，尝试用IFileManager的方案打开（中文路径也是打不开的）
#if WITH_EDITOR
		if (i != 0)
#endif
		{
			loaded_asm = mono_assembly_open(TCHAR_TO_ANSI(*AbsoluteAssemblyPath), &status);
			if (loaded_asm)
			{
				UE_LOG(LogMono, Log, TEXT("Loaded assembly from path '%s'."), *AsmPath);
				return loaded_asm;
			}
		}

        MonoImage *image = nullptr;
        
        image = mono_image_loaded(name);
        
        if(image == nullptr)
        {
			//从档案加载
			IFileManager& FileManager = IFileManager::Get();
			auto Reader = FileManager.CreateFileReader(*AsmPath);
			if (!Reader)
			{
				UE_LOG(LogMono, Error, TEXT("Failed to read assembly from UFS path '%s'."), *AsmPath);
				continue;
			}

			uint32 Size = Reader->TotalSize();
			void* Data = FMemory::Malloc(Size);
			Reader->Serialize(Data, Size);

			image = mono_image_open_from_data_with_name((char*)Data, Size, true, &status, false, name);

			//释放读取的文件
			FMemory::Free(Data);
			//关闭文件，这样可以热更
			Reader->Close();

        }
        else
        {
            loaded_asm =mono_image_get_assembly(image);
            if(loaded_asm != nullptr)
            {
                UE_LOG(LogMono, Log, TEXT("return loaded assembily %s."), *AsmPath);
                return loaded_asm;
            }
        }
        
		if (!image)
		{
			UE_LOG(LogMono, Error, TEXT("Failed to load image from UFS path '%s'."), *AsmPath);
			continue;
		}

		loaded_asm = mono_assembly_load_from_full(image, name, &status, 0);
		if (!loaded_asm)
		{
			UE_LOG(LogMono, Error, TEXT("Failed to load image from UFS path '%s'."), *AsmPath);
			continue;
		}

		if (mono_image_get_assembly(image) == NULL)
		{
			UE_LOG(LogMono, Warning, TEXT("Failed to load image from UFS path '%s'. image.assembly==NULL Maybe Load The Same Assembly ,or you need change you assembly version number"), *AsmPath);
		}
		else
		{
			UE_LOG(LogMono, Log, TEXT("Loaded assembly from UFS path '%s'."), *AsmPath);
		}

		return loaded_asm;
	}

	UE_LOG(LogMono, Error, TEXT("Could not find assembly %s."), *AsmName);
	return NULL;
}

static void install_preload_hook(const FString& MonoRuntimeDirectory, const FString& InGameAssemblyDirectory, const FString& MonoEngineDirectory)
{
	if (MonoPreloadSearchPaths.Num() == 0)
	{
		mono_install_assembly_preload_hook(assembly_preload_hook, NULL);
	}
	else
	{
		MonoPreloadSearchPaths.Empty();
	}

	MonoPreloadSearchPaths.Add(*InGameAssemblyDirectory);
	MonoPreloadSearchPaths.Add(*MonoEngineDirectory);
	MonoPreloadSearchPaths.Add(*MonoRuntimeDirectory);
}

//日志回调
extern "C" void MonoPrintf(const char *string, mono_bool is_stdout)
{
#if !NO_LOGGING
	{
		UE_LOG(LogMono, Warning, TEXT("%s"), ANSI_TO_TCHAR(string));
	}
#endif
}

extern "C" void MonoLog(const char *log_domain, const char *log_level, const char *message, mono_bool fatal, void *user_data)
{
	// logs are always a single line, so can avoid routing through log bridge
	// note: code is repeated because verbosity suppression is performed at compile-time
	if (fatal || 0 == FCStringAnsi::Strncmp("error", log_level, 5))
	{
		// fatal error
		UE_LOG(LogMono, Fatal, TEXT("%s%s%s"), log_domain != nullptr ? ANSI_TO_TCHAR(log_domain) : TEXT(""), log_domain != nullptr ? TEXT(": ") : TEXT(""), ANSI_TO_TCHAR(message));
	}
#if NO_LOGGING
#else
	else if (0 == FCStringAnsi::Strncmp("warning", log_level, 7))
	{
		UE_LOG(LogMono, Warning, TEXT("%s%s%s"), log_domain != nullptr ? ANSI_TO_TCHAR(log_domain) : TEXT(""), log_domain != nullptr ? TEXT(": ") : TEXT(""), ANSI_TO_TCHAR(message));
	}
	else if (0 == FCStringAnsi::Strncmp("critical", log_level, 8))
	{
		UE_LOG(LogMono, Error, TEXT("%s%s%s"), log_domain != nullptr ? ANSI_TO_TCHAR(log_domain) : TEXT(""), log_domain != nullptr ? TEXT(": ") : TEXT(""), ANSI_TO_TCHAR(message));
	}
	else
	{
		UE_LOG(LogMono, Log, TEXT("%s%s%s"), log_domain != nullptr ? ANSI_TO_TCHAR(log_domain) : TEXT(""), log_domain != nullptr ? TEXT(": ") : TEXT(""), ANSI_TO_TCHAR(message));
	}
#endif
}


//本机热更通知
void G_NativeReload()
{
#if	WITH_MONO_HOTRELOAD
	FMonoDomain::Get()->NeedHotReload = true;
#endif
}

FMonoDomain* FMonoDomain::Instance = NULL;

void FMonoDomain::Init()
{
    //IOS平台以AOT方式运行
#if PLATFORM_IOS
    // 文件
    RegisterMonoModules();
    mono_jit_set_aot_only(true);
#endif
    
    RuntimeAssemblyDirectory = FPaths::Combine(*FPaths::GameDir(), TEXT("Content"), TEXT("Scripts"), TEXT("framework"));
	GameAssemblyDirectory = FPaths::Combine(*FPaths::GameDir(), TEXT("Content"), TEXT("Scripts"),TEXT("GameAssemblies"));
	EngineAssemblyDirectory = FPaths::Combine(*FPaths::GameDir(), TEXT("Content"), TEXT("Scripts"), TEXT("EngineAssemblies"));

	mono_trace_set_log_handler(MonoLog, nullptr);
	mono_trace_set_print_handler(MonoPrintf);
	mono_trace_set_printerr_handler(MonoPrintf);

	install_preload_hook(RuntimeAssemblyDirectory, GameAssemblyDirectory, EngineAssemblyDirectory);

#if PLATFORM_IOS
    FCommandLine::Append(TEXT(" MONOARGS=--optimize=aot"));
#endif
	FString MonoArgs;
	if (FParse::Value(FCommandLine::Get(), TEXT("MONOARGS="), MonoArgs))
	{
		TArray<ANSICHAR*> Options;
		FString Token;
		const TCHAR* MonoArgsPtr = *MonoArgs;
		while (FParse::Token(MonoArgsPtr, Token, false))
		{
			auto s = new ANSICHAR[Token.Len() + 1];
			FCStringAnsi::Strcpy(s, Token.Len() + 1, TCHAR_TO_ANSI(*Token));
			Options.Add(s);
		}
		mono_jit_parse_options(Options.Num(), Options.GetData());

		for (auto s : Options)
		{
			delete[] s;
		}
	}
    
#if !UE_BUILD_SHIPPING
    
	mono_debug_init(MONO_DEBUG_FORMAT_MONO);

#endif

#if WITH_EDITOR
	FEditorDelegates::BeginPIE.AddRaw(this, &FMonoDomain::OnBeginPIE);
	FEditorDelegates::EndPIE.AddRaw(this, &FMonoDomain::OnEndPIE);
	FEditorDelegates::PausePIE.AddRaw(this, &FMonoDomain::OnPausePIE);
#endif
}

#if WITH_EDITOR
void CopyFolder(const TCHAR* Dest, const  TCHAR* Src)
{
	if (!FPaths::DirectoryExists(Dest))
		IFileManager::Get().MakeDirectory(Dest);

	// 子文件夹
	TArray<FString> Dirs;
	IFileManager::Get().FindFiles(Dirs, *(FString()+Src+"/*"), false, true);

	for (auto sub : Dirs)
	{
		CopyFolder(*FPaths::Combine(Dest, *sub), *FPaths::Combine(Src,*sub));
	}
		

	// 文件
	TArray<FString> Files;
	IFileManager::Get().FindFiles(Files, *(FString() + Src + "/*"), true, false);
	for (auto file : Files)
	{
		IFileManager::Get().Copy(*FPaths::Combine(Dest, *file), *FPaths::Combine(Src,*file), true);
	}
}

void FMonoDomain::Install()
{
	FString PluginDir = IPluginManager::Get().FindPlugin(TEXT("UnrealCS"))->GetBaseDir();
	//检查内容
	if (!FPaths::DirectoryExists(FPaths::Combine(*FPaths::GameContentDir(), TEXT("Scripts"), TEXT("GameAssemblies"))))
	{
		//复制内容模板到内容目录
		FString ScriptsDir = FPaths::Combine(*PluginDir, TEXT("Scripts"));
		CopyFolder(*FPaths::Combine(*FPaths::GameContentDir(), TEXT("Scripts")), *ScriptsDir);
	}
	//检查动态库
	if (!FPaths::DirectoryExists(FPaths::Combine(*FPaths::EngineDir(), TEXT("Binaries"), TEXT("ThirdParty"), TEXT("EMono"))))
	{
		//复制内容模板到内容目录
		FString BinDir = FPaths::Combine(*PluginDir, TEXT("EMono"));
		CopyFolder(*FPaths::Combine(*FPaths::EngineDir(), TEXT("Binaries"),TEXT("ThirdParty"), TEXT("EMono")), *BinDir);
	}

	////检查脚本工程
	//if (!FPaths::DirectoryExists(FPaths::Combine(*FPaths::GameDir(),TEXT("Project"))))
	//{
	//	//复制脚本模板到工程目录
	//	FString ProjectDir = FPaths::Combine(*FPaths::GamePluginsDir(), TEXT("Mono"), TEXT("Project"));
	//	CopyFolder(*FPaths::Combine(*FPaths::GameDir(), TEXT("Project")), *ProjectDir);
	//}
}

MonoDomain* LastDomain = nullptr;

void FMonoDomain::OnBeginPIE(const bool bIsSimulating)
{
	LastDomain = Domain;
	Domain = CreateGameDomain();
}
void FMonoDomain::OnEndPIE(const bool bIsSimulating)
{
	Domain  = LastDomain;
	if (!mono_domain_set(Domain, false))
	{
		UE_LOG(LogMono, Warning, TEXT("Domain Recover Failed"));
		return;
	}
}
void FMonoDomain::OnPausePIE(const bool bIsSimulating)
{
}


#else
void FMonoDomain::Install()
{
}
#endif

#if	WITH_MONO_HOTRELOAD
MonoDomain* FMonoDomain::CreateGameDomain()
{
	{
		if (!mono_domain_set(MainDomain, false))
		{
			UE_LOG(LogMono, Log, TEXT("MainDomain Unloaded"));
			return NULL;
		}

		//调用初始化方法
		MonoClass* AssemblyMainClass = mono_class_from_name(MainImage, "MainDomain", "Main");
		if (AssemblyMainClass == NULL)
			return NULL;
		//内部使用
		MonoMethod* methodHotReload = mono_class_get_method_from_name(AssemblyMainClass, "HotReload", -1);
		if (methodHotReload == NULL)
			return NULL;

		MonoObject* exception = NULL;

		mono_runtime_invoke(methodHotReload, mainObject, nullptr, &exception);
		if (exception)
		{
			mono_print_unhandled_exception(exception);
			return NULL;
		}
	}

	{
		MonoClass* AssemblyMainClass = mono_class_from_name(MainImage, "MainDomain", "Main");
		MonoClassField* Field_gameDomain = mono_class_get_field_from_name(AssemblyMainClass, "gameDomain");
		MonoObject* gameDomain = nullptr;
		mono_field_get_value(mainObject, Field_gameDomain, &gameDomain);
		if (gameDomain == nullptr)
			return NULL;

		MonoClass* AppDomainClass = mono_class_from_name(mono_get_corlib(), "System", "AppDomain");
		check(AppDomainClass);
		MonoClassField* AppDomainMonoAppDomainField = mono_class_get_field_from_name(AppDomainClass, "_mono_app_domain");
		check(AppDomainMonoAppDomainField);
		MonoObject* IntPtrObject = mono_load_remote_field_new(gameDomain, AppDomainClass, AppDomainMonoAppDomainField);
		check(IntPtrObject);
		MonoDomain* GameDomain = *((MonoDomain**)mono_object_unbox(IntPtrObject));
		//Domain = mono_domain_from_appdomain(gameDomain);
		check(GameDomain);

		if (!mono_domain_set(GameDomain, false))
		{
			UE_LOG(LogMono, Warning, TEXT("Domain Set Failed"));
			return NULL;
		}

		return GameDomain;
	}
}
#endif

FMonoDomain::FMonoDomain()
{
	Domain = nullptr;
	Assembly = nullptr;
	Image = nullptr;

	MainDomain = nullptr;
	MainImage = nullptr;
	mainObject = nullptr;
	mainObjectHandle = 0;

	EngineImage = nullptr;
	EngineAssembly = nullptr;
	methodCreateInstance = nullptr;
	methodCreateArray = nullptr;

#if WITH_MONO_HOTRELOAD
	NeedHotReload = false;
#endif
	
	check(Instance == NULL);
	Instance = this;

	Init();

	InitCreateMainDomain();

	//HotReload();
}

FMonoDomain::~FMonoDomain()
{
	Instance = NULL;
	ShutDownMainDomain();
#if WITH_EDITOR
	FEditorDelegates::BeginPIE.RemoveAll(this);
#endif
}

void FMonoDomain::InitCreateMainDomain()
{
	FString AssemblyName = "MainDomain";
	FString GameName = FApp::GetGameName();
	if (GameName.Len() == 0)
	{
		GameName = "AppGame";
	}

	FString monoVersion;
	if (!GConfig->GetString(TEXT("MonoPlugin"), TEXT("MonoRuntimeVersion"), monoVersion, GEngineIni))
	{
		monoVersion = "mobile";
	}

    //mono_trace_set_mask_string("all");
    //mono_trace_set_level_string("debug");
	MainDomain = mono_jit_init_version(TCHAR_TO_ANSI(*GameName), TCHAR_TO_ANSI(*monoVersion));
	check(MainDomain);

	//Mac上的特殊处理
#if PLATFORM_MAC
	FModuleStatus MonoRuntimeStatus;
	FModuleManager::Get().QueryModule("MonoPlugin", MonoRuntimeStatus);
	mono_dllmap_insert(NULL, "__Internal", NULL, TCHAR_TO_ANSI(*MonoRuntimeStatus.FilePath), NULL);
#endif
	MonoAssembly* MainAssembly = Open(MainDomain,TCHAR_TO_ANSI(*AssemblyName));
	if (nullptr == MainAssembly)
	{
		return;
	}

	//绑定本机代码
	UnrealEngine::MonoBindFunctions();
	UnrealEngine::ExtFunctionBinds();
	mono_add_internal_call("MainDomain.Main::NativeReload", (const void*)G_NativeReload);
	MainImage = mono_assembly_get_image(MainAssembly);

	//调用初始化方法
	MonoClass* AssemblyMainClass = mono_class_from_name(MainImage, "MainDomain", "Main");
	if (AssemblyMainClass != NULL)
	{
		//内部使用
		MonoMethod* methodInitialize = mono_class_get_method_from_name(AssemblyMainClass, "Initialize", -1);
		if (methodInitialize != nullptr)
		{
			MonoObject* exception = NULL;
			FString PluginDir = IPluginManager::Get().FindPlugin(TEXT("UnrealCS"))->GetBaseDir();
			MonoString* monoStr_gameDir = FStringToMonoString(GameName, MainDomain);
			MonoString* monoStr_PluginDir = FStringToMonoString(PluginDir,MainDomain);
			MonoString* monoStr_GameAssemblyDirectory = FStringToMonoString(IFileManager::Get().ConvertToAbsolutePathForExternalAppForRead(*GameAssemblyDirectory), MainDomain);
			MonoString* monoStr_EngineAssemblyDirectory = FStringToMonoString(IFileManager::Get().ConvertToAbsolutePathForExternalAppForRead(*EngineAssemblyDirectory), MainDomain);
			MonoString* monoStr_ShadowCopyDirectory = FStringToMonoString(IFileManager::Get().ConvertToAbsolutePathForExternalAppForRead(*FPaths::Combine(*FPaths::GameSavedDir(), TEXT("MonoRuntime"))), MainDomain);
#if WITH_EDITOR
			int withEditor = 1;
#else
			int withEditor = 0;
#endif

			void* args[] = { monoStr_gameDir, monoStr_PluginDir, monoStr_EngineAssemblyDirectory,monoStr_GameAssemblyDirectory,monoStr_ShadowCopyDirectory,&withEditor };
			mainObject = mono_runtime_invoke(methodInitialize, nullptr, args, &exception);

			if (exception)
			{
				mono_print_unhandled_exception(exception);
			}
			else
			{
				mainObjectHandle = mono_gchandle_new(mainObject,1);
				//初始化Game
				this->HotReload();
			}
		}
	}
}

void FMonoDomain::ShutDownMainDomain()
{
	if (MainDomain != nullptr)
	{
		mono_gchandle_free(mainObjectHandle);

		mono_jit_cleanup(MainDomain);
		MainDomain = nullptr;
	}
}


//真正的热更
void FMonoDomain::NativeHotReload()
{
	TArray<FString> files;
	IFileManager::Get().FindFiles(files, *FPaths::Combine(*GameAssemblyDirectory, TEXT("*")), true, false);
	if (files.Num() == 0)
	{
		UE_LOG(LogMono, Warning, TEXT("Game Assembly Not Found"));
		return;
	}
    files[0].LeftChop(4);
	Assembly = Open(Domain, files[0]);
	if (Assembly == nullptr)
		return;
	Image = mono_assembly_get_image(Assembly);

	if (EngineAssembly == nullptr)
	{
		EngineAssembly = Open(Domain, "UnrealEngine");
		if (EngineAssembly == nullptr)
			return;
		EngineImage = mono_assembly_get_image(EngineAssembly);
	}


	//获取方法
	MonoClass* MarshalUtilClass = mono_class_from_name(EngineImage, "UnrealEngine", "MarshalUtil");
	if (MarshalUtilClass != NULL)
	{
		//内部使用
		methodCreateInstance = mono_class_get_method_from_name(MarshalUtilClass, "CreateInstance", -1);
		methodCreateArray = mono_class_get_method_from_name(MarshalUtilClass, "CreateArray", -1);
	}

#if WITH_MONO_HOTRELOAD
	//查找所有导出类
	TArray<FString> ExportedClass;

	MonoClass* AssemblyExportedClass = mono_class_from_name(Image, "Game", "AssemblyExportedClass");

	if (AssemblyExportedClass != NULL)
	{
		MonoMethod* GetExportedTypes = mono_class_get_method_from_name(AssemblyExportedClass, "GetExportedTypes", -1);
		if (GetExportedTypes != NULL)
		{
			MonoArray* data = NULL;
			MonoObject* exec = NULL;
			void *args[1];
			args[0] = &data;
			mono_runtime_invoke(GetExportedTypes, NULL, args, &exec);

			if (NULL != data) //
			{
				int32 len = mono_array_length(data);
				for (int i = 0; i < len; i++)
				{
					MonoString* t = (MonoString*)mono_array_get(data, MonoObject*, i);
					ExportedClass.Add(MonoStringToFString(t));
				}
			}
		}

	}
	//生成蓝图脚本
	for (int i = 0; i < ExportedClass.Num(); i++)
	{
		MonoClass* C = mono_class_from_name(Image, "Game", TCHAR_TO_ANSI(*ExportedClass[i]));
		if (C != NULL)
		{
			UClass* Parent = NULL;

			//查找父类
			MonoClass* C_Parent = mono_class_get_parent(C);
			while (C_Parent != NULL)
			{
				MonoMethod* StaticClassMethod = mono_class_get_method_from_name(C_Parent, "StaticClass", 0);
				if (StaticClassMethod)
				{
					MonoObject* exec = NULL;
					MonoObject* r = mono_runtime_invoke(StaticClassMethod, NULL, NULL, &exec);
					if (r != NULL)
					{
						void* ptr = mono_object_unbox(r);
						Parent = *(UClass**)ptr;
						break;
					}
					else
					{
						UE_LOG(LogMono, Log, TEXT("Parent Not Found"));
					}
				}
				C_Parent = mono_class_get_parent(C_Parent);
			}
			if (Parent == NULL)
			{
				UE_LOG(LogMono, Log, TEXT("Could not Found Class %s parent %s"), *ExportedClass[i], Parent != NULL ? *Parent->GetName() : TEXT(" null "));
			}
			else
			{

				UE_LOG(LogMono, Log, TEXT("Found Class %s parent %s"), *ExportedClass[i], Parent != NULL ? *Parent->GetName() : TEXT(" null "));
				IMonoPlugin::Get().Event_OnNewClass().Broadcast(ExportedClass[i], Parent);
			}
		}
	}

#endif

}

void FMonoDomain::HotReload()
{
	UE_LOG(LogMono, Log, TEXT("Start Hot Reload"));

	//移除所有Tick对象
	for (int32 i = 0; i < TickObjects.Num(); i++)
	{
		if (!TickObjects[i].removed)
		{
			mono_gchandle_free(TickObjects[i].gc_handle);
		}
	}
	TickObjects.Empty();

#if WITH_MONO_HOTRELOAD
	eventBeginHotReload.Broadcast();

	Domain = CreateGameDomain();
	NativeHotReload();

	eventEndHotReload.Broadcast();
#else
	Domain = MainDomain;
    NativeHotReload();
#endif

	UE_LOG(LogMono, Log, TEXT("Finish Hot Reload"));
}


bool FMonoDomain::AddTickableObject(MonoObject* obj)
{
	if (obj == nullptr)
		return false;
	MonoClass* ObjectClass = mono_object_get_class(obj);

	TickObject Data;
	Data.removed = false;
	Data.Obj = obj;
	Data.TickMethod = mono_class_get_method_from_name(ObjectClass, "Tick", 1);
	if (Data.TickMethod == nullptr)
		return false;
	Data.gc_handle = mono_gchandle_new(obj, 1);

	for (int32 i = 0; i < TickObjects.Num(); i++)
	{
		if (TickObjects[i].removed)
		{
			TickObjects[i] = Data;
			return true;
		}
	}
	TickObjects.Add(Data);
	return true;
}
bool FMonoDomain::RemoveTickableObject(MonoObject* obj)
{
	for (int32 i = 0; i < TickObjects.Num(); i++)
	{
		if (TickObjects[i].Obj == obj && !TickObjects[i].removed)
		{
			TickObjects[i].Obj = nullptr;
			mono_gchandle_free(TickObjects[i].gc_handle);
			TickObjects[i].removed = true;
			return true;
		}
	}
	return false;
}

void FMonoDomain::Tick(float DeltaTime)
{

#if WITH_MONO_HOTRELOAD
	if (NeedHotReload)
	{
		NeedHotReload = false;
		HotReload();
	}
#endif
	for (int32 i = 0; i < TickObjects.Num(); i++)
	{
		if (!TickObjects[i].removed)
		{
			void *args[1];
			args[0] = &DeltaTime;
			MonoObject* exception = NULL;
			MonoObject* ret = mono_runtime_invoke(TickObjects[i].TickMethod, TickObjects[i].Obj, args, &exception);
			if (exception)
			{
				mono_print_unhandled_exception(exception);
			}
		}
	}
}


MonoAssembly* FMonoDomain::Open(MonoDomain* domain, const FString& AssemblyName)
{
	MonoDomain *PreviousDomain = mono_domain_get();
	if (PreviousDomain != domain) {
		mono_domain_set(domain, false);
	}
	else {
		PreviousDomain = NULL;
	}

	MonoImageOpenStatus status;
	MonoAssembly* Asb = mono_assembly_load_with_partial_name(TCHAR_TO_ANSI(*AssemblyName), &status);

	if (PreviousDomain)
	{
		mono_domain_set(PreviousDomain, false);
	}

	if (nullptr == Asb)
	{
		UE_LOG(LogMono, Error, TEXT("Cannot load assembly %s"), *AssemblyName);

	}

	return Asb;
}


MonoObject* FMonoDomain::CreateInstance(const FString& TypeName)
{
	if (methodCreateInstance == NULL)
		return NULL;

	MonoObject* exception = NULL;
	MonoString* pArg = FStringToMonoString(TypeName);
	void *args[1];
	args[0] = pArg;
	MonoObject* ret = mono_runtime_invoke(methodCreateInstance, NULL, args, &exception);
	return ret;
}

MonoObject* FMonoDomain::CreateArray(const FString& TypeName, int32 len)
{
	if (methodCreateArray == NULL)
		return NULL;

	MonoObject* exception = NULL;
	MonoString* pArg = FStringToMonoString(TypeName);
	void *args[2];
	args[0] = pArg;
	args[1] = &len;
	MonoObject* ret = mono_runtime_invoke(methodCreateArray, NULL, args, &exception);
	return ret;
}

void FMonoDomain::SendCommand(const FString& cmd)
{
	MonoDomain *PreviousDomain = mono_domain_get();
	if (PreviousDomain != MainDomain) {
		mono_domain_set(MainDomain, false);
	}
	else {
		PreviousDomain = NULL;
	}

	//调用初始化方法
	MonoClass* AssemblyMainClass = mono_class_from_name(MainImage, "MainDomain", "Main");
	if (AssemblyMainClass != NULL)
	{
		//内部使用
		MonoMethod* methodOnCommand = mono_class_get_method_from_name(AssemblyMainClass, "OnCommand", -1);
		if (methodOnCommand != nullptr)
		{
			MonoObject* exception = NULL;
			MonoString* monoStr_Cmd = FStringToMonoString(cmd, MainDomain);
			void* args[] = { monoStr_Cmd };
			mono_runtime_invoke(methodOnCommand, mainObject, args, &exception);
			if (exception)
			{
				mono_print_unhandled_exception(exception);
			}
		}
	}

	if (PreviousDomain != nullptr)
	{
		mono_domain_set(PreviousDomain, false);
	}
}


#endif //WITH_MONO
