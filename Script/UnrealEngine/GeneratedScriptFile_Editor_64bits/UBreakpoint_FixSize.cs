#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBreakpoint
	{
		static readonly int bEnabled__Offset;
		/// <summary>Is the breakpoint currently enabled?</summary>
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int Node__Offset;
		/// <summary>Node that the breakpoint is placed on</summary>
		public UEdGraphNode Node
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Node__Offset); if (v == IntPtr.Zero)return null; UEdGraphNode retValue = new UEdGraphNode(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bStepOnce__Offset;
		/// <summary>Is this breakpoint auto-generated, and should be removed when next hit?</summary>
		public bool bStepOnce
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStepOnce__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bStepOnce_WasPreviouslyDisabled__Offset;
		public bool bStepOnce_WasPreviouslyDisabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStepOnce_WasPreviouslyDisabled__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bStepOnce_RemoveAfterHit__Offset;
		public bool bStepOnce_RemoveAfterHit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStepOnce_RemoveAfterHit__Offset, 1, 0, 4, 4);}
			
		}
		
		static UBreakpoint()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Breakpoint");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			Node__Offset=GetPropertyOffset(NativeClassPtr,"Node");
			bStepOnce__Offset=GetPropertyOffset(NativeClassPtr,"bStepOnce");
			bStepOnce_WasPreviouslyDisabled__Offset=GetPropertyOffset(NativeClassPtr,"bStepOnce_WasPreviouslyDisabled");
			bStepOnce_RemoveAfterHit__Offset=GetPropertyOffset(NativeClassPtr,"bStepOnce_RemoveAfterHit");
			
		}
		
	}
	
}
#endif
#endif
