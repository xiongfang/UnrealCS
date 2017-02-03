using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>typical vertex attribute formats but as they are only CPU processed at the moment we could chnage that</summary>
	public enum EVertexAttributeStreamType:byte
	{
		VAST_unknown=0,
		VAST_float=1,
		VAST_float2=2,
		/// <summary>FVector2D e.g. UV</summary>
		VAST_float3=3,
		/// <summary>FVector e.g. position</summary>
		VAST_float4=4,
		VAST_MAX=5,
		
	}
	
}
