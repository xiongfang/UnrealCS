#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCameraModifier
	{
		static readonly int bDebug__Offset;
		public bool bDebug
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDebug__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDebug__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bExclusive__Offset;
		public bool bExclusive
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bExclusive__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bExclusive__Offset, 1,0,2,2);}
			
		}
		
		static readonly int Priority__Offset;
		public byte Priority
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(byte));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int CameraOwner__Offset;
		public APlayerCameraManager CameraOwner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraOwner__Offset); if (v == IntPtr.Zero)return null; APlayerCameraManager retValue = new APlayerCameraManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AlphaInTime__Offset;
		public float AlphaInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AlphaInTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaInTime__Offset, false);}
			
		}
		
		static readonly int AlphaOutTime__Offset;
		public float AlphaOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AlphaOutTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaOutTime__Offset, false);}
			
		}
		
		static readonly int Alpha__Offset;
		public float Alpha
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Alpha__Offset, typeof(float));}
			
		}
		
		static UCameraModifier()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraModifier");
			bDebug__Offset=GetPropertyOffset(NativeClassPtr,"bDebug");
			bExclusive__Offset=GetPropertyOffset(NativeClassPtr,"bExclusive");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			CameraOwner__Offset=GetPropertyOffset(NativeClassPtr,"CameraOwner");
			AlphaInTime__Offset=GetPropertyOffset(NativeClassPtr,"AlphaInTime");
			AlphaOutTime__Offset=GetPropertyOffset(NativeClassPtr,"AlphaOutTime");
			Alpha__Offset=GetPropertyOffset(NativeClassPtr,"Alpha");
			
		}
		
	}
	
}
#endif
#endif
