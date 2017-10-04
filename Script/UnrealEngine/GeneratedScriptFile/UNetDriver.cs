using System;
namespace UnrealEngine
{
	public partial class UNetDriver:UObject
	{
		/// <summary>Used to specify the class to use for connections</summary>
		public FString NetConnectionClassName;
		
		/// <summary>@todo document</summary>
		public int MaxDownloadSize;
		
		/// <summary>@todo document</summary>
		public bool bClampListenServerTickRate;
		
		/// <summary>@todo document</summary>
		public int NetServerMaxTickRate;
		
		/// <summary>@todo document</summary>
		public int MaxInternetClientRate;
		
		/// <summary>@todo document</summary>
		public int MaxClientRate;
		
		/// <summary>Amount of time a server will wait before traveling to next map, gives clients time to receive final RPCs on existing level @see NextSwitchCountdown</summary>
		public float ServerTravelPause;
		
		/// <summary>@todo document</summary>
		public float SpawnPrioritySeconds;
		
		/// <summary>@todo document</summary>
		public float RelevantTimeout;
		
		/// <summary>@todo document</summary>
		public float KeepAliveTime;
		
		/// <summary>Amount of time to wait for a new net connection to be established before destroying the connection</summary>
		public float InitialConnectTimeout;
		
		/// <summary>
		/// Amount of time to wait before considering an established connection timed out.
		/// Typically shorter than the time to wait on a new connection because this connection
		/// should already have been setup and any interruption should be trapped quicker.
		/// </summary>
		public float ConnectionTimeout;
		
		/// <summary>If true, ignore timeouts completely.  Should be used only in development</summary>
		public bool bNoTimeouts;
		
		/// <summary>Connection to the server (this net driver is a client)</summary>
		public UNetConnection ServerConnection;
		
		/// <summary>World this net driver is associated with</summary>
		public UWorld World;
		
		/// <summary>The loaded UClass of the net connection type to use</summary>
		public UClass NetConnectionClass;
		
		/// <summary>@todo document</summary>
		public UProperty RoleProperty;
		
		/// <summary>@todo document</summary>
		public UProperty RemoteRoleProperty;
		
		/// <summary>Used to specify the net driver to filter actors with (NAME_None || NAME_GameNetDriver is the default net driver)</summary>
		public FName NetDriverName;
		
		/// <summary>Accumulated time for the net driver, updated by Tick</summary>
		public float Time;
		
		
	}
	
}
