#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// This is a component to allow interaction with the Widget Component.  This class allows you to
	/// simulate a sort of laser pointer device, when it hovers over widgets it will send the basic signals
	/// to show as if the mouse were moving on top of it.  You'll then tell the component to simulate key presses,
	/// like Left Mouse, down and up, to simulate a mouse click.
	/// </summary>
	public partial class UWidgetInteractionComponent
	{
		static readonly int OnHoveredWidgetChanged__Offset;
		/// <summary>
		/// Called when the hovered Widget Component changes.  The interaction component functions at the Slate
		/// level - so it's unable to report anything about what UWidget is under the hit result.
		/// </summary>
		public FMulticastScriptDelegate OnHoveredWidgetChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnHoveredWidgetChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnHoveredWidgetChanged__Offset, false);}
			
		}
		
		static readonly int VirtualUserIndex__Offset;
		/// <summary>
		/// Represents the Virtual User Index.  Each virtual user should be represented by a different
		/// index number, this will maintain separate capture and focus states for them.  Each
		/// controller or finger-tip should get a unique PointerIndex.
		/// </summary>
		public int VirtualUserIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VirtualUserIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VirtualUserIndex__Offset, false);}
			
		}
		
		static readonly int PointerIndex__Offset;
		/// <summary>Each user virtual controller or virtual finger tips being simulated should use a different pointer index.</summary>
		public float PointerIndex
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PointerIndex__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PointerIndex__Offset, false);}
			
		}
		
		static readonly int TraceChannel__Offset;
		/// <summary>The trace channel to use when tracing for widget components in the world.</summary>
		public ECollisionChannel TraceChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+TraceChannel__Offset, typeof(ECollisionChannel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TraceChannel__Offset, false);}
			
		}
		
		static readonly int InteractionDistance__Offset;
		/// <summary>The distance in game units the component should be able to interact with a widget component.</summary>
		public float InteractionDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InteractionDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InteractionDistance__Offset, false);}
			
		}
		
		static readonly int bEnableHitTesting__Offset;
		/// <summary>
		/// Should the interaction component perform hit testing (Automatic or Custom) and attempt to
		/// simulate hover - if you were going to emulate a keyboard you would want to turn this option off
		/// if the virtual keyboard was separate from the virtual pointer device and used a second interaction
		/// component.
		/// </summary>
		public bool bEnableHitTesting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableHitTesting__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableHitTesting__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bShowDebug__Offset;
		/// <summary>Shows some debugging lines and a hit sphere to help you debug interactions.</summary>
		public bool bShowDebug
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowDebug__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowDebug__Offset, 1,0,1,255);}
			
		}
		
		static readonly int DebugColor__Offset;
		/// <summary>Determines the color of the debug lines.</summary>
		public FLinearColor DebugColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+DebugColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DebugColor__Offset, false);}
			
		}
		
		static readonly int CustomHitResult__Offset;
		/// <summary>Stores the custom hit result set by the player.</summary>
		public FHitResult CustomHitResult
		{
			get{ CheckIsValid();return (FHitResult)Marshal.PtrToStructure(_this.Get()+CustomHitResult__Offset, typeof(FHitResult));}
			
		}
		
		static readonly int LocalHitLocation__Offset;
		/// <summary>The 2D location on the widget component that was hit.</summary>
		public FVector2D LocalHitLocation
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+LocalHitLocation__Offset, typeof(FVector2D));}
			
		}
		
		static readonly int LastLocalHitLocation__Offset;
		/// <summary>The last 2D location on the widget component that was hit.</summary>
		public FVector2D LastLocalHitLocation
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+LastLocalHitLocation__Offset, typeof(FVector2D));}
			
		}
		
		static readonly int HoveredWidgetComponent__Offset;
		/// <summary>The widget component we're currently hovering over.</summary>
		public UWidgetComponent HoveredWidgetComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + HoveredWidgetComponent__Offset); if (v == IntPtr.Zero)return null; UWidgetComponent retValue = new UWidgetComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LastHitResult__Offset;
		/// <summary>The last hit result we used.</summary>
		public FHitResult LastHitResult
		{
			get{ CheckIsValid();return (FHitResult)Marshal.PtrToStructure(_this.Get()+LastHitResult__Offset, typeof(FHitResult));}
			
		}
		
		static readonly int bIsHoveredWidgetInteractable__Offset;
		/// <summary>Are we hovering over any interactive widgets.</summary>
		public bool bIsHoveredWidgetInteractable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsHoveredWidgetInteractable__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsHoveredWidgetFocusable__Offset;
		/// <summary>Are we hovering over any focusable widget?</summary>
		public bool bIsHoveredWidgetFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsHoveredWidgetFocusable__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsHoveredWidgetHitTestVisible__Offset;
		/// <summary>Are we hovered over a widget that is hit test visible?</summary>
		public bool bIsHoveredWidgetHitTestVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsHoveredWidgetHitTestVisible__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ArrowComponent__Offset;
		/// <summary>The arrow component we show at editor time.</summary>
		public UArrowComponent ArrowComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowComponent__Offset); if (v == IntPtr.Zero)return null; UArrowComponent retValue = new UArrowComponent(); retValue._this = v; return retValue; }
			
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
			ArrowComponent__Offset=GetPropertyOffset(NativeClassPtr,"ArrowComponent");
			
		}
		
	}
	
}
#endif
#endif
