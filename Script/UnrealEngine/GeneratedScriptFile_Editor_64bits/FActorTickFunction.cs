#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Tick function that calls AActor::TickActor</summary>
	[StructLayout(LayoutKind.Explicit,Size=88)]
	public partial struct FActorTickFunction
	{
		/// <summary>
		/// Defines the minimum tick group for this tick function. These groups determine the relative order of when objects tick during a frame update.
		/// Given prerequisites, the tick may be delayed.
		/// @see ETickingGroup
		/// @see FTickFunction::AddPrerequisite()
		/// </summary>
		[FieldOffset(8)]
		public ETickingGroup TickGroup;
		/// <summary>
		/// Defines the tick group that this tick function must finish in. These groups determine the relative order of when objects tick during a frame update.
		/// @see ETickingGroup
		/// </summary>
		[FieldOffset(9)]
		public ETickingGroup EndTickGroup;
		/// <summary>Bool indicating that this function should execute even if the game is paused. Pause ticks are very limited in capabilities. *</summary>
		public bool bTickEvenWhenPaused
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If false, this tick function will never be registered and will never tick. Only settable in defaults.</summary>
		public bool bCanEverTick
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 2, 2); } }}
			
		}
		/// <summary>If true, this tick function will start enabled, but can be disabled later on.</summary>
		public bool bStartWithTickEnabled
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 4, 4); } }}
			
		}
		/// <summary>If we allow this tick to run on a dedicated server</summary>
		public bool bAllowTickOnDedicatedServer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 8, 8); } }}
			
		}
		/// <summary>The frequency in seconds at which this tick function will be executed.  If less than or equal to 0 then it will tick every frame</summary>
		[FieldOffset(64)]
		public float TickInterval;
		
	}
	
}
#endif
#endif
