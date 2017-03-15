// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoBlueprintCompiler.h"
#include "MonoEditorPluginPrivatePCH.h"
#include "MonoBlueprint.h"
#include "MonoScriptClass.h"
#include "MonoScriptBind_Component.h"

#include "Kismet2NameValidators.h"
#include "KismetReinstanceUtilities.h"

///-------------------------------------------------------------

FMonoBlueprintCompiler::FMonoBlueprintCompiler(UMonoBlueprint* SourceSketch, FCompilerResultsLog& InMessageLog, const FKismetCompilerOptions& InCompilerOptions, TArray<UObject*>* InObjLoaded)
	: Super(SourceSketch, InMessageLog, InCompilerOptions, InObjLoaded)
	, NewScriptBlueprintClass(NULL)
	, ContextProperty(NULL)
{
}

FMonoBlueprintCompiler::~FMonoBlueprintCompiler()
{
}

void FMonoBlueprintCompiler::CleanAndSanitizeClass(UBlueprintGeneratedClass* ClassToClean, UObject*& OldCDO)
{
	Super::CleanAndSanitizeClass(ClassToClean, OldCDO);

	// Make sure our typed pointer is set
	check(ClassToClean == NewClass);	
	NewScriptBlueprintClass = CastChecked<UMonoScriptClass>((UObject*)NewClass);
	ContextProperty = NULL;
}


void GetFieldBlueprintArgs(FScriptField& Field, FString& PinCategory, bool& IsArray, UObject*& InnerType)
{
	IsArray = false;
	PinCategory.Empty();
	InnerType = Field.InnerType;
	if (Field.Class->IsChildOf(UStrProperty::StaticClass()))
	{
		PinCategory = UEdGraphSchema_K2::PC_String;
	}
	else if (Field.Class->IsChildOf(UFloatProperty::StaticClass()))
	{
		PinCategory = UEdGraphSchema_K2::PC_Float;
	}
	else if (Field.Class->IsChildOf(UIntProperty::StaticClass()))
	{
		PinCategory = UEdGraphSchema_K2::PC_Int;
	}
	else if (Field.Class->IsChildOf(UBoolProperty::StaticClass()))
	{
		PinCategory = UEdGraphSchema_K2::PC_Boolean;
	}
	//类放在对象属性之前判定，因为 UClassProperty << UObjectProperty
	else if (Field.Class->IsChildOf(UClassProperty::StaticClass()))
	{
		PinCategory = UEdGraphSchema_K2::PC_Class;
	}
	else if (Field.Class->IsChildOf(UObjectProperty::StaticClass()))
	{
		PinCategory = UEdGraphSchema_K2::PC_Object;
	}
	else if (Field.Class->IsChildOf(UArrayProperty::StaticClass()))
	{
		IsArray = true;
		PinCategory = UEdGraphSchema_K2::PC_Object;
	}
	else if (Field.Class->IsChildOf(UStructProperty::StaticClass()))
	{
		PinCategory = UEdGraphSchema_K2::PC_Struct;
	}
}

void FMonoBlueprintCompiler::CreateClassVariablesFromBlueprint()
{
	Super::CreateClassVariablesFromBlueprint();

	UMonoBlueprint* MyBlueprint = ScriptBlueprint();
	UMonoScriptClass* NewScripClass = CastChecked<UMonoScriptClass>(NewClass);
	NewScripClass->ScriptProperties.Empty();

	for (auto& Field : ScriptDefinedFields)
	{
		if (Field.Class->IsChildOf(UProperty::StaticClass()))
		{
			FString PinCategory;
			bool IsArray;
			UObject* InnerType;

			GetFieldBlueprintArgs(Field, PinCategory, IsArray, InnerType);
			if (!PinCategory.IsEmpty())
			{
				FEdGraphPinType ScriptPinType(PinCategory, TEXT(""), InnerType, IsArray, false,false,false, FEdGraphTerminalType());
				UProperty* ScriptProperty = CreateVariable(Field.Name, ScriptPinType);
				if (ScriptProperty != NULL)
				{
					ScriptProperty->SetMetaData(TEXT("Category"), *MyBlueprint->GetName());
					ScriptProperty->SetPropertyFlags(CPF_BlueprintVisible | CPF_Edit);
					NewScripClass->ScriptProperties.Add(ScriptProperty);
				}
			}
		}
	}

	//CreateScriptContextProperty();
}

