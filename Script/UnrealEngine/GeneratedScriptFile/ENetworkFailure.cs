using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Types of network failures broadcast from the engine</summary>
	public enum ENetworkFailure:byte
	{
		/// <summary>A relevant net driver has already been created for this service</summary>
		NetDriverAlreadyExists=0,
		/// <summary>The net driver creation failed</summary>
		NetDriverCreateFailure=1,
		/// <summary>The net driver failed its Listen() call</summary>
		NetDriverListenFailure=2,
		/// <summary>A connection to the net driver has been lost</summary>
		ConnectionLost=3,
		/// <summary>A connection to the net driver has timed out</summary>
		ConnectionTimeout=4,
		/// <summary>The net driver received an NMT_Failure message</summary>
		FailureReceived=5,
		/// <summary>The client needs to upgrade their game</summary>
		OutdatedClient=6,
		/// <summary>The server needs to upgrade their game</summary>
		OutdatedServer=7,
		/// <summary>There was an error during connection to the game</summary>
		PendingConnectionFailure=8,
		/// <summary>NetGuid mismatch</summary>
		NetGuidMismatch=9,
		/// <summary>Network checksum mismatch</summary>
		NetChecksumMismatch=10,
		ENetworkFailure_MAX=11,
		
	}
	
}
