#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A material track which is specialized for animation materials which are owned by actor components.</summary>
	public partial class UMovieSceneComponentMaterialTrack
	{
		static readonly int MaterialIndex__Offset;
		/// <summary>The index of this material this track is animating.</summary>
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
