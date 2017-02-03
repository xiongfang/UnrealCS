using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>PhysicsBody options when bone is hidden</summary>
	public enum EPhysBodyOp:byte
	{
		/// <summary>Don't do anything.</summary>
		PBO_None=0,
		/// <summary>Terminate - if you terminate, you won't be able to re-init when unhidden.</summary>
		PBO_Term=1,
		/// <summary>Disable collision - it will enable collision when unhidden.</summary>
		PBO_Disable=2,
		PBO_MAX=3,
		
	}
	
}
