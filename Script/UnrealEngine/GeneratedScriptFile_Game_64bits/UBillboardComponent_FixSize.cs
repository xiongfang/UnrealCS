#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBillboardComponent
	{
		static readonly int Sprite__Offset;
		public UTexture2D Sprite
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Sprite__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Sprite__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Sprite__Offset, value._this.Get()); }
			
		}
		
		static readonly int bIsScreenSizeScaled__Offset;
		public bool bIsScreenSizeScaled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsScreenSizeScaled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsScreenSizeScaled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int ScreenSize__Offset;
		public float ScreenSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ScreenSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScreenSize__Offset, false);}
			
		}
		
		static readonly int U__Offset;
		public float U
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+U__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+U__Offset, false);}
			
		}
		
		static readonly int UL__Offset;
		public float UL
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UL__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UL__Offset, false);}
			
		}
		
		static readonly int V__Offset;
		public float V
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+V__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+V__Offset, false);}
			
		}
		
		static readonly int VL__Offset;
		public float VL
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VL__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VL__Offset, false);}
			
		}
		
		static UBillboardComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BillboardComponent");
			Sprite__Offset=GetPropertyOffset(NativeClassPtr,"Sprite");
			bIsScreenSizeScaled__Offset=GetPropertyOffset(NativeClassPtr,"bIsScreenSizeScaled");
			ScreenSize__Offset=GetPropertyOffset(NativeClassPtr,"ScreenSize");
			U__Offset=GetPropertyOffset(NativeClassPtr,"U");
			UL__Offset=GetPropertyOffset(NativeClassPtr,"UL");
			V__Offset=GetPropertyOffset(NativeClassPtr,"V");
			VL__Offset=GetPropertyOffset(NativeClassPtr,"VL");
			
		}
		
	}
	
}
#endif
#endif
