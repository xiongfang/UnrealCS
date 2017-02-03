#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=224)]
	public partial struct FTimeline
	{
		/// <summary>Specified how the timeline determines its own length (e.g. specified length, last keyframe)</summary>
		[FieldOffset(0)]
		public ETimelineLengthMode LengthMode;
		/// <summary>How long the timeline is, will stop or loop at the end</summary>
		[FieldOffset(4)]
		public float Length;
		/// <summary>Whether timeline should loop when it reaches the end, or stop</summary>
		public bool bLooping
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If playback should move the current position backwards instead of forwards</summary>
		public bool bReversePlayback
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Are we currently playing (moving Position)</summary>
		public bool bPlaying
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 4, 4); } }}
			
		}
		/// <summary>How fast we should play through the timeline</summary>
		[FieldOffset(12)]
		public float PlayRate;
		/// <summary>Current position in the timeline</summary>
		[FieldOffset(16)]
		public float Position;
		/// <summary>Array of events that are fired at various times during the timeline</summary>
		public TStructArray<FTimelineEventEntry> Events
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTimelineEventEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+24, false);}}}
			
		}
		/// <summary>Array of vector interpolations performed during the timeline</summary>
		public TStructArray<FTimelineVectorTrack> InterpVectors
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTimelineVectorTrack>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		/// <summary>Array of float interpolations performed during the timeline</summary>
		public TStructArray<FTimelineFloatTrack> InterpFloats
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTimelineFloatTrack>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+56, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+56, false);}}}
			
		}
		/// <summary>Array of linear color interpolations performed during the timeline</summary>
		public TStructArray<FTimelineLinearColorTrack> InterpLinearColors
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTimelineLinearColorTrack>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+72, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+72, false);}}}
			
		}
		/// <summary>Optional. If set, Timeline will also set ETimelineDirection property on PropertySetObject using the name.</summary>
		[FieldOffset(200)]
		public FName DirectionPropertyName;
		/// <summary>Cached property pointer for setting timeline direction</summary>
		
	}
	
}
#endif
#endif
