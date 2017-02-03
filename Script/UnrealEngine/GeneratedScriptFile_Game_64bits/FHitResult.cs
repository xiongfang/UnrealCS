#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=136)]
	public partial struct FHitResult
	{
		public bool bBlockingHit
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		public bool bStartPenetrating
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		[FieldOffset(4)]
		public float Time;
		[FieldOffset(8)]
		public float Distance;
		[FieldOffset(12)]
		public FVector_NetQuantize Location;
		[FieldOffset(24)]
		public FVector_NetQuantize ImpactPoint;
		[FieldOffset(36)]
		public FVector_NetQuantizeNormal Normal;
		[FieldOffset(48)]
		public FVector_NetQuantizeNormal ImpactNormal;
		[FieldOffset(60)]
		public FVector_NetQuantize TraceStart;
		[FieldOffset(72)]
		public FVector_NetQuantize TraceEnd;
		[FieldOffset(84)]
		public float PenetrationDepth;
		[FieldOffset(88)]
		public int Item;
		[FieldOffset(120)]
		public FName BoneName;
		[FieldOffset(128)]
		public int FaceIndex;
		
	}
	
}
#endif
#endif
