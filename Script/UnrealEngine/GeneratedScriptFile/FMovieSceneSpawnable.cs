using System;
namespace UnrealEngine
{
	/// <summary>MovieSceneSpawnable describes an object that can be spawned for this MovieScene</summary>
	public partial struct FMovieSceneSpawnable
	{
		/// <summary>
		/// Unique identifier of the spawnable object. // @todo sequencer: Guids need to be handled carefully when the asset is duplicated (or loaded after being copied on disk).
		/// //                                     Sometimes we'll need to generate fresh Guids.
		/// </summary>
		public FGuid Guid;
		/// <summary>Name label // @todo sequencer: Should be editor-only probably</summary>
		public FString Name;
		public UObject ObjectTemplate;
		/// <summary>Deprecated generated class</summary>
		public UClass GeneratedClass;
		
	}
	
}
