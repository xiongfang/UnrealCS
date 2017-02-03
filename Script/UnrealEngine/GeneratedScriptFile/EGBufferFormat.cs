using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// * Enumerates available GBufferFormats.
	/// // When this enum is updated please update CVarGBufferFormat comments
	/// </summary>
	public enum EGBufferFormat:byte
	{
		/// <summary>Forces all GBuffers to 8 bits per channel. Intended as profiling for best performance.</summary>
		Force8BitsPerChannel=0,
		/// <summary>See GBuffer allocation function for layout details.</summary>
		Default=1,
		/// <summary>Same as Default except normals are encoded at 16 bits per channel.</summary>
		HighPrecisionNormals=3,
		/// <summary>Forces all GBuffers to 16 bits per channel. Intended as profiling for best quality.</summary>
		Force16BitsPerChannel=5,
		EGBufferFormat_MAX=6,
		
	}
	
}
