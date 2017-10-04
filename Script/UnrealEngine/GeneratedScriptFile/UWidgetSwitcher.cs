using System;
namespace UnrealEngine
{
	public partial class UWidgetSwitcher:UPanelWidget
	{
		/// <summary>Get a widget at the provided index</summary>
		public extern UWidget GetWidgetAtIndex(int Index);
		/// <summary>Activates the widget and makes it the active index.</summary>
		public extern virtual void SetActiveWidget(UWidget Widget);
		/// <summary>Activates the widget at the specified index.</summary>
		public extern virtual void SetActiveWidgetIndex(int Index);
		/// <summary>Gets the slot index of the currently active widget</summary>
		public extern int GetActiveWidgetIndex();
		/// <summary>Gets the number of widgets that this switcher manages.</summary>
		public extern int GetNumWidgets();
		/// <summary>The slot index to display</summary>
		public int ActiveWidgetIndex;
		
		
	}
	
}
