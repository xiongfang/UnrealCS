#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The user widget is extensible by users through the WidgetBlueprint.</summary>
	public partial class UUserWidget
	{
		static readonly int ColorAndOpacity__Offset;
		/// <summary>The color and opacity of this widget.  Tints all child widgets.</summary>
		public FLinearColor ColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorAndOpacity__Offset, false);}
			
		}
		
		static readonly int ForegroundColor__Offset;
		/// <summary>
		/// The foreground color of the widget, this is inherited by sub widgets.  Any color property
		/// that is marked as inherit will use this color.
		/// </summary>
		public FSlateColor ForegroundColor
		{
			get{ CheckIsValid();return (FSlateColor)Marshal.PtrToStructure(_this.Get()+ForegroundColor__Offset, typeof(FSlateColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForegroundColor__Offset, false);}
			
		}
		
		static readonly int Padding__Offset;
		/// <summary>The padding area around the content.</summary>
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
		/// <summary>Setting this flag to true, allows this widget to accept focus when clicked, or when navigated to.</summary>
		public bool bIsFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFocusable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsFocusable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int WidgetTree__Offset;
		/// <summary>The widget tree contained inside this user widget initialized by the blueprint</summary>
		public UWidgetTree WidgetTree
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WidgetTree__Offset); if (v == IntPtr.Zero)return null; UWidgetTree retValue = new UWidgetTree(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ActiveSequencePlayers__Offset;
		/// <summary>All the sequence players currently playing</summary>
		public TObjectArray<UUMGSequencePlayer>  ActiveSequencePlayers
		{
					get{ CheckIsValid();return new TObjectArray<UUMGSequencePlayer>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveSequencePlayers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveSequencePlayers__Offset, false);}
			
		}
		
		static readonly int StoppedSequencePlayers__Offset;
		/// <summary>List of sequence players to cache and clean up when safe</summary>
		public TObjectArray<UUMGSequencePlayer>  StoppedSequencePlayers
		{
					get{ CheckIsValid();return new TObjectArray<UUMGSequencePlayer>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StoppedSequencePlayers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StoppedSequencePlayers__Offset, false);}
			
		}
		
		static readonly int NamedSlotBindings__Offset;
		/// <summary>Stores the widgets being assigned to named slots</summary>
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
		
		static readonly int DesignTimeSize__Offset;
		/// <summary>Stores the design time desired size of the user widget</summary>
		public FVector2D DesignTimeSize
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+DesignTimeSize__Offset, typeof(FVector2D));}
			
		}
		
		static readonly int bUseDesignTimeSize__Offset;
		/// <summary>A flag that determines if the design time size is used for previewing the widget in the designer.</summary>
		public bool bUseDesignTimeSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDesignTimeSize__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bUseDesiredSizeAtDesignTime__Offset;
		/// <summary>A flag that determines if the widget's desired size is used for previewing the widget in the designer.</summary>
		public bool bUseDesiredSizeAtDesignTime
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDesiredSizeAtDesignTime__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int PaletteCategory__Offset;
		/// <summary>The category this widget appears in the palette.</summary>
		public string PaletteCategory
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+PaletteCategory__Offset, typeof(FText))).ToString();}
			
		}
		
		static readonly int PreviewBackground__Offset;
		/// <summary>
		/// A preview background that you can use when designing the UI to get a sense of scale on the screen.  Use
		/// a texture with a screenshot of your game in it, for example if you were designing a HUD.
		/// </summary>
		public UTexture2D PreviewBackground
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewBackground__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PreviewBackground__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PreviewBackground__Offset, value._this.Get()); }
			
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
			DesignTimeSize__Offset=GetPropertyOffset(NativeClassPtr,"DesignTimeSize");
			bUseDesignTimeSize__Offset=GetPropertyOffset(NativeClassPtr,"bUseDesignTimeSize");
			bUseDesiredSizeAtDesignTime__Offset=GetPropertyOffset(NativeClassPtr,"bUseDesiredSizeAtDesignTime");
			PaletteCategory__Offset=GetPropertyOffset(NativeClassPtr,"PaletteCategory");
			PreviewBackground__Offset=GetPropertyOffset(NativeClassPtr,"PreviewBackground");
			InputComponent__Offset=GetPropertyOffset(NativeClassPtr,"InputComponent");
			
		}
		
	}
	
}
#endif
#endif
