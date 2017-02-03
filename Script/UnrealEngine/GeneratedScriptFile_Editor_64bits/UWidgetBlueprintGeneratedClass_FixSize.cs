#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The widget blueprint generated class allows us to create blueprint-able widgets for UMG at runtime.
	/// All WBPGC's are of UUserWidget classes, and they perform special post initialization using this class
	/// to give themselves many of the same capabilities as AActor blueprints, like dynamic delegate binding for
	/// widgets.
	/// </summary>
	public partial class UWidgetBlueprintGeneratedClass
	{
		static readonly int WidgetTree__Offset;
		/// <summary>A tree of the widget templates to be created</summary>
		public UWidgetTree WidgetTree
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WidgetTree__Offset); if (v == IntPtr.Zero)return null; UWidgetTree retValue = new UWidgetTree(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Bindings__Offset;
		public TStructArray<FDelegateRuntimeBinding> Bindings
		{
			get{ CheckIsValid();return new TStructArray<FDelegateRuntimeBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Bindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Bindings__Offset, false);}
			
		}
		
		static readonly int Animations__Offset;
		public TObjectArray<UWidgetAnimation>  Animations
		{
					get{ CheckIsValid();return new TObjectArray<UWidgetAnimation>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Animations__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Animations__Offset, false);}
			
		}
		
		static readonly int NamedSlots__Offset;
		public TStructArray<FName> NamedSlots
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NamedSlots__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NamedSlots__Offset, false);}
			
		}
		
		static readonly int bCanEverTick__Offset;
		public bool bCanEverTick
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanEverTick__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bCanEverPaint__Offset;
		public bool bCanEverPaint
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanEverPaint__Offset, 1, 0, 2, 2);}
			
		}
		
		static UWidgetBlueprintGeneratedClass()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WidgetBlueprintGeneratedClass");
			WidgetTree__Offset=GetPropertyOffset(NativeClassPtr,"WidgetTree");
			Bindings__Offset=GetPropertyOffset(NativeClassPtr,"Bindings");
			Animations__Offset=GetPropertyOffset(NativeClassPtr,"Animations");
			NamedSlots__Offset=GetPropertyOffset(NativeClassPtr,"NamedSlots");
			bCanEverTick__Offset=GetPropertyOffset(NativeClassPtr,"bCanEverTick");
			bCanEverPaint__Offset=GetPropertyOffset(NativeClassPtr,"bCanEverPaint");
			
		}
		
	}
	
}
#endif
#endif