void FMonoBlueprintCompiler::CreateScriptContextProperty()
{
	//// The only case we don't need a script context is if the script class derives form UScriptPluginComponent
	//UClass* ContextClass = NULL;
	////if (Blueprint->ParentClass->IsChildOf(AActor::StaticClass()))
	//{
	//	ContextClass = UMonoScriptBind_Component::StaticClass();
	//}
	////else if (!Blueprint->ParentClass->IsChildOf(UScriptPluginComponent::StaticClass()))
	////{
	////	ContextClass = UScriptContext::StaticClass();
	////}

	//if (ContextClass)
	//{
	//	FEdGraphPinType ScriptContextPinType(Schema->PC_Object, TEXT(""), ContextClass, false, false);
	//	ContextProperty = CastChecked<UObjectProperty>(CreateVariable(TEXT("Generated_ScriptContext"), ScriptContextPinType));
	//	ContextProperty->SetPropertyFlags(CPF_ContainsInstancedReference | CPF_InstancedReference);
	//}
}




void FMonoBlueprintCompiler::CreateFunctionList()
{
	//创建函数
	UMonoScriptClass* NewScriptClass = CastChecked<UMonoScriptClass>(NewClass);
	NewScriptClass->Init(ScriptContext);

	Super::CreateFunctionList();

	//if (!Blueprint->ParentClass->IsChildOf(UMonoScriptClass::StaticClass()))
	//{
	//	for (auto& Field : ScriptDefinedFields)
	//	{
	//		if (Field.Class->IsChildOf(UFunction::StaticClass()))
	//		{
	//			CreateScriptDefinedFunction(Field);
	//		}
	//	}
	//}
}

void FMonoBlueprintCompiler::CreateScriptDefinedFunction(FScriptField& Field)
{
	////check(ContextProperty);
	//
	//UMonoBlueprint* Blueprint = ScriptBlueprint();
	//const FString FunctionName = Field.Name.ToString();
	//// Create Blueprint Graph which consists of 3 nodes: 'Entry', 'Get Script Context' and 'Call Function'
	//// @todo: once we figure out how to get parameter lists for functions we can add suport for that here

	//UEdGraph* ScriptFunctionGraph = NewObject<UEdGraph>(Blueprint, *FString::Printf(TEXT("%s_Graph"), *FunctionName));
	//ScriptFunctionGraph->Schema = UEdGraphSchema_K2::StaticClass();
	//ScriptFunctionGraph->SetFlags(RF_Transient);
	//
	//FKismetFunctionContext* FunctionContext = CreateFunctionContext();
	//FunctionContext->SourceGraph = ScriptFunctionGraph;
	//FunctionContext->bCreateDebugData = false;

	//UK2Node_FunctionEntry* EntryNode = SpawnIntermediateNode<UK2Node_FunctionEntry>(NULL, ScriptFunctionGraph);
	//EntryNode->CustomGeneratedFunctionName = Field.Name;
	//EntryNode->AllocateDefaultPins();

	////UK2Node_VariableGet* GetVariableNode = SpawnIntermediateNode<UK2Node_VariableGet>(NULL, ScriptFunctionGraph);
	////GetVariableNode->VariableReference.SetSelfMember(ContextProperty->GetFName());
	////GetVariableNode->AllocateDefaultPins();

	//
	//UK2Node_CallFunction* CallFunctionNode = SpawnIntermediateNode<UK2Node_CallFunction>(NULL, ScriptFunctionGraph);
	//CallFunctionNode->FunctionReference.SetExternalMember(*(FunctionName+"_1")/*TEXT("CallScriptFunction")*/, NewClass/*UMonoScriptBind_Component::StaticClass()*/);
	//CallFunctionNode->AllocateDefaultPins();
	////UEdGraphPin* FunctionNamePin = CallFunctionNode->FindPinChecked(TEXT("FunctionName"));
	////FunctionNamePin->DefaultValue = FunctionName;

	//// Link nodes together
	//UEdGraphPin* ExecPin = Schema->FindExecutionPin(*EntryNode, EGPD_Output);
	////UEdGraphPin* GetVariableOutPin = GetVariableNode->FindPinChecked(ContextProperty->GetName());
	//UEdGraphPin* CallFunctionPin = Schema->FindExecutionPin(*CallFunctionNode, EGPD_Input);
	////UEdGraphPin* FunctionTargetPin = CallFunctionNode->FindPinChecked(TEXT("self"));
	//ExecPin->MakeLinkTo(CallFunctionPin);
	////GetVariableOutPin->MakeLinkTo(FunctionTargetPin);
}

