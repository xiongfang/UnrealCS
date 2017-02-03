#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FNode
	{
		[FieldOffset(0)]
		public FName Name;
		[FieldOffset(8)]
		public FName ParentName;
		[FieldOffset(16)]
		public FTransform Transform;
		[FieldOffset(64)]
		public FString DisplayName;
		public bool bAdvanced
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 76, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 76, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
