#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A basic command line console that accepts most commands.</summary>
	public partial class UConsole
	{
		static readonly int ConsoleTargetPlayer__Offset;
		/// <summary>The player which the next console command should be executed in the context of.  If nullptr, execute in the viewport.</summary>
		public ULocalPlayer ConsoleTargetPlayer
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConsoleTargetPlayer__Offset); if (v == IntPtr.Zero)return null; ULocalPlayer retValue = new ULocalPlayer(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultTexture_Black__Offset;
		public UTexture2D DefaultTexture_Black
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultTexture_Black__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultTexture_White__Offset;
		public UTexture2D DefaultTexture_White
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultTexture_White__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int HistoryBuffer__Offset;
		/// <summary>Holds the history buffer, order is old to new</summary>
		public TStructArray<FString> HistoryBuffer
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HistoryBuffer__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HistoryBuffer__Offset, false);}
			
		}
		
		static UConsole()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Console");
			ConsoleTargetPlayer__Offset=GetPropertyOffset(NativeClassPtr,"ConsoleTargetPlayer");
			DefaultTexture_Black__Offset=GetPropertyOffset(NativeClassPtr,"DefaultTexture_Black");
			DefaultTexture_White__Offset=GetPropertyOffset(NativeClassPtr,"DefaultTexture_White");
			HistoryBuffer__Offset=GetPropertyOffset(NativeClassPtr,"HistoryBuffer");
			
		}
		
	}
	
}
#endif
#endif
