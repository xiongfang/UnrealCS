using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Controls the movement behaviour</summary>
	public enum EInterpToBehaviourType:byte
	{
		/// <summary>Move to destination and stop</summary>
		OneShot=0,
		/// <summary>Move to destination, return and stop</summary>
		OneShot_Reverse=1,
		/// <summary>Reset back to start when reaching the end</summary>
		Loop_Reset=2,
		/// <summary>Repeatedly lerp from start to end and back</summary>
		PingPong=3,
		EInterpToBehaviourType_MAX=4,
		
	}
	
}
