#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single object bound to a UMG sequence.</summary>
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FWidgetAnimationBinding
	{
		[FieldOffset(0)]
		public FName WidgetName;
		[FieldOffset(12)]
		public FName SlotWidgetName;
		[FieldOffset(24)]
		public FGuid AnimationGuid;
		public bool bIsRootWidget
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 40, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 40, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
