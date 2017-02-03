using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Rules for detaching components - needs to be kept synced to EAttachmentRule</summary>
	public enum EDetachmentRule:byte
	{
		/// <summary>Keeps current relative transform.</summary>
		KeepRelative=0,
		/// <summary>Automatically calculates the relative transform such that the detached component maintains the same world transform.</summary>
		KeepWorld=1,
		EDetachmentRule_MAX=2,
		
	}
	
}
