using System;
namespace UnrealEngine
{
	public partial class UVectorField:UObject
	{
		/// <summary>Bounds of the volume in local space.</summary>
		public FBox Bounds;
		
		/// <summary>The intensity with which to multiplie vectors in this field.</summary>
		public float Intensity;
		
		
	}
	
}
