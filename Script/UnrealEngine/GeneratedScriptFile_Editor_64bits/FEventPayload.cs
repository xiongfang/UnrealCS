#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FEventPayload
	{
		/// <summary>The name of the event to trigger</summary>
		[FieldOffset(0)]
		public FName EventName;
		/// <summary>The event parameters</summary>
		[FieldOffset(16)]
		public FMovieSceneEventParameters Parameters;
		
	}
	
}
#endif
#endif
