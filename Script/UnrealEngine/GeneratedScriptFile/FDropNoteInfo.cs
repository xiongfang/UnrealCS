using System;
namespace UnrealEngine
{
	/// <summary>Info about one note dropped in the map during PIE.</summary>
	public partial struct FDropNoteInfo
	{
		/// <summary>Location to create Note actor in edited level.</summary>
		public FVector Location;
		/// <summary>Rotation to create Note actor in edited level.</summary>
		public FRotator Rotation;
		/// <summary>Text to assign to Note actor in edited level.</summary>
		public FString Comment;
		
	}
	
}
