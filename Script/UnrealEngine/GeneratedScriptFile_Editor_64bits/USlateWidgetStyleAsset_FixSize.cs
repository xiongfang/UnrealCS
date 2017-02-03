#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Just a wrapper for the struct with real data in it.</summary>
	public partial class USlateWidgetStyleAsset
	{
		static readonly int CustomStyle__Offset;
		public USlateWidgetStyleContainerBase CustomStyle
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CustomStyle__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleContainerBase retValue = new USlateWidgetStyleContainerBase(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CustomStyle__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CustomStyle__Offset, value._this.Get()); }
			
		}
		
		static USlateWidgetStyleAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SlateWidgetStyleAsset");
			CustomStyle__Offset=GetPropertyOffset(NativeClassPtr,"CustomStyle");
			
		}
		
	}
	
}
#endif
#endif
