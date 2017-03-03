#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
	public partial class UComboBoxString
	{
		static readonly int DefaultOptions__Offset;
		/// <summary>The default list of items to be displayed on the combobox.</summary>
		public TStructArray<FString> DefaultOptions
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DefaultOptions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DefaultOptions__Offset, false);}
			
		}
		
		static readonly int SelectedOption__Offset;
		/// <summary>The item in the combobox to select by default</summary>
		public FString SelectedOption
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SelectedOption__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectedOption__Offset, false);}
			
		}
		
		static readonly int WidgetStyle__Offset;
		/// <summary>The style.</summary>
		public FComboBoxStyle WidgetStyle
		{
			get{ CheckIsValid();return (FComboBoxStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FComboBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int ItemStyle__Offset;
		/// <summary>The item row style.</summary>
		public FTableRowStyle ItemStyle
		{
			get{ CheckIsValid();return (FTableRowStyle)Marshal.PtrToStructure(_this.Get()+ItemStyle__Offset, typeof(FTableRowStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ItemStyle__Offset, false);}
			
		}
		
		static readonly int ContentPadding__Offset;
		public FMargin ContentPadding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+ContentPadding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ContentPadding__Offset, false);}
			
		}
		
		static readonly int MaxListHeight__Offset;
		/// <summary>The max height of the combobox list that opens</summary>
		public float MaxListHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxListHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxListHeight__Offset, false);}
			
		}
		
		static readonly int HasDownArrow__Offset;
		/// <summary>
		/// When false, the down arrow is not generated and it is up to the API consumer
		/// to make their own visual hint that this is a drop down.
		/// </summary>
		public bool HasDownArrow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), HasDownArrow__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), HasDownArrow__Offset, 1,0,1,255);}
			
		}
		
		static readonly int EnableGamepadNavigationMode__Offset;
		/// <summary>
		/// When false, directional keys will change the selection. When true, ComboBox
		/// must be activated and will only capture arrow input while activated.
		/// </summary>
		public bool EnableGamepadNavigationMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), EnableGamepadNavigationMode__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), EnableGamepadNavigationMode__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Font__Offset;
		/// <summary>
		/// The default font to use in the combobox, only applies if you're not implementing OnGenerateWidgetEvent
		/// to factory each new entry.
		/// </summary>
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Font__Offset, false);}
			
		}
		
		static readonly int ForegroundColor__Offset;
		/// <summary>The foreground color to pass through the hierarchy.</summary>
		public FSlateColor ForegroundColor
		{
			get{ CheckIsValid();return (FSlateColor)Marshal.PtrToStructure(_this.Get()+ForegroundColor__Offset, typeof(FSlateColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForegroundColor__Offset, false);}
			
		}
		
		static readonly int bIsFocusable__Offset;
		public bool bIsFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFocusable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsFocusable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int OnSelectionChanged__Offset;
		/// <summary>Called when a new item is selected in the combobox.</summary>
		public FMulticastScriptDelegate OnSelectionChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnSelectionChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnSelectionChanged__Offset, false);}
			
		}
		
		static readonly int OnOpening__Offset;
		/// <summary>Called when the combobox is opening</summary>
		public FMulticastScriptDelegate OnOpening
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnOpening__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnOpening__Offset, false);}
			
		}
		
		static UComboBoxString()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ComboBoxString");
			DefaultOptions__Offset=GetPropertyOffset(NativeClassPtr,"DefaultOptions");
			SelectedOption__Offset=GetPropertyOffset(NativeClassPtr,"SelectedOption");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			ItemStyle__Offset=GetPropertyOffset(NativeClassPtr,"ItemStyle");
			ContentPadding__Offset=GetPropertyOffset(NativeClassPtr,"ContentPadding");
			MaxListHeight__Offset=GetPropertyOffset(NativeClassPtr,"MaxListHeight");
			HasDownArrow__Offset=GetPropertyOffset(NativeClassPtr,"HasDownArrow");
			EnableGamepadNavigationMode__Offset=GetPropertyOffset(NativeClassPtr,"EnableGamepadNavigationMode");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			ForegroundColor__Offset=GetPropertyOffset(NativeClassPtr,"ForegroundColor");
			bIsFocusable__Offset=GetPropertyOffset(NativeClassPtr,"bIsFocusable");
			OnSelectionChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnSelectionChanged");
			OnOpening__Offset=GetPropertyOffset(NativeClassPtr,"OnOpening");
			
		}
		
	}
	
}
#endif
#endif
