#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FCollisionResponseContainer
	{
		[FieldOffset(0)]
		public ECollisionResponse WorldStatic;
		[FieldOffset(1)]
		public ECollisionResponse WorldDynamic;
		[FieldOffset(2)]
		public ECollisionResponse Pawn;
		[FieldOffset(3)]
		public ECollisionResponse Visibility;
		[FieldOffset(4)]
		public ECollisionResponse Camera;
		[FieldOffset(5)]
		public ECollisionResponse PhysicsBody;
		[FieldOffset(6)]
		public ECollisionResponse Vehicle;
		[FieldOffset(7)]
		public ECollisionResponse Destructible;
		[FieldOffset(8)]
		public ECollisionResponse EngineTraceChannel1;
		[FieldOffset(9)]
		public ECollisionResponse EngineTraceChannel2;
		[FieldOffset(10)]
		public ECollisionResponse EngineTraceChannel3;
		[FieldOffset(11)]
		public ECollisionResponse EngineTraceChannel4;
		[FieldOffset(12)]
		public ECollisionResponse EngineTraceChannel5;
		[FieldOffset(13)]
		public ECollisionResponse EngineTraceChannel6;
		[FieldOffset(14)]
		public ECollisionResponse GameTraceChannel1;
		[FieldOffset(15)]
		public ECollisionResponse GameTraceChannel2;
		[FieldOffset(16)]
		public ECollisionResponse GameTraceChannel3;
		[FieldOffset(17)]
		public ECollisionResponse GameTraceChannel4;
		[FieldOffset(18)]
		public ECollisionResponse GameTraceChannel5;
		[FieldOffset(19)]
		public ECollisionResponse GameTraceChannel6;
		[FieldOffset(20)]
		public ECollisionResponse GameTraceChannel7;
		[FieldOffset(21)]
		public ECollisionResponse GameTraceChannel8;
		[FieldOffset(22)]
		public ECollisionResponse GameTraceChannel9;
		[FieldOffset(23)]
		public ECollisionResponse GameTraceChannel10;
		[FieldOffset(24)]
		public ECollisionResponse GameTraceChannel11;
		[FieldOffset(25)]
		public ECollisionResponse GameTraceChannel12;
		[FieldOffset(26)]
		public ECollisionResponse GameTraceChannel13;
		[FieldOffset(27)]
		public ECollisionResponse GameTraceChannel14;
		[FieldOffset(28)]
		public ECollisionResponse GameTraceChannel15;
		[FieldOffset(29)]
		public ECollisionResponse GameTraceChannel16;
		[FieldOffset(30)]
		public ECollisionResponse GameTraceChannel17;
		[FieldOffset(31)]
		public ECollisionResponse GameTraceChannel18;
		
	}
	
}
#endif
#endif
