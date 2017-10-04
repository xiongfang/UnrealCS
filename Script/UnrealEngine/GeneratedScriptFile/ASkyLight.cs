using System;
namespace UnrealEngine
{
	public partial class ASkyLight:AInfo
	{
		/// <summary>Replication Notification Callbacks</summary>
		public extern virtual void OnRep_bEnabled();
		public USkyLightComponent LightComponent;
		
		/// <summary>replicated copy of LightComponent's bEnabled property</summary>
		public bool bEnabled;
		
		
	}
	
}
