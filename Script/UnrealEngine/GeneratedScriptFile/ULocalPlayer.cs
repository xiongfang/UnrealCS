using System;
namespace UnrealEngine
{
	public partial class ULocalPlayer:UPlayer
	{
		/// <summary>The master viewport containing this player's view.</summary>
		public UGameViewportClient ViewportClient;
		
		/// <summary>How to constrain perspective viewport FOV</summary>
		public EAspectRatioAxisConstraint AspectRatioAxisConstraint;
		
		/// <summary>The class of PlayerController to spawn for players logging in.</summary>
		public TSubclassOf<APlayerController>  PendingLevelPlayerControllerClass;
		
		/// <summary>set when we've sent a split join request</summary>
		public bool bSentSplitJoin;
		
		
	}
	
}
