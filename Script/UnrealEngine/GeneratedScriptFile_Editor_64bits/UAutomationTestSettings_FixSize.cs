#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Implements the Editor's user settings.</summary>
	public partial class UAutomationTestSettings
	{
		static readonly int AutomationTestmap__Offset;
		/// <summary>The automation test map to be used for several of the automation tests.</summary>
		public FStringAssetReference AutomationTestmap
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+AutomationTestmap__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AutomationTestmap__Offset, false);}
			
		}
		
		static readonly int EditorPerformanceTestMaps__Offset;
		/// <summary>The map to be used for the editor performance capture tool.</summary>
		public TStructArray<FEditorMapPerformanceTestDefinition> EditorPerformanceTestMaps
		{
			get{ CheckIsValid();return new TStructArray<FEditorMapPerformanceTestDefinition>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EditorPerformanceTestMaps__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EditorPerformanceTestMaps__Offset, false);}
			
		}
		
		static readonly int BuildPromotionTest__Offset;
		/// <summary>Editor build promotion test settings</summary>
		public FBuildPromotionTestSettings BuildPromotionTest
		{
			get{ CheckIsValid();return (FBuildPromotionTestSettings)Marshal.PtrToStructure(_this.Get()+BuildPromotionTest__Offset, typeof(FBuildPromotionTestSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BuildPromotionTest__Offset, false);}
			
		}
		
		static readonly int MaterialEditorPromotionTest__Offset;
		/// <summary>Material editor promotion test settings</summary>
		public FMaterialEditorPromotionSettings MaterialEditorPromotionTest
		{
			get{ CheckIsValid();return (FMaterialEditorPromotionSettings)Marshal.PtrToStructure(_this.Get()+MaterialEditorPromotionTest__Offset, typeof(FMaterialEditorPromotionSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaterialEditorPromotionTest__Offset, false);}
			
		}
		
		static readonly int ParticleEditorPromotionTest__Offset;
		/// <summary>Particle editor promotion test settings</summary>
		public FParticleEditorPromotionSettings ParticleEditorPromotionTest
		{
			get{ CheckIsValid();return (FParticleEditorPromotionSettings)Marshal.PtrToStructure(_this.Get()+ParticleEditorPromotionTest__Offset, typeof(FParticleEditorPromotionSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParticleEditorPromotionTest__Offset, false);}
			
		}
		
		static readonly int BlueprintEditorPromotionTest__Offset;
		/// <summary>Blueprint editor promotion test settings</summary>
		public FBlueprintEditorPromotionSettings BlueprintEditorPromotionTest
		{
			get{ CheckIsValid();return (FBlueprintEditorPromotionSettings)Marshal.PtrToStructure(_this.Get()+BlueprintEditorPromotionTest__Offset, typeof(FBlueprintEditorPromotionSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlueprintEditorPromotionTest__Offset, false);}
			
		}
		
		static readonly int EngineTestModules__Offset;
		/// <summary>Modules to load that have engine tests</summary>
		public TStructArray<FString> EngineTestModules
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EngineTestModules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EngineTestModules__Offset, false);}
			
		}
		
		static readonly int EditorTestModules__Offset;
		/// <summary>Modules to load that have editor tests</summary>
		public TStructArray<FString> EditorTestModules
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EditorTestModules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EditorTestModules__Offset, false);}
			
		}
		
		static readonly int TestLevelFolders__Offset;
		/// <summary>Folders containing levels to exclude from automated tests</summary>
		public TStructArray<FString> TestLevelFolders
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TestLevelFolders__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TestLevelFolders__Offset, false);}
			
		}
		
		static readonly int TestAssetsToOpen__Offset;
		/// <summary>Asset to test for open in automation process</summary>
		public TStructArray<FOpenTestAsset> TestAssetsToOpen
		{
			get{ CheckIsValid();return new TStructArray<FOpenTestAsset>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TestAssetsToOpen__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TestAssetsToOpen__Offset, false);}
			
		}
		
		static readonly int ExternalTools__Offset;
		/// <summary>External executables and scripts to run as part of automation.</summary>
		public TStructArray<FExternalToolDefinition> ExternalTools
		{
			get{ CheckIsValid();return new TStructArray<FExternalToolDefinition>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ExternalTools__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ExternalTools__Offset, false);}
			
		}
		
		static readonly int ImportExportTestDefinitions__Offset;
		/// <summary>Asset import / Export test settings</summary>
		public TStructArray<FEditorImportExportTestDefinition> ImportExportTestDefinitions
		{
			get{ CheckIsValid();return new TStructArray<FEditorImportExportTestDefinition>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ImportExportTestDefinitions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ImportExportTestDefinitions__Offset, false);}
			
		}
		
		static readonly int LaunchOnSettings__Offset;
		/// <summary>The map and device type to be used for the editor Launch On With Map Iterations test.</summary>
		public TStructArray<FLaunchOnTestSettings> LaunchOnSettings
		{
			get{ CheckIsValid();return new TStructArray<FLaunchOnTestSettings>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LaunchOnSettings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LaunchOnSettings__Offset, false);}
			
		}
		
		static readonly int DefaultScreenshotResolution__Offset;
		/// <summary>The default resolution to take all automation screenshots at.</summary>
		public FIntPoint DefaultScreenshotResolution
		{
			get{ CheckIsValid();return (FIntPoint)Marshal.PtrToStructure(_this.Get()+DefaultScreenshotResolution__Offset, typeof(FIntPoint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultScreenshotResolution__Offset, false);}
			
		}
		
		static UAutomationTestSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AutomationTestSettings");
			AutomationTestmap__Offset=GetPropertyOffset(NativeClassPtr,"AutomationTestmap");
			EditorPerformanceTestMaps__Offset=GetPropertyOffset(NativeClassPtr,"EditorPerformanceTestMaps");
			BuildPromotionTest__Offset=GetPropertyOffset(NativeClassPtr,"BuildPromotionTest");
			MaterialEditorPromotionTest__Offset=GetPropertyOffset(NativeClassPtr,"MaterialEditorPromotionTest");
			ParticleEditorPromotionTest__Offset=GetPropertyOffset(NativeClassPtr,"ParticleEditorPromotionTest");
			BlueprintEditorPromotionTest__Offset=GetPropertyOffset(NativeClassPtr,"BlueprintEditorPromotionTest");
			EngineTestModules__Offset=GetPropertyOffset(NativeClassPtr,"EngineTestModules");
			EditorTestModules__Offset=GetPropertyOffset(NativeClassPtr,"EditorTestModules");
			TestLevelFolders__Offset=GetPropertyOffset(NativeClassPtr,"TestLevelFolders");
			TestAssetsToOpen__Offset=GetPropertyOffset(NativeClassPtr,"TestAssetsToOpen");
			ExternalTools__Offset=GetPropertyOffset(NativeClassPtr,"ExternalTools");
			ImportExportTestDefinitions__Offset=GetPropertyOffset(NativeClassPtr,"ImportExportTestDefinitions");
			LaunchOnSettings__Offset=GetPropertyOffset(NativeClassPtr,"LaunchOnSettings");
			DefaultScreenshotResolution__Offset=GetPropertyOffset(NativeClassPtr,"DefaultScreenshotResolution");
			
		}
		
	}
	
}
#endif
#endif
