using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The method to use in determining the source/target tangent.</summary>
	public enum Beam2SourceTargetTangentMethod:byte
	{
		/// <summary>Direct - a direct line between source and target.</summary>
		PEB2STTM_Direct=0,
		/// <summary>UserSet        - use the user set value.</summary>
		PEB2STTM_UserSet=1,
		/// <summary>Distribution - use the distribution.</summary>
		PEB2STTM_Distribution=2,
		/// <summary>Emitter        - use the emitter direction.</summary>
		PEB2STTM_Emitter=3,
		PEB2STTM_MAX=4,
		
	}
	
}
