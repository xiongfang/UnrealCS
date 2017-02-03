#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FBakedAnimationStateMachine
	{
		[FieldOffset(0)]
		public FName MachineName;
		[FieldOffset(8)]
		public int InitialState;
		public TStructArray<FBakedAnimationState> States
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBakedAnimationState>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		public TStructArray<FAnimationTransitionBetweenStates> Transitions
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FAnimationTransitionBetweenStates>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
