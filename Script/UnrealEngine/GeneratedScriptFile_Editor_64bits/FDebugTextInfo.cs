#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// * Single entry of a debug text item to render.
	/// *
	/// * @see AHud
	/// * @see AddDebugText(), RemoveDebugText() and DrawDebugTextList()
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FDebugTextInfo
	{
		/// <summary>AActor related to text item</summary>
		/// <summary>Offset from SrcActor.Location to apply</summary>
		[FieldOffset(8)]
		public FVector SrcActorOffset;
		/// <summary>Desired offset to interpolate to</summary>
		[FieldOffset(20)]
		public FVector SrcActorDesiredOffset;
		/// <summary>Text to display</summary>
		[FieldOffset(32)]
		public FString DebugText;
		/// <summary>Time remaining for the debug text, -1.f == infinite</summary>
		[FieldOffset(48)]
		public float TimeRemaining;
		/// <summary>Duration used to lerp desired offset</summary>
		[FieldOffset(52)]
		public float Duration;
		/// <summary>Text color</summary>
		[FieldOffset(56)]
		public FColor TextColor;
		/// <summary>whether the offset should be treated as absolute world location of the string</summary>
		public bool bAbsoluteLocation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 60, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 60, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If the actor moves does the text also move with it?</summary>
		public bool bKeepAttachedToActor
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 60, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 60, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Whether to draw a shadow for the text</summary>
		public bool bDrawShadow
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 60, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 60, 1, 0, 4, 4); } }}
			
		}
		/// <summary>When we first spawn store off the original actor location for use with bKeepAttachedToActor</summary>
		[FieldOffset(64)]
		public FVector OrigActorLocation;
		/// <summary>The Font which to display this as.  Will Default to GetSmallFont()*</summary>
		/// <summary>Scale to apply to font when rendering</summary>
		[FieldOffset(88)]
		public float FontScale;
		
	}
	
}
#endif
#endif
