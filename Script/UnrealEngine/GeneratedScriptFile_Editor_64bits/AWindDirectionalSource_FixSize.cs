#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Actor that provides a directional wind source. Only affects SpeedTree assets.</summary>
	public partial class AWindDirectionalSource
	{
		static readonly int Component__Offset;
		public UWindDirectionalSourceComponent Component
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Component__Offset); if (v == IntPtr.Zero)return null; UWindDirectionalSourceComponent retValue = new UWindDirectionalSourceComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Component__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Component__Offset, value._this.Get()); }
			
		}
		
		static readonly int ArrowComponent__Offset;
		public UArrowComponent ArrowComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowComponent__Offset); if (v == IntPtr.Zero)return null; UArrowComponent retValue = new UArrowComponent(); retValue._this = v; return retValue; }
			
		}
		
		static AWindDirectionalSource()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WindDirectionalSource");
			Component__Offset=GetPropertyOffset(NativeClassPtr,"Component");
			ArrowComponent__Offset=GetPropertyOffset(NativeClassPtr,"ArrowComponent");
			
		}
		
	}
	
}
#endif
#endif
