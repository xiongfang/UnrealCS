using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ECollisionTraceFlag:byte
	{
		/// <summary>Use project physics settings (DefaultShapeComplexity)</summary>
		CTF_UseDefault=0,
		/// <summary>Create both simple and complex shapes. Simple shapes are used for regular scene queries and collision tests. Complex shape (per poly) is used for complex scene queries.</summary>
		CTF_UseSimpleAndComplex=1,
		/// <summary>Create only simple shapes. Use simple shapes for all scene queries and collision tests.</summary>
		CTF_UseSimpleAsComplex=2,
		/// <summary>Create only complex shapes (per poly). Use complex shapes for all scene queries and collision tests. Can be used in simulation for static shapes only (i.e can be collided against but not moved through forces or velocity.)</summary>
		CTF_UseComplexAsSimple=3,
		CTF_MAX=4,
		
	}
	
}
