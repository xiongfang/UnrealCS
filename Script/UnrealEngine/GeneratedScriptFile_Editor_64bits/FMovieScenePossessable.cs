#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>MovieScenePossessable is a "typed slot" used to allow the MovieScene to control an already-existing object</summary>
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FMovieScenePossessable
	{
		/// <summary>
		/// Unique identifier of the possessable object. // @todo sequencer: Guids need to be handled carefully when the asset is duplicated (or loaded after being copied on disk).
		/// //                                     Sometimes we'll need to generate fresh Guids.
		/// </summary>
		[FieldOffset(0)]
		public FGuid Guid;
		/// <summary>Name label for this slot // @todo sequencer: Should be editor-only probably</summary>
		[FieldOffset(16)]
		public FString Name;
		/// <summary>
		/// Type of the object we'll be possessing // @todo sequencer: Might be able to be editor-only.  We'll see.
		/// // @todo sequencer: This isn't used for anything yet.  We could use it to gate which types of objects can be bound to a
		/// // possessable "slot" though.  Or we could use it to generate a "preview" spawnable puppet when previewing with no
		/// // possessable object available.
		/// </summary>
		/// <summary>GUID relating to this possessable's parent, if applicable.</summary>
		[FieldOffset(40)]
		public FGuid ParentGuid;
		
	}
	
}
#endif
#endif
