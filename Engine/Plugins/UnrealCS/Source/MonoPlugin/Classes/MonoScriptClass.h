// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "Engine/BlueprintGeneratedClass.h"
#include "MonoScriptClass.generated.h"

class UMonoScriptClass;

struct MONOPLUGIN_API FScriptField
{
	/** Field name */
	FName Name;
	/** Field type */
	UClass* Class;
	/** 是否是数组*/
	//bool IsArray;
	/*  内部确定类型*/
	UObject* InnerType;

	FScriptField()
		: Class(NULL),
		InnerType(NULL)
	{
	}
	FScriptField(FName InName, UClass* InClass,UClass* InType=NULL)
		: Name(InName)
		, Class(InClass)
		, InnerType(InType)
	{
	}
};

/** Script context for this component */
class MONOPLUGIN_API FScriptContextBase
{
public:

	virtual ~FScriptContextBase() {}

	/**
	* Creates a script context object
	*/
	static FScriptContextBase* CreateContext(const FString& SourceCode, UMonoScriptClass* Class, UObject* Owner);

	/**
	* Gets supported script file formats (UFactory formats)
	*/
	static void GetSupportedScriptFileFormats(TArray<FString>& OutFormats);

	/**
	* Initializes script context given script code
	* @param Code Script code
	* @param Owner Owner of this context
	*/
	virtual bool Initialize(const FString& Code, UObject* Owner) = 0;

	/**
	* Sends BeginPlay event to the script
	*/
	virtual void BeginPlay() = 0;

	/**
	* Sends Tick event to the script
	*/
	virtual void Tick(float DeltaTime) = 0;

	/**
	* Sends EndPlay event to the script
	*/
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) = 0;

	/**
	* Sends Destroy event to the script and destroys the script.
	*/
	virtual void Destroy() = 0;


	virtual void* Invoke(void* method, void** args)=0;

	// Property accessors

	/*virtual bool SetFloatProperty(const FString& PropertyName, float NewValue) = 0;
	virtual float GetFloatProperty(const FString& PropertyName) = 0;
	virtual bool SetIntProperty(const FString& PropertyName, int32 NewValue) = 0;
	virtual int32 GetIntProperty(const FString& PropertyName) = 0;
	virtual bool SetObjectProperty(const FString& PropertyName, UObject* NewValue) = 0;
	virtual UObject* GetObjectProperty(const FString& PropertyName) = 0;
	virtual bool SetBoolProperty(const FString& PropertyName, bool NewValue) = 0;
	virtual bool GetBoolProperty(const FString& PropertyName) = 0;
	virtual bool SetStringProperty(const FString& PropertyName, const FString& NewValue) = 0;
	virtual FString GetStringProperty(const FString& PropertyName) = 0;
	virtual bool SetArrayProperty(const FString& PropertyName, const UObject* CppObj, UArrayProperty* Property) = 0;
	virtual bool GetArrayProperty(const FString& PropertyName, UObject* CppObj, UArrayProperty* Property) = 0;
	virtual bool SetStructProperty(const FString& PropertyName, const UObject* CppObj, UStructProperty* Property) = 0;
	virtual bool GetStructProperty(const FString& PropertyName, UObject* CppObj, UStructProperty* Property) = 0;
*/
	//virtual bool SetProperty(const FString& PropertyName, const UObject* CppObj, UProperty* Property) = 0;
	//virtual bool GetProperty(const FString& PropertyName, UObject* CppObj, UProperty* Property) = 0;

	/**
	* Invokes script function from Blueprint code
	*/
	virtual void InvokeScriptFunction(FFrame& Stack, RESULT_DECL) = 0;

#if WITH_EDITOR
	/**
	* Returns a list of exported fields from script (member variables and functions).
	*/
	virtual void GetScriptDefinedFields(TArray<FScriptField>& OutFields) = 0;
	virtual void BeginHotReload(){}
	virtual void EndHotReload() {}
#endif

	// Utilities

	/**
	* Pushes all property values from class instance to script.
	*/
	virtual void PushScriptPropertyValues(UMonoScriptClass* Class, const UObject* Obj) = 0;

	/**
	* Fetches all property values from script to class instance.
	*/
	virtual void FetchScriptPropertyValues(UMonoScriptClass* Class, UObject* Obj) = 0;
};


/**
* Script generated class
*/
UCLASS()
class MONOPLUGIN_API UMonoScriptClass : public UBlueprintGeneratedClass
{
	GENERATED_UCLASS_BODY()

	/** Script source code. @todo: this should be editor-only */
	UPROPERTY()
	FString ClassName;

	/** Script-generated properties */
	UPROPERTY()
	TArray<UProperty*> ScriptProperties;
	UPROPERTY()
	TArray<UFunction*> ScriptFunctions;

	virtual void Link(FArchive& Ar, bool bRelinkExistingProperties) override;
	virtual void Bind() override;
	virtual void PurgeClass(bool bRecompilingOnLoad) override;
	/**
	* Adds a unique native function mapping
	* @param InName Name of the native function
	* @param InPointer Pointer to the native member function
	*/
	void AddUniqueNativeFunction(const FName& InName, Native InPointer);

	/**
	* Removes native function mapping
	* @param InName Name of the native function
	*/
	void RemoveNativeFunction(const FName& InName);

	/**
	* Gets UScriptBlueprintGeneratedClass from class hierarchy
	* @return UScriptBlueprintGeneratedClass or NULL
	*/
	FORCEINLINE static UMonoScriptClass* GetScriptGeneratedClass(UClass* InClass)
	{
		UMonoScriptClass* ScriptClass = NULL;
		for (UClass* MyClass = InClass; MyClass && !ScriptClass; MyClass = MyClass->GetSuperClass())
		{
			ScriptClass = Cast<UMonoScriptClass>(MyClass);
		}
		return ScriptClass;
	}

	virtual void Serialize(FArchive& Ar) override;
	virtual void PostLoad() override;
#if WITH_EDITOR
	//初始化所有方法
	void Init(FScriptContextBase* Context);
#endif

protected:
	virtual UObject* CreateDefaultObject() override;
	//是否已经序列化完成的标记。正在序列化过程不能设置属性值.
	bool InSerialize;
};