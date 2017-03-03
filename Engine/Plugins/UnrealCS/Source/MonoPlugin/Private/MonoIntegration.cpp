// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
//#if WITH_MONO
#include "MonoIntegration.h"
#include "MonoPluginPrivatePCH.h"

#include "MonoScriptClass.h"
#include "MonoDomain.h"
#include "MonoScriptBind_Component.h"


FMonoContext::FMonoContext()
{
	Obj = NULL;
	method_BeginPlay = NULL;
	method_Tick = NULL;
	method_EndPlay = NULL;
	method_Destroy = NULL;
	Class = NULL;
}

FMonoContext::~FMonoContext()
{
}


MonoMethod* FMonoContext::FindMethod(const char* name, int paramCount)
{
	MonoClass* p = Class;
	while (p != NULL)
	{
		MonoMethod* method = mono_class_get_method_from_name(p, name, paramCount);
		if (method != NULL)
		{
			return method;
		}
		p = mono_class_get_parent(p);
	};

	return NULL;
}

void* FMonoContext::Invoke(void* method, void** param)
{
	MonoObject* exception = NULL;
	MonoObject* ret = mono_runtime_invoke((MonoMethod*)method, Obj, param, &exception);
	if (exception)
	{
		mono_print_unhandled_exception(exception);
	}
	return ret;
}

bool FMonoContext::Initialize(const FString& Code, UObject* Owner)
{
	ClassName = Code;
	ObjectPtr = Owner;
	UpdateData();
	if (Obj == NULL)
		return false;
	return true;
}

void FMonoContext::BeginPlay()
{
	if (method_BeginPlay)
	{
		Invoke(method_BeginPlay, NULL);
	}
}

void FMonoContext::Tick(float DeltaTime)
{
	if (method_Tick)
	{
		void *args[1];
		args[0] = &DeltaTime;
		Invoke(method_Tick, args);
	}
}

void FMonoContext::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	if (method_EndPlay)
	{
		int32 Reason = (int32)EndPlayReason;
		void* Args[] = { &Reason };
		Invoke(method_EndPlay, Args);
	}
}
void FMonoContext::Destroy()
{
	if (method_Destroy)
	{
		Invoke(method_Destroy, NULL);
	}

	if (Obj != NULL)
	{
		mono_gchandle_free(handle);
		Obj = NULL;
		method_BeginPlay = NULL;
		method_Tick = NULL;
		method_EndPlay = NULL;
		method_Destroy = NULL;
	}

	//#if WITH_MONO_HOTRELOAD
	//	if (FMonoDomain::Get() != NULL)
	//	{
	//		FMonoDomain::Get()->UnRegistScriptComponent(this);
	//	}
	//#endif
}

void FMonoContext::UpdateData()
{

	if (Obj != NULL)
	{
		mono_gchandle_free(handle);
		Obj = NULL;
		method_BeginPlay = NULL;
		method_Tick = NULL;
		method_EndPlay = NULL;
		method_Destroy = NULL;
		Class = NULL;
	}

	if (FMonoDomain::Get() != NULL)
	{
		Class = mono_class_from_name(FMonoDomain::Get()->GetImage(), "Game", TCHAR_TO_ANSI(*ClassName));
		if (Class != NULL)
		{
			Obj = mono_object_new(FMonoDomain::Get()->GetDomain(), Class);
			if (Obj != NULL)
			{
				handle = mono_gchandle_new(Obj, 1);


				method_BeginPlay = FindMethod("BeginPlay", -1);
				method_Tick = FindMethod("Tick", 1);
				method_EndPlay = FindMethod("EndPlay", 1);
				method_Destroy = FindMethod("BeginDestroy", -1);

				MonoClassField* Field = mono_class_get_field_from_name(Class, "_this");
				if (Field)
				{
					void* params = &ObjectPtr;
					mono_field_set_value(Obj, Field, params);
				}

				mono_runtime_object_init(Obj);
			}
		}
	}

}

#if WITH_MONO_HOTRELOAD
void FMonoContext::BeginHotReload()
{
	if (Obj != NULL)
	{
		mono_gchandle_free(handle);
		Obj = NULL;
		method_BeginPlay = NULL;
		method_Tick = NULL;
		method_EndPlay = NULL;
		method_Destroy = NULL;
		Class = NULL;
	}
}
void FMonoContext::EndHotReload()
{
	UpdateData();
}
#endif
//
//bool FMonoContext::CallFunction(const FString& FunctionName)
//{
//	if (Obj)
//	{
//		if (Class != NULL)
//		{
//			MonoMethod* method = mono_class_get_method_from_name(Class, TCHAR_TO_ANSI(*FunctionName), -1);
//			if (method)
//			{
//				Invoke(method, NULL);
//				return true;
//			}
//				
//		}
//	}
//	return false;
//}

bool FMonoContext::SetFloatProperty(const FString& PropertyName, float NewValue)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		void* params = &NewValue;
		mono_field_set_value(Obj, Field, params);
		return true;
	}

	return false;
}

