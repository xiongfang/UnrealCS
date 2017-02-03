#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FEdGraphPinType
	{
		[FieldOffset(0)]
		public FString PinCategory;
		[FieldOffset(12)]
		public FString PinSubCategory;
		[FieldOffset(32)]
		public FSimpleMemberReference PinSubCategoryMemberReference;
		public bool bIsArray
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 64, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 64, 1, 0, 1, 255); } }}
			
		}
		public bool bIsReference
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 65, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 65, 1, 0, 1, 255); } }}
			
		}
		public bool bIsConst
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 66, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 66, 1, 0, 1, 255); } }}
			
		}
		public bool bIsWeakPointer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 67, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 67, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
