using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Bone translation retargeting mode.</summary>
	public enum EBoneTranslationRetargetingMode:byte
	{
		/// <summary>Use translation from animation data.</summary>
		Animation=0,
		/// <summary>Use fixed translation from Skeleton.</summary>
		Skeleton=1,
		/// <summary>Use Translation from animation, but scale length by Skeleton's proportions.</summary>
		AnimationScaled=2,
		/// <summary>Use Translation from animation, but also play the difference from retargeting pose as an additive.</summary>
		AnimationRelative=3,
		EBoneTranslationRetargetingMode_MAX=4,
		
	}
	
}
