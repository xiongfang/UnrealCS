// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

#include "Templates/UnrealTypeTraits.h"

UProperty* FindScriptPropertyHelper(UClass* Class, FName PropertyName, bool ExcludeSuper = true)
{
	for (TFieldIterator<UProperty> PropertyIt(Class, ExcludeSuper ? EFieldIteratorFlags::ExcludeSuper : EFieldIteratorFlags::IncludeSuper); PropertyIt; ++PropertyIt)
	{
		UProperty* Property = *PropertyIt;
		if (Property->GetFName() == PropertyName)
		{
			return Property;
		}
	}
	return NULL;
}

FString MonoStringToFString(MonoString* InString)
{
	FString Result;
	if (InString == nullptr)
		return Result;
	int32 StringLength = mono_string_length(InString);
	Result.Empty(StringLength + 1);
#if PLATFORM_TCHAR_IS_4_BYTES
	mono_unichar4* StringResult = mono_string_to_utf32(InString);
	Result = reinterpret_cast<TCHAR *>(StringResult);
	mono_free(StringResult);
#else
	Result.AppendChars((const TCHAR*)mono_string_chars(InString), StringLength);
#endif
	return Result;
}

FName MonoStringToFName(MonoString* InString)
{
	FString TempString = MonoStringToFString(InString);
	return FName(*TempString);
}

MonoString* FStringToMonoString(const FString& InString,MonoDomain* domain=nullptr)
{
	MonoDomain* InDomain = domain==nullptr?FMonoDomain::Get()->GetDomain(): domain;
#if PLATFORM_TCHAR_IS_4_BYTES
	return mono_string_new_utf32(InDomain, reinterpret_cast<const mono_unichar4*>(*InString), InString.Len());
#else
	return mono_string_new_utf16(InDomain, reinterpret_cast<const mono_unichar2*>(*InString), InString.Len());
#endif
}

MonoString* FNameToMonoString(FName InName)
{
	return FStringToMonoString(InName.ToString());
}

template <class T>
TArray<T> MonoArrayToTArray(MonoArray* ReturnArray)
{
	TArray<T> Ret;
	if (nullptr != ReturnArray)
	{
		uintptr_t ArrayLength = mono_array_length(ReturnArray);

		Ret.Empty(ArrayLength);
		Ret.AddZeroed(ArrayLength);

		for (uintptr_t i = 0; i < ArrayLength; ++i)
		{
			Ret[i] = mono_array_get(ReturnArray, T, i);
		}
	}

	return Ret;
}


template <class T>
MonoArray* TArrayToMonoArray(const TArray<T>& TA,FString ClassName)
{
	MonoArray* Ret = (MonoArray*)FMonoDomain::Get()->CreateArray(ClassName, TA.Num());

	if (!Ret)
		return NULL;

	for (int32 i = 0; i < TA.Num(); ++i)
	{
		mono_array_set(Ret, T, i, TA[i]);
	}

	return Ret;
}


template <class T>
TArray<T> FScriptArrayToTArray(FScriptArray& Array)
{
	void* ArrayPtr = &Array;

	TArray<T>* Ret = (TArray<T>*)ArrayPtr;

	return *Ret;
}

template <class T>
FScriptArray TArrayToFScriptArray(TArray<T>& Array)
{
	void* ArrayPtr = &Array;

	FScriptArray* Ret = (FScriptArray*)ArrayPtr;

	return *Ret;
}


template<typename T>
static void CopyStruct(T* Dest, T* Source)
{
	FMemory::Memcpy(Dest, Source, sizeof(T));
}