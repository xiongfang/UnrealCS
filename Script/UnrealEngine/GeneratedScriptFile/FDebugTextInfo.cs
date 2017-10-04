using System;
namespace UnrealEngine
{
	/// <summary>
	/// * Single entry of a debug text item to render.
	/// *
	/// * @see AHud
	/// * @see AddDebugText(), RemoveDebugText() and DrawDebugTextList()
	/// </summary>
	public partial struct FDebugTextInfo
	{
		/// <summary>AActor related to text item</summary>
		public AActor SrcActor;
		/// <summary>Offset from SrcActor.Location to apply</summary>
		public FVector SrcActorOffset;
		/// <summary>Desired offset to interpolate to</summary>
		public FVector SrcActorDesiredOffset;
		/// <summary>Text to display</summary>
		public FString DebugText;
		/// <summary>Time remaining for the debug text, -1.f == infinite</summary>
		public float TimeRemaining;
		/// <summary>Duration used to lerp desired offset</summary>
		public float Duration;
		/// <summary>Text color</summary>
		public FColor TextColor;
		/// <summary>whether the offset should be treated as absolute world location of the string</summary>
		public bool bAbsoluteLocation;
		/// <summary>If the actor moves does the text also move with it?</summary>
		public bool bKeepAttachedToActor;
		/// <summary>Whether to draw a shadow for the text</summary>
		public bool bDrawShadow;
		/// <summary>When we first spawn store off the original actor location for use with bKeepAttachedToActor</summary>
		public FVector OrigActorLocation;
		/// <summary>The Font which to display this as.  Will Default to GetSmallFont()*</summary>
		public UFont Font;
		/// <summary>Scale to apply to font when rendering</summary>
		public float FontScale;
		
	}
	
}
