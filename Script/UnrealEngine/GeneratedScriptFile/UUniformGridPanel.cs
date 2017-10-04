using System;
namespace UnrealEngine
{
	public partial class UUniformGridPanel:UPanelWidget
	{
		public extern UUniformGridSlot AddChildToUniformGrid(UWidget Content);
		public extern void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight);
		public extern void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth);
		public extern void SetSlotPadding(FMargin InSlotPadding);
		/// <summary>Padding given to each slot</summary>
		public FMargin SlotPadding;
		
		/// <summary>The minimum desired width of the slots</summary>
		public float MinDesiredSlotWidth;
		
		/// <summary>The minimum desired height of the slots</summary>
		public float MinDesiredSlotHeight;
		
		
	}
	
}
