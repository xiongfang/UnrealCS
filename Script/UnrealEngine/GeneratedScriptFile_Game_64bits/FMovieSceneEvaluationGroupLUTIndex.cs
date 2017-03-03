#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FMovieSceneEvaluationGroupLUTIndex
	{
		public bool bRequiresImmediateFlush
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(4)]
		public int LUTOffset;
		[FieldOffset(8)]
		public int NumInitPtrs;
		[FieldOffset(12)]
		public int NumEvalPtrs;
		
	}
	
}
#endif
#endif
