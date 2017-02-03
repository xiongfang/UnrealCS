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
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			ThumbnailInfo__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailInfo");
			PreviewPoseAsset__Offset=GetPropertyOffset(NativeClassPtr,"PreviewPoseAsset");
			
		}
		
	}
	
}
#endif
#endif
