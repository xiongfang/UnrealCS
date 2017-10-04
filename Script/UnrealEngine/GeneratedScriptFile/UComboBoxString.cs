using System;
namespace UnrealEngine
{
	public partial class UComboBoxString:UWidget
	{
		/// <summary>@return The number of options</summary>
		public extern int GetOptionCount();
		public extern FString GetSelectedOption();
		public extern void SetSelectedOption(FString Option);
		/// <summary>
		/// Refreshes the list of options.  If you added new ones, and want to update the list even if it's
		/// currently being displayed use this.
		/// </summary>
		public extern void RefreshOptions();
		public extern void ClearSelection();
		public extern void ClearOptions();
		public extern FString GetOptionAtIndex(int Index);
		public extern int FindOptionIndex(FString Option);
		public extern bool RemoveOption(FString Option);
		public extern void AddOption(FString Option);
		/// <summary>The item in the combobox to select by default</summary>
		public FString SelectedOption;
		
		/// <summary>The style.</summary>
		public FComboBoxStyle WidgetStyle;
		
		/// <summary>The item row style.</summary>
		public FTableRowStyle ItemStyle;
		
		public FMargin ContentPadding;
		
		/// <summary>The max height of the combobox list that opens</summary>
		public float MaxListHeight;
		
		/// <summary>
		/// When false, the down arrow is not generated and it is up to the API consumer
		/// to make their own visual hint that this is a drop down.
		/// </summary>
		public bool HasDownArrow;
		
		/// <summary>
		/// When false, directional keys will change the selection. When true, ComboBox
		/// must be activated and will only capture arrow input while activated.
		/// </summary>
		public bool EnableGamepadNavigationMode;
		
		/// <summary>
		/// The default font to use in the combobox, only applies if you're not implementing OnGenerateWidgetEvent
		/// to factory each new entry.
		/// </summary>
		public FSlateFontInfo Font;
		
		/// <summary>The foreground color to pass through the hierarchy.</summary>
		public FSlateColor ForegroundColor;
		
		public bool bIsFocusable;
		
		
	}
	
}
