#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=76)]
	public partial struct FDebugTextInfo
	{
		[FieldOffset(4)]
		public FVector SrcActorOffset;
		[FieldOffset(16)]
		public FVector SrcActorDesiredOffset;
		[FieldOffset(28)]
		public FString DebugText;
		[FieldOffset(40)]
		public float TimeRemaining;
		[FieldOffset(44)]
		public float Duration;
		[FieldOffset(48)]
		public FColor TextColor;
		public bool bAbsoluteLocation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 52, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 52, 1, 0, 1, 1); } }}
			
		}
		public bool bKeepAttachedToActor
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 52, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 52, 1, 0, 2, 2); } }}
			
		}
		public bool bDrawShadow
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 52, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 52, 1, 0, 4, 4); } }}
			
		}
		[FieldOffset(56)]
		public FVector OrigActorLocation;
		[FieldOffset(72)]
		public float FontScale;
		
	}
	
}
#endif
#endif
