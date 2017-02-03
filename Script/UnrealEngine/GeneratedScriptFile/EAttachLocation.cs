using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EAttachLocation:byte
	{
		/// <summary>Keeps current relative transform as the relative transform to the new parent.</summary>
		KeepRelativeOffset=0,
		/// <summary>Automatically calculates the relative transform such that the attached component maintains the same world transform.</summary>
		KeepWorldPosition=1,
		/// <summary>Snaps location and rotation to the attach point. Calculates the relative scale so that the final world scale of the component remains the same.</summary>
		SnapToTarget=2,
		/// <summary>Snaps entire transform to target, including scale.</summary>
		SnapToTargetIncludingScale=3,
		EAttachLocation_MAX=4,
		
	}
	
}