float FMonoContext::GetFloatProperty(const FString& PropertyName)
{
	check(Class);
	float NewValue = 0.0f;
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		mono_field_get_value(Obj, Field, &NewValue);
		return NewValue;
	}

	return NewValue;
}

bool FMonoContext::SetIntProperty(const FString& PropertyName, int32 NewValue)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		void* params = &NewValue;
		mono_field_set_value(Obj, Field, params);
		return true;
	}

	return false;
}

int32 FMonoContext::GetIntProperty(const FString& PropertyName)
{
	check(Class);
	int32 NewValue = 0;
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{

		mono_field_get_value(Obj, Field, &NewValue);
		return NewValue;
	}

	return NewValue;
}

bool FMonoContext::SetObjectProperty(const FString& PropertyName, UObject* NewValue)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		MonoClass* ObjClass = mono_type_get_class(mono_field_get_type(Field));
		MonoObject* ObjProperty = mono_object_new(FMonoDomain::Get()->GetDomain(), ObjClass);
		MonoClassField* _ThisField = mono_class_get_field_from_name(ObjClass, "_this");
		if (_ThisField)
		{
			TWeakObjectPtr<UObject> ptr(NewValue);
			void* params = &ptr;
			mono_field_set_value(ObjProperty, _ThisField, params);

			mono_field_set_value(Obj, Field, ObjProperty);
			return true;
		}
	}

	return false;
}

UObject* FMonoContext::GetObjectProperty(const FString& PropertyName)
{
	check(Class);
	UObject* NewValue = NULL;
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		MonoObject* MonoObj = NULL;
		mono_field_get_value(Obj, Field, &MonoObj);
		if (MonoObj != NULL)
		{
			MonoClass* ObjClass = mono_object_get_class(MonoObj);
			Field = mono_class_get_field_from_name(ObjClass, "_this");
			if (Field)
			{
				TWeakObjectPtr<UObject> ptr;
				mono_field_get_value(MonoObj, Field, &ptr);
				return ptr.Get();
			}
		}
	}

	return NewValue;
}

bool FMonoContext::SetBoolProperty(const FString& PropertyName, bool NewValue)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		void* params = &NewValue;
		mono_field_set_value(Obj, Field, params);
		return true;
	}

	return false;
}

bool FMonoContext::GetBoolProperty(const FString& PropertyName)
{
	check(Class);
	bool NewValue = false;
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{

		mono_field_get_value(Obj, Field, &NewValue);
		return NewValue;
	}

	return NewValue;
}

bool FMonoContext::SetStringProperty(const FString& PropertyName, const FString& NewValue)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		MonoString* Str = FStringToMonoString(NewValue);
		mono_field_set_value(Obj, Field, Str);
		return true;
	}

	return false;
}

