using System;
namespace UnrealEngine
{
	public partial class AGameSession:AInfo
	{
		/// <summary>Maximum number of spectators allowed by this server.</summary>
		public int MaxSpectators;
		
		/// <summary>Maximum number of players allowed by this server.</summary>
		public int MaxPlayers;
		
		/// <summary>Restrictions on the largest party that can join together</summary>
		public int MaxPartySize;
		
		/// <summary>Maximum number of splitscreen players to allow from one connection</summary>
		public byte MaxSplitscreensPerConnection;
		
		/// <summary>Is voice enabled always or via a push to talk keybinding</summary>
		public bool bRequiresPushToTalk;
		
		/// <summary>SessionName local copy from PlayerState class.  should really be define in this class, but need to address replication issues</summary>
		public FName SessionName;
		
		
	}
	
}
