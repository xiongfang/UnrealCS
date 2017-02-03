using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UStaticMesh:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumSections(IntPtr _this,int InLOD);
/// <summary>Returns number of Sections that this StaticMesh has, in the supplied LOD (LOD 0 is the highest)</summary>
public  int GetNumSections(int InLOD)
{
	CheckIsValid();
	int ___ret = GetNumSections(_this.Get(),InLOD);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FBox GetBoundingBox(IntPtr _this);
/// <summary>Returns the bounding box, in local space including bounds extension(s), of the StaticMesh asset</summary>
public  FBox GetBoundingBox()
{
	CheckIsValid();
	FBox ___ret = GetBoundingBox(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FBoxSphereBounds GetBounds(IntPtr _this);
/// <summary>
/// Returns the number of bounds of the mesh.
/// @return      The bounding box represented as box origin with extents and also a sphere that encapsulates that box
/// </summary>
public  FBoxSphereBounds GetBounds()
{
	CheckIsValid();
	FBoxSphereBounds ___ret = GetBounds(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumLODs(IntPtr _this);
/// <summary>Returns the number of LODs used by the mesh.</summary>
public  int GetNumLODs()
{
	CheckIsValid();
	int ___ret = GetNumLODs(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
