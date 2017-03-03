#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=132)]
	public partial struct FAnimNotifyEvent
	{
		[FieldOffset(36)]
		public float DisplayTime;
		[FieldOffset(40)]
		public float TriggerTimeOffset;
		[FieldOffset(44)]
		public float EndTriggerTimeOffset;
		[FieldOffset(48)]
		public float TriggerWeightThreshold;
		[FieldOffset(52)]
		public FName NotifyName;
		[FieldOffset(68)]
		public float Duration;
		[FieldOffset(72)]
		public FAnimLinkableElement EndLink;
		public bool bConvertedFromBranchingPoint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(109)]
		public EMontageNotifyTickType MontageTickType;
		[FieldOffset(112)]
		public float NotifyTriggerChance;
		[FieldOffset(116)]
		public ENotifyFilterType NotifyFilterType;
		[FieldOffset(120)]
		public int NotifyFilterLOD;
		public bool bTriggerOnDedicatedServer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(128)]
		public int TrackIndex;
		[FieldOffset(8)]
		public int SlotIndex;
		[FieldOffset(12)]
		public int SegmentIndex;
		[FieldOffset(16)]
		public EAnimLinkMethod LinkMethod;
		[FieldOffset(17)]
		public EAnimLinkMethod CachedLinkMethod;
		[FieldOffset(20)]
		public float SegmentBeginTime;
		[FieldOffset(24)]
		public float SegmentLength;
		[FieldOffset(28)]
		public float LinkValue;
		
	}
	
}
#endif
#endif
