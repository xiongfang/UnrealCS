using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EInterpTrackMoveRotMode:byte
	{
		/// <summary>Should take orientation from the keyframe.</summary>
		IMR_Keyframed=0,
		/// <summary>Point the X-Axis of the controlled Actor at the group specified by LookAtGroupName.</summary>
		IMR_LookAtGroup=1,
		/// <summary>Do not change rotation. Ignore it.</summary>
		IMR_Ignore=2,
		IMR_MAX=3,
		
	}
	
}
