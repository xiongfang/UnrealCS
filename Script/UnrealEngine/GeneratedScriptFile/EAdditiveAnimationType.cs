using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Indicates whether an animation is additive, and what kind.</summary>
	public enum EAdditiveAnimationType:byte
	{
		/// <summary>No additive.</summary>
		AAT_None=0,
		/// <summary>Create Additive from LocalSpace Base.</summary>
		AAT_LocalSpaceBase=1,
		/// <summary>Create Additive from MeshSpace Rotation Only, Translation still will be LocalSpace.</summary>
		AAT_RotationOffsetMeshSpace=2,
		AAT_MAX=3,
		
	}
	
}
