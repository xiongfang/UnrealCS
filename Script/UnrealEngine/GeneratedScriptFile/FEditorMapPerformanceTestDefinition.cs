using System;
namespace UnrealEngine
{
	/// <summary>Holds settings for the asset import / export automation test</summary>
	public partial struct FEditorMapPerformanceTestDefinition
	{
		/// <summary>Map to be used for the Performance Capture *</summary>
		public FStringAssetReference PerformanceTestmap;
		/// <summary>This is the length of time in seconds that this test will run for before stopping.</summary>
		public int TestTimer;
		
	}
	
}
