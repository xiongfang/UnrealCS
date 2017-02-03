#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimationAsset
	{
		static readonly int Skeleton__Offset;
		/// <summary>Pointer to the Skeleton this asset can be played on .</summary>
		public USkeleton Skeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Skeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Skeleton__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Skeleton__Offset, value._this.Get()); }
			
		}
		
		static readonly int MetaData__Offset;
		/// <summary>
		/// Meta data that can be saved with the asset
		/// You can query by GetMetaData function
		/// </summary>
		public TObjectArray<UAnimMetaData>  MetaData
		{
					get{ CheckIsValid();return new TObjectArray<UAnimMetaData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MetaData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MetaData__Offset, false);}
			
		}
		
		static readonly int ParentAsset__Offset;
		/// <summary>
		/// Parent Asset, if set, you won't be able to edit any data in here but just mapping table
		/// During cooking, this data will be used to bake out to normal asset
		/// </summary>
		public UAnimationAsset ParentAsset
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ParentAsset__Offset); if (v == IntPtr.Zero)return null; UAnimationAsset retValue = new UAnimationAsset(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ParentAsset__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ParentAsset__Offset, value._this.Get()); }
			
		}
		
		static readonly int ChildrenAssets__Offset;
		/// <summary>note this is transient as they're added as they're loaded</summary>
		public TObjectArray<UAnimationAsset>  ChildrenAssets
		{
					get{ CheckIsValid();return new TObjectArray<UAnimationAsset>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildrenAssets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildrenAssets__Offset, false);}
			
		}
		
		static readonly int AssetMappingTable__Offset;
		/// <summary>Asset mapping table when ParentAsset is set</summary>
		public UAssetMappingTable AssetMappingTable
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AssetMappingTable__Offset); if (v == IntPtr.Zero)return null; UAssetMappingTable retValue = new UAssetMappingTable(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AssetMappingTable__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AssetMappingTable__Offset, value._this.Get()); }
			
		}
		
		static readonly int AssetUserData__Offset;
		/// <summary>Array of user data stored with the asset</summary>
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static readonly int ThumbnailInfo__Offset;
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ThumbnailInfo__Offset); if (v == IntPtr.Zero)return null; UThumbnailInfo retValue = new UThumbnailInfo(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, value._this.Get()); }
			
		}
		
		static readonly int PreviewPoseAsset__Offset;
		/// <summary>The default skeletal mesh to use when previewing this asset - this only applies when you open Persona using this asset// @todo: note that this doesn't retarget right now</summary>
		public UPoseAsset PreviewPoseAsset
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewPoseAsset__Offset); if (v == IntPtr.Zero)return null; UPoseAsset retValue = new UPoseAsset(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PreviewPoseAsset__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PreviewPoseAsset__Offset, value._this.Get()); }
			
		}
		
		static UAnimationAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimationAsset");
			Skeleton__Offset=GetPropertyOffset(NativeClassPtr,"Skeleton");
			MetaData__Offset=GetPropertyOffset(NativeClassPtr,"MetaData");
			ParentAsset__Offset=GetPropertyOffset(NativeClassPtr,"ParentAsset");
			ChildrenAssets__Offset=GetPropertyOffset(NativeClassPtr,"ChildrenAssets");
			AssetMappingTable__Offset=GetPropertyOffset(NativeClassPtr,"AssetMappingTable");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			ThumbnailInfo__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailInfo");
			PreviewPoseAsset__Offset=GetPropertyOffset(NativeClassPtr,"PreviewPoseAsset");
			
		}
		
	}
	
}
#endif
#endif
