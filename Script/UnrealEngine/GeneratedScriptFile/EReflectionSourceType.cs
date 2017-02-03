using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EReflectionSourceType:byte
	{
		/// <summary>Construct the reflection source from the captured scene</summary>
		CapturedScene=0,
		/// <summary>Construct the reflection source from the specified cubemap.</summary>
		SpecifiedCubemap=1,
		EReflectionSourceType_MAX=2,
		
	}
	
}