FString FMonoContext::GetStringProperty(const FString& PropertyName)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		MonoString* Str = NULL;
		mono_field_get_value(Obj, Field, &Str);
		return MonoStringToFString(Str);
	}

	return FString();
}
bool FMonoContext::SetArrayProperty(const FString& PropertyName, const  UObject* CppObj, UArrayProperty* Property)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		TSharedPtr<FScriptArrayHelper> helper = MakeShareable(new FScriptArrayHelper(Property, Property->ContainerPtrToValuePtr<void>(CppObj)));
		int32 len = helper->Num();

		MonoType* type = mono_field_get_type(Field);
		MonoClass* elementClass = mono_class_get_element_class(mono_type_get_class(type));
		MonoType* elementType = mono_class_get_type(elementClass);
		MonoArray* value = mono_array_new(FMonoDomain::Get()->GetDomain(), elementClass, len);

		for (int i = 0; i < len; i++)
		{
			void* Ptr = helper->GetRawPtr(i);
			if (UFloatProperty* FloatProperty = Cast<UFloatProperty>(Property->Inner))
			{
				float v;
				Property->Inner->CopyCompleteValue(&v, Property->Inner->ContainerPtrToValuePtr<uint8>(Ptr));
				mono_array_set(value, float, i, v);
			}
			else if (UIntProperty* IntProperty = Cast<UIntProperty>(Property->Inner))
			{
				int v;
				Property->Inner->CopyCompleteValue(&v, Property->Inner->ContainerPtrToValuePtr<uint8>(Ptr));
				mono_array_set(value, int, i, v);
			}
			else if (UBoolProperty* BoolProperty = Cast<UBoolProperty>(Property->Inner))
			{
				bool Value = BoolProperty->GetPropertyValue(Property->Inner->ContainerPtrToValuePtr<uint8>(Ptr));
				mono_array_set(value, bool, i, Value);
			}
			else if (UStrProperty* StrProperty = Cast<UStrProperty>(Property->Inner))
			{
				FString Value = StrProperty->GetPropertyValue(Property->Inner->ContainerPtrToValuePtr<uint8>(Ptr));
				mono_array_set(value, MonoString*, i, FStringToMonoString(Value));
			}
			else if (UClassProperty* ClassProperty = Cast<UClassProperty>(Property->Inner))
			{
				UObject* NewValue = ClassProperty->GetObjectPropertyValue(Property->Inner->ContainerPtrToValuePtr<UObject*>(Ptr));
				mono_array_set(value, UObject*, i, NewValue);
			}
			else if (UObjectProperty* ObjectProperty = Cast<UObjectProperty>(Property->Inner))
			{
				UObject* NewValue = ObjectProperty->GetObjectPropertyValue(Property->Inner->ContainerPtrToValuePtr<UObject*>(Ptr));

				MonoObject* ObjProperty = mono_object_new(FMonoDomain::Get()->GetDomain(), elementClass);
				MonoClassField* _ThisField = mono_class_get_field_from_name(elementClass, "_this");
				if (_ThisField)
				{
					TWeakObjectPtr<UObject> ptr(NewValue);
					void* params = &ptr;
					mono_field_set_value(ObjProperty, _ThisField, params);
					mono_array_set(value, MonoObject*, i, ObjProperty);
				}
			}
		}

		mono_field_set_value(Obj, Field, value);
	}
	return false;
}
bool FMonoContext::GetArrayProperty(const FString& PropertyName, UObject* CppObj, UArrayProperty* Property)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		MonoType* type = mono_field_get_type(Field);
		MonoArray* value = NULL;
		mono_field_get_value(Obj, Field, &value);
		if (value != NULL)
		{
			MonoClass* elementClass = mono_class_get_element_class(mono_type_get_class(type));
			MonoType* elementType = mono_class_get_type(elementClass);
			int32 len = mono_array_length(value);

			TSharedPtr<FScriptArrayHelper> helper = MakeShareable(new FScriptArrayHelper(Property, Property->ContainerPtrToValuePtr<uint8>(CppObj)));
			helper->Resize(len);

			for (int i = 0; i < len; i++)
			{
				void* Ptr = helper->GetRawPtr(i);
				if (UFloatProperty* FloatProperty = Cast<UFloatProperty>(Property->Inner))
				{
					float v = mono_array_get(value, float, i);
					Property->Inner->CopyCompleteValue(Property->Inner->ContainerPtrToValuePtr<uint8>(Ptr), &v);
				}
				else if (UIntProperty* IntProperty = Cast<UIntProperty>(Property->Inner))
				{
					int v = mono_array_get(value, int, i);
					Property->Inner->CopyCompleteValue(Property->Inner->ContainerPtrToValuePtr<uint8>(Ptr), &v);
				}
				else if (UBoolProperty* BoolProperty = Cast<UBoolProperty>(Property->Inner))
				{
					bool v = mono_array_get(value, bool, i);
					BoolProperty->SetPropertyValue(Property->Inner->ContainerPtrToValuePtr<float>(Obj), v);
				}
				else if (UStrProperty* StrProperty = Cast<UStrProperty>(Property->Inner))
				{
					MonoString* v = mono_array_get(value, MonoString*, i);
					StrProperty->SetPropertyValue(Property->Inner->ContainerPtrToValuePtr<uint8>(Ptr), MonoStringToFString(v));
				}
				else if (UClassProperty* ClassProperty = Cast<UClassProperty>(Property->Inner))
				{
					UClass* v = mono_array_get(value, UClass*, i);
					ClassProperty->SetObjectPropertyValue(Property->Inner->ContainerPtrToValuePtr<UObject*>(Ptr), v);
				}
				else if (UObjectProperty* ObjectProperty = Cast<UObjectProperty>(Property->Inner))
				{
					MonoObject* MonoObj = mono_array_get(value, MonoObject*, i);
					if (MonoObj != NULL)
					{
						MonoClass* ObjClass = mono_object_get_class(MonoObj);
						MonoClassField* _ThisField = mono_class_get_field_from_name(ObjClass, "_this");
						if (_ThisField)
						{
							TWeakObjectPtr<UObject> ptr;
							mono_field_get_value(MonoObj, _ThisField, &ptr);
							UObject* NewValue = ptr.Get();
							ObjectProperty->SetObjectPropertyValue(Property->Inner->ContainerPtrToValuePtr<UObject*>(Ptr), NewValue);
						}
					}
				}
			}
			return true;
		}
	}
	TSharedPtr<FScriptArrayHelper> helper = MakeShareable(new FScriptArrayHelper(Property, Property->ContainerPtrToValuePtr<uint8>(CppObj)));
	helper->Resize(0);
	return false;
}

