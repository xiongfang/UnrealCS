using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EHasCustomNavigableGeometry:byte
	{
		/// <summary>Primitive doesn't have custom navigation geometry, if collision is enabled then its convex/trimesh collision will be used for generating the navmesh</summary>
		No=0,
		/// <summary>If primitive would normally affect navmesh, DoCustomNavigableGeometryExport() should be called to export this primitive's navigable geometry</summary>
		Yes=1,
		/// <summary>DoCustomNavigableGeometryExport() should be called even if the mesh is non-collidable and wouldn't normally affect the navmesh</summary>
		EvenIfNotCollidable=2,
		/// <summary>Don't export navigable geometry even if primitive is relevant for navigation (can still add modifiers)</summary>
		DontExport=3,
		EHasCustomNavigableGeometry_MAX=4,
		
	}
	
}
