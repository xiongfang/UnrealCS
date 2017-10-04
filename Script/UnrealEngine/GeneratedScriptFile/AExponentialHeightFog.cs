using System;
namespace UnrealEngine
{
	public partial class AExponentialHeightFog:AInfo
	{
		/// <summary>Replication Notification Callbacks</summary>
		public extern virtual void OnRep_bEnabled();
		public UExponentialHeightFogComponent Component;
		
		/// <summary>replicated copy of ExponentialHeightFogComponent's bEnabled property</summary>
		public bool bEnabled;
		
		
	}
	
}
