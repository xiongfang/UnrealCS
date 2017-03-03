// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

//包含文件列表
class MONOHELPER_API FInclusionLists
{
public:
	void AddEnum(FName EnumName)
	{
		Enumerations.Add(EnumName);
	}

	bool HasEnum(const UEnum* Enum) const
	{
		return Enumerations.Contains(Enum->GetFName());
	}

	void AddClass(FName ClassName)
	{
		Classes.Add(ClassName);
	}

	bool HasClass(const UClass* Class) const
	{
		return Classes.Contains(Class->GetFName());
	}

	void AddStruct(FName StructName)
	{
		Structs.Add(StructName);
	}

	bool HasStruct(const UStruct* Struct) const
	{
		return Structs.Contains(Struct->GetFName());
	}

	void AddAllFunctions(FName StructName)
	{
		AllFunctions.Add(StructName);
	}

	void AddFunction(FName StructName, FName FunctionName)
	{
		Functions.FindOrAdd(StructName).Add(FunctionName);
	}

	void AddFunctionCategory(FName StructName, const FString& Category)
	{
		FunctionCategories.FindOrAdd(StructName).Add(Category);
	}

	bool HasFunction(const UStruct* Struct, const UFunction* Function) const;

	void AddOverridableFunction(FName StructName, FName OverridableFunctionName)
	{
		OverridableFunctions.FindOrAdd(StructName).Add(OverridableFunctionName);
	}

	bool HasOverridableFunction(const UStruct* Struct, const UFunction* OverridableFunction) const
	{
		const TSet<FName>* List = OverridableFunctions.Find(Struct->GetFName());
		return List && List->Contains(OverridableFunction->GetFName());
	}

	void AddProperty(FName StructName, FName PropertyName)
	{
		Properties.FindOrAdd(StructName).Add(PropertyName);
	}

	bool HasProperty(const UStruct* Struct, const UProperty* Property) const;

private:
	TSet<FName> Enumerations;
	TSet<FName> Classes;
	TSet<FName> Structs;
	TSet<FName> AllFunctions;
	TMap<FName, TSet<FString>> FunctionCategories;
	TMap<FName, TSet<FName>> Functions;
	TMap<FName, TSet<FName>> OverridableFunctions;
	TMap<FName, TSet<FName>> Properties;
};
