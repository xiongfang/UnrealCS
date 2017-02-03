#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A channel for exchanging actor and its subobject's properties and RPCs.
	/// ActorChannel manages the creation and lifetime of a replicated actor. Actual replication of properties and RPCs
	/// actually happens in FObjectReplicator now (see DataReplication.h).
	/// An ActorChannel bunch looks like this:
	///             |----------------------|---------------------------------------------------------------------------|
	///             | SpawnInfo                    | (Spawn Info) Initial bunch only                                           |
	///             |  -Actor Class        |        -Created by ActorChannel                                                   |
	///             |  -Spawn Loc/Rot      |                                                                           |
	///      | NetGUID assigns      |                                                                           |
	///             |  -Actor NetGUID      |                                                                           |
	///             |  -Component NetGUIDs |                                                                           |
	///             |----------------------|---------------------------------------------------------------------------|
	///             |                      |                                                                           |
	///             |----------------------|---------------------------------------------------------------------------|
	///             | NetGUID ObjRef       | (Content chunks) x number of replicating objects (Actor + any components) |
	///             |                      |                -Each chunk created by its own FObjectReplicator instance.         |
	///             |----------------------|---------------------------------------------------------------------------|
	///      |                      |                                                                                  |
	///             | Properties...        |                                                                           |
	///             |                      |                                                                               |
	///             | RPCs...              |                                                                           |
	///      |                      |                                                                           |
	///      |----------------------|---------------------------------------------------------------------------|
	///             | </End Tag>           |                                                                           |
	///             |----------------------|---------------------------------------------------------------------------|
	/// </summary>
	public partial class UActorChannel
	{
		static readonly int Actor__Offset;
		/// <summary>Variables.</summary>
		public AActor Actor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Actor__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static UActorChannel()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ActorChannel");
			Actor__Offset=GetPropertyOffset(NativeClassPtr,"Actor");
			
		}
		
	}
	
}
#endif
#endif