void FMonoBlueprintCompiler::FinishCompilingClass(UClass* Class)
{
	UMonoBlueprint* MyBlueprint = ScriptBlueprint();

	UMonoScriptClass* ScriptClass = CastChecked<UMonoScriptClass>(Class);
	ScriptClass->ClassName = MyBlueprint->ClassName;

	// Allow Blueprint Components to be used in Blueprints
	if (MyBlueprint->ParentClass->IsChildOf(UActorComponent::StaticClass()) && Class != MyBlueprint->SkeletonGeneratedClass)
	{
		Class->SetMetaData(TEXT("BlueprintSpawnableComponent"), TEXT("true"));
	}

	Super::FinishCompilingClass(Class);

	// Ff context property has been created, create a DSO and set it on the CDO
	if (ContextProperty)
	{
		UObject* CDO = Class->GetDefaultObject();
		UObject* ContextDefaultSubobject = NewObject<UObject>(CDO, ContextProperty->PropertyClass, "ScriptContext", RF_DefaultSubObject | RF_Public);
		ContextProperty->SetObjectPropertyValue(ContextProperty->ContainerPtrToValuePtr<UObject*>(CDO), ContextDefaultSubobject);
	}
}

void FMonoBlueprintCompiler::Compile()
{
	ScriptBlueprint()->UpdateSourceCodeIfChanged();
	ScriptContext = FScriptContextBase::CreateContext(ScriptBlueprint()->ClassName, NULL, NULL);
	bool Result = true;
	if (ScriptContext.IsValid())
	{
		ScriptDefinedFields.Empty();
		ScriptContext->GetScriptDefinedFields(ScriptDefinedFields);
	}
	else
	{
		return;
	}
	ContextProperty = NULL;

	Super::Compile();
}

void FMonoBlueprintCompiler::EnsureProperGeneratedClass(UClass*& TargetUClass)
{
	if ( TargetUClass && !( (UObject*)TargetUClass )->IsA(UMonoScriptClass::StaticClass()) )
	{
		FKismetCompilerUtilities::ConsignToOblivion(TargetUClass, Blueprint->bIsRegeneratingOnLoad);
		TargetUClass = NULL;
	}
}

void FMonoBlueprintCompiler::SpawnNewClass(const FString& NewClassName)
{
	NewScriptBlueprintClass = FindObject<UMonoScriptClass>(Blueprint->GetOutermost(), *NewClassName);

	if ( NewScriptBlueprintClass == NULL )
	{
		NewScriptBlueprintClass = NewObject<UMonoScriptClass>(Blueprint->GetOutermost(), FName(*NewClassName), RF_Public | RF_Transactional);
	}
	else
	{
		// Already existed, but wasn't linked in the Blueprint yet due to load ordering issues
		FBlueprintCompileReinstancer::Create(NewScriptBlueprintClass);
	}
	NewClass = NewScriptBlueprintClass;
}

bool FMonoBlueprintCompiler::ValidateGeneratedClass(UBlueprintGeneratedClass* Class)
{
	bool SuperResult = Super::ValidateGeneratedClass(Class);
	bool Result = UMonoBlueprint::ValidateGeneratedClass(Class);
	return SuperResult && Result;
}
