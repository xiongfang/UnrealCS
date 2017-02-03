#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPlaneReflectionCaptureComponent
	{
		static readonly int InfluenceRadiusScale__Offset;
		public float InfluenceRadiusScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InfluenceRadiusScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InfluenceRadiusScale__Offset, false);}
			
		}
		
		static readonly int PreviewInfluenceRadius__Offset;
		public UDrawSphereComponent PreviewInfluenceRadius
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewInfluenceRadius__Offset); if (v == IntPtr.Zero)return null; UDrawSphereComponent retValue = new UDrawSphereComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PreviewCaptureBox__Offset;
		public UBoxComponent PreviewCaptureBox
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewCaptureBox__Offset); if (v == IntPtr.Zero)return null; UBoxComponent retValue = new UBoxComponent(); retValue._this = v; return retValue; }
			
		}
		
		static UPlaneReflectionCaptureComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlaneReflectionCaptureComponent");
			InfluenceRadiusScale__Offset=GetPropertyOffset(NativeClassPtr,"InfluenceRadiusScale");
			PreviewInfluenceRadius__Offset=GetPropertyOffset(NativeClassPtr,"PreviewInfluenceRadius");
			PreviewCaptureBox__Offset=GetPropertyOffset(NativeClassPtr,"PreviewCaptureBox");
			
		}
		
	}
	
}
#endif
#endif
