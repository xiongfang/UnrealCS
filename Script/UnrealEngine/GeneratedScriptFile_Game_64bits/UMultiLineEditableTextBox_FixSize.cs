#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMultiLineEditableTextBox
	{
		static readonly int Text__Offset;
		public string Text
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+Text__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+Text__Offset, false);}
			
		}
		
		static readonly int HintText__Offset;
		public string HintText
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+HintText__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+HintText__Offset, false);}
			
		}
		
		static readonly int WidgetStyle__Offset;
		public FEditableTextBoxStyle WidgetStyle
		{
			get{ CheckIsValid();return (FEditableTextBoxStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FEditableTextBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int TextStyle__Offset;
		public FTextBlockStyle TextStyle
		{
			get{ CheckIsValid();return (FTextBlockStyle)Marshal.PtrToStructure(_this.Get()+TextStyle__Offset, typeof(FTextBlockStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextStyle__Offset, false);}
			
		}
		
		static readonly int AllowContextMenu__Offset;
		public bool AllowContextMenu
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AllowContextMenu__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AllowContextMenu__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Style__Offset;
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
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
		
		static UMultiLineEditableTextBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MultiLineEditableTextBox");
			Text__Offset=GetPropertyOffset(NativeClassPtr,"Text");
			HintText__Offset=GetPropertyOffset(NativeClassPtr,"HintText");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			TextStyle__Offset=GetPropertyOffset(NativeClassPtr,"TextStyle");
			AllowContextMenu__Offset=GetPropertyOffset(NativeClassPtr,"AllowContextMenu");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			ForegroundColor__Offset=GetPropertyOffset(NativeClassPtr,"ForegroundColor");
			BackgroundColor__Offset=GetPropertyOffset(NativeClassPtr,"BackgroundColor");
			ReadOnlyForegroundColor__Offset=GetPropertyOffset(NativeClassPtr,"ReadOnlyForegroundColor");
			OnTextChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnTextChanged");
			OnTextCommitted__Offset=GetPropertyOffset(NativeClassPtr,"OnTextCommitted");
			
		}
		
	}
	
}
#endif
#endif
