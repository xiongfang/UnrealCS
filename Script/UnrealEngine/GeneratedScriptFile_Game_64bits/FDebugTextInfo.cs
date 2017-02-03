#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FDebugTextInfo
	{
		[FieldOffset(8)]
		public FVector SrcActorOffset;
		[FieldOffset(20)]
		public FVector SrcActorDesiredOffset;
		[FieldOffset(32)]
		public FString DebugText;
		[FieldOffset(48)]
		public float TimeRemaining;
		[FieldOffset(52)]
		public float Duration;
		[FieldOffset(56)]
		public FColor TextColor;
		public bool bAbsoluteLocation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 60, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 60, 1, 0, 1, 1); } }}
			
		}
		public bool bKeepAttachedToActor
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 60, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 60, 1, 0, 2, 2); } }}
			
		}
		public bool bDrawShadow
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 60, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 60, 1, 0, 4, 4); } }}
			
		}
		[FieldOffset(64)]
		public FVector OrigActorLocation;
		[FieldOffset(88)]
		public float FontScale;
		
	}
	
}
#endif
#endif
