using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ENetRole:byte
	{
		/// <summary>No role at all.</summary>
		ROLE_None=0,
		/// <summary>Locally simulated proxy of this actor.</summary>
		ROLE_SimulatedProxy=1,
		/// <summary>Locally autonomous proxy of this actor.</summary>
		ROLE_AutonomousProxy=2,
		/// <summary>Authoritative control over the actor.</summary>
		ROLE_Authority=3,
		ROLE_MAX=4,
		
	}
	
}
