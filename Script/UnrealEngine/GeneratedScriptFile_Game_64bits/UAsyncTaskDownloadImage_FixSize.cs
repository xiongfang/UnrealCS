#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAsyncTaskDownloadImage
	{
		static readonly int OnSuccess__Offset;
		public FMulticastScriptDelegate OnSuccess
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnSuccess__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnSuccess__Offset, false);}
			
		}
		
		static readonly int OnFail__Offset;
		public FMulticastScriptDelegate OnFail
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnFail__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnFail__Offset, false);}
			
		}
		
		static UAsyncTaskDownloadImage()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AsyncTaskDownloadImage");
			OnSuccess__Offset=GetPropertyOffset(NativeClassPtr,"OnSuccess");
			OnFail__Offset=GetPropertyOffset(NativeClassPtr,"OnFail");
			
		}
		
	}
	
}
#endif
#endif
