#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A set of tracks bound to runtime objects</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FMovieSceneBinding
	{
		/// <summary>Object binding guid for runtime objects</summary>
		[FieldOffset(0)]
		public FGuid ObjectGuid;
		/// <summary>Display name</summary>
		[FieldOffset(16)]
		public FString BindingName;
		/// <summary>All tracks in this binding</summary>
		public TObjectArray<UMovieSceneTrack> Tracks
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UMovieSceneTrack>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
