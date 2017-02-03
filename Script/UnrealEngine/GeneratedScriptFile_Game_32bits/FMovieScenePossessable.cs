#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FMovieScenePossessable
	{
		[FieldOffset(0)]
		public FGuid Guid;
		[FieldOffset(16)]
		public FString Name;
		[FieldOffset(32)]
		public FGuid ParentGuid;
		
	}
	
}
#endif
#endif
