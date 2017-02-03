using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Rules for attaching components - needs to be kept synced to EDetachmentRule</summary>
	public enum EAttachmentRule:byte
	{
		/// <summary>Keeps current relative transform as the relative transform to the new parent.</summary>
		KeepRelative=0,
		/// <summary>Automatically calculates the relative transform such that the attached component maintains the same world transform.</summary>
		KeepWorld=1,
		/// <summary>Snaps transform to the attach point</summary>
		SnapToTarget=2,
		EAttachmentRule_MAX=3,
		
	}
	
}
