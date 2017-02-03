#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEditableTextBox
	{
		static readonly int Text__Offset;
		public string Text
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+Text__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+Text__Offset, false);}
			
		}
		
		static readonly int WidgetStyle__Offset;
		public FEditableTextBoxStyle WidgetStyle
		{
			get{ CheckIsValid();return (FEditableTextBoxStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FEditableTextBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int Style__Offset;
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int HintText__Offset;
		public string HintText
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+HintText__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+HintText__Offset, false);}
			
		}
		
		static readonly int Font__Offset;
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			
		}
		
		static readonly int ForegroundColor__Offset;
		public FLinearColor ForegroundColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ForegroundColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int BackgroundColor__Offset;
		public FLinearColor BackgroundColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+BackgroundColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int ReadOnlyForegroundColor__Offset;
		public FLinearColor ReadOnlyForegroundColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ReadOnlyForegroundColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int IsReadOnly__Offset;
		public bool IsReadOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsReadOnly__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsReadOnly__Offset, 1,0,1,255);}
			
		}
		
		static readonly int IsPassword__Offset;
		public bool IsPassword
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsPassword__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsPassword__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MinimumDesiredWidth__Offset;
		public float MinimumDesiredWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinimumDesiredWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinimumDesiredWidth__Offset, false);}
			
		}
		
		static readonly int Padding__Offset;
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			
		}
		
		static readonly int IsCaretMovedWhenGainFocus__Offset;
		public bool IsCaretMovedWhenGainFocus
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsCaretMovedWhenGainFocus__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsCaretMovedWhenGainFocus__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SelectAllTextWhenFocused__Offset;
		public bool SelectAllTextWhenFocused
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), SelectAllTextWhenFocused__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), SelectAllTextWhenFocused__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RevertTextOnEscape__Offset;
		public bool RevertTextOnEscape
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), RevertTextOnEscape__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), RevertTextOnEscape__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ClearKeyboardFocusOnCommit__Offset;
		public bool ClearKeyboardFocusOnCommit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ClearKeyboardFocusOnCommit__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), ClearKeyboardFocusOnCommit__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SelectAllTextOnCommit__Offset;
		public bool SelectAllTextOnCommit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), SelectAllTextOnCommit__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), SelectAllTextOnCommit__Offset, 1,0,1,255);}
			
		}
		
		static readonly int AllowContextMenu__Offset;
		public bool AllowContextMenu
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AllowContextMenu__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AllowContextMenu__Offset, 1,0,1,255);}
			
		}
		
		static readonly int KeyboardType__Offset;
		public EVirtualKeyboardType KeyboardType
		{
			get{ CheckIsValid();return (EVirtualKeyboardType)Marshal.PtrToStructure(_this.Get()+KeyboardType__Offset, typeof(EVirtualKeyboardType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+KeyboardType__Offset, false);}
			
		}
		
		static readonly int ShapedTextOptions__Offset;
		public FShapedTextOptions ShapedTextOptions
		{
			get{ CheckIsValid();return (FShapedTextOptions)Marshal.PtrToStructure(_this.Get()+ShapedTextOptions__Offset, typeof(FShapedTextOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShapedTextOptions__Offset, false);}
			
		}
		
		static readonly int OnTextChanged__Offset;
		public FMulticastScriptDelegate OnTextChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTextChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTextChanged__Offset, false);}
			
		}
		
		static readonly int OnTextCommitted__Offset;
		public FMulticastScriptDelegate OnTextCommitted
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTextCommitted__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTextCommitted__Offset, false);}
			
		}
		
		static UEditableTextBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EditableTextBox");
			Text__Offset=GetPropertyOffset(NativeClassPtr,"Text");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			HintText__Offset=GetPropertyOffset(NativeClassPtr,"HintText");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			ForegroundColor__Offset=GetPropertyOffset(NativeClassPtr,"ForegroundColor");
			BackgroundColor__Offset=GetPropertyOffset(NativeClassPtr,"BackgroundColor");
			ReadOnlyForegroundColor__Offset=GetPropertyOffset(NativeClassPtr,"ReadOnlyForegroundColor");
			IsReadOnly__Offset=GetPropertyOffset(NativeClassPtr,"IsReadOnly");
			IsPassword__Offset=GetPropertyOffset(NativeClassPtr,"IsPassword");
			MinimumDesiredWidth__Offset=GetPropertyOffset(NativeClassPtr,"MinimumDesiredWidth");
			Padding__Offset=GetPropertyOffset(NativeClassPtr,"Padding");
			IsCaretMovedWhenGainFocus__Offset=GetPropertyOffset(NativeClassPtr,"IsCaretMovedWhenGainFocus");
			SelectAllTextWhenFocused__Offset=GetPropertyOffset(NativeClassPtr,"SelectAllTextWhenFocused");
			RevertTextOnEscape__Offset=GetPropertyOffset(NativeClassPtr,"RevertTextOnEscape");
			ClearKeyboardFocusOnCommit__Offset=GetPropertyOffset(NativeClassPtr,"ClearKeyboardFocusOnCommit");
			SelectAllTextOnCommit__Offset=GetPropertyOffset(NativeClassPtr,"SelectAllTextOnCommit");
			AllowContextMenu__Offset=GetPropertyOffset(NativeClassPtr,"AllowContextMenu");
			KeyboardType__Offset=GetPropertyOffset(NativeClassPtr,"KeyboardType");
			ShapedTextOptions__Offset=GetPropertyOffset(NativeClassPtr,"ShapedTextOptions");
			OnTextChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnTextChanged");
			OnTextCommitted__Offset=GetPropertyOffset(NativeClassPtr,"OnTextCommitted");
			
		}
		
	}
	
}
#endif
#endif
