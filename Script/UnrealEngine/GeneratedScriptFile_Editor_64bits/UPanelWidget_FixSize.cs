#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The base class for all UMG panel widgets.  Panel widgets layout a collection of child widgets.</summary>
	public partial class UPanelWidget
	{
		static readonly int Slots__Offset;
		/// <summary>The slots in the widget holding the child widgets of this panel.</summary>
		public TObjectArray<UPanelSlot>  Slots
		{
					get{ CheckIsValid();return new TObjectArray<UPanelSlot>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Slots__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Slots__Offset, false);}
			
		}
		
		static UPanelWidget()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PanelWidget");
			Slots__Offset=GetPropertyOffset(NativeClassPtr,"Slots");
			
		}
		
	}
	
}
#endif
#endif
