#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Handles manipulation of component transforms in a movie scene</summary>
	public partial class UMovieSceneVectorTrack
	{
		static readonly int NumChannelsUsed__Offset;
		/// <summary>The number of channels used by the vector (2,3, or 4)</summary>
		public int NumChannelsUsed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumChannelsUsed__Offset, typeof(int));}
			
		}
		
		static UMovieSceneVectorTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneVectorTrack");
			NumChannelsUsed__Offset=GetPropertyOffset(NativeClassPtr,"NumChannelsUsed");
			
		}
		
	}
	
}
#endif
#endif