bool FMonoContext::SetStructProperty(const FString& PropertyName, const UObject* CppObj, UStructProperty* Property)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		void* params = (void*)Property->ContainerPtrToValuePtr<uint8>(CppObj);
		mono_field_set_value(Obj, Field, params);
		return true;
	}

	return false;
}
bool FMonoContext::GetStructProperty(const FString& PropertyName, UObject* CppObj, UStructProperty* Property)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		uint8* NewValue = Property->ContainerPtrToValuePtr<uint8>(CppObj);
		mono_field_get_value(Obj, Field, &NewValue);
		return true;
	}
	return false;
}

bool FMonoContext::SetClassProperty(const FString& PropertyName, UClass* NewValue)
{
	check(Class);
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{
		void* params = &NewValue;
		mono_field_set_value(Obj, Field, params);
		return true;
	}

	return false;
}
UClass* FMonoContext::GetClassProperty(const FString& PropertyName)
{
	check(Class);
	UClass* NewValue = nullptr;
	MonoClassField* Field = mono_class_get_field_from_name(Class, TCHAR_TO_ANSI(*PropertyName));
	if (Field)
	{

		mono_field_get_value(Obj, Field, &NewValue);
		return NewValue;
	}

	return NewValue;
}

void FMonoContext::PushScriptPropertyValues(UMonoScriptClass* ScriptClass, const UObject* ThisObj)
{
	// @todo: optimize this
	for (auto Property : ScriptClass->ScriptProperties)
	{
		if (UFloatProperty* FloatProperty = Cast<UFloatProperty>(Property))
		{
			float Value = FloatProperty->GetFloatingPointPropertyValue(Property->ContainerPtrToValuePtr<uint8>(ThisObj));
			SetFloatProperty(Property->GetName(), Value);
		}
		else if (UIntProperty* IntProperty = Cast<UIntProperty>(Property))
		{
			int32 Value = IntProperty->GetSignedIntPropertyValue(Property->ContainerPtrToValuePtr<uint8>(ThisObj));
			SetIntProperty(Property->GetName(), Value);
		}
		else if (UBoolProperty* BoolProperty = Cast<UBoolProperty>(Property))
		{
			bool Value = BoolProperty->GetPropertyValue(Property->ContainerPtrToValuePtr<uint8>(ThisObj));
			SetBoolProperty(Property->GetName(), Value);
		}
		else if (UClassProperty* ClassProperty = Cast<UClassProperty>(Property))
		{
			UObject* Value = ClassProperty->GetObjectPropertyValue(Property->ContainerPtrToValuePtr<UObject*>(ThisObj));
			SetClassProperty(Property->GetName(), (UClass*)Value);
		}
		else if (UObjectProperty* ObjectProperty = Cast<UObjectProperty>(Property))
		{
			UObject* Value = ObjectProperty->GetObjectPropertyValue(Property->ContainerPtrToValuePtr<UObject*>(ThisObj));
			SetObjectProperty(Property->GetName(), Value);
		}
		else if (UStrProperty* StringProperty = Cast<UStrProperty>(Property))
		{
			FString Value = StringProperty->GetPropertyValue(Property->ContainerPtrToValuePtr<uint8>(ThisObj));
			SetStringProperty(Property->GetName(), Value);
		}
		else if (UArrayProperty* ArrayProperty = Cast<UArrayProperty>(Property))
		{
			SetArrayProperty(Property->GetName(), ThisObj, ArrayProperty);
		}
		else if (UStructProperty* StructProperty = Cast<UStructProperty>(Property))
		{
			SetStructProperty(Property->GetName(), ThisObj, StructProperty);
		}
	}
}

void FMonoContext::FetchScriptPropertyValues(UMonoScriptClass* ScriptClass, UObject* ThisObj)
{
	// @todo: optimize this
	for (auto Property : ScriptClass->ScriptProperties)
	{
		if (Property->GetOffset_ForInternal() == 0)
		{
			UE_LOG(LogMono, Warning, TEXT("Property %s Offset == 0  Is Not Initialized"), *Property->GetName());
			return;
		}
		if (UFloatProperty* FloatProperty = Cast<UFloatProperty>(Property))
		{
			float Value = GetFloatProperty(Property->GetName());
			FloatProperty->SetFloatingPointPropertyValue(Property->ContainerPtrToValuePtr<uint8>(ThisObj), Value);
		}
		else if (UIntProperty* IntProperty = Cast<UIntProperty>(Property))
		{
			int32 Value = GetIntProperty(Property->GetName());
			IntProperty->SetPropertyValue(Property->ContainerPtrToValuePtr<uint8>(ThisObj), Value);
		}
		else if (UBoolProperty* BoolProperty = Cast<UBoolProperty>(Property))
		{
			bool Value = GetBoolProperty(Property->GetName());
			BoolProperty->SetPropertyValue(Property->ContainerPtrToValuePtr<uint8>(ThisObj), Value);
		}
		else if (UClassProperty* ClassProperty = Cast<UClassProperty>(Property))
		{
			UClass* Value = GetClassProperty(Property->GetName());
			ClassProperty->SetObjectPropertyValue(Property->ContainerPtrToValuePtr<UObject*>(ThisObj), Value);
		}
		else if (UObjectProperty* ObjectProperty = Cast<UObjectProperty>(Property))
		{
			UObject* Value = GetObjectProperty(Property->GetName());
			ObjectProperty->SetObjectPropertyValue(Property->ContainerPtrToValuePtr<UObject*>(ThisObj), Value);
		}
		else if (UStrProperty* StringProperty = Cast<UStrProperty>(Property))
		{
			FString Value = GetStringProperty(Property->GetName());
			StringProperty->InitializeValue_InContainer(ThisObj);
			StringProperty->SetPropertyValue(Property->ContainerPtrToValuePtr<uint8>(ThisObj), Value);
		}
		else if (UArrayProperty* ArrayProperty = Cast<UArrayProperty>(Property))
		{
			GetArrayProperty(Property->GetName(), ThisObj, ArrayProperty);
		}
		else if (UStructProperty* StructProperty = Cast<UStructProperty>(Property))
		{
			GetStructProperty(Property->GetName(), ThisObj, StructProperty);
		}
	}
}

