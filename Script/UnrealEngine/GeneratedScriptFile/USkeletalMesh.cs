using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USkeletalMesh:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsSectionUsingCloth(IntPtr _this,int InSectionIndex,int bCheckCorrespondingSections);
/// <summary>
/// Checks whether the provided section is using APEX cloth. if bCheckCorrespondingSections is true
/// disabled sections will defer to correspond sections to see if they use cloth (non-cloth sections
/// are disabled and another section added when cloth is enabled, using this flag allows for a check
/// on the original section to succeed)
/// @param InSectionIndex Index to check
/// @param bCheckCorrespondingSections Whether to check corresponding sections for disabled sections
/// </summary>
public  bool IsSectionUsingCloth(int InSectionIndex,bool bCheckCorrespondingSections=true)
{
	CheckIsValid();
	int ___ret = IsSectionUsingCloth(_this.Get(),InSectionIndex,bCheckCorrespondingSections?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetSocketByIndex(IntPtr _this,int Index);
/// <summary>Returns a socket by index. Max index is NumSockets(). The meshes sockets are accessed first, then the skeletons.</summary>
public  USkeletalMeshSocket GetSocketByIndex(int Index)
{
	CheckIsValid();
	IntPtr ___ret = GetSocketByIndex(_this.Get(),Index);
	if(___ret==IntPtr.Zero) return null; USkeletalMeshSocket ___ret2= new USkeletalMeshSocket(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NumSockets(IntPtr _this);
/// <summary>Returns the number of sockets available. Both on this mesh and it's skeleton.</summary>
public  int NumSockets()
{
	CheckIsValid();
	int ___ret = NumSockets(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr FindSocketAndIndex(IntPtr _this,string InSocketName,out int OutIndex);
/// <summary>
/// Find a socket object in this SkeletalMesh by name.
/// Entering NAME_None will return NULL. If there are multiple sockets with the same name, will return the first one.
/// Also returns the index for the socket allowing for future fast access via GetSocketByIndex()
/// </summary>
public  USkeletalMeshSocket FindSocketAndIndex(string InSocketName,out int OutIndex)
{
	CheckIsValid();
	IntPtr ___ret = FindSocketAndIndex(_this.Get(),InSocketName,out OutIndex);
	if(___ret==IntPtr.Zero) return null; USkeletalMeshSocket ___ret2= new USkeletalMeshSocket(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr FindSocket(IntPtr _this,string InSocketName);
/// <summary>
/// Find a socket object in this SkeletalMesh by name.
/// Entering NAME_None will return NULL. If there are multiple sockets with the same name, will return the first one.
/// </summary>
public  USkeletalMeshSocket FindSocket(string InSocketName)
{
	CheckIsValid();
	IntPtr ___ret = FindSocket(_this.Get(),InSocketName);
	if(___ret==IntPtr.Zero) return null; USkeletalMeshSocket ___ret2= new USkeletalMeshSocket(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FBoxSphereBounds GetImportedBounds(IntPtr _this);
/// <summary>Get the original imported bounds of the skel mesh</summary>
public  FBoxSphereBounds GetImportedBounds()
{
	CheckIsValid();
	FBoxSphereBounds ___ret = GetImportedBounds(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FBoxSphereBounds GetBounds(IntPtr _this);
/// <summary>Get the extended bounds of this mesh (imported bounds plus bounds extension)</summary>
public  FBoxSphereBounds GetBounds()
{
	CheckIsValid();
	FBoxSphereBounds ___ret = GetBounds(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
