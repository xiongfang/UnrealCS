#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Info about one note dropped in the map during PIE.</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FDropNoteInfo
	{
		/// <summary>Location to create Note actor in edited level.</summary>
		[FieldOffset(0)]
		public FVector Location;
		/// <summary>Rotation to create Note actor in edited level.</summary>
		[FieldOffset(12)]
		public FRotator Rotation;
		/// <summary>Text to assign to Note actor in edited level.</summary>
		[FieldOffset(24)]
		public FString Comment;
		
	}
	
}
#endif
#endif
