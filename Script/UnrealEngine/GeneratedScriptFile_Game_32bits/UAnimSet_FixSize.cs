#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimSet
	{
		static readonly int bAnimRotationOnly__Offset;
		public bool bAnimRotationOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAnimRotationOnly__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAnimRotationOnly__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TrackBoneNames__Offset;
		public TStructArray<FName> TrackBoneNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TrackBoneNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TrackBoneNames__Offset, false);}
			
		}
		
		static readonly int LinkupCache__Offset;
		public TStructArray<FAnimSetMeshLinkup> LinkupCache
		{
			get{ CheckIsValid();return new TStructArray<FAnimSetMeshLinkup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LinkupCache__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LinkupCache__Offset, false);}
			
		}
		
		static readonly int BoneUseAnimTranslation__Offset;
		public TStructArray<byte> BoneUseAnimTranslation
		{
			get{ CheckIsValid();return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BoneUseAnimTranslation__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BoneUseAnimTranslation__Offset, false);}
			
		}
		
		static readonly int ForceUseMeshTranslation__Offset;
		public TStructArray<byte> ForceUseMeshTranslation
		{
			get{ CheckIsValid();return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ForceUseMeshTranslation__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ForceUseMeshTranslation__Offset, false);}
			
		}
		
		static readonly int UseTranslationBoneNames__Offset;
		public TStructArray<FName> UseTranslationBoneNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+UseTranslationBoneNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+UseTranslationBoneNames__Offset, false);}
			
		}
		
		static readonly int ForceMeshTranslationBoneNames__Offset;
		public TStructArray<FName> ForceMeshTranslationBoneNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ForceMeshTranslationBoneNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ForceMeshTranslationBoneNames__Offset, false);}
			
		}
		
		static readonly int PreviewSkelMeshName__Offset;
		public FName PreviewSkelMeshName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PreviewSkelMeshName__Offset, typeof(FName));}
			
		}
		
		static readonly int BestRatioSkelMeshName__Offset;
		public FName BestRatioSkelMeshName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+BestRatioSkelMeshName__Offset, typeof(FName));}
			
		}
		
		static UAnimSet()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimSet");
			bAnimRotationOnly__Offset=GetPropertyOffset(NativeClassPtr,"bAnimRotationOnly");
			TrackBoneNames__Offset=GetPropertyOffset(NativeClassPtr,"TrackBoneNames");
			LinkupCache__Offset=GetPropertyOffset(NativeClassPtr,"LinkupCache");
			BoneUseAnimTranslation__Offset=GetPropertyOffset(NativeClassPtr,"BoneUseAnimTranslation");
			ForceUseMeshTranslation__Offset=GetPropertyOffset(NativeClassPtr,"ForceUseMeshTranslation");
			UseTranslationBoneNames__Offset=GetPropertyOffset(NativeClassPtr,"UseTranslationBoneNames");
			ForceMeshTranslationBoneNames__Offset=GetPropertyOffset(NativeClassPtr,"ForceMeshTranslationBoneNames");
			PreviewSkelMeshName__Offset=GetPropertyOffset(NativeClassPtr,"PreviewSkelMeshName");
			BestRatioSkelMeshName__Offset=GetPropertyOffset(NativeClassPtr,"BestRatioSkelMeshName");
			
		}
		
	}
	
}
#endif
#endif
