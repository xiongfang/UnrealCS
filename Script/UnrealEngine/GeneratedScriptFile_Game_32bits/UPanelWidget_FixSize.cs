#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPanelWidget
	{
		static readonly int Slots__Offset;
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
