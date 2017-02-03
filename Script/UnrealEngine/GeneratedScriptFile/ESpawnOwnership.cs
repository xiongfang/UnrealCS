using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESpawnOwnership:byte
	{
		/// <summary>The object's lifetime is managed by the sequence that spawned it</summary>
		InnerSequence=0,
		/// <summary>The object's lifetime is managed by the outermost sequence</summary>
		MasterSequence=1,
		/// <summary>Once spawned, the object's lifetime is managed externally.</summary>
		External=2,
		ESpawnOwnership_MAX=3,
		
	}
	
}
