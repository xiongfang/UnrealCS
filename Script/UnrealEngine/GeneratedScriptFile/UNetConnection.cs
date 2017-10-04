using System;
namespace UnrealEngine
{
	public partial class UNetConnection:UPlayer
	{
		/// <summary>Owning net driver</summary>
		public UNetDriver Driver;
		
		/// <summary>Package map between local and remote. (negotiates net serialization)</summary>
		public UPackageMap PackageMap;
		
		/// <summary>The actor that is currently being viewed/controlled by the owning controller</summary>
		public AActor ViewTarget;
		
		/// <summary>Reference to controlling actor (usually PlayerController)</summary>
		public AActor OwningActor;
		
		public int MaxPacket;
		
		/// <summary>Maximum packet size.</summary>
		public bool InternalAck;
		
		/// <summary>Net id of remote player on this connection. Only valid on client connections (server side).</summary>
		public FUniqueNetIdRepl PlayerId;
		
		/// <summary>Internal.</summary>
		public double LastReceiveTime;
		
		
	}
	
}
