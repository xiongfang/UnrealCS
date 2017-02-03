#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// An asset describing a button's appearance.
	/// Just a wrapper for the struct with real data in it.style factory
	/// </summary>
	public partial class UButtonStyleAsset
	{
		static readonly int ButtonStyle__Offset;
		/// <summary>The actual data describing the button's appearance.</summary>
		public FButtonStyle ButtonStyle
		{
			get{ CheckIsValid();return (FButtonStyle)Marshal.PtrToStructure(_this.Get()+ButtonStyle__Offset, typeof(FButtonStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ButtonStyle__Offset, false);}
			
		}
		
		static UButtonStyleAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ButtonStyleAsset");
			ButtonStyle__Offset=GetPropertyOffset(NativeClassPtr,"ButtonStyle");
			
		}
		
	}
	
}
#endif
#endif
