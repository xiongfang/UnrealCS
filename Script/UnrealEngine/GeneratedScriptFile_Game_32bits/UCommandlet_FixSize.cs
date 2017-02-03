#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCommandlet
	{
		static readonly int HelpDescription__Offset;
		public FString HelpDescription
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+HelpDescription__Offset, typeof(FString));}
			
		}
		
		static readonly int HelpUsage__Offset;
		public FString HelpUsage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+HelpUsage__Offset, typeof(FString));}
			
		}
		
		static readonly int HelpWebLink__Offset;
		public FString HelpWebLink
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+HelpWebLink__Offset, typeof(FString));}
			
		}
		
		static readonly int HelpParamNames__Offset;
		public TStructArray<FString> HelpParamNames
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HelpParamNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HelpParamNames__Offset, false);}
			
		}
		
		static readonly int HelpParamDescriptions__Offset;
		public TStructArray<FString> HelpParamDescriptions
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HelpParamDescriptions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HelpParamDescriptions__Offset, false);}
			
		}
		
		static readonly int IsServer__Offset;
		public bool IsServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsServer__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int IsClient__Offset;
		public bool IsClient
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsClient__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int IsEditor__Offset;
		public bool IsEditor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsEditor__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int LogToConsole__Offset;
		public bool LogToConsole
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), LogToConsole__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int ShowErrorCount__Offset;
		public bool ShowErrorCount
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ShowErrorCount__Offset, 1, 0, 16, 16);}
			
		}
		
		static UCommandlet()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Commandlet");
			HelpDescription__Offset=GetPropertyOffset(NativeClassPtr,"HelpDescription");
			HelpUsage__Offset=GetPropertyOffset(NativeClassPtr,"HelpUsage");
			HelpWebLink__Offset=GetPropertyOffset(NativeClassPtr,"HelpWebLink");
			HelpParamNames__Offset=GetPropertyOffset(NativeClassPtr,"HelpParamNames");
			HelpParamDescriptions__Offset=GetPropertyOffset(NativeClassPtr,"HelpParamDescriptions");
			IsServer__Offset=GetPropertyOffset(NativeClassPtr,"IsServer");
			IsClient__Offset=GetPropertyOffset(NativeClassPtr,"IsClient");
			IsEditor__Offset=GetPropertyOffset(NativeClassPtr,"IsEditor");
			LogToConsole__Offset=GetPropertyOffset(NativeClassPtr,"LogToConsole");
			ShowErrorCount__Offset=GetPropertyOffset(NativeClassPtr,"ShowErrorCount");
			
		}
		
	}
	
}
#endif
#endif
