#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=168)]
	public partial struct FAnimNotifyEvent
	{
		[FieldOffset(48)]
		public float DisplayTime;
		[FieldOffset(52)]
		public float TriggerTimeOffset;
		[FieldOffset(56)]
		public float EndTriggerTimeOffset;
		[FieldOffset(60)]
		public float TriggerWeightThreshold;
		[FieldOffset(64)]
		public FName NotifyName;
		[FieldOffset(88)]
		public float Duration;
		[FieldOffset(96)]
		public FAnimLinkableElement EndLink;
		public bool bConvertedFromBranchingPoint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 144, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 144, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(145)]
		public EMontageNotifyTickType MontageTickType;
		[FieldOffset(148)]
		public float NotifyTriggerChance;
		[FieldOffset(152)]
		public ENotifyFilterType NotifyFilterType;
		[FieldOffset(156)]
		public int NotifyFilterLOD;
		public bool bTriggerOnDedicatedServer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 160, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 160, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(164)]
		public int TrackIndex;
		[FieldOffset(16)]
		public int SlotIndex;
		[FieldOffset(20)]
		public int SegmentIndex;
		[FieldOffset(24)]
		public EAnimLinkMethod LinkMethod;
		[FieldOffset(25)]
		public EAnimLinkMethod CachedLinkMethod;
		[FieldOffset(28)]
		public float SegmentBeginTime;
		[FieldOffset(32)]
		public float SegmentLength;
		[FieldOffset(36)]
		public float LinkValue;
		
	}
	
}
#endif
#endif
