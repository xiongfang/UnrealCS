#if WITH_GAME
#if PLATFORM_32BITS
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
		
		static readonly int bIsFocusable__Offset;
		public bool bIsFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFocusable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsFocusable__Offset, 1,0,1,255);}
			
		}
		
		static UComboBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ComboBox");
			Items__Offset=GetPropertyOffset(NativeClassPtr,"Items");
			bIsFocusable__Offset=GetPropertyOffset(NativeClassPtr,"bIsFocusable");
			
		}
		
	}
	
}
#endif
#endif
