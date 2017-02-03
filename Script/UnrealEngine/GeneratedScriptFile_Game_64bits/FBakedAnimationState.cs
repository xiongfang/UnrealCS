#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FBakedAnimationState
	{
		[FieldOffset(0)]
		public FName StateName;
		public TStructArray<FBakedStateExitTransition> Transitions
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBakedStateExitTransition>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+8, false);}}}
			
		}
		[FieldOffset(24)]
		public int StateRootNodeIndex;
		[FieldOffset(28)]
		public int StartNotify;
		[FieldOffset(32)]
		public int EndNotify;
		[FieldOffset(36)]
		public int FullyBlendedNotify;
		public bool bIsAConduit
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 40, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 40, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(44)]
		public int EntryRuleNodeIndex;
		public TStructArray<int> PlayerNodeIndices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+48, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+48, false);}}}
			
		}
		public bool bAlwaysResetOnEntry
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 64, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 64, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
