using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Trace option to SuggestProjectileVelocity functions.</summary>
	public enum ESuggestProjVelocityTraceOption:byte
	{
		DoNotTrace=0,
		TraceFullPath=1,
		OnlyTraceWhileAscending=2,
		ESuggestProjVelocityTraceOption_MAX=3,
		
	}
	
}
