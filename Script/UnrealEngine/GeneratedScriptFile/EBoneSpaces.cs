using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Values for specifying bone space.</summary>
	public enum EBoneSpaces:byte
	{
		/// <summary>Set absolute position of bone in world space.</summary>
		WorldSpace=0,
		/// <summary>Set position of bone in components reference frame.</summary>
		ComponentSpace=1,
		EBoneSpaces_MAX=2,
		
	}
	
}
