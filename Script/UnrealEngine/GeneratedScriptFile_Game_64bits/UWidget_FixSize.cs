#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWidget
	{
		static readonly int bIsVariable__Offset;
		public bool bIsVariable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsVariable__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bCreatedByConstructionScript__Offset;
		public bool bCreatedByConstructionScript
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCreatedByConstructionScript__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int Slot__Offset;
		public UPanelSlot Slot
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Slot__Offset); if (v == IntPtr.Zero)return null; UPanelSlot retValue = new UPanelSlot(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Slot__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Slot__Offset, value._this.Get()); }
			
		}
		
		static readonly int bIsEnabled__Offset;
		public bool bIsEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsEnabled__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsEnabled__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ToolTipText__Offset;
		public string ToolTipText
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+ToolTipText__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+ToolTipText__Offset, false);}
			
		}
		
		static readonly int ToolTipWidget__Offset;
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
		public EMouseCursor Cursor
		{
			get{ CheckIsValid();return (EMouseCursor)Marshal.PtrToStructure(_this.Get()+Cursor__Offset, typeof(EMouseCursor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Cursor__Offset, false);}
			
		}
		
		static readonly int bIsVolatile__Offset;
		public bool bIsVolatile
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsVolatile__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsVolatile__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RenderTransform__Offset;
		public FWidgetTransform RenderTransform
		{
			get{ CheckIsValid();return (FWidgetTransform)Marshal.PtrToStructure(_this.Get()+RenderTransform__Offset, typeof(FWidgetTransform));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RenderTransform__Offset, false);}
			
		}
		
		static readonly int RenderTransformPivot__Offset;
		public FVector2D RenderTransformPivot
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+RenderTransformPivot__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RenderTransformPivot__Offset, false);}
			
		}
		
		static readonly int Navigation__Offset;
		public UWidgetNavigation Navigation
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Navigation__Offset); if (v == IntPtr.Zero)return null; UWidgetNavigation retValue = new UWidgetNavigation(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Navigation__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Navigation__Offset, value._this.Get()); }
			
		}
		
		static readonly int NativeBindings__Offset;
		public TObjectArray<UPropertyBinding>  NativeBindings
		{
					get{ CheckIsValid();return new TObjectArray<UPropertyBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NativeBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NativeBindings__Offset, false);}
			
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
			NativeBindings__Offset=GetPropertyOffset(NativeClassPtr,"NativeBindings");
			
		}
		
	}
	
}
#endif
#endif
