#pragma once

#if WITH_MONO

class FMonoDomain
	:public FTickableGameObject
{
private:
	//C# Object Tickable Support
	struct TickObject
	{
		//C# Object Pointer
		MonoObject* Obj;
		//C# Object Handle
		uint32 gc_handle;
		//C# Object Tick Method
		MonoMethod* TickMethod;
		//If Marked As Removed
		bool removed;
	};

	//Tick Object Array
	TArray<TickObject> TickObjects;
public:
	FMonoDomain();
	~FMonoDomain();

	MonoDomain* GetDomain() const { return Domain; }
	MonoImage* GetImage()const { return Image; }

	//Full Hot Reload
	void HotReload();

	//called by HotReload
	void NativeHotReload();

	static FMonoDomain* Get(){ return Instance; }

	//Open an .Net dll file
	MonoAssembly* Open(MonoDomain* domain,const FString& AssemblyName);

	//Create an C# object by type name
	MonoObject* CreateInstance(const FString& TypeName);
	//Create an c# array by type name and length
	MonoObject* CreateArray(const FString& TypeName,int32 len);

	bool AddTickableObject(MonoObject* obj);
	bool RemoveTickableObject(MonoObject* obj);

	//override FTickableGameObject-------------------------------------
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
	//end override FTickableGameObject-------------------------------------

	//Send command to MainDoman.dll
	void SendCommand(const FString& cmd);

	//When open the project for the first time, install the necessary files to the project folder
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
	//Init mono runtime
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
