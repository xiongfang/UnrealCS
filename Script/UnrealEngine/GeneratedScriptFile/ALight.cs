using System;
namespace UnrealEngine
{
	public partial class ALight:AActor
	{
		/// <summary>Replication Notification Callbacks</summary>
		public extern virtual void OnRep_bEnabled();
		public ULightComponent LightComponent;
		
		/// <summary>replicated copy of LightComponent's bEnabled property</summary>
		public bool bEnabled;
		
		
	}
	
}
