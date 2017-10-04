using System;
namespace UnrealEngine
{
	public partial class UNetworkSettings:UDeveloperSettings
	{
		/// <summary>If true, libcurl authenticates the peer's certificate. Disable to allow self-signed certificates.</summary>
		public bool bVerifyPeer;
		
		/// <summary>If true, origin rebasing is enabled in multiplayer games, meaning that servers and clients can have different local world origins.</summary>
		public bool bEnableMultiplayerWorldOriginRebasing;
		
		/// <summary>Maximum allowable size for replicated dynamic arrays (in number of elements). Must be between 1 and 65535.</summary>
		public int MaxRepArraySize;
		
		/// <summary>Maximum allowable size for replicated dynamic arrays (in bytes).  Must be between 1 and 65535.</summary>
		public int MaxRepArrayMemory;
		
		
	}
	
}
