using System;
namespace UnrealEngine
{
	/// <summary>MovieScenePossessable is a "typed slot" used to allow the MovieScene to control an already-existing object</summary>
	public partial struct FMovieScenePossessable
	{
		/// <summary>
		/// Unique identifier of the possessable object. // @todo sequencer: Guids need to be handled carefully when the asset is duplicated (or loaded after being copied on disk).
		/// //                                     Sometimes we'll need to generate fresh Guids.
		/// </summary>
		public FGuid Guid;
		/// <summary>Name label for this slot // @todo sequencer: Should be editor-only probably</summary>
		public FString Name;
		/// <summary>
		/// Type of the object we'll be possessing // @todo sequencer: Might be able to be editor-only.  We'll see.
		/// // @todo sequencer: This isn't used for anything yet.  We could use it to gate which types of objects can be bound to a
		/// // possessable "slot" though.  Or we could use it to generate a "preview" spawnable puppet when previewing with no
		/// // possessable object available.
		/// </summary>
		public UClass PossessedObjectClass;
		/// <summary>GUID relating to this possessable's parent, if applicable.</summary>
		public FGuid ParentGuid;
		
	}
	
}
