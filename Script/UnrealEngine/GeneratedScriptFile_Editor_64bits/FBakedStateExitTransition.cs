#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FBakedStateExitTransition
	{
		/// <summary>The node property index for this rule</summary>
		[FieldOffset(0)]
		public int CanTakeDelegateIndex;
		/// <summary>The blend graph result node index</summary>
		[FieldOffset(4)]
		public int CustomResultNodeIndex;
		/// <summary>The index into the machine table of transitions</summary>
		[FieldOffset(8)]
		public int TransitionIndex;
		/// <summary>What the transition rule node needs to return to take this transition (for bidirectional transitions)</summary>
		public bool bDesiredTransitionReturnValue
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Automatic Transition Rule based on animation remaining time.</summary>
		public bool bAutomaticRemainingTimeRule
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 1, 255); } }}
			
		}
		public TStructArray<int> PoseEvaluatorLinks
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