void FMonoContext::InvokeScriptFunction(FFrame& Stack, RESULT_DECL)
{
	MonoMethod* method = FindMethod(TCHAR_TO_ANSI(*Stack.CurrentNativeFunction->GetName()), -1);
	if (method != NULL)
	{
		UFunction* Function = Stack.CurrentNativeFunction;

		TArray<uint8*> Args;

		{
			FFrame& NewStack = Stack;
			FOutParmRec** LastOut = &NewStack.OutParms;
			UProperty* Property;

			
			// Check to see if we need to handle a return value for this function.  We need to handle this first, because order of return parameters isn't always first.
			if (Function->HasAnyFunctionFlags(FUNC_HasOutParms))
			{
				// Iterate over the function parameters, searching for the ReturnValue
				for (TFieldIterator<UProperty> ParmIt(Function); ParmIt; ++ParmIt)
				{
					Property = *ParmIt;
					if (Property->HasAnyPropertyFlags(CPF_ReturnParm))
					{
						CA_SUPPRESS(6263)
							FOutParmRec* RetVal = (FOutParmRec*)FMemory_Alloca(sizeof(FOutParmRec));

						// Our context should be that we're in a variable assignment to the return value, so ensure that we have a valid property to return to
						check(RESULT_PARAM != NULL);
						RetVal->PropAddr = (uint8*)RESULT_PARAM;
						RetVal->Property = Property;
						NewStack.OutParms = RetVal;

						// A function can only have one return value, so we can stop searching
						break;
					}
				}
			}

			if (Stack.Code != nullptr)
			{
				for (Property = (UProperty*)Function->Children; *Stack.Code != EX_EndFunctionParms; Property = (UProperty*)Property->Next)
				{
					Stack.MostRecentPropertyAddress = NULL;

					// Skip the return parameter case, as we've already handled it above
					const bool bIsReturnParam = ((Property->PropertyFlags & CPF_ReturnParm) != 0);
					if (bIsReturnParam)
					{
						continue;
					}

					if (Property->PropertyFlags & CPF_OutParm)
					{
						// evaluate the expression for this parameter, which sets Stack.MostRecentPropertyAddress to the address of the property accessed
						Stack.Step(Stack.Object, NULL);

						CA_SUPPRESS(6263)
							FOutParmRec* Out = (FOutParmRec*)FMemory_Alloca(sizeof(FOutParmRec));
						// set the address and property in the out param info
						// warning: Stack.MostRecentPropertyAddress could be NULL for optional out parameters
						// if that's the case, we use the extra memory allocated for the out param in the function's locals
						// so there's always a valid address
						ensure(Stack.MostRecentPropertyAddress); // possible problem - output param values on local stack are neither initialized nor cleaned.
						Out->PropAddr = (Stack.MostRecentPropertyAddress != NULL) ? Stack.MostRecentPropertyAddress : Property->ContainerPtrToValuePtr<uint8>(NewStack.Locals);
						Out->Property = Property;
						Args.Add(Out->PropAddr);

						// add the new out param info to the stack frame's linked list
						if (*LastOut)
						{
							(*LastOut)->NextOutParm = Out;
							LastOut = &(*LastOut)->NextOutParm;
						}
						else
						{
							*LastOut = Out;
						}


					}
					else
					{
						// copy the result of the expression for this parameter into the appropriate part of the local variable space
						uint8* Param = Property->ContainerPtrToValuePtr<uint8>(NewStack.Locals);
						checkSlow(Param);
						Args.Add(Param);
						Property->InitializeValue_InContainer(NewStack.Locals);

						Stack.Step(Stack.Object, Param);
					}
				}
			}
			}
			
		
		MonoObject* Ret =(MonoObject*) Invoke(method, (void**)Args.GetData());
		UProperty* ReturnProperty = Function->GetReturnProperty();

		if (ReturnProperty != nullptr)
		{
			
			if (Cast<UBoolProperty>(ReturnProperty) && ReturnProperty->ArrayDim == 1)
			{
				void* Ptr = mono_object_unbox(Ret);
				// we're going to get '1' returned for bools that are set, so we need to manually mask it in to the proper place
				bool bValue = *((int*)Ptr) != 0;
				((UBoolProperty*)ReturnProperty)->SetPropertyValue((uint8*)RESULT_PARAM, bValue);
			}
			else if(Cast<UIntProperty>(ReturnProperty) != nullptr
				|| Cast<UFloatProperty>(ReturnProperty) != nullptr
				|| Cast<UDoubleProperty>(ReturnProperty) != nullptr
				|| Cast<UInt8Property>(ReturnProperty) != nullptr
				|| Cast<UInt16Property>(ReturnProperty) != nullptr
				|| Cast<UInt64Property>(ReturnProperty) != nullptr
				|| Cast<UUInt16Property>(ReturnProperty) != nullptr
				|| Cast<UUInt32Property>(ReturnProperty) != nullptr
				|| Cast<UUInt64Property>(ReturnProperty) != nullptr
				|| Cast<UByteProperty>(ReturnProperty) != nullptr
				|| Cast<UStructProperty>(ReturnProperty) != nullptr
				)
			{
				void* Ptr = mono_object_unbox(Ret);
				ReturnProperty->CopyCompleteValue((uint8*)RESULT_PARAM, Ptr);
			}
			else if (Cast<UObjectProperty>(ReturnProperty) != nullptr)
			{
				void* Ptr = mono_object_unbox(Ret);
				ReturnProperty->CopyCompleteValue((uint8*)RESULT_PARAM, Ptr);
			}
		}
	}
}

