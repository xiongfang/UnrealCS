using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ENavigationOptionFlag:byte
	{
		Default=0,
		Enable=1,
		/// <summary>UHT was complaining when tried to use True as value instead of Enable</summary>
		Disable=2,
		MAX=3,
		ENavigationOptionFlag_MAX=4,
		
	}
	
}
