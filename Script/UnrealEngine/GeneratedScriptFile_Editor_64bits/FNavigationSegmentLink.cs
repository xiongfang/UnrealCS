#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=120)]
	public partial struct FNavigationSegmentLink
	{
		[FieldOffset(72)]
		public FVector LeftStart;
		[FieldOffset(84)]
		public FVector LeftEnd;
		[FieldOffset(96)]
		public FVector RightStart;
		[FieldOffset(108)]
		public FVector RightEnd;
		/// <summary>if greater than 0 nav system will attempt to project navlink's start point on geometry below</summary>
		[FieldOffset(0)]
		public float LeftProjectHeight;
		/// <summary>if greater than 0 nav system will attempt to project navlink's end point on geometry below</summary>
		[FieldOffset(4)]
		public float MaxFallDownLength;
		[FieldOffset(8)]
		public ENavLinkDirection Direction;
		[FieldOffset(16)]
		public float SnapRadius;
		[FieldOffset(20)]
		public float SnapHeight;
		/// <summary>restrict area only to specified agents</summary>
		[FieldOffset(24)]
		public FNavAgentSelector SupportedAgents;
		/// <summary>DEPRECATED AGENT CONFIG</summary>
		public bool bSupportsAgent0
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 1, 1); } }}
			
		}
		public bool bSupportsAgent1
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 2, 2); } }}
			
		}
		public bool bSupportsAgent2
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 4, 4); } }}
			
		}
		public bool bSupportsAgent3
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 8, 8); } }}
			
		}
		public bool bSupportsAgent4
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 16, 16); } }}
			
		}
		public bool bSupportsAgent5
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 32, 32); } }}
			
		}
		public bool bSupportsAgent6
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 64, 64); } }}
			
		}
		public bool bSupportsAgent7
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 128, 128); } }}
			
		}
		public bool bSupportsAgent8
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 29, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 29, 1, 0, 1, 1); } }}
			
		}
		public bool bSupportsAgent9
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 29, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 29, 1, 0, 2, 2); } }}
			
		}
		public bool bSupportsAgent10
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 29, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 29, 1, 0, 4, 4); } }}
			
		}
		public bool bSupportsAgent11
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 29, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 29, 1, 0, 8, 8); } }}
			
		}
		public bool bSupportsAgent12
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 29, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 29, 1, 0, 16, 16); } }}
			
		}
		public bool bSupportsAgent13
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 29, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 29, 1, 0, 32, 32); } }}
			
		}
		public bool bSupportsAgent14
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 29, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 29, 1, 0, 64, 64); } }}
			
		}
		public bool bSupportsAgent15
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 29, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 29, 1, 0, 128, 128); } }}
			
		}
		/// <summary>this is an editor-only property to put descriptions in navlinks setup, to be able to identify it easier</summary>
		[FieldOffset(32)]
		public FString Description;
		/// <summary>WITH_EDITORONLY_DATA</summary>
		public bool bUseSnapHeight
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If set, link will try to snap to cheapest area in given radius</summary>
		public bool bSnapToCheapestArea
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 2, 2); } }}
			
		}
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag0
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 4, 4); } }}
			
		}
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag1
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 8, 8); } }}
			
		}
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag2
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 16, 16); } }}
			
		}
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag3
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 32, 32); } }}
			
		}
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag4
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 64, 64); } }}
			
		}
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag5
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 128, 128); } }}
			
		}
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag6
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 49, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 49, 1, 0, 1, 1); } }}
			
		}
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag7
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 49, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 49, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Area type of this link (empty = default)</summary>
		
	}
	
}
#endif
#endif
