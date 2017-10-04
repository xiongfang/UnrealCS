using System;
namespace UnrealEngine
{
	public partial class UAnimationAsset:UObject
	{
		/// <summary>Pointer to the Skeleton this asset can be played on .</summary>
		public USkeleton Skeleton;
		
		/// <summary>
		/// Parent Asset, if set, you won't be able to edit any data in here but just mapping table
		/// During cooking, this data will be used to bake out to normal asset
		/// </summary>
		public UAnimationAsset ParentAsset;
		
		/// <summary>Asset mapping table when ParentAsset is set</summary>
		public UAssetMappingTable AssetMappingTable;
		
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo;
		
		/// <summary>The default skeletal mesh to use when previewing this asset - this only applies when you open Persona using this asset// @todo: note that this doesn't retarget right now</summary>
		public UPoseAsset PreviewPoseAsset;
		
		
	}
	
}
