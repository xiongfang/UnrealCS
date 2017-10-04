using System;
namespace UnrealEngine
{
	/// <summary>A single object bound to a UMG sequence.</summary>
	public partial struct FWidgetAnimationBinding
	{
		public FName WidgetName;
		public FName SlotWidgetName;
		public FGuid AnimationGuid;
		public bool bIsRootWidget;
		
	}
	
}
