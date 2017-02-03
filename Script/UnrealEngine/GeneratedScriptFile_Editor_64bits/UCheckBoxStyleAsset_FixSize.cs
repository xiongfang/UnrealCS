#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// An asset describing a CheckBox's appearance.
	/// Just a wrapper for the struct with real data in it.
	/// </summary>
	public partial class UCheckBoxStyleAsset
	{
		static readonly int CheckBoxStyle__Offset;
		/// <summary>The actual data describing the Check Box's appearance.</summary>
		public FCheckBoxStyle CheckBoxStyle
		{
			get{ CheckIsValid();return (FCheckBoxStyle)Marshal.PtrToStructure(_this.Get()+CheckBoxStyle__Offset, typeof(FCheckBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CheckBoxStyle__Offset, false);}
			
		}
		
		static UCheckBoxStyleAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CheckBoxStyleAsset");
			CheckBoxStyle__Offset=GetPropertyOffset(NativeClassPtr,"CheckBoxStyle");
			
		}
		
	}
	
}
#endif
#endif
