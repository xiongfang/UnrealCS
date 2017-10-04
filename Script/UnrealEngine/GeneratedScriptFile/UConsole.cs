using System;
namespace UnrealEngine
{
	public partial class UConsole:UObject
	{
		/// <summary>The player which the next console command should be executed in the context of.  If nullptr, execute in the viewport.</summary>
		public ULocalPlayer ConsoleTargetPlayer;
		
		public UTexture2D DefaultTexture_Black;
		
		public UTexture2D DefaultTexture_White;
		
		
	}
	
}
