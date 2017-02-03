#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FMovieSceneBinding
	{
		[FieldOffset(0)]
		public FGuid ObjectGuid;
		[FieldOffset(16)]
		public FString BindingName;
		public TObjectArray<UMovieSceneTrack> Tracks
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UMovieSceneTrack>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+28, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+28, false);}}}
			
		}
		
	}
	
}
#endif
#endif
