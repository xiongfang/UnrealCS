// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

#if WITH_MONO

struct FFunctionField
{
	/** Field name */
	FName Name;
	TArray<UProperty*> Params;
	UProperty* ReturnValue;
};

class UMonoScriptClass;

class FMonoContext : public FScriptContextBase
{
protected:

	void UpdateData();


	MonoClass* Class;
	MonoObject* Obj;
	uint32 handle;
	MonoMethod* method_BeginPlay;
	MonoMethod* method_Tick;
	MonoMethod* method_EndPlay;
	MonoMethod* method_Destroy;
	TWeakObjectPtr<UObject> ObjectPtr;
	FString ClassName;
public:
	FMonoContext();
	virtual ~FMonoContext();

	MonoObject* GetManagedObject() { return Obj; }

	// FScriptContextBase interface
	virtual bool Initialize(const FString& Code, UObject* Owner) override;
	virtual void BeginPlay() override;
	virtual void Tick(float DeltaTime) override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
	virtual void Destroy() override;

	virtual bool SetFloatProperty(const FString& PropertyName, float NewValue);
	virtual float GetFloatProperty(const FString& PropertyName);
	virtual bool SetIntProperty(const FString& PropertyName, int32 NewValue);
	virtual int32 GetIntProperty(const FString& PropertyName);
	virtual bool SetObjectProperty(const FString& PropertyName, UObject* NewValue);
	virtual UObject* GetObjectProperty(const FString& PropertyName);
	virtual bool SetBoolProperty(const FString& PropertyName, bool NewValue);
	virtual bool GetBoolProperty(const FString& PropertyName);
	virtual bool SetStringProperty(const FString& PropertyName, const FString& NewValue);
	virtual FString GetStringProperty(const FString& PropertyName);
	virtual bool SetArrayProperty(const FString& PropertyName, const  UObject* CppObj, UArrayProperty* Property);
	virtual bool GetArrayProperty(const FString& PropertyName, UObject* CppObj, UArrayProperty* Property);
	virtual bool SetStructProperty(const FString& PropertyName, const UObject* CppObj, UStructProperty* Property);
	virtual bool GetStructProperty(const FString& PropertyName, UObject* CppObj, UStructProperty* Property);
	virtual bool SetClassProperty(const FString& PropertyName, UClass* NewValue);
	virtual UClass* GetClassProperty(const FString& PropertyName);

	virtual void InvokeScriptFunction(FFrame& Stack, RESULT_DECL) override;

#if WITH_EDITOR
	virtual void GetScriptDefinedFields(TArray<FScriptField>& OutFields) override;
	virtual void BeginHotReload();
	virtual void EndHotReload();
	void CreateFunctions(UMonoScriptClass* NewClass);
#endif

	MonoMethod* FindMethod(const char* name, int paramCount);
	virtual void* Invoke(void* method, void** param) override;

	/**
	* Pushes all property values from class instance to script.
	*/
	virtual void PushScriptPropertyValues(UMonoScriptClass* Class, const UObject* Obj) override;

	/**
	* Fetches all property values from script to class instance.
	*/
	virtual void FetchScriptPropertyValues(UMonoScriptClass* Class, UObject* Obj) override;
};

#endif