#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FBakedAnimationStateMachine
	{
		/// <summary>Name of this machine (primarily for debugging purposes)</summary>
		[FieldOffset(0)]
		public FName MachineName;
		/// <summary>Index of the initial state that the machine will start in</summary>
		[FieldOffset(12)]
		public int InitialState;
		/// <summary>List of all states this machine can be in</summary>
		public TStructArray<FBakedAnimationState> States
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBakedAnimationState>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>List of all transitions between states</summary>
		public TStructArray<FAnimationTransitionBetweenStates> Transitions
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FAnimationTransitionBetweenStates>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
