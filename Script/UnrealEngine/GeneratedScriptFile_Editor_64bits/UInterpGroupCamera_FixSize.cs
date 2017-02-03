#if WITH_EDITOR
#if PLATFORM_64BITS
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
		
		static readonly int Target__Offset;
		/// <summary>
		/// this is interaction property info for CameraAnim
		/// this information isn't really saved with it
		/// </summary>
		public FCameraPreviewInfo Target
		{
			get{ CheckIsValid();return (FCameraPreviewInfo)Marshal.PtrToStructure(_this.Get()+Target__Offset, typeof(FCameraPreviewInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Target__Offset, false);}
			
		}
		
		static readonly int CompressTolerance__Offset;
		/// <summary>When compress, tolerance option *</summary>
		public float CompressTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CompressTolerance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompressTolerance__Offset, false);}
			
		}
		
		static UInterpGroupCamera()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpGroupCamera");
			CameraAnimInst__Offset=GetPropertyOffset(NativeClassPtr,"CameraAnimInst");
			Target__Offset=GetPropertyOffset(NativeClassPtr,"Target");
			CompressTolerance__Offset=GetPropertyOffset(NativeClassPtr,"CompressTolerance");
			
		}
		
	}
	
}
#endif
#endif
