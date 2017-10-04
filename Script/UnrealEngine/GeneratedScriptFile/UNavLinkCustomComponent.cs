using System;
namespace UnrealEngine
{
	public partial class UNavLinkCustomComponent:UNavRelevantComponent
	{
		/// <summary>link Id assigned by navigation system</summary>
		public uint NavLinkUserId;
		
		/// <summary>area class to use when link is enabled</summary>
		public TSubclassOf<UNavArea>  EnabledAreaClass;
		
		/// <summary>area class to use when link is disabled</summary>
		public TSubclassOf<UNavArea>  DisabledAreaClass;
		
		/// <summary>start point, relative to owner</summary>
		public FVector LinkRelativeStart;
		
		/// <summary>end point, relative to owner</summary>
		public FVector LinkRelativeEnd;
		
		/// <summary>direction of link</summary>
		public ENavLinkDirection LinkDirection;
		
		/// <summary>is link currently in enabled state? (area class)</summary>
		public bool bLinkEnabled;
		
		/// <summary>should link notify nearby agents when it changes state to enabled</summary>
		public bool bNotifyWhenEnabled;
		
		/// <summary>should link notify nearby agents when it changes state to disabled</summary>
		public bool bNotifyWhenDisabled;
		
		/// <summary>if set, box obstacle area will be added to generation</summary>
		public bool bCreateBoxObstacle;
		
		/// <summary>offset of simple box obstacle</summary>
		public FVector ObstacleOffset;
		
		/// <summary>extent of simple box obstacle</summary>
		public FVector ObstacleExtent;
		
		/// <summary>area class for simple box obstacle</summary>
		public TSubclassOf<UNavArea>  ObstacleAreaClass;
		
		/// <summary>radius of state change broadcast</summary>
		public float BroadcastRadius;
		
		/// <summary>interval for state change broadcast (0 = single broadcast)</summary>
		public float BroadcastInterval;
		
		/// <summary>trace channel for state change broadcast</summary>
		public ECollisionChannel BroadcastChannel;
		
		
	}
	
}
