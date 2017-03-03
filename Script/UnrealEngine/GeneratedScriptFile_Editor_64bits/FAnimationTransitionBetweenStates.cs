#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This represents a baked transition</summary>
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FAnimationTransitionBetweenStates
	{
		/// <summary>Transition-only: State being transitioned from</summary>
		[FieldOffset(12)]
		public int PreviousState;
		/// <summary>Transition-only: State being transitioned to</summary>
		[FieldOffset(16)]
		public int NextState;
		[FieldOffset(20)]
		public float CrossfadeDuration;
		[FieldOffset(24)]
		public int StartNotify;
		[FieldOffset(28)]
		public int EndNotify;
		[FieldOffset(32)]
		public int InterruptNotify;
		[FieldOffset(56)]
		public ETransitionLogicType LogicType;
		/// <summary>The name of this state</summary>
		[FieldOffset(0)]
		public FName StateName;
		
	}
	
}
#endif
#endif
