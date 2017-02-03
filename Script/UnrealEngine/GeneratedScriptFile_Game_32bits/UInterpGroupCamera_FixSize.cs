#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpGroupCamera
	{
		static readonly int CameraAnimInst__Offset;
		public UCameraAnim CameraAnimInst
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraAnimInst__Offset); if (v == IntPtr.Zero)return null; UCameraAnim retValue = new UCameraAnim(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CompressTolerance__Offset;
		public float CompressTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CompressTolerance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompressTolerance__Offset, false);}
			
		}
		
		static UInterpGroupCamera()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpGroupCamera");
			CameraAnimInst__Offset=GetPropertyOffset(NativeClassPtr,"CameraAnimInst");
			CompressTolerance__Offset=GetPropertyOffset(NativeClassPtr,"CompressTolerance");
			
		}
		
	}
	
}
#endif
#endif
