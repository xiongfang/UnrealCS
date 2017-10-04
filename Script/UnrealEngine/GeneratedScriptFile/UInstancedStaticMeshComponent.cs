using System;
namespace UnrealEngine
{
	public partial class UInstancedStaticMeshComponent:UStaticMeshComponent
	{
		/// <summary>Sets the fading start and culling end distances for this component.</summary>
		public extern void SetCullDistances(int StartCullDistance,int EndCullDistance);
		/// <summary>Get the number of instances in this component.</summary>
		public extern int GetInstanceCount();
		/// <summary>Clear all instances being rendered by this component.</summary>
		public extern virtual void ClearInstances();
		/// <summary>Remove the instance specified. Returns True on success. Note that this will leave the array in order, but may shrink it.</summary>
		public extern virtual bool RemoveInstance(int InstanceIndex);
		/// <summary>
		/// Update the transform for the instance specified.
		/// @param InstanceIndex                  The index of the instance to update
		/// @param NewInstanceTransform   The new transform
		/// @param bWorldSpace                    If true, the new transform interpreted as a World Space transform, otherwise it is interpreted as Local Space
		/// @param bMarkRenderStateDirty  If true, the change should be visible immediately. If you are updating many instances you should only set this to true for the last instance.
		/// @param bTeleport                              Whether or not the instance's physics should be moved normally, or teleported (moved instantly, ignoring velocity).
		/// @return                                               True on success.
		/// </summary>
		public extern virtual bool UpdateInstanceTransform(int InstanceIndex,FTransform NewInstanceTransform,bool bWorldSpace=false,bool bMarkRenderStateDirty=false,bool bTeleport=false);
		/// <summary>Get the transform for the instance specified. Instance is returned in local space of this component unless bWorldSpace is set.  Returns True on success.</summary>
		public extern bool GetInstanceTransform(int InstanceIndex,out FTransform OutInstanceTransform,bool bWorldSpace=false);
		/// <summary>Add an instance to this component. Transform is given in world space.</summary>
		public extern int AddInstanceWorldSpace(FTransform WorldTransform);
		/// <summary>Add an instance to this component. Transform is given in local space of this component.</summary>
		public extern virtual int AddInstance(FTransform InstanceTransform);
		/// <summary>
		/// Value used to seed the random number stream that generates random numbers for each of this mesh's instances.
		///               The random number is stored in a buffer accessible to materials through the PerInstanceRandom expression. If
		///               this is set to zero (default), it will be populated automatically by the editor.
		/// </summary>
		public int InstancingRandomSeed;
		
		/// <summary>Distance from camera at which each instance begins to fade out.</summary>
		public int InstanceStartCullDistance;
		
		/// <summary>Distance from camera at which each instance completely fades out.</summary>
		public int InstanceEndCullDistance;
		
		/// <summary>Serialization of all the InstanceBodies. Helps speed up physics creation time.</summary>
		public UPhysicsSerializer PhysicsSerializer;
		
		/// <summary>Number of pending lightmaps still to be calculated (Apply()'d).</summary>
		public int NumPendingLightmaps;
		
		
	}
	
}
