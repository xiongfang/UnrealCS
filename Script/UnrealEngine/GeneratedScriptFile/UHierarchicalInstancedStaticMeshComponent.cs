using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UHierarchicalInstancedStaticMeshComponent:UInstancedStaticMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RemoveInstances(IntPtr _this,int[] InstancesToRemove);
/// <summary>Removes all the instances with indices specified in the InstancesToRemove array. Returns true on success.</summary>
public  bool RemoveInstances(int[] InstancesToRemove)
{
	CheckIsValid();
	int ___ret = RemoveInstances(_this.Get(),InstancesToRemove);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
