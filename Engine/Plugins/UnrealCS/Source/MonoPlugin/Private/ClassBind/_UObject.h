// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "MonoScriptBind_Component.h"
#include "../MonoIntegration.h"

namespace UnrealEngine
{
	class _UObject
	{
		static void LogInfo(MonoString *msg)
		{
			UE_LOG(LogMono, Log, TEXT("%s"), *MonoStringToFString(msg));
		}
		static void LogWarning(MonoString *msg)
		{
			UE_LOG(LogMono, Warning, TEXT("%s"), *MonoStringToFString(msg));
		}
		static void LogError(MonoString *msg)
		{
			UE_LOG(LogMono, Error, TEXT("%s"), *MonoStringToFString(msg));
		}

		static MonoString* GetName(UObject* _this)
		{
			UObject* Obj = _this;
			return FStringToMonoString(Obj->GetName());
		}

		static UObject* _GetClass(UObject* _this)
		{
			UObject* Obj = _this;
			return Obj->GetClass();
		}
		static UObject* GetOuter(UObject* _this)
		{
			UObject* Obj = _this;
			return Obj->GetOuter();
		}

		static UObject* NewObject(UClass* Class)
		{
			return ::NewObject<UObject>((UObject*)GetTransientPackage(), Class);
		}

		static UClass* _StaticClass()
		{
			return UObject::StaticClass();
		}

		static int GetPropertyOffset(UClass* Struct, MonoString* ProName)
		{
			FString Name = MonoStringToFString(ProName);
			UProperty* Property = FindScriptPropertyHelper(Struct, *Name, false);
			if (Property)
			{
				return Property->GetOffset_ForInternal();
			}
			return 0;
		}
		// Property exposure
		static UClass* GetNativeClassFromName(MonoString* InClassName)
		{
			FString ClassName = MonoStringToFString(InClassName);
			return FindObject<UClass>(ANY_PACKAGE, *ClassName, true);
		}

		static UStruct* GetNativeStructFromName(MonoString* InStructName)
		{
			FString StructName = MonoStringToFString(InStructName);
			return FindObject<UScriptStruct>(ANY_PACKAGE, *StructName, true);
		}

		static int32 GetNativeStructSize(MonoString* InStructName)
		{
			UStruct* S = GetNativeStructFromName(InStructName);
			if (S != nullptr)
			{
				if (UScriptStruct* ScriptStruct = Cast<UScriptStruct>(S))
				{
					return ScriptStruct->GetCppStructOps()->GetSize();
				}
				return S->GetStructureSize();
			}
			return -1;
		}

		static int IsChildOf(UObject* _this, UClass* Class)
		{
			return _this->GetClass()->IsChildOf(Class)?1:0;
		}

		static UWorld* GetWorld(UObject* _this)
		{
			return _this->GetWorld();
		}

		static UObject* _StaticLoadObject(UClass* Class, UObject* InOuter, MonoString* Name, MonoString* Filename, uint32 LoadFlags, UPackageMap* Sandbox, bool bAllowObjectReconciliation)
		{
			return StaticLoadObject(Class, InOuter, *MonoStringToFString(Name), *MonoStringToFString(Filename), LoadFlags, Sandbox, bAllowObjectReconciliation);
		}
		static UClass* _StaticLoadClass(UClass* BaseClass, UObject* InOuter, MonoString* Name, MonoString* Filename, uint32 LoadFlags, UPackageMap* Sandbox)
		{
			return StaticLoadClass(BaseClass, InOuter, *MonoStringToFString(Name), *MonoStringToFString(Filename), LoadFlags, Sandbox);
		}
		static UObject* _StaticFindObjectFast(UClass* Class, UObject* InOuter, MonoString* InName, bool ExactClass = false, bool AnyPackage = false)
		{
			return StaticFindObjectFast(Class, InOuter, *MonoStringToFString(InName),ExactClass, AnyPackage, RF_NoFlags, EInternalObjectFlags::None);
		}
		static UObject* _StaticFindObject(UClass* Class, UObject* InOuter, MonoString* Name, bool ExactClass = false)
		{
			return StaticFindObject(Class, InOuter, *MonoStringToFString(Name), ExactClass);
		}

		static MonoString* _MakeUniqueObjectName(UObject* Outer, UClass* Class, MonoString* BaseName)
		{
			return FNameToMonoString(MakeUniqueObjectName(Outer,Class, MonoStringToFName(BaseName)));
		}

		static MonoObject* GetManagedObject(UObject* Ptr)
		{
			if (Ptr != nullptr)
			{
				UMonoScriptBind_Component* Comp = Cast<UMonoScriptBind_Component>(Ptr);
				if (Comp != nullptr)
				{
					FMonoContext* Context = (FMonoContext*) Comp->GetContext();
					if (Context != nullptr)
					{
						return Context->GetManagedObject();
					}
				}
			}

			return nullptr;
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UObject::_LogInfo", (const void*)LogInfo);
			mono_add_internal_call("UnrealEngine.UObject::_LogWarning", (const void*)LogWarning);
			mono_add_internal_call("UnrealEngine.UObject::_LogError", (const void*)LogError);
			mono_add_internal_call("UnrealEngine.UObject::GetName", (const void*)GetName);
			mono_add_internal_call("UnrealEngine.UObject::_GetClass", (const void*)_GetClass);
			mono_add_internal_call("UnrealEngine.UObject::GetOuter", (const void*)GetOuter);
			mono_add_internal_call("UnrealEngine.UObject::NewObject", (const void*)NewObject);
			mono_add_internal_call("UnrealEngine.UObject::_StaticClass", (const void*)_StaticClass);
			mono_add_internal_call("UnrealEngine.UObject::GetPropertyOffset", (const void*)GetPropertyOffset);
			mono_add_internal_call("UnrealEngine.UObject::GetNativeClassFromName", (const void*)GetNativeClassFromName);
			mono_add_internal_call("UnrealEngine.UObject::GetNativeStructFromName", (const void*)GetNativeStructFromName);
			mono_add_internal_call("UnrealEngine.UObject::GetNativeStructSize", (const void*)GetNativeStructSize);
			mono_add_internal_call("UnrealEngine.UObject::IsChildOf", (const void*)IsChildOf);
			mono_add_internal_call("UnrealEngine.UObject::GetWorld", (const void*)GetWorld);

			mono_add_internal_call("UnrealEngine.UObject::_StaticLoadObject", (const void*)_StaticLoadObject);
			mono_add_internal_call("UnrealEngine.UObject::_StaticLoadClass", (const void*)_StaticLoadClass);
			mono_add_internal_call("UnrealEngine.UObject::_StaticFindObjectFast", (const void*)_StaticFindObjectFast);
			mono_add_internal_call("UnrealEngine.UObject::_StaticFindObject", (const void*)_StaticFindObject);
			mono_add_internal_call("UnrealEngine.UObject::_MakeUniqueObjectName", (const void*)_MakeUniqueObjectName);

			mono_add_internal_call("UnrealEngine.UObject::GetManagedObject", (const void*)GetManagedObject);
		}
	};

	class _UClass_Ext
	{
		static  MonoString* GetClassNameCpp(UClass* Class)
		{
			return FStringToMonoString(FString::Printf(TEXT("%s%s"), Class->GetPrefixCPP(), *Class->GetName()));
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UClass::GetClassNameCpp", (const void*)GetClassNameCpp);
		}
	};
}
