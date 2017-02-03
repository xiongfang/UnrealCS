#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Editable text box widget</summary>
	public partial class UEditableText
	{
		static readonly int Text__Offset;
		/// <summary>The text content for this editable text box widget</summary>
		public string Text
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+Text__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+Text__Offset, false);}
			
		}
		
		static readonly int HintText__Offset;
		/// <summary>Hint text that appears when there is no text in the text box</summary>
		public string HintText
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+HintText__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+HintText__Offset, false);}
			
		}
		
		static readonly int WidgetStyle__Offset;
		/// <summary>The style</summary>
		public FEditableTextStyle WidgetStyle
		{
			get{ CheckIsValid();return (FEditableTextStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FEditableTextStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int Style__Offset;
		/// <summary>Text style</summary>
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BackgroundImageSelected__Offset;
		/// <summary>Background image for the selected text (overrides Style)</summary>
		public USlateBrushAsset BackgroundImageSelected
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BackgroundImageSelected__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BackgroundImageComposing__Offset;
		/// <summary>Background image for the composing text (overrides Style)</summary>
		public USlateBrushAsset BackgroundImageComposing
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BackgroundImageComposing__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CaretImage__Offset;
		/// <summary>Image brush used for the caret (overrides Style)</summary>
		public USlateBrushAsset CaretImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CaretImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Font__Offset;
		/// <summary>Font color and opacity (overrides Style)</summary>
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			
		}
		
		static readonly int ColorAndOpacity__Offset;
		/// <summary>Text color and opacity (overrides Style)</summary>
		public FSlateColor ColorAndOpacity
		{
			get{ CheckIsValid();return (FSlateColor)Marshal.PtrToStructure(_this.Get()+ColorAndOpacity__Offset, typeof(FSlateColor));}
			
		}
		
		static readonly int IsReadOnly__Offset;
		/// <summary>Sets whether this text box can actually be modified interactively by the user</summary>
		public bool IsReadOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsReadOnly__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsReadOnly__Offset, 1,0,1,255);}
			
		}
		
		static readonly int IsPassword__Offset;
		/// <summary>Sets whether this text box is for storing a password</summary>
		public bool IsPassword
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsPassword__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsPassword__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MinimumDesiredWidth__Offset;
		/// <summary>Minimum width that a text block should be</summary>
		public float MinimumDesiredWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinimumDesiredWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinimumDesiredWidth__Offset, false);}
			
		}
		
		static readonly int IsCaretMovedWhenGainFocus__Offset;
		/// <summary>Workaround as we lose focus when the auto completion closes.</summary>
		public bool IsCaretMovedWhenGainFocus
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsCaretMovedWhenGainFocus__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsCaretMovedWhenGainFocus__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SelectAllTextWhenFocused__Offset;
		/// <summary>Whether to select all text when the user clicks to give focus on the widget</summary>
		public bool SelectAllTextWhenFocused
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), SelectAllTextWhenFocused__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), SelectAllTextWhenFocused__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RevertTextOnEscape__Offset;
		/// <summary>Whether to allow the user to back out of changes when they press the escape key</summary>
		public bool RevertTextOnEscape
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), RevertTextOnEscape__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), RevertTextOnEscape__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ClearKeyboardFocusOnCommit__Offset;
		/// <summary>Whether to clear keyboard focus when pressing enter to commit changes</summary>
		public bool ClearKeyboardFocusOnCommit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ClearKeyboardFocusOnCommit__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), ClearKeyboardFocusOnCommit__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SelectAllTextOnCommit__Offset;
		/// <summary>Whether to select all text when pressing enter to commit changes</summary>
		public bool SelectAllTextOnCommit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), SelectAllTextOnCommit__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), SelectAllTextOnCommit__Offset, 1,0,1,255);}
			
		}
		
		static readonly int AllowContextMenu__Offset;
		/// <summary>Whether the context menu can be opened</summary>
		public bool AllowContextMenu
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AllowContextMenu__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AllowContextMenu__Offset, 1,0,1,255);}
			
		}
		
		static readonly int KeyboardType__Offset;
		/// <summary>If we're on a platform that requires a virtual keyboard, what kind of keyboard should this widget use?</summary>
		public EVirtualKeyboardType KeyboardType
		{
			get{ CheckIsValid();return (EVirtualKeyboardType)Marshal.PtrToStructure(_this.Get()+KeyboardType__Offset, typeof(EVirtualKeyboardType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+KeyboardType__Offset, false);}
			
		}
		
		static readonly int ShapedTextOptions__Offset;
		/// <summary>Controls how the text within this widget should be shaped.</summary>
		public FShapedTextOptions ShapedTextOptions
		{
			get{ CheckIsValid();return (FShapedTextOptions)Marshal.PtrToStructure(_this.Get()+ShapedTextOptions__Offset, typeof(FShapedTextOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShapedTextOptions__Offset, false);}
			
		}
		
		static readonly int OnTextChanged__Offset;
		/// <summary>Called whenever the text is changed interactively by the user</summary>
		public FMulticastScriptDelegate OnTextChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTextChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTextChanged__Offset, false);}
			
		}
		
		static readonly int OnTextCommitted__Offset;
		/// <summary>Called whenever the text is committed.  This happens when the user presses enter or the text box loses focus.</summary>
		public FMulticastScriptDelegate OnTextCommitted
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTextCommitted__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTextCommitted__Offset, false);}
			
		}
		
		static UEditableText()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EditableText");
			Text__Offset=GetPropertyOffset(NativeClassPtr,"Text");
			HintText__Offset=GetPropertyOffset(NativeClassPtr,"HintText");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			BackgroundImageSelected__Offset=GetPropertyOffset(NativeClassPtr,"BackgroundImageSelected");
			BackgroundImageComposing__Offset=GetPropertyOffset(NativeClassPtr,"BackgroundImageComposing");
			CaretImage__Offset=GetPropertyOffset(NativeClassPtr,"CaretImage");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			ColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"ColorAndOpacity");
			IsReadOnly__Offset=GetPropertyOffset(NativeClassPtr,"IsReadOnly");
			IsPassword__Offset=GetPropertyOffset(NativeClassPtr,"IsPassword");
			MinimumDesiredWidth__Offset=GetPropertyOffset(NativeClassPtr,"MinimumDesiredWidth");
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
