using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates available options for custom depth.</summary>
	public enum ECustomDepthStencil:byte
	{
		Disabled=0,
		/// <summary>Depth buffer created immediately. Stencil disabled.</summary>
		Enabled=1,
		/// <summary>Depth buffer created on first use, can save memory but cause stalls. Stencil disabled.</summary>
		EnabledOnDemand=2,
		/// <summary>Depth buffer created immediately. Stencil available for read/write.</summary>
		EnabledWithStencil=3,
		ECustomDepthStencil_MAX=4,
		
	}
	
}
