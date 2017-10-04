using System;
namespace UnrealEngine
{
	public partial class ANavLinkProxy:AActor
	{
		/// <summary>check if any agent is moving through smart link right now</summary>
		public extern bool HasMovingAgents();
		/// <summary>change state of smart link</summary>
		public extern void SetSmartLinkEnabled(bool bEnabled);
		/// <summary>check if smart link is enabled</summary>
		public extern bool IsSmartLinkEnabled();
		/// <summary>resume normal path following</summary>
		public extern void ResumePathFollowing(AActor Agent);
		public UNavLinkCustomComponent SmartLinkComp;
		
		/// <summary>Smart link: toggle relevancy</summary>
		public bool bSmartLinkIsRelevant;
		
		public UNavLinkRenderingComponent EdRenderComp;
		
		public UBillboardComponent SpriteComponent;
		
		
	}
	
}
