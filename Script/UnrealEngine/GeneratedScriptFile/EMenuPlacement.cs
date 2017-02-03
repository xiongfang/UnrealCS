using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates possible placements for pop-up menus.</summary>
	public enum EMenuPlacement:byte
	{
		/// <summary>Place the menu immediately below the anchor</summary>
		MenuPlacement_BelowAnchor=0,
		/// <summary>Place the menu immediately centered below the anchor</summary>
		MenuPlacement_CenteredBelowAnchor=1,
		/// <summary>Place the menu immediately below the anchor aligned to the right of the content</summary>
		MenuPlacement_BelowRightAnchor=2,
		/// <summary>Place the menu immediately below the anchor and match is width to the anchor's content</summary>
		MenuPlacement_ComboBox=3,
		/// <summary>Place the menu immediately below the anchor and match is width to the anchor's content. If the width overflows, align with the right edge of the anchor.</summary>
		MenuPlacement_ComboBoxRight=4,
		/// <summary>Place the menu to the right of the anchor</summary>
		MenuPlacement_MenuRight=5,
		/// <summary>Place the menu immediately above the anchor, no transition effect</summary>
		MenuPlacement_AboveAnchor=6,
		/// <summary>Place the menu immediately centered above the anchor, no transition effect</summary>
		MenuPlacement_CenteredAboveAnchor=7,
		/// <summary>Place the menu immediately above the anchor aligned to the right of the content</summary>
		MenuPlacement_AboveRightAnchor=8,
		/// <summary>Place the menu to the left of the anchor</summary>
		MenuPlacement_MenuLeft=9,
		/// <summary>Place the menu's center on top of the menu anchor's center point</summary>
		MenuPlacement_Center=10,
		/// <summary>Place the menu's vertical center on the left side at the menu anchor's vertical center on the right side</summary>
		MenuPlacement_RightLeftCenter=11,
		MenuPlacement_MAX=12,
		
	}
	
}
