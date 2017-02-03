#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FNavigationFilterArea
	{
		/// <summary>navigation area class</summary>
		/// <summary>override for travel cost</summary>
		[FieldOffset(8)]
		public float TravelCostOverride;
		/// <summary>override for entering cost</summary>
		[FieldOffset(12)]
		public float EnteringCostOverride;
		/// <summary>mark as excluded</summary>
		public bool bIsExcluded
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		public bool bOverrideTravelCost
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 2, 2); } }}
			
		}
		public bool bOverrideEnteringCost
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 4, 4); } }}
			
		}
		
	}
	
}
#endif
#endif
