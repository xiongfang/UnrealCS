#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FEdGraphTerminalType
	{
		[FieldOffset(0)]
		public FString TerminalCategory;
		[FieldOffset(12)]
		public FString TerminalSubCategory;
		public bool bTerminalIsConst
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 255); } }}
			
		}
		public bool bTerminalIsWeakPointer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 33, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 33, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
