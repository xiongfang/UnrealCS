using System;
namespace UnrealEngine
{
	public partial class UGameInstance:UObject
	{
		/// <summary>
		/// Debug console command to remove the player with a given controller ID.
		/// @param ControllerId - The controller ID to search for.
		/// </summary>
		public extern virtual void DebugRemovePlayer(int ControllerId);
		/// <summary>
		/// Debug console command to create a player.
		/// @param ControllerId - The controller ID the player should accept input from.
		/// </summary>
		public extern virtual void DebugCreatePlayer(int ControllerId);
		/// <summary>Class to manage online services</summary>
		public UOnlineSession OnlineSession;
		
		
	}
	
}
