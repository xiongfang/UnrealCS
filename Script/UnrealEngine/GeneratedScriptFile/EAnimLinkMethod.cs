using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Supported types of time for a linked element</summary>
	public enum EAnimLinkMethod:byte
	{
		/// <summary>Element stays at a specific time without moving.</summary>
		Absolute=0,
		/// <summary>Element moves with its segment, but not when the segment changes size.</summary>
		Relative=1,
		/// <summary>Element moves with its segment and will stay at a certain proportion through the segment.</summary>
		Proportional=2,
		EAnimLinkMethod_MAX=3,
		
	}
	
}