#if WITH_EDITOR

void GetTypeProperty(MonoType* type, UClass*& PropClass, UObject*& InnerType)
{
	InnerType = NULL;
	PropClass = NULL;
	switch (mono_type_get_type(type))
	{
	case MONO_TYPE_I4:
		PropClass = UIntProperty::StaticClass();
		InnerType = PropClass;
		break;
	case 		MONO_TYPE_BOOLEAN:
		PropClass = UBoolProperty::StaticClass();
		InnerType = PropClass;
		break;
	case 		MONO_TYPE_R4:
		PropClass = UFloatProperty::StaticClass();
		InnerType = PropClass;
		break;
	case 		MONO_TYPE_STRING:
		PropClass = UStrProperty::StaticClass();
		InnerType = PropClass;
		break;
	case MONO_TYPE_CLASS:
	{
		FString name(ANSI_TO_TCHAR(mono_type_get_name(type)));
		name = name.Mid(14);
		InnerType = FindObject<UClass>(ANY_PACKAGE, *name, true);
		if (InnerType != nullptr)
			PropClass = UObjectProperty::StaticClass();
	}
	break;
	case MONO_TYPE_SZARRAY:
	{
		MonoClass* elementClass = mono_class_get_element_class(mono_type_get_class(type));
		MonoType* elementType = mono_class_get_type(elementClass);
		UClass* ArrayPropClass;
		UObject* ArrayInnerClass;
		GetTypeProperty(elementType, ArrayPropClass, ArrayInnerClass);
		InnerType = ArrayInnerClass;
		if (InnerType != nullptr)
			PropClass = UArrayProperty::StaticClass();
	}
	break;

	case MONO_TYPE_VALUETYPE:
	{
		if (mono_type_is_struct(type))
		{
			FString name(ANSI_TO_TCHAR(mono_type_get_name(type)));
			name = name.Mid(14);
			InnerType = FindObject<UScriptStruct>(ANY_PACKAGE, *name, true);
			if (InnerType != nullptr)
				PropClass = UStructProperty::StaticClass();
		}
	}
	break;

	case MONO_TYPE_GENERICINST:
	{
		//结构体
		//if (mono_type_is_struct(type))
		{

			FString name(ANSI_TO_TCHAR(mono_type_get_name(type)));
			if (name.Contains("UnrealEngine.TSubclassOf"))
			{
				//MonoGenericClass *gclass = type->data.generic_class;
				//MonoClass *container_class = gclass->container_class;
				//MonoType* containerType = mono_class_get_type(container_class);
				//UClass* ChildPropClass, *ChildInnerClass;
				//GetTypeProperty(containerType, ChildPropClass, ChildInnerClass);
				int index_0;
				int index_1;
				if (name.FindLastChar('.', index_0))
				{
					index_0 += 2;
				}
				if (name.FindLastChar('>', index_1))
				{

				}

				if (index_0 == INDEX_NONE || index_1 == INDEX_NONE)
				{
					return;
				}

				InnerType = FindObject<UClass>(ANY_PACKAGE, *name.Mid(index_0, index_1 - index_0), true);
				if (InnerType != nullptr)
					PropClass = UClassProperty::StaticClass();
			}

		}
	}
	break;
	case 		MONO_TYPE_CHAR:
	case 		MONO_TYPE_I1:
	case 		MONO_TYPE_U1:
	case 		MONO_TYPE_I2:
	case 		MONO_TYPE_U2:
	case 		MONO_TYPE_U4:
	case 		MONO_TYPE_I8:
	case 		MONO_TYPE_U8:
	default:
		UE_LOG(LogMono, Warning, TEXT("Not Supported Type:Type %d"), mono_type_get_type(type));
		break;
	}
}

