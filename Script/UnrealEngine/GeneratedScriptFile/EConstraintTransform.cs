using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Constraint Transform Type. - currently unused</summary>
	public enum EConstraintTransform:byte
	{
		/// <summary>Absolute value.</summary>
		Absolute=0,
		/// <summary>Apply relative transform from ref pose.</summary>
		Relative=1,
		EConstraintTransform_MAX=2,
		
	}
	
}
