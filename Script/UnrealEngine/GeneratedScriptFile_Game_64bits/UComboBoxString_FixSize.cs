#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UComboBoxString
	{
		static readonly int DefaultOptions__Offset;
		public TStructArray<FString> DefaultOptions
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DefaultOptions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DefaultOptions__Offset, false);}
			
		}
		
		static readonly int SelectedOption__Offset;
		public FString SelectedOption
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SelectedOption__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectedOption__Offset, false);}
			
		}
		
		static readonly int WidgetStyle__Offset;
		public FComboBoxStyle WidgetStyle
		{
			get{ CheckIsValid();return (FComboBoxStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FComboBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int ItemStyle__Offset;
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
		public float MaxListHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxListHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxListHeight__Offset, false);}
			
		}
		
		static readonly int HasDownArrow__Offset;
		public bool HasDownArrow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), HasDownArrow__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), HasDownArrow__Offset, 1,0,1,255);}
			
		}
		
		static readonly int EnableGamepadNavigationMode__Offset;
		public bool EnableGamepadNavigationMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), EnableGamepadNavigationMode__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), EnableGamepadNavigationMode__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Font__Offset;
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Font__Offset, false);}
			
		}
		
		static readonly int ForegroundColor__Offset;
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
		public FMulticastScriptDelegate OnSelectionChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnSelectionChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnSelectionChanged__Offset, false);}
			
		}
		
		static readonly int OnOpening__Offset;
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