void FMonoContext::GetScriptDefinedFields(TArray<FScriptField>& OutFields)
{
	check(Class);

	void* iter = NULL;
	MonoClassField* field = mono_class_get_fields(Class, &iter);
	while (field != NULL)
	{
		uint32 flags = mono_field_get_flags(field);
		if ((flags & MONO_FIELD_ATTR_PUBLIC) && (flags & MONO_FIELD_ATTR_STATIC) == 0)
		{
			FString KeyName(ANSI_TO_TCHAR(mono_field_get_name(field)));
			MonoType* type = mono_field_get_type(field);
			FScriptField PropertyInfo;
			UClass* PropClass;
			UObject* InnerType;
			GetTypeProperty(type, PropClass, InnerType);
			if (PropClass)
			{
				PropertyInfo.Class = PropClass;
				PropertyInfo.InnerType = InnerType;
				PropertyInfo.Name = FName(*KeyName);
				OutFields.Add(PropertyInfo);
			}
		}
		field = mono_class_get_fields(Class, &iter);
	}
}

UProperty* CreateParamFromMonoType(MonoType* type, UStruct* Scope, FName PropertyName)
{
	UObject* PropertyScope = Scope;
	const EObjectFlags ObjectFlags = RF_Public;
	FName ValidatedPropertyName = PropertyName;

	switch (mono_type_get_type(type))
	{
	case MONO_TYPE_I4:
	{
		return NewObject<UIntProperty>(Scope, ValidatedPropertyName, ObjectFlags);
	}

	case 		MONO_TYPE_BOOLEAN:
	{
		UBoolProperty* BoolProperty = NewObject<UBoolProperty>(Scope, ValidatedPropertyName, ObjectFlags);
		BoolProperty->SetBoolSize(sizeof(int32), false);
		return BoolProperty;
	}
	case 		MONO_TYPE_R4:
	{
		return NewObject<UFloatProperty>(PropertyScope, ValidatedPropertyName, ObjectFlags);
	}
	break;
	case 		MONO_TYPE_STRING:
		UE_LOG(LogMono, Warning, TEXT("Not Supported Param Type:Type %d"), mono_type_get_type(type));
		break;
	case MONO_TYPE_CLASS:
	{
		FString name(ANSI_TO_TCHAR(mono_type_get_name(type)));
		name = name.Mid(14);
		UClass* InnerType = FindObject<UClass>(ANY_PACKAGE, *name, true);
		if (InnerType == nullptr)
		{
			InnerType = UObject::StaticClass();
		}
		UObjectProperty* NewPropertyObj = NewObject<UObjectProperty>(PropertyScope, ValidatedPropertyName, ObjectFlags);
		NewPropertyObj->SetPropertyClass(InnerType);
		return NewPropertyObj;
	}
	break;
	case MONO_TYPE_SZARRAY:
	{
		UE_LOG(LogMono, Warning, TEXT("Not Supported Param Type:Type %d"), mono_type_get_type(type));
	}
	break;

	case MONO_TYPE_VALUETYPE:
	{
		FString name;
		int flag = 0;
		if (mono_type_is_struct(type))
		{
			name = (ANSI_TO_TCHAR(mono_type_get_name(type)));
			name = name.Mid(14);
			
		}
		else if (mono_type_is_reference(type))
		{
			name = (ANSI_TO_TCHAR(mono_type_get_name(type)));
			name = name.Mid(14);
			name.Replace(TEXT("&"),TEXT(""));
			flag |=  CPF_ReferenceParm | CPF_OutParm;
		}
		else if (mono_type_is_byref(type))
		{
			name = (ANSI_TO_TCHAR(mono_type_get_name(type)));
			name = name.Mid(14);
			name.RemoveAt(name.Len() - 1);
			flag |=  CPF_OutParm;
		}
		UScriptStruct* InnerType = FindObject<UScriptStruct>(ANY_PACKAGE, *name, true);
		if (InnerType != nullptr)
		{
			UStructProperty* NewPropertyStruct = NewObject<UStructProperty>(PropertyScope, ValidatedPropertyName, ObjectFlags);
			NewPropertyStruct->Struct = InnerType;
			NewPropertyStruct->PropertyFlags |= flag;
			return NewPropertyStruct;
		}
		else
		{
			UE_LOG(LogMono, Warning, TEXT("Not Supported Param Type %s:Type %d"), *name, mono_type_get_type(type));
		}
	}
	break;
	case MONO_TYPE_VOID:
		//不提示void类型
		break;
	case MONO_TYPE_GENERICINST:
	case 		MONO_TYPE_CHAR:
	case 		MONO_TYPE_I1:
	case 		MONO_TYPE_U1:
	case 		MONO_TYPE_I2:
	case 		MONO_TYPE_U2:
	case 		MONO_TYPE_U4:
	case 		MONO_TYPE_I8:
	case 		MONO_TYPE_U8:
	default:
		UE_LOG(LogMono, Warning, TEXT("Not Supported Param Type:Type %d"), mono_type_get_type(type));
		break;
	}

	return nullptr;
}



