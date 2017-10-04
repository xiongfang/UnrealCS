using System;
namespace UnrealEngine
{
	public partial class UCanvasPanelSlot:UPanelSlot
	{
		/// <summary>Sets the anchors on the slot</summary>
		public extern void SetMaximum(FVector2D InMaximumAnchors);
		/// <summary>Sets the anchors on the slot</summary>
		public extern void SetMinimum(FVector2D InMinimumAnchors);
		/// <summary>Gets the z-order on the slot</summary>
		public extern int GetZOrder();
		/// <summary>Sets the z-order on the slot</summary>
		public extern void SetZOrder(int InZOrder);
		/// <summary>Gets if the slot to be auto-sized</summary>
		public extern bool GetAutoSize();
		/// <summary>Sets if the slot to be auto-sized</summary>
		public extern void SetAutoSize(bool InbAutoSize);
		/// <summary>Gets the alignment on the slot</summary>
		public extern FVector2D GetAlignment();
		/// <summary>Sets the alignment on the slot</summary>
		public extern void SetAlignment(FVector2D InAlignment);
		/// <summary>Gets the anchors on the slot</summary>
		public extern FAnchors GetAnchors();
		/// <summary>Sets the anchors on the slot</summary>
		public extern void SetAnchors(FAnchors InAnchors);
		/// <summary>Gets the offset data of the slot, which could be position and size, or margins depending on the anchor points</summary>
		public extern FMargin GetOffsets();
		/// <summary>Sets the offset data of the slot, which could be position and size, or margins depending on the anchor points</summary>
		public extern void SetOffsets(FMargin InOffset);
		/// <summary>Gets the size of the slot</summary>
		public extern FVector2D GetSize();
		/// <summary>Sets the size of the slot</summary>
		public extern void SetSize(FVector2D InSize);
		/// <summary>Gets the position of the slot</summary>
		public extern FVector2D GetPosition();
		/// <summary>Sets the position of the slot</summary>
		public extern void SetPosition(FVector2D InPosition);
		/// <summary>Gets the layout data of the slot</summary>
		public extern FAnchorData GetLayout();
		/// <summary>Sets the layout data of the slot</summary>
		public extern void SetLayout(FAnchorData InLayoutData);
		/// <summary>The anchoring information for the slot</summary>
		public FAnchorData LayoutData;
		
		/// <summary>When AutoSize is true we use the widget's desired size</summary>
		public bool bAutoSize;
		
		/// <summary>The order priority this widget is rendered in.  Higher values are rendered last (and so they will appear to be on top).</summary>
		public int ZOrder;
		
		
	}
	
}
