using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>@note, if you change this, change GetCollisionChannelFromOverlapFilter() to match</summary>
	public enum EOverlapFilterOption:byte
	{
		/// <summary>returns both overlaps with both dynamic and static components</summary>
		OverlapFilter_All=0,
		/// <summary>returns only overlaps with dynamic actors (far fewer results in practice, much more efficient)</summary>
		OverlapFilter_DynamicOnly=1,
		/// <summary>returns only overlaps with static actors (fewer results, more efficient)</summary>
		OverlapFilter_StaticOnly=2,
		OverlapFilter_MAX=3,
		
	}
	
}
