#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Sample data</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FBlendSample
	{
		/// <summary>blend 0->x, blend 1->y, blend 2->z</summary>
		[FieldOffset(8)]
		public FVector SampleValue;
		[FieldOffset(20)]
		public float RateScale;
		public bool bIsValid
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
