using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Flags indicating lock</summary>
	public enum EParticleAxisLock:byte
	{
		/// <summary>No locking to an axis...</summary>
		EPAL_NONE=0,
		/// <summary>Lock the sprite facing towards the positive X-axis</summary>
		EPAL_X=1,
		/// <summary>Lock the sprite facing towards the positive Y-axis</summary>
		EPAL_Y=2,
		/// <summary>Lock the sprite facing towards the positive Z-axis</summary>
		EPAL_Z=3,
		/// <summary>Lock the sprite facing towards the negative X-axis</summary>
		EPAL_NEGATIVE_X=4,
		/// <summary>Lock the sprite facing towards the negative Y-axis</summary>
		EPAL_NEGATIVE_Y=5,
		/// <summary>Lock the sprite facing towards the negative Z-axis</summary>
		EPAL_NEGATIVE_Z=6,
		/// <summary>Lock the sprite rotation on the X-axis</summary>
		EPAL_ROTATE_X=7,
		/// <summary>Lock the sprite rotation on the Y-axis</summary>
		EPAL_ROTATE_Y=8,
		/// <summary>Lock the sprite rotation on the Z-axis</summary>
		EPAL_ROTATE_Z=9,
		EPAL_MAX=10,
		
	}
	
}
