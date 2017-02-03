#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpCurveEdSetup
	{
		static readonly int Tabs__Offset;
		public TStructArray<FCurveEdTab> Tabs
		{
			get{ CheckIsValid();return new TStructArray<FCurveEdTab>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Tabs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Tabs__Offset, false);}
			
		}
		
		static readonly int ActiveTab__Offset;
		public int ActiveTab
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ActiveTab__Offset, typeof(int));}
			
		}
		
		static UInterpCurveEdSetup()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpCurveEdSetup");
			Tabs__Offset=GetPropertyOffset(NativeClassPtr,"Tabs");
			ActiveTab__Offset=GetPropertyOffset(NativeClassPtr,"ActiveTab");
			
		}
		
	}
	
}
#endif
#endif
