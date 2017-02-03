#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInputKeySelector
	{
		static readonly int SelectedKey__Offset;
		public FInputChord SelectedKey
		{
			get{ CheckIsValid();return (FInputChord)Marshal.PtrToStructure(_this.Get()+SelectedKey__Offset, typeof(FInputChord));}
			
		}
		
		static readonly int Font__Offset;
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Font__Offset, false);}
			
		}
		
		static readonly int Margin__Offset;
		public FMargin Margin
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Margin__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Margin__Offset, false);}
			
		}
		
		static readonly int ColorAndOpacity__Offset;
		public FLinearColor ColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorAndOpacity__Offset, false);}
			
		}
		
		static readonly int KeySelectionText__Offset;
		public string KeySelectionText
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+KeySelectionText__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+KeySelectionText__Offset, false);}
			
		}
		
		static readonly int bAllowModifierKeys__Offset;
		public bool bAllowModifierKeys
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowModifierKeys__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowModifierKeys__Offset, 1,0,1,255);}
			
		}
		
		static readonly int OnKeySelected__Offset;
		public FMulticastScriptDelegate OnKeySelected
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnKeySelected__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnKeySelected__Offset, false);}
			
		}
		
		static readonly int OnIsSelectingKeyChanged__Offset;
		public FMulticastScriptDelegate OnIsSelectingKeyChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnIsSelectingKeyChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnIsSelectingKeyChanged__Offset, false);}
			
		}
		
		static UInputKeySelector()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InputKeySelector");
			SelectedKey__Offset=GetPropertyOffset(NativeClassPtr,"SelectedKey");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			Margin__Offset=GetPropertyOffset(NativeClassPtr,"Margin");
			ColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"ColorAndOpacity");
			KeySelectionText__Offset=GetPropertyOffset(NativeClassPtr,"KeySelectionText");
			bAllowModifierKeys__Offset=GetPropertyOffset(NativeClassPtr,"bAllowModifierKeys");
			OnKeySelected__Offset=GetPropertyOffset(NativeClassPtr,"OnKeySelected");
			OnIsSelectingKeyChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnIsSelectingKeyChanged");
			
		}
		
	}
	
}
#endif
#endif
