#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This is the base class for all wrapped Slate controls that are exposed to UObjects.</summary>
	public partial class UWidget
	{
		static readonly int bIsVariable__Offset;
		/// <summary>
		/// Allows controls to be exposed as variables in a blueprint.  Not all controls need to be exposed
		/// as variables, so this allows only the most useful ones to end up being exposed.
		/// </summary>
		public bool bIsVariable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsVariable__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bCreatedByConstructionScript__Offset;
		/// <summary>Flag if the Widget was created from a blueprint</summary>
		public bool bCreatedByConstructionScript
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCreatedByConstructionScript__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int Slot__Offset;
		/// <summary>The parent slot of the UWidget.  Allows us to easily inline edit the layout controlling this widget.</summary>
		public UPanelSlot Slot
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Slot__Offset); if (v == IntPtr.Zero)return null; UPanelSlot retValue = new UPanelSlot(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Slot__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Slot__Offset, value._this.Get()); }
			
		}
		
		static readonly int bIsEnabled__Offset;
		/// <summary>Sets whether this widget can be modified interactively by the user</summary>
		public bool bIsEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsEnabled__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsEnabled__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ToolTipText__Offset;
		/// <summary>Tooltip text to show when the user hovers over the widget with the mouse</summary>
		public string ToolTipText
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+ToolTipText__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+ToolTipText__Offset, false);}
			
		}
		
		static readonly int ToolTipWidget__Offset;
		/// <summary>Tooltip widget to show when the user hovers over the widget with the mouse</summary>
		public UWidget ToolTipWidget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ToolTipWidget__Offset); if (v == IntPtr.Zero)return null; UWidget retValue = new UWidget(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ToolTipWidget__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ToolTipWidget__Offset, value._this.Get()); }
			
		}
		
		static readonly int bOverride_Cursor__Offset;
		public bool bOverride_Cursor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_Cursor__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_Cursor__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Cursor__Offset;
		/// <summary>The cursor to show when the mouse is over the widget</summary>
		public EMouseCursor Cursor
		{
			get{ CheckIsValid();return (EMouseCursor)Marshal.PtrToStructure(_this.Get()+Cursor__Offset, typeof(EMouseCursor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Cursor__Offset, false);}
			
		}
		
		static readonly int bIsVolatile__Offset;
		/// <summary>
		/// If true prevents the widget or its child's geometry or layout information from being cached.  If this widget
		/// changes every frame, but you want it to still be in an invalidation panel you should make it as volatile
		/// instead of invalidating it every frame, which would prevent the invalidation panel from actually
		/// ever caching anything.
		/// </summary>
		public bool bIsVolatile
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsVolatile__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsVolatile__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RenderTransform__Offset;
		/// <summary>The render transform of the widget allows for arbitrary 2D transforms to be applied to the widget.</summary>
		public FWidgetTransform RenderTransform
		{
			get{ CheckIsValid();return (FWidgetTransform)Marshal.PtrToStructure(_this.Get()+RenderTransform__Offset, typeof(FWidgetTransform));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RenderTransform__Offset, false);}
			
		}
		
		static readonly int RenderTransformPivot__Offset;
		/// <summary>
		/// The render transform pivot controls the location about which transforms are applied.
		/// This value is a normalized coordinate about which things like rotations will occur.
		/// </summary>
		public FVector2D RenderTransformPivot
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+RenderTransformPivot__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RenderTransformPivot__Offset, false);}
			
		}
		
		static readonly int Navigation__Offset;
		/// <summary>
		/// The navigation object for this widget is optionally created if the user has configured custom
		/// navigation rules for this widget in the widget designer.  Those rules determine how navigation transitions
		/// can occur between widgets.
		/// </summary>
		public UWidgetNavigation Navigation
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Navigation__Offset); if (v == IntPtr.Zero)return null; UWidgetNavigation retValue = new UWidgetNavigation(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Navigation__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Navigation__Offset, value._this.Get()); }
			
		}
		
		static readonly int bHiddenInDesigner__Offset;
		/// <summary>Stores the design time flag setting if the widget is hidden inside the designer</summary>
		public bool bHiddenInDesigner
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHiddenInDesigner__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bExpandedInDesigner__Offset;
		/// <summary>Stores the design time flag setting if the widget is expanded inside the designer</summary>
		public bool bExpandedInDesigner
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bExpandedInDesigner__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int NativeBindings__Offset;
		/// <summary>Native property bindings.</summary>
		public TObjectArray<UPropertyBinding>  NativeBindings
		{
					get{ CheckIsValid();return new TObjectArray<UPropertyBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NativeBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NativeBindings__Offset, false);}
			
		}
		
		static readonly int DesignerFlags__Offset;
		/// <summary>Any flags used by the designer at edit time.</summary>
		public EWidgetDesignFlags DesignerFlags
		{
			get{ CheckIsValid();return (EWidgetDesignFlags)Marshal.PtrToStructure(_this.Get()+DesignerFlags__Offset, typeof(EWidgetDesignFlags));}
			
		}
		
		static readonly int DisplayLabel__Offset;
		/// <summary>The friendly name for this widget displayed in the designer and BP graph.</summary>
		public FString DisplayLabel
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+DisplayLabel__Offset, typeof(FString));}
			
		}
		
		static UWidget()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Widget");
			bIsVariable__Offset=GetPropertyOffset(NativeClassPtr,"bIsVariable");
			bCreatedByConstructionScript__Offset=GetPropertyOffset(NativeClassPtr,"bCreatedByConstructionScript");
			Slot__Offset=GetPropertyOffset(NativeClassPtr,"Slot");
			bIsEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bIsEnabled");
			ToolTipText__Offset=GetPropertyOffset(NativeClassPtr,"ToolTipText");
			ToolTipWidget__Offset=GetPropertyOffset(NativeClassPtr,"ToolTipWidget");
			bOverride_Cursor__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_Cursor");
			Cursor__Offset=GetPropertyOffset(NativeClassPtr,"Cursor");
			bIsVolatile__Offset=GetPropertyOffset(NativeClassPtr,"bIsVolatile");
			RenderTransform__Offset=GetPropertyOffset(NativeClassPtr,"RenderTransform");
			RenderTransformPivot__Offset=GetPropertyOffset(NativeClassPtr,"RenderTransformPivot");
			Navigation__Offset=GetPropertyOffset(NativeClassPtr,"Navigation");
			bHiddenInDesigner__Offset=GetPropertyOffset(NativeClassPtr,"bHiddenInDesigner");
			bExpandedInDesigner__Offset=GetPropertyOffset(NativeClassPtr,"bExpandedInDesigner");
			NativeBindings__Offset=GetPropertyOffset(NativeClassPtr,"NativeBindings");
			DesignerFlags__Offset=GetPropertyOffset(NativeClassPtr,"DesignerFlags");
			DisplayLabel__Offset=GetPropertyOffset(NativeClassPtr,"DisplayLabel");
			
		}
		
	}
	
}
#endif
#endif
