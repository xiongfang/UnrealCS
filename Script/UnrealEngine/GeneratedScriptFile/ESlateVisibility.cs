using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Is an entity visible?</summary>
	public enum ESlateVisibility:byte
	{
		/// <summary>Default widget visibility - visible and can interactive with the cursor</summary>
		Visible=0,
		/// <summary>Not visible and takes up no space in the layout; can never be clicked on because it takes up no space.</summary>
		Collapsed=1,
		/// <summary>Not visible, but occupies layout space. Not interactive for obvious reasons.</summary>
		Hidden=2,
		/// <summary>Visible to the user, but only as art. The cursors hit tests will never see this widget.</summary>
		HitTestInvisible=3,
		/// <summary>Same as HitTestInvisible, but doesn't apply to child widgets.</summary>
		SelfHitTestInvisible=4,
		ESlateVisibility_MAX=5,
		
	}
	
}
