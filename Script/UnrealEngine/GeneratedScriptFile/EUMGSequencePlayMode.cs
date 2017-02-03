using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Describes playback modes for UMG sequences.</summary>
	public enum EUMGSequencePlayMode:byte
	{
		/// <summary>Animation plays and loops from the beginning to the end.</summary>
		Forward=0,
		/// <summary>Animation plays and loops from the end to the beginning.</summary>
		Reverse=1,
		/// <summary>Animation plays from the begging to the end and then from the end to beginning.</summary>
		PingPong=2,
		EUMGSequencePlayMode_MAX=3,
		
	}
	
}
