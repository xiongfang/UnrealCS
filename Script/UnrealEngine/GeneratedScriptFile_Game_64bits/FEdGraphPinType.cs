#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FEdGraphPinType
	{
		[FieldOffset(0)]
		public FString PinCategory;
		[FieldOffset(16)]
		public FString PinSubCategory;
		[FieldOffset(40)]
		public FSimpleMemberReference PinSubCategoryMemberReference;
		public bool bIsArray
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 72, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 72, 1, 0, 1, 255); } }}
			
		}
		public bool bIsReference
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 73, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 73, 1, 0, 1, 255); } }}
			
		}
		public bool bIsConst
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 74, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 74, 1, 0, 1, 255); } }}
			
		}
		public bool bIsWeakPointer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 75, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 75, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
