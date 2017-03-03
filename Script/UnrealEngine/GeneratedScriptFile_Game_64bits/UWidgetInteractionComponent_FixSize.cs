#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWidgetInteractionComponent
	{
		static readonly int OnHoveredWidgetChanged__Offset;
		public FMulticastScriptDelegate OnHoveredWidgetChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnHoveredWidgetChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnHoveredWidgetChanged__Offset, false);}
			
		}
		
		static readonly int VirtualUserIndex__Offset;
		public int VirtualUserIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VirtualUserIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VirtualUserIndex__Offset, false);}
			
		}
		
		static readonly int PointerIndex__Offset;
		public float PointerIndex
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PointerIndex__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PointerIndex__Offset, false);}
			
		}
		
		static readonly int TraceChannel__Offset;
		public ECollisionChannel TraceChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+TraceChannel__Offset, typeof(ECollisionChannel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TraceChannel__Offset, false);}
			
		}
		
		static readonly int InteractionDistance__Offset;
		public float InteractionDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InteractionDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InteractionDistance__Offset, false);}
			
		}
		
		static readonly int bEnableHitTesting__Offset;
		public bool bEnableHitTesting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableHitTesting__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableHitTesting__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bShowDebug__Offset;
		public bool bShowDebug
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowDebug__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowDebug__Offset, 1,0,1,255);}
			
		}
		
		static readonly int DebugColor__Offset;
		public FLinearColor DebugColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+DebugColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DebugColor__Offset, false);}
			
		}
		
		static readonly int CustomHitResult__Offset;
		public FHitResult CustomHitResult
		{
			get{ CheckIsValid();return (FHitResult)Marshal.PtrToStructure(_this.Get()+CustomHitResult__Offset, typeof(FHitResult));}
			
		}
		
		static readonly int LocalHitLocation__Offset;
		public FVector2D LocalHitLocation
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+LocalHitLocation__Offset, typeof(FVector2D));}
			
		}
		
		static readonly int LastLocalHitLocation__Offset;
		public FVector2D LastLocalHitLocation
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+LastLocalHitLocation__Offset, typeof(FVector2D));}
			
		}
		
		static readonly int HoveredWidgetComponent__Offset;
		public UWidgetComponent HoveredWidgetComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + HoveredWidgetComponent__Offset); if (v == IntPtr.Zero)return null; UWidgetComponent retValue = new UWidgetComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LastHitResult__Offset;
		public FHitResult LastHitResult
		{
			get{ CheckIsValid();return (FHitResult)Marshal.PtrToStructure(_this.Get()+LastHitResult__Offset, typeof(FHitResult));}
			
		}
		
		static readonly int bIsHoveredWidgetInteractable__Offset;
		public bool bIsHoveredWidgetInteractable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsHoveredWidgetInteractable__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsHoveredWidgetFocusable__Offset;
		public bool bIsHoveredWidgetFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsHoveredWidgetFocusable__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsHoveredWidgetHitTestVisible__Offset;
		public bool bIsHoveredWidgetHitTestVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsHoveredWidgetHitTestVisible__Offset, 1, 0, 1, 255);}
			
		}
		
		static UWidgetInteractionComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WidgetInteractionComponent");
			OnHoveredWidgetChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnHoveredWidgetChanged");
			VirtualUserIndex__Offset=GetPropertyOffset(NativeClassPtr,"VirtualUserIndex");
			PointerIndex__Offset=GetPropertyOffset(NativeClassPtr,"PointerIndex");
			TraceChannel__Offset=GetPropertyOffset(NativeClassPtr,"TraceChannel");
			InteractionDistance__Offset=GetPropertyOffset(NativeClassPtr,"InteractionDistance");
			bEnableHitTesting__Offset=GetPropertyOffset(NativeClassPtr,"bEnableHitTesting");
			bShowDebug__Offset=GetPropertyOffset(NativeClassPtr,"bShowDebug");
			DebugColor__Offset=GetPropertyOffset(NativeClassPtr,"DebugColor");
			CustomHitResult__Offset=GetPropertyOffset(NativeClassPtr,"CustomHitResult");
			LocalHitLocation__Offset=GetPropertyOffset(NativeClassPtr,"LocalHitLocation");
			LastLocalHitLocation__Offset=GetPropertyOffset(NativeClassPtr,"LastLocalHitLocation");
			HoveredWidgetComponent__Offset=GetPropertyOffset(NativeClassPtr,"HoveredWidgetComponent");
			LastHitResult__Offset=GetPropertyOffset(NativeClassPtr,"LastHitResult");
			bIsHoveredWidgetInteractable__Offset=GetPropertyOffset(NativeClassPtr,"bIsHoveredWidgetInteractable");
			bIsHoveredWidgetFocusable__Offset=GetPropertyOffset(NativeClassPtr,"bIsHoveredWidgetFocusable");
			bIsHoveredWidgetHitTestVisible__Offset=GetPropertyOffset(NativeClassPtr,"bIsHoveredWidgetHitTestVisible");
			
		}
		
	}
	
}
#endif
#endif
