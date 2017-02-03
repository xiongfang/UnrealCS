using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UInstancedStaticMeshComponent:UStaticMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int[] GetInstancesOverlappingBox(IntPtr _this,ref FBox Box,int bBoxInWorldSpace);
/// <summary>Returns the instances with instance bounds overlapping the specified box. The return value is an array of instance indices.</summary>
public  int[] GetInstancesOverlappingBox(FBox Box,bool bBoxInWorldSpace=true)
{
	CheckIsValid();
	int[] ___ret = GetInstancesOverlappingBox(_this.Get(),ref Box,bBoxInWorldSpace?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int[] GetInstancesOverlappingSphere(IntPtr _this,ref FVector Center,float Radius,int bSphereInWorldSpace);
/// <summary>Returns the instances with instance bounds overlapping the specified sphere. The return value is an array of instance indices.</summary>
public  int[] GetInstancesOverlappingSphere(FVector Center,float Radius,bool bSphereInWorldSpace=true)
{
	CheckIsValid();
	int[] ___ret = GetInstancesOverlappingSphere(_this.Get(),ref Center,Radius,bSphereInWorldSpace?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCullDistances(IntPtr _this,int StartCullDistance,int EndCullDistance);
/// <summary>Sets the fading start and culling end distances for this component.</summary>
public  void SetCullDistances(int StartCullDistance,int EndCullDistance)
{
	CheckIsValid();
	SetCullDistances(_this.Get(),StartCullDistance,EndCullDistance);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetInstanceCount(IntPtr _this);
/// <summary>Get the number of instances in this component.</summary>
public  int GetInstanceCount()
{
	CheckIsValid();
	int ___ret = GetInstanceCount(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearInstances(IntPtr _this);
/// <summary>Clear all instances being rendered by this component.</summary>
public  void ClearInstances()
{
	CheckIsValid();
	ClearInstances(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RemoveInstance(IntPtr _this,int InstanceIndex);
/// <summary>Remove the instance specified. Returns True on success. Note that this will leave the array in order, but may shrink it.</summary>
public  bool RemoveInstance(int InstanceIndex)
{
	CheckIsValid();
	int ___ret = RemoveInstance(_this.Get(),InstanceIndex);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int UpdateInstanceTransform(IntPtr _this,int InstanceIndex,ref FTransform NewInstanceTransform,int bWorldSpace,int bMarkRenderStateDirty,int bTeleport);
/// <summary>
/// Update the transform for the instance specified.
/// @param InstanceIndex                  The index of the instance to update
/// @param NewInstanceTransform   The new transform
/// @param bWorldSpace                    If true, the new transform interpreted as a World Space transform, otherwise it is interpreted as Local Space
/// @param bMarkRenderStateDirty  If true, the change should be visible immediately. If you are updating many instances you should only set this to true for the last instance.
/// @param bTeleport                              Whether or not the instance's physics should be moved normally, or teleported (moved instantly, ignoring velocity).
/// @return                                               True on success.
/// </summary>
public  bool UpdateInstanceTransform(int InstanceIndex,FTransform NewInstanceTransform,bool bWorldSpace=false,bool bMarkRenderStateDirty=false,bool bTeleport=false)
{
	CheckIsValid();
	int ___ret = UpdateInstanceTransform(_this.Get(),InstanceIndex,ref NewInstanceTransform,bWorldSpace?1:0,bMarkRenderStateDirty?1:0,bTeleport?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetInstanceTransform(IntPtr _this,int InstanceIndex,out FTransform OutInstanceTransform,int bWorldSpace);
/// <summary>Get the transform for the instance specified. Instance is returned in local space of this component unless bWorldSpace is set.  Returns True on success.</summary>
public  bool GetInstanceTransform(int InstanceIndex,out FTransform OutInstanceTransform,bool bWorldSpace=false)
{
	CheckIsValid();
	int ___ret = GetInstanceTransform(_this.Get(),InstanceIndex,out OutInstanceTransform,bWorldSpace?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int AddInstanceWorldSpace(IntPtr _this,ref FTransform WorldTransform);
/// <summary>Add an instance to this component. Transform is given in world space.</summary>
public  int AddInstanceWorldSpace(FTransform WorldTransform)
{
	CheckIsValid();
	int ___ret = AddInstanceWorldSpace(_this.Get(),ref WorldTransform);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int AddInstance(IntPtr _this,ref FTransform InstanceTransform);
/// <summary>Add an instance to this component. Transform is given in local space of this component.</summary>
public  int AddInstance(FTransform InstanceTransform)
{
	CheckIsValid();
	int ___ret = AddInstance(_this.Get(),ref InstanceTransform);
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
