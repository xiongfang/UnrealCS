#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FParticleEvent_GenerateInfo
	{
		/// <summary>The type of event.</summary>
		[FieldOffset(0)]
		public EParticleEventType Type;
		/// <summary>How often to trigger the event (<= 1 means EVERY time).</summary>
		[FieldOffset(4)]
		public int Frequency;
		/// <summary>Only fire the first time (collision only).</summary>
		[FieldOffset(8)]
		public int ParticleFrequency;
		/// <summary>Only fire the first time (collision only).</summary>
		public bool FirstTimeOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Only fire the last time (collision only).</summary>
		public bool LastTimeOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Use the impact FVector not the hit normal (collision only).</summary>
		public bool UseReflectedImpactVector
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 4, 4); } }}
			
		}
		/// <summary>Use the orbit offset when computing the position at which the event occurred.</summary>
		public bool bUseOrbitOffset
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 8, 8); } }}
			
		}
		/// <summary>Should the event tag with a custom name? Leave blank for the default.</summary>
		[FieldOffset(16)]
		public FName CustomName;
		/// <summary>The events we want to fire off when this event has been generated</summary>
		public TObjectArray<UParticleModuleEventSendToGame> ParticleModuleEventsToSendToGame
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UParticleModuleEventSendToGame>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
