using System;
namespace UnrealEngine
{
	public partial class UGameViewportClient:UScriptViewportClient
	{
		/// <summary>Sets the player which console commands will be executed in the context of.</summary>
		public extern virtual void SetConsoleTarget(int PlayerIndex);
		/// <summary>Exec for toggling the display of the title safe area</summary>
		public extern virtual void ShowTitleSafeArea();
		/// <summary>Rotates controller ids among gameplayers, useful for testing splitscreen with only one controller.</summary>
		public extern virtual void SSSwapControllers();
		/// <summary>The viewport's console.   Might be null on consoles</summary>
		public UConsole ViewportConsole;
		
		/// <summary>The relative world context for this viewport</summary>
		public UWorld World;
		
		public UGameInstance GameInstance;
		
		
	}
	
}
