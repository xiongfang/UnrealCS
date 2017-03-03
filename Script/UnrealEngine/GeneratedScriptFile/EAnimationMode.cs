using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EAnimationMode:byte
	{
		AnimationBlueprint=0,
		AnimationSingleNode=1,
		/// <summary>This is custom type, engine leaves AnimInstance as it is</summary>
		AnimationCustomMode=2,
		EAnimationMode_MAX=3,
		
	}
	
}
