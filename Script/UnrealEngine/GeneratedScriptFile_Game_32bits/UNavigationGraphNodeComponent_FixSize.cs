#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavigationGraphNodeComponent
	{
		static readonly int Node__Offset;
		public FNavGraphNode Node
		{
			get{ CheckIsValid();return (FNavGraphNode)Marshal.PtrToStructure(_this.Get()+Node__Offset, typeof(FNavGraphNode));}
			
		}
		
		static readonly int NextNodeComponent__Offset;
		public UNavigationGraphNodeComponent NextNodeComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NextNodeComponent__Offset); if (v == IntPtr.Zero)return null; UNavigationGraphNodeComponent retValue = new UNavigationGraphNodeComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PrevNodeComponent__Offset;
		public UNavigationGraphNodeComponent PrevNodeComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PrevNodeComponent__Offset); if (v == IntPtr.Zero)return null; UNavigationGraphNodeComponent retValue = new UNavigationGraphNodeComponent(); retValue._this = v; return retValue; }
			
		}
		
		static UNavigationGraphNodeComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavigationGraphNodeComponent");
			Node__Offset=GetPropertyOffset(NativeClassPtr,"Node");
			NextNodeComponent__Offset=GetPropertyOffset(NativeClassPtr,"NextNodeComponent");
			PrevNodeComponent__Offset=GetPropertyOffset(NativeClassPtr,"PrevNodeComponent");
			
		}
		
	}
	
}
#endif
#endif
