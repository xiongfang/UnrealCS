#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USphereReflectionCaptureComponent
	{
		static readonly int InfluenceRadius__Offset;
		public float InfluenceRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InfluenceRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InfluenceRadius__Offset, false);}
			
		}
		
		static readonly int CaptureDistanceScale__Offset;
		public float CaptureDistanceScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CaptureDistanceScale__Offset, typeof(float));}
			
		}
		
		static readonly int PreviewInfluenceRadius__Offset;
		public UDrawSphereComponent PreviewInfluenceRadius
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewInfluenceRadius__Offset); if (v == IntPtr.Zero)return null; UDrawSphereComponent retValue = new UDrawSphereComponent(); retValue._this = v; return retValue; }
			
		}
		
		static USphereReflectionCaptureComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SphereReflectionCaptureComponent");
			InfluenceRadius__Offset=GetPropertyOffset(NativeClassPtr,"InfluenceRadius");
			CaptureDistanceScale__Offset=GetPropertyOffset(NativeClassPtr,"CaptureDistanceScale");
			PreviewInfluenceRadius__Offset=GetPropertyOffset(NativeClassPtr,"PreviewInfluenceRadius");
			
		}
		
	}
	
}
#endif
#endif
