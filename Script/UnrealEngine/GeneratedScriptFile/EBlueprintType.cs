using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates types of blueprints.</summary>
	public enum EBlueprintType:byte
	{
		/// <summary>Normal blueprint.</summary>
		BPTYPE_Normal=0,
		/// <summary>Blueprint that is const during execution (no state graph and methods cannot modify member variables).</summary>
		BPTYPE_Const=1,
		/// <summary>Blueprint that serves as a container for macros to be used in other blueprints.</summary>
		BPTYPE_MacroLibrary=2,
		/// <summary>Blueprint that serves as an interface to be implemented by other blueprints.</summary>
		BPTYPE_Interface=3,
		/// <summary>Blueprint that handles level scripting.</summary>
		BPTYPE_LevelScript=4,
		/// <summary>Blueprint that serves as a container for functions to be used in other blueprints.</summary>
		BPTYPE_FunctionLibrary=5,
		BPTYPE_MAX=6,
		
	}
	
}
