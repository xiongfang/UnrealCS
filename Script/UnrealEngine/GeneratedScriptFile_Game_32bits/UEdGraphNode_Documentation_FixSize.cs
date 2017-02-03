#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEdGraphNode_Documentation
	{
		static readonly int Link__Offset;
		public FString Link
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Link__Offset, typeof(FString));}
			
		}
		
		static readonly int Excerpt__Offset;
		public FString Excerpt
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Excerpt__Offset, typeof(FString));}
			
		}
		
		static UEdGraphNode_Documentation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EdGraphNode_Documentation");
			Link__Offset=GetPropertyOffset(NativeClassPtr,"Link");
			Excerpt__Offset=GetPropertyOffset(NativeClassPtr,"Excerpt");
			
		}
		
	}
	
}
#endif
#endif
