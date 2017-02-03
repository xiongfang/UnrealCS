using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EEmitterNormalsMode:byte
	{
		/// <summary>Default mode, normals are based on the camera facing geometry.</summary>
		ENM_CameraFacing=0,
		/// <summary>Normals are generated from a sphere centered at NormalsSphereCenter.</summary>
		ENM_Spherical=1,
		/// <summary>Normals are generated from a cylinder going through NormalsSphereCenter, in the direction NormalsCylinderDirection.</summary>
		ENM_Cylindrical=2,
		ENM_MAX=3,
		
	}
	
}
