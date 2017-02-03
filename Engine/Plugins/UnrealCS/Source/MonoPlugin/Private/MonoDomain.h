#pragma once

#if WITH_MONO

class FMonoDomain
	:public FTickableGameObject
{
private:
	struct TickObject
	{
		MonoObject* Obj;
		uint32 gc_handle;
		MonoMethod* TickMethod;
		bool removed;
	};

	TArray<TickObject> TickObjects;
public:
	FMonoDomain();
	~FMonoDomain();

	MonoDomain* GetDomain() const { return Domain; }
	MonoImage* GetImage()const { return Image; }

	//触发热更命令
	void HotReload();

	//真正的热更
	void NativeHotReload();

	static FMonoDomain* Get(){ return Instance; }

	MonoAssembly* Open(MonoDomain* domain,const FString& AssemblyName);

	MonoObject* CreateInstance(const FString& TypeName);
	MonoObject* CreateArray(const FString& TypeName,int32 len);

	bool AddTickableObject(MonoObject* obj);
	bool RemoveTickableObject(MonoObject* obj);

	virtual bool IsTickableWhenPaused() const override
	{
		return true;
	}
	virtual bool IsTickableInEditor() const override
	{
		return true;
	}
	virtual void Tick(float DeltaTime) override;
	virtual bool IsTickable() const {
		return true;
	}
	virtual TStatId GetStatId() const override { RETURN_QUICK_DECLARE_CYCLE_STAT(FMonoDomain, STATGROUP_Tickables); }


	//向MainDoman发送指令
	void SendCommand(const FString& cmd);

	//安装插件必须的文件到指定目录
	static void Install();
#if WITH_EDITOR
	void OnBeginPIE(const bool bIsSimulating);
	void OnEndPIE(const bool bIsSimulating);
	void OnPausePIE(const bool bIsSimulating);
#endif

#if WITH_MONO_HOTRELOAD
	DECLARE_MULTICAST_DELEGATE(FOnHotReload);
	FOnHotReload eventBeginHotReload;
	FOnHotReload eventEndHotReload;
	bool NeedHotReload;
	MonoDomain* CreateGameDomain();
#endif
private:
	void Init();
	FString GameAssemblyDirectory;
	FString EngineAssemblyDirectory;
	FString RuntimeAssemblyDirectory;

	void InitCreateMainDomain();
	void ShutDownMainDomain();

	//GameDomain
	MonoDomain* Domain;

	//Game Image
	MonoImage* Image;
	MonoAssembly* Assembly;

	//Engine Image
	MonoImage* EngineImage;
	MonoAssembly* EngineAssembly;
	MonoMethod* methodCreateInstance;
	MonoMethod* methodCreateArray;

	//MainDomain
	MonoDomain* MainDomain;
	MonoImage* MainImage;
	MonoObject* mainObject;
	uint32 mainObjectHandle;
	//MonoClassField* Field_NeedHotReload;

	static FMonoDomain* Instance;
};

namespace Mono
{
	void LoadMonoDLL();
	void UnloadMonoDLL();
}

#endif