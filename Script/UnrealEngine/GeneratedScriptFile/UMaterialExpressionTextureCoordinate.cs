using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureCoordinate:UMaterialExpression
	{
		/// <summary>Texture coordinate index</summary>
		public int CoordinateIndex;
		
		/// <summary>Controls how much the texture tiles horizontally, by scaling the U component of the vertex UVs by the specified amount.</summary>
		public float UTiling;
		
		/// <summary>Controls how much the texture tiles vertically, by scaling the V component of the vertex UVs by the specified amount.</summary>
		public float VTiling;
		
		/// <summary>
		/// Would like to unmirror U or V
		/// - if the texture is mirrored and if you would like to undo mirroring for this texture sample, use this to unmirror
		/// </summary>
		public bool UnMirrorU;
		
		public bool UnMirrorV;
		
		
	}
	
}
