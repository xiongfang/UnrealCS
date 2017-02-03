#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UComboBox
	{
		static readonly int Items__Offset;
		public TObjectArray<UObject>  Items
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Items__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Items__Offset, false);}
			
		}
		
		static UComboBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ComboBox");
			Items__Offset=GetPropertyOffset(NativeClassPtr,"Items");
			
		}
		
	}
	
}
#endif
#endif
