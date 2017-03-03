#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAutomationTestSettings
	{
		static readonly int AutomationTestmap__Offset;
		public FStringAssetReference AutomationTestmap
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+AutomationTestmap__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AutomationTestmap__Offset, false);}
			
		}
		
		static readonly int EditorPerformanceTestMaps__Offset;
		public TStructArray<FEditorMapPerformanceTestDefinition> EditorPerformanceTestMaps
		{
			get{ CheckIsValid();return new TStructArray<FEditorMapPerformanceTestDefinition>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EditorPerformanceTestMaps__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EditorPerformanceTestMaps__Offset, false);}
			
		}
		
		static readonly int BuildPromotionTest__Offset;
		public FBuildPromotionTestSettings BuildPromotionTest
		{
			get{ CheckIsValid();return (FBuildPromotionTestSettings)Marshal.PtrToStructure(_this.Get()+BuildPromotionTest__Offset, typeof(FBuildPromotionTestSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BuildPromotionTest__Offset, false);}
			
		}
		
		static readonly int MaterialEditorPromotionTest__Offset;
		public FMaterialEditorPromotionSettings MaterialEditorPromotionTest
		{
			get{ CheckIsValid();return (FMaterialEditorPromotionSettings)Marshal.PtrToStructure(_this.Get()+MaterialEditorPromotionTest__Offset, typeof(FMaterialEditorPromotionSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaterialEditorPromotionTest__Offset, false);}
			
		}
		
		static readonly int ParticleEditorPromotionTest__Offset;
		public FParticleEditorPromotionSettings ParticleEditorPromotionTest
		{
			get{ CheckIsValid();return (FParticleEditorPromotionSettings)Marshal.PtrToStructure(_this.Get()+ParticleEditorPromotionTest__Offset, typeof(FParticleEditorPromotionSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParticleEditorPromotionTest__Offset, false);}
			
		}
		
		static readonly int BlueprintEditorPromotionTest__Offset;
		public FBlueprintEditorPromotionSettings BlueprintEditorPromotionTest
		{
			get{ CheckIsValid();return (FBlueprintEditorPromotionSettings)Marshal.PtrToStructure(_this.Get()+BlueprintEditorPromotionTest__Offset, typeof(FBlueprintEditorPromotionSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlueprintEditorPromotionTest__Offset, false);}
			
		}
		
		static readonly int EngineTestModules__Offset;
		public TStructArray<FString> EngineTestModules
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EngineTestModules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EngineTestModules__Offset, false);}
			
		}
		
		static readonly int EditorTestModules__Offset;
		public TStructArray<FString> EditorTestModules
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EditorTestModules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EditorTestModules__Offset, false);}
			
		}
		
		static readonly int TestLevelFolders__Offset;
		public TStructArray<FString> TestLevelFolders
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TestLevelFolders__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TestLevelFolders__Offset, false);}
			
		}
		
		static readonly int TestAssetsToOpen__Offset;
		public TStructArray<FOpenTestAsset> TestAssetsToOpen
		{
			get{ CheckIsValid();return new TStructArray<FOpenTestAsset>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TestAssetsToOpen__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TestAssetsToOpen__Offset, false);}
			
		}
		
		static readonly int ExternalTools__Offset;
		public TStructArray<FExternalToolDefinition> ExternalTools
		{
			get{ CheckIsValid();return new TStructArray<FExternalToolDefinition>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ExternalTools__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ExternalTools__Offset, false);}
			
		}
		
		static readonly int ImportExportTestDefinitions__Offset;
		public TStructArray<FEditorImportExportTestDefinition> ImportExportTestDefinitions
		{
			get{ CheckIsValid();return new TStructArray<FEditorImportExportTestDefinition>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ImportExportTestDefinitions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ImportExportTestDefinitions__Offset, false);}
			
		}
		
		static readonly int LaunchOnSettings__Offset;
		public TStructArray<FLaunchOnTestSettings> LaunchOnSettings
		{
			get{ CheckIsValid();return new TStructArray<FLaunchOnTestSettings>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LaunchOnSettings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LaunchOnSettings__Offset, false);}
			
		}
		
		static readonly int DefaultScreenshotResolution__Offset;
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
