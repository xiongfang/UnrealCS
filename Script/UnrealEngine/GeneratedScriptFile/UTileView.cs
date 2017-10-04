using System;
namespace UnrealEngine
{
	public partial class UTileView:UTableViewBase
	{
		/// <summary>Refreshes the list</summary>
		public extern void RequestListRefresh();
		/// <summary>Set item height</summary>
		public extern void SetItemHeight(float Height);
		/// <summary>Set item width</summary>
		public extern void SetItemWidth(float Width);
		public float ItemWidth;
		
		public float ItemHeight;
		
		public ESelectionMode SelectionMode;
		
		
	}
	
}
