#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=224)]
	public partial struct FTimeline
	{
		[FieldOffset(0)]
		public ETimelineLengthMode LengthMode;
		[FieldOffset(4)]
		public float Length;
		public bool bLooping
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 1); } }}
			
		}
		public bool bReversePlayback
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 2, 2); } }}
			
		}
		public bool bPlaying
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 4, 4); } }}
			
		}
		[FieldOffset(12)]
		public float PlayRate;
		[FieldOffset(16)]
		public float Position;
		public TStructArray<FTimelineEventEntry> Events
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTimelineEventEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+24, false);}}}
			
		}
		public TStructArray<FTimelineVectorTrack> InterpVectors
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTimelineVectorTrack>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		public TStructArray<FTimelineFloatTrack> InterpFloats
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTimelineFloatTrack>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+56, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+56, false);}}}
			
		}
		public TStructArray<FTimelineLinearColorTrack> InterpLinearColors
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTimelineLinearColorTrack>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+72, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+72, false);}}}
			
		}
		[FieldOffset(200)]
		public FName DirectionPropertyName;
		
	}
	
}
#endif
#endif
