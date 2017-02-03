using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The shape to use for the stereo layer.  Note that some shapes might not be supported on all platforms!</summary>
	public enum EStereoLayerShape:byte
	{
		/// <summary>Quad layer</summary>
		SLSH_QuadLayer=0,
		/// <summary>Cylinder layer</summary>
		SLSH_CylinderLayer=1,
		/// <summary>Cubemap layer</summary>
		SLSH_CubemapLayer=2,
		SLSH_MAX=3,
		
	}
	
}
