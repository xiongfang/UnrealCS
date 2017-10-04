using System;
namespace UnrealEngine
{
	public partial class ALODActor:AActor
	{
		/// <summary>disable display of this component</summary>
		public UStaticMeshComponent StaticMeshComponent;
		
		/// <summary>what distance do you want this to show up instead of SubActors</summary>
		public float LODDrawDistance;
		
		/// <summary>The hierarchy level of this actor; the first tier of HLOD is level 1, the second tier is level 2 and so on.</summary>
		public int LODLevel;
		
		/// <summary>Whether or not this LODActor is not build or needs rebuilding</summary>
		public bool bDirty;
		
		/// <summary>Cached number of triangles contained in the SubActors</summary>
		public uint NumTrianglesInSubActors;
		
		/// <summary>Cached number of triangles contained in the SubActors</summary>
		public uint NumTrianglesInMergedMesh;
		
		/// <summary>Flag whether or not to use the override MaterialSettings when creating the proxy mesh</summary>
		public bool bOverrideMaterialMergeSettings;
		
		/// <summary>Override Material Settings, used when creating the proxy mesh</summary>
		public FMaterialProxySettings MaterialSettings;
		
		/// <summary>Flag whether or not to use the override TransitionScreenSize for this proxy mesh</summary>
		public bool bOverrideTransitionScreenSize;
		
		/// <summary>
		/// Override transition screen size value, determines the screen size at which the proxy is visible
		/// The screen size is based around the projected diameter of the bounding
		/// sphere of the model. i.e. 0.5 means half the screen's maximum dimension.
		/// </summary>
		public float TransitionScreenSize;
		
		/// <summary>Flag whether or not to use the override ScreenSize when creating the proxy mesh</summary>
		public bool bOverrideScreenSize;
		
		/// <summary>Override screen size value used in mesh reduction, when creating the proxy mesh</summary>
		public int ScreenSize;
		
		
	}
	
}
