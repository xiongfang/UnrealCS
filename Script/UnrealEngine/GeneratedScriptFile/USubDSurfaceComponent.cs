using System;
namespace UnrealEngine
{
	public partial class USubDSurfaceComponent:UPrimitiveComponent
	{
		/// <summary>Change the SubDSurface used by this instance.</summary>
		public extern virtual bool SetMesh(USubDSurface NewMesh);
		public USubDSurface Mesh;
		
		/// <summary>Refinement Level of the SubD mesh</summary>
		public int DebugLevel;
		
		public UStaticMeshComponent DisplayMeshComponent;
		
		
	}
	
}
