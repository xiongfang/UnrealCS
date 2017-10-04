using System;
namespace UnrealEngine
{
	public partial class UDestructibleMesh:USkeletalMesh
	{
		/// <summary>Parameters controlling the destruction behavior.</summary>
		public FDestructibleParameters DefaultDestructibleParameters;
		
		/// <summary>Information used to author an NxDestructibleAsset</summary>
		public UDestructibleFractureSettings FractureSettings;
		
		/// <summary>Static mesh this destructible mesh is created from. Is nullptr if not created from a static mesh</summary>
		public UStaticMesh SourceStaticMesh;
		
		/// <summary>Timestamp of the source static meshes last import at the time this destruction mesh has been generated.</summary>
		public FDateTime SourceSMImportTimestamp;
		
		
	}
	
}
