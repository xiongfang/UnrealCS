#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=60)]
	public partial struct FBakedAnimationState
	{
		[FieldOffset(0)]
		public FName StateName;
		public TStructArray<FBakedStateExitTransition> Transitions
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBakedStateExitTransition>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+8, false);}}}
			
		}
		[FieldOffset(20)]
		public int StateRootNodeIndex;
		[FieldOffset(24)]
		public int StartNotify;
		[FieldOffset(28)]
		public int EndNotify;
		[FieldOffset(32)]
		public int FullyBlendedNotify;
		public bool bIsAConduit
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 36, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 36, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(40)]
		public int EntryRuleNodeIndex;
		public TStructArray<int> PlayerNodeIndices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+44, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+44, false);}}}
			
		}
		public bool bAlwaysResetOnEntry
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
