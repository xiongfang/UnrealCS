using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Types of server travel failures broadcast by the engine</summary>
	public enum ETravelFailure:byte
	{
		/// <summary>No level found in the loaded package</summary>
		NoLevel=0,
		/// <summary>LoadMap failed on travel (about to Browse to default map)</summary>
		LoadMapFailure=1,
		/// <summary>Invalid URL specified</summary>
		InvalidURL=2,
		/// <summary>A package is missing on the client</summary>
		PackageMissing=3,
		/// <summary>A package version mismatch has occurred between client and server</summary>
		PackageVersion=4,
		/// <summary>A package is missing and the client is unable to download the file</summary>
		NoDownload=5,
		/// <summary>General travel failure</summary>
		TravelFailure=6,
		/// <summary>Cheat commands have been used disabling travel</summary>
		CheatCommands=7,
		/// <summary>Failed to create the pending net game for travel</summary>
		PendingNetGameCreateFailure=8,
		/// <summary>Failed to save before travel</summary>
		CloudSaveFailure=9,
		/// <summary>There was an error during a server travel to a new map</summary>
		ServerTravelFailure=10,
		/// <summary>There was an error during a client travel to a new map</summary>
		ClientTravelFailure=11,
		ETravelFailure_MAX=12,
		
	}
	
}
