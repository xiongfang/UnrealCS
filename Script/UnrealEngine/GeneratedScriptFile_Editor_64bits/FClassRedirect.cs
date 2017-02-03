#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=88)]
	public partial struct FClassRedirect
	{
		[FieldOffset(0)]
		public FName ObjectName;
		[FieldOffset(12)]
		public FName OldClassName;
		[FieldOffset(24)]
		public FName NewClassName;
		[FieldOffset(36)]
		public FName OldSubobjName;
		[FieldOffset(48)]
		public FName NewSubobjName;
		[FieldOffset(60)]
		public FName NewClassClass;
		[FieldOffset(72)]
		public FName NewClassPackage;
		public bool InstanceOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 84, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 84, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
