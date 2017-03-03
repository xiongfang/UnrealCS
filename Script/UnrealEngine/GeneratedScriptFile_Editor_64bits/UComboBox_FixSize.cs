#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
	public partial class UComboBox
	{
		static readonly int Items__Offset;
		/// <summary>The list of items to be displayed on the combobox.</summary>
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
