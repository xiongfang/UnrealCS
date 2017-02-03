#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPlatformInterfaceWebResponse
	{
		static readonly int OriginalURL__Offset;
		public FString OriginalURL
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+OriginalURL__Offset, typeof(FString));}
			
		}
		
		static readonly int ResponseCode__Offset;
		public int ResponseCode
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ResponseCode__Offset, typeof(int));}
			
		}
		
		static readonly int Tag__Offset;
		public int Tag
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Tag__Offset, typeof(int));}
			
		}
		
		static readonly int StringResponse__Offset;
		public FString StringResponse
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+StringResponse__Offset, typeof(FString));}
			
		}
		
		static readonly int BinaryResponse__Offset;
		public TStructArray<byte> BinaryResponse
		{
			get{ CheckIsValid();return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BinaryResponse__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BinaryResponse__Offset, false);}
			
		}
		
		static UPlatformInterfaceWebResponse()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlatformInterfaceWebResponse");
			OriginalURL__Offset=GetPropertyOffset(NativeClassPtr,"OriginalURL");
			ResponseCode__Offset=GetPropertyOffset(NativeClassPtr,"ResponseCode");
			Tag__Offset=GetPropertyOffset(NativeClassPtr,"Tag");
			StringResponse__Offset=GetPropertyOffset(NativeClassPtr,"StringResponse");
			BinaryResponse__Offset=GetPropertyOffset(NativeClassPtr,"BinaryResponse");
			
		}
		
	}
	
}
#endif
#endif
