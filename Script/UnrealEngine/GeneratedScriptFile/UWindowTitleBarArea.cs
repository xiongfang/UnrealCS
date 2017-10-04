using System;
namespace UnrealEngine
{
	public partial class UWindowTitleBarArea:UContentWidget
	{
		public extern void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment);
		public extern void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment);
		public extern void SetPadding(FMargin InPadding);
		/// <summary>Should double clicking the title bar area toggle fullscreen instead of maximizing the window.</summary>
		public bool bDoubleClickTogglesFullscreen;
		
		
	}
	
}
