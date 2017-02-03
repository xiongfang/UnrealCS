#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneParticleSection
	{
		static readonly int ParticleKeys__Offset;
		public FIntegralCurve ParticleKeys
		{
			get{ CheckIsValid();return (FIntegralCurve)Marshal.PtrToStructure(_this.Get()+ParticleKeys__Offset, typeof(FIntegralCurve));}
			
		}
		
		static UMovieSceneParticleSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneParticleSection");
			ParticleKeys__Offset=GetPropertyOffset(NativeClassPtr,"ParticleKeys");
			
		}
		
	}
	
}
#endif
#endif
