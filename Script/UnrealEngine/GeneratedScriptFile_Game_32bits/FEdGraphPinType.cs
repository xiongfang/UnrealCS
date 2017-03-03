#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FEdGraphPinType
	{
		[FieldOffset(0)]
		public FString PinCategory;
		[FieldOffset(12)]
		public FString PinSubCategory;
		[FieldOffset(32)]
		public FSimpleMemberReference PinSubCategoryMemberReference;
		[FieldOffset(60)]
		public FEdGraphTerminalType PinValueType;
		public bool bIsMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 96, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 96, 1, 0, 1, 255); } }}
			
		}
		public bool bIsSet
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 97, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 97, 1, 0, 1, 255); } }}
			
		}
		public bool bIsArray
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 98, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 98, 1, 0, 1, 255); } }}
			
		}
		public bool bIsReference
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 99, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 99, 1, 0, 1, 255); } }}
			
		}
		public bool bIsConst
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 100, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 100, 1, 0, 1, 255); } }}
			
		}
		public bool bIsWeakPointer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 101, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 101, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
