#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FBakedAnimationStateMachine
	{
		[FieldOffset(0)]
		public FName MachineName;
		[FieldOffset(8)]
		public int InitialState;
		public TStructArray<FBakedAnimationState> States
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBakedAnimationState>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+12, false);}}}
			
		}
		public TStructArray<FAnimationTransitionBetweenStates> Transitions
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FAnimationTransitionBetweenStates>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+24, false);}}}
			
		}
		
	}
	
}
#endif
#endif
