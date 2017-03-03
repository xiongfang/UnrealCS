#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FMovieSceneObjectBindingPtr
	{
		[FieldOffset(0)]
		public FGuid Guid;
		
	}
	
}
#endif
#endif
