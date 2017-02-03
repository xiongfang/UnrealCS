using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Determines which ticking group a tick function belongs to.</summary>
	public enum ETickingGroup:byte
	{
		/// <summary>Any item that needs to be executed before physics simulation starts.</summary>
		TG_PrePhysics=0,
		/// <summary>Special tick group that starts physics simulation.</summary>
		TG_StartPhysics=1,
		/// <summary>Any item that can be run in parallel with our physics simulation work.</summary>
		TG_DuringPhysics=2,
		/// <summary>Special tick group that ends physics simulation.</summary>
		TG_EndPhysics=3,
		/// <summary>Any item that needs rigid body and cloth simulation to be complete before being executed.</summary>
		TG_PostPhysics=4,
		/// <summary>Any item that needs the update work to be done before being ticked.</summary>
		TG_PostUpdateWork=5,
		/// <summary>Catchall for anything demoted to the end.</summary>
		TG_LastDemotable=6,
		/// <summary>Special tick group that is not actually a tick group. After every tick group this is repeatedly re-run until there are no more newly spawned items to run.</summary>
		TG_NewlySpawned=7,
		TG_MAX=8,
		
	}
	
}
