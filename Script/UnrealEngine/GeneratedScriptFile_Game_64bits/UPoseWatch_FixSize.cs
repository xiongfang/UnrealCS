#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPoseWatch
	{
		static readonly int Node__Offset;
		public UEdGraphNode Node
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Node__Offset); if (v == IntPtr.Zero)return null; UEdGraphNode retValue = new UEdGraphNode(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PoseWatchColour__Offset;
		public FColor PoseWatchColour
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+PoseWatchColour__Offset, typeof(FColor));}
			
		}
		
		static UPoseWatch()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PoseWatch");
			Node__Offset=GetPropertyOffset(NativeClassPtr,"Node");
			PoseWatchColour__Offset=GetPropertyOffset(NativeClassPtr,"PoseWatchColour");
			
		}
		
	}
	
}
#endif
#endif
