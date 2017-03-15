// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#pragma once
#include "KismetCompiler.h"

class UMonoBlueprint;
class UMonoScriptClass;

/**
* Script Blueprint Compiler
*/
class FMonoBlueprintCompiler : public FKismetCompilerContext
{
protected:

	typedef FKismetCompilerContext Super;

public:
	FMonoBlueprintCompiler(UMonoBlueprint* SourceSketch, FCompilerResultsLog& InMessageLog, const FKismetCompilerOptions& InCompilerOptions, TArray<UObject*>* InObjLoaded);
	virtual ~FMonoBlueprintCompiler();

	// FKismetCompilerContext
	virtual void Compile() override;
	// End FKismetCompilerContext

protected:
	UMonoBlueprint* ScriptBlueprint() const { return Cast<UMonoBlueprint>(Blueprint); }

	// FKismetCompilerContext
	virtual void SpawnNewClass(const FString& NewClassName) override;
	virtual void CleanAndSanitizeClass(UBlueprintGeneratedClass* ClassToClean, UObject*& OldCDO) override;
	virtual void EnsureProperGeneratedClass(UClass*& TargetClass) override;
	virtual void CreateClassVariablesFromBlueprint() override;
	virtual void CreateFunctionList() override;
	virtual void FinishCompilingClass(UClass* Class) override;
	virtual bool ValidateGeneratedClass(UBlueprintGeneratedClass* Class) override;
	// End FKismetCompilerContext

protected:

	/**
	* Creates a script context property for this class (if needed)
	*/
	void CreateScriptContextProperty();

	/**
	* Creates a Blueprint Graph function definition for script defined function
	*
	* @param Field Function exported by script
	*/
	void CreateScriptDefinedFunction(FScriptField& Field);

	/** New script class */
	UMonoScriptClass* NewScriptBlueprintClass;
	/** Script context */
	TUniquePtr<FScriptContextBase> ScriptContext;
	/** Script-defined properties and functions */
	TArray<FScriptField> ScriptDefinedFields;
	/** Script context property generated for the compiled class */
	UObjectProperty* ContextProperty;
};

