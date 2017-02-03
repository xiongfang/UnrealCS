using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EOrbitChainMode:byte
	{
		/// <summary>Add the module values to the previous results</summary>
		EOChainMode_Add=0,
		/// <summary>Multiply the module values by the previous results</summary>
		EOChainMode_Scale=1,
		/// <summary>'Break' the chain and apply the values from the previous results</summary>
		EOChainMode_Link=2,
		EOChainMode_MAX=3,
		
	}
	
}
