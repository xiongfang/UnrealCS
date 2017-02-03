using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Supported options for runtime navigation data generation</summary>
	public enum ERuntimeGenerationType:byte
	{
		/// <summary>No runtime generation, fully static navigation data</summary>
		Static=0,
		/// <summary>Supports only navigation modifiers updates</summary>
		DynamicModifiersOnly=1,
		/// <summary>Fully dynamic, supports geometry changes along with navigation modifiers</summary>
		Dynamic=2,
		/// <summary>Only for legacy loading don't use it!</summary>
		LegacyGeneration=3,
		ERuntimeGenerationType_MAX=4,
		
	}
	
}
