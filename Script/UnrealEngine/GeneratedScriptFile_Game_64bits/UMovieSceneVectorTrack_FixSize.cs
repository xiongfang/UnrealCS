#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneVectorTrack
	{
		static readonly int NumChannelsUsed__Offset;
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
