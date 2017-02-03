#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UUserWidget
	{
		static readonly int ColorAndOpacity__Offset;
		public FLinearColor ColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorAndOpacity__Offset, false);}
			
		}
		
		static readonly int ForegroundColor__Offset;
		public FSlateColor ForegroundColor
		{
			get{ CheckIsValid();return (FSlateColor)Marshal.PtrToStructure(_this.Get()+ForegroundColor__Offset, typeof(FSlateColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForegroundColor__Offset, false);}
			
		}
		
		static readonly int Padding__Offset;
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Padding__Offset, false);}
			
		}
		
		static readonly int bSupportsKeyboardFocus__Offset;
		public bool bSupportsKeyboardFocus
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsKeyboardFocus__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsFocusable__Offset;
		public bool bIsFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFocusable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsFocusable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int WidgetTree__Offset;
		public UWidgetTree WidgetTree
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WidgetTree__Offset); if (v == IntPtr.Zero)return null; UWidgetTree retValue = new UWidgetTree(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ActiveSequencePlayers__Offset;
		public TObjectArray<UUMGSequencePlayer>  ActiveSequencePlayers
		{
					get{ CheckIsValid();return new TObjectArray<UUMGSequencePlayer>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveSequencePlayers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveSequencePlayers__Offset, false);}
			
		}
		
		static readonly int StoppedSequencePlayers__Offset;
		public TObjectArray<UUMGSequencePlayer>  StoppedSequencePlayers
		{
					get{ CheckIsValid();return new TObjectArray<UUMGSequencePlayer>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StoppedSequencePlayers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StoppedSequencePlayers__Offset, false);}
			
		}
		
		static readonly int NamedSlotBindings__Offset;
		public TStructArray<FNamedSlotBinding> NamedSlotBindings
		{
			get{ CheckIsValid();return new TStructArray<FNamedSlotBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NamedSlotBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NamedSlotBindings__Offset, false);}
			
		}
		
		static readonly int bStopAction__Offset;
		public bool bStopAction
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStopAction__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStopAction__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Priority__Offset;
		public int Priority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int InputComponent__Offset;
		public UInputComponent InputComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InputComponent__Offset); if (v == IntPtr.Zero)return null; UInputComponent retValue = new UInputComponent(); retValue._this = v; return retValue; }
			
		}
		
		static UUserWidget()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UserWidget");
			ColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"ColorAndOpacity");
			ForegroundColor__Offset=GetPropertyOffset(NativeClassPtr,"ForegroundColor");
			Padding__Offset=GetPropertyOffset(NativeClassPtr,"Padding");
			bSupportsKeyboardFocus__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsKeyboardFocus");
			bIsFocusable__Offset=GetPropertyOffset(NativeClassPtr,"bIsFocusable");
			WidgetTree__Offset=GetPropertyOffset(NativeClassPtr,"WidgetTree");
			ActiveSequencePlayers__Offset=GetPropertyOffset(NativeClassPtr,"ActiveSequencePlayers");
			StoppedSequencePlayers__Offset=GetPropertyOffset(NativeClassPtr,"StoppedSequencePlayers");
			NamedSlotBindings__Offset=GetPropertyOffset(NativeClassPtr,"NamedSlotBindings");
			bStopAction__Offset=GetPropertyOffset(NativeClassPtr,"bStopAction");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			InputComponent__Offset=GetPropertyOffset(NativeClassPtr,"InputComponent");
			
		}
		
	}
	
}
#endif
#endif
