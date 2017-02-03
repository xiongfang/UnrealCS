#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FDestructibleDamageParameters
	{
		[FieldOffset(0)]
		public float DamageThreshold;
		[FieldOffset(4)]
		public float DamageSpread;
		public bool bEnableImpactDamage
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(12)]
		public float ImpactDamage;
		[FieldOffset(16)]
		public int DefaultImpactDamageDepth;
		public bool bCustomImpactResistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(24)]
		public float ImpactResistance;
		
	}
	
}
#endif
#endif