void CreateFunction(UMonoScriptClass* NewClass, MonoMethod* method)
{
	FString KeyName(ANSI_TO_TCHAR(mono_method_get_name(method)));
	FString InterFuncName = KeyName;

	FNativeFunctionRegistrar::RegisterFunction(NewClass, TCHAR_TO_ANSI(*InterFuncName), (Native)&UMonoScriptBind_Component::InvokeMonoEventThunk);

	uint64 FuncFlags = FUNC_Native | FUNC_BlueprintCallable;

	UFunction* NewFunction = new(NewClass, *InterFuncName, /*RF_Transient |*/ RF_Public)
		UFunction(FObjectInitializer(), nullptr, FuncFlags);

	FFunctionField PropertyInfo;
	PropertyInfo.Name = FName(*KeyName);

	UE_LOG(LogMono, Log, TEXT("Method Name %s"), *KeyName);
	bool hasOutParam = false;

	//参数
	MonoMethodSignature* sig = mono_method_signature(method);
	if (sig != nullptr)
	{
		void* iter = nullptr;
		MonoType* param = mono_signature_get_params(sig, &iter);
		int param_num = 0;

		while (param != nullptr)
		{

			UProperty* P = CreateParamFromMonoType(param, NewFunction, *FString::Printf(TEXT("param_%d"),param_num));
			if (P != nullptr)
			{
				PropertyInfo.Params.Add(P);
			}
			else
			{
				NewFunction->MarkPendingKill();
				NewFunction = nullptr;
				break;
			}

			param_num++;
			param = mono_signature_get_params(sig, &iter);
		}

		if (!NewFunction)
			return;

		for (int i = 0; i < PropertyInfo.Params.Num(); i++)
		{
			if (mono_signature_param_is_out(sig, i))
			{
				PropertyInfo.Params[i]->PropertyFlags |= CPF_OutParm;
			}
		}

		//返回值
		{
			MonoType* returnType = mono_signature_get_return_type(sig);
			UProperty* P = CreateParamFromMonoType(returnType, NewFunction, "ReturnValue");
			PropertyInfo.ReturnValue = P;
		}
	}

	//根据获得的属性，创建函数

	if (PropertyInfo.ReturnValue != nullptr)
	{
		hasOutParam = true;
		PropertyInfo.ReturnValue->PropertyFlags |= CPF_Parm | CPF_OutParm | CPF_ReturnParm;
		NewFunction->LinkChild(PropertyInfo.ReturnValue);
	}

	// Parameter creation order dictates the order of insertion at the head of the property list during linking, so create
	// in reverse order to get a list of all parameters, in order, followed by the return value.
	for (int i = PropertyInfo.Params.Num() - 1; i >= 0; --i)
	{
		UProperty* ParamProperty = PropertyInfo.Params[i];
		ParamProperty->PropertyFlags |= CPF_Parm;
		NewFunction->LinkChild(ParamProperty);

		if ((PropertyInfo.Params[i]->PropertyFlags & CPF_OutParm) != 0)
		{
			hasOutParam = true;
		}
	}

	if (hasOutParam)
	{
		NewFunction->FunctionFlags |= FUNC_HasOutParms;
	}

	//绑定并链接
	NewFunction->Bind();
	NewFunction->StaticLink(true);

	NewClass->LinkChild(NewFunction);
	NewClass->AddFunctionToFunctionMap(NewFunction);

	NewClass->ScriptFunctions.Add(NewFunction);
}


void FMonoContext::CreateFunctions(UMonoScriptClass* NewClass)
{
	check(Class);
	{
		void* iter = NULL;
		MonoMethod* method = nullptr;
		while ((method = mono_class_get_methods(Class, &iter)) != nullptr)
		{
			FFunctionField FuncFields;
			uint32 flags = 0;
			uint32 iflags = 0;
			flags = mono_method_get_flags(method, &iflags);
			if ((flags & MONO_METHOD_ATTR_PUBLIC) && (flags & MONO_METHOD_ATTR_STATIC) == 0)
			{
				FString KeyName(ANSI_TO_TCHAR(mono_method_get_name(method)));

				if (!KeyName.Contains(".ctor"))
				{
					CreateFunction(NewClass, method);
				}

			}
		}
	}
}


#endif //WITH_EDITOR
