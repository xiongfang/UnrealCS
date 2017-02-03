#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FClassRedirect
	{
		[FieldOffset(0)]
		public FName ObjectName;
		[FieldOffset(8)]
		public FName OldClassName;
		[FieldOffset(16)]
		public FName NewClassName;
		[FieldOffset(24)]
		public FName OldSubobjName;
		[FieldOffset(32)]
		public FName NewSubobjName;
		[FieldOffset(40)]
		public FName NewClassClass;
		[FieldOffset(48)]
		public FName NewClassPackage;
		public bool InstanceOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
