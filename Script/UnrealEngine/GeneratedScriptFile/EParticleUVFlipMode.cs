using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EParticleUVFlipMode:byte
	{
		/// <summary>Flips UV on all particles.</summary>
		None=0,
		/// <summary>Flips UV on all particles.</summary>
		FlipUV=1,
		/// <summary>Flips U only on all particles.</summary>
		FlipUOnly=2,
		/// <summary>Flips V only on all particles.</summary>
		FlipVOnly=3,
		/// <summary>Flips UV randomly for each particle on spawn.</summary>
		RandomFlipUV=4,
		/// <summary>Flips U only randomly for each particle on spawn.</summary>
		RandomFlipUOnly=5,
		/// <summary>Flips V only randomly for each particle on spawn.</summary>
		RandomFlipVOnly=6,
		/// <summary>Flips U and V independently at random for each particle on spawn.</summary>
		RandomFlipUVIndependent=7,
		EParticleUVFlipMode_MAX=8,
		
	}
	
}
