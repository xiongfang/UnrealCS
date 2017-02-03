#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneComponentMaterialTrack
	{
		static readonly int MaterialIndex__Offset;
		public int MaterialIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaterialIndex__Offset, typeof(int));}
			
		}
		
		static UMovieSceneComponentMaterialTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneComponentMaterialTrack");
			MaterialIndex__Offset=GetPropertyOffset(NativeClassPtr,"MaterialIndex");
			
		}
		
	}
	
}
#endif
#endif
