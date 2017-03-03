#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FAnimationTransitionBetweenStates
	{
		[FieldOffset(8)]
		public int PreviousState;
		[FieldOffset(12)]
		public int NextState;
		[FieldOffset(16)]
		public float CrossfadeDuration;
		[FieldOffset(20)]
		public int StartNotify;
		[FieldOffset(24)]
		public int EndNotify;
		[FieldOffset(28)]
		public int InterruptNotify;
		[FieldOffset(56)]
		public ETransitionLogicType LogicType;
		[FieldOffset(0)]
		public FName StateName;
		
	}
	
}
#endif
#endif
