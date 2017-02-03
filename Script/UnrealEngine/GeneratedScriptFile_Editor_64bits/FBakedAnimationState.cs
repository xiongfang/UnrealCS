#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FBakedAnimationState
	{
		/// <summary>The name of this state</summary>
		[FieldOffset(0)]
		public FName StateName;
		/// <summary>Set of legal transitions out of this state; already in priority order</summary>
		public TStructArray<FBakedStateExitTransition> Transitions
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBakedStateExitTransition>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>The root node index (into the AnimNodeProperties array of the UAnimBlueprintGeneratedClass)</summary>
		[FieldOffset(32)]
		public int StateRootNodeIndex;
		[FieldOffset(36)]
		public int StartNotify;
		[FieldOffset(40)]
		public int EndNotify;
		[FieldOffset(44)]
		public int FullyBlendedNotify;
		public bool bIsAConduit
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(52)]
		public int EntryRuleNodeIndex;
		/// <summary>Indices into the property array for player nodes in the state</summary>
		public TStructArray<int> PlayerNodeIndices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+56, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+56, false);}}}
			
		}
		/// <summary>Whether or not this state will ALWAYS reset it's state on reentry, regardless of remaining weight</summary>
		public bool bAlwaysResetOnEntry
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 72, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 72, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
