#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AVectorFieldVolume
	{
		static readonly int VectorFieldComponent__Offset;
		public UVectorFieldComponent VectorFieldComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VectorFieldComponent__Offset); if (v == IntPtr.Zero)return null; UVectorFieldComponent retValue = new UVectorFieldComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + VectorFieldComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + VectorFieldComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static AVectorFieldVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VectorFieldVolume");
			VectorFieldComponent__Offset=GetPropertyOffset(NativeClassPtr,"VectorFieldComponent");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			
		}
		
	}
	
}
#endif
#endif
