#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWidgetTree
	{
		static readonly int RootWidget__Offset;
		public UWidget RootWidget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RootWidget__Offset); if (v == IntPtr.Zero)return null; UWidget retValue = new UWidget(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AllWidgets__Offset;
		public TObjectArray<UWidget>  AllWidgets
		{
					get{ CheckIsValid();return new TObjectArray<UWidget>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AllWidgets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AllWidgets__Offset, false);}
			
		}
		
		static UWidgetTree()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WidgetTree");
			RootWidget__Offset=GetPropertyOffset(NativeClassPtr,"RootWidget");
			AllWidgets__Offset=GetPropertyOffset(NativeClassPtr,"AllWidgets");
			
		}
		
	}
	
}
#endif
#endif
