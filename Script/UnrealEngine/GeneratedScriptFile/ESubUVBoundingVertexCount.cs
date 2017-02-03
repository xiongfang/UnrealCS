using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// More bounding vertices results in reduced overdraw, but adds more triangle overhead.
	/// The eight vertex mode is best used when the SubUV texture has a lot of space to cut out that is not captured by the four vertex version,
	/// and when the particles using the texture will be few and large.
	/// </summary>
	public enum ESubUVBoundingVertexCount:byte
	{
		BVC_FourVertices=0,
		BVC_EightVertices=1,
		BVC_MAX=2,
		
	}
	
}
