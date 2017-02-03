#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Particle section, for particle toggling and triggering.</summary>
	public partial class UMovieSceneParticleSection
	{
		static readonly int ParticleKeys__Offset;
		/// <summary>Curve containing the particle keys.</summary>
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
