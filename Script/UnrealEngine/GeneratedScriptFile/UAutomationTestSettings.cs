using System;
namespace UnrealEngine
{
	public partial class UAutomationTestSettings:UObject
	{
		/// <summary>The automation test map to be used for several of the automation tests.</summary>
		public FStringAssetReference AutomationTestmap;
		
		/// <summary>Editor build promotion test settings</summary>
		public FBuildPromotionTestSettings BuildPromotionTest;
		
		/// <summary>Material editor promotion test settings</summary>
		public FMaterialEditorPromotionSettings MaterialEditorPromotionTest;
		
		/// <summary>Particle editor promotion test settings</summary>
		public FParticleEditorPromotionSettings ParticleEditorPromotionTest;
		
		/// <summary>Blueprint editor promotion test settings</summary>
		public FBlueprintEditorPromotionSettings BlueprintEditorPromotionTest;
		
		/// <summary>The default resolution to take all automation screenshots at.</summary>
		public FIntPoint DefaultScreenshotResolution;
		
		
	}
	
}
