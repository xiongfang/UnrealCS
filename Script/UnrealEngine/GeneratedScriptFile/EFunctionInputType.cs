using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Supported input types</summary>
	public enum EFunctionInputType:byte
	{
		FunctionInput_Scalar=0,
		FunctionInput_Vector2=1,
		FunctionInput_Vector3=2,
		FunctionInput_Vector4=3,
		FunctionInput_Texture2D=4,
		FunctionInput_TextureCube=5,
		FunctionInput_StaticBool=6,
		FunctionInput_MaterialAttributes=7,
		FunctionInput_MAX=8,
		
	}
	
}
