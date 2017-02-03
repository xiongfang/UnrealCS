// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#include "ScriptGeneratorPluginPrivatePCH.h"
#include "ScriptCodeGeneratorBase.h"
#include "IProjectManager.h"
#include "Runtime/Core/Public/Features/IModularFeatures.h"
#include "MonoScriptCodeGenerator.h"

DEFINE_LOG_CATEGORY(LogScriptGenerator);

class FScriptGeneratorPlugin : public IScriptGeneratorPlugin
{
	/** Specialized script code generator */
	TAutoPtr<FScriptCodeGeneratorBase> CodeGenerator;

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;

	/** IScriptGeneratorPlugin interface */
    /** IScriptGeneratorPlugin interface */
    virtual FString GetGeneratedCodeModuleName() const override
    {
        return TEXT("MonoPlugin");
    }
	virtual bool ShouldExportClassesForModule(const FString& ModuleName, EBuildModuleType::Type ModuleType, const FString& ModuleGeneratedIncludeDirectory) const override;
	virtual bool SupportsTarget(const FString& TargetName) const override;
	virtual void Initialize(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& IncludeBase) override;
	virtual void ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged) override;
	virtual void FinishExport() override;
	virtual FString GetGeneratorName() const override;

	TArray<FString> ScriptSupportedModules;
};

IMPLEMENT_MODULE( FScriptGeneratorPlugin, ScriptGeneratorPlugin )


void FScriptGeneratorPlugin::StartupModule()
{
	// Register ourselves as an editor feature
	IModularFeatures::Get().RegisterModularFeature(TEXT("ScriptGenerator"), this);
	ScriptSupportedModules.Add("CoreUObject");
	ScriptSupportedModules.Add("Engine");
	ScriptSupportedModules.Add("MovieScene");
	ScriptSupportedModules.Add("SlateCore");
	ScriptSupportedModules.Add("PacketHandler");
	ScriptSupportedModules.Add("MovieSceneTracks");
	ScriptSupportedModules.Add("UMG");
}

void FScriptGeneratorPlugin::ShutdownModule()
{
	CodeGenerator.Reset();
	ScriptSupportedModules.Empty();
	// Unregister our feature
	IModularFeatures::Get().UnregisterModularFeature(TEXT("ScriptGenerator"), this);
}

FString FScriptGeneratorPlugin::GetGeneratorName() const
{
    return TEXT("Mono Example Code Generator Plugin");
}

void FScriptGeneratorPlugin::Initialize(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& IncludeBase)
{

    UE_LOG(LogScriptGenerator, Log, TEXT("Using Mono Script Generator."));
    CodeGenerator = new FMonoScriptCodeGenerator(RootLocalPath, RootBuildPath, OutputDirectory, IncludeBase);
	UE_LOG(LogScriptGenerator, Log, TEXT("Output directory: %s"), *OutputDirectory);
}

bool FScriptGeneratorPlugin::ShouldExportClassesForModule(const FString& ModuleName, EBuildModuleType::Type ModuleType, const FString& ModuleGeneratedIncludeDirectory) const
{
	bool bCanExport = (ModuleType == EBuildModuleType::EngineRuntime || ModuleType == EBuildModuleType::GameRuntime);
	return bCanExport && ScriptSupportedModules.Contains(ModuleName);
}

void FScriptGeneratorPlugin::ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged)
{
	CodeGenerator->ExportClass(Class, SourceHeaderFilename, GeneratedHeaderFilename, bHasChanged);
}

void FScriptGeneratorPlugin::FinishExport()
{
	CodeGenerator->FinishExport();
}

bool FScriptGeneratorPlugin::SupportsTarget(const FString& TargetName) const
{
    return true;
}