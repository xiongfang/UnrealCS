using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ECameraAnimPlaySpace:byte
	{
		/// <summary>This anim is applied in camera space.</summary>
		CameraLocal=0,
		/// <summary>This anim is applied in world space.</summary>
		World=1,
		/// <summary>This anim is applied in a user-specified space (defined by UserPlaySpaceMatrix).</summary>
		UserDefined=2,
		ECameraAnimPlaySpace_MAX=3,
		
	}
	
}
