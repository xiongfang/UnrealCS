#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCommandlet
	{
		static readonly int HelpDescription__Offset;
		/// <summary>Description of the commandlet's purpose</summary>
		public FString HelpDescription
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+HelpDescription__Offset, typeof(FString));}
			
		}
		
		static readonly int HelpUsage__Offset;
		/// <summary>Usage template to show for "ucc help"</summary>
		public FString HelpUsage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+HelpUsage__Offset, typeof(FString));}
			
		}
		
		static readonly int HelpWebLink__Offset;
		/// <summary>Hyperlink for more info</summary>
		public FString HelpWebLink
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+HelpWebLink__Offset, typeof(FString));}
			
		}
		
		static readonly int HelpParamNames__Offset;
		/// <summary>The name of the parameter the commandlet takes</summary>
		public TStructArray<FString> HelpParamNames
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HelpParamNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HelpParamNames__Offset, false);}
			
		}
		
		static readonly int HelpParamDescriptions__Offset;
		/// <summary>The description of the parameter</summary>
		public TStructArray<FString> HelpParamDescriptions
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HelpParamDescriptions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HelpParamDescriptions__Offset, false);}
			
		}
		
		static readonly int IsServer__Offset;
		/// <summary>
		/// Whether to load objects required in server, client, and editor context.  If IsEditor is set to false, then a
		/// UGameEngine (or whatever the value of /Script/Engine.Engine.GameEngine is) will be created for the commandlet instead
		/// of a UEditorEngine (or /Script/Engine.Engine.EditorEngine), unless the commandlet overrides the CreateCustomEngine method.
		/// </summary>
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
		/// <summary>Whether to redirect standard log to the console</summary>
		public bool LogToConsole
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), LogToConsole__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int ShowErrorCount__Offset;
		/// <summary>Whether to show standard error and warning count on exit</summary>
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
