#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimSet
	{
		static readonly int bAnimRotationOnly__Offset;
		/// <summary>
		/// Indicates that only the rotation should be taken from the animation sequence and the translation should come from the USkeletalMesh ref pose.
		/// Note that the root bone always takes translation from the animation, even if this flag is set.
		/// You can use the UseTranslationBoneNames array to specify other bones that should use translation with this flag set.
		/// </summary>
		public bool bAnimRotationOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAnimRotationOnly__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAnimRotationOnly__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TrackBoneNames__Offset;
		/// <summary>Bone name that each track relates to. TrackBoneName.Num() == Number of tracks.</summary>
		public TStructArray<FName> TrackBoneNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TrackBoneNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TrackBoneNames__Offset, false);}
			
		}
		
		static readonly int Sequences__Offset;
		/// <summary>Actual animation sequence information.</summary>
		public TObjectArray<UAnimSequence>  Sequences
		{
					get{ CheckIsValid();return new TObjectArray<UAnimSequence>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sequences__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sequences__Offset, false);}
			
		}
		
		static readonly int LinkupCache__Offset;
		/// <summary>Non-serialised cache of linkups between different skeletal meshes and this AnimSet. // @UE4: Do not change private - they will go away</summary>
		public TStructArray<FAnimSetMeshLinkup> LinkupCache
		{
			get{ CheckIsValid();return new TStructArray<FAnimSetMeshLinkup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LinkupCache__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LinkupCache__Offset, false);}
			
		}
		
		static readonly int BoneUseAnimTranslation__Offset;
		/// <summary>
		/// Array of booleans that indicate whether or not to read the translation of a bone from animation or ref skeleton.
		/// This is basically a cooked down version of UseTranslationBoneNames for speed.
		/// Size matches the number of tracks.
		///    // @UE4: Do not change private - they will go away
		/// </summary>
		public TStructArray<byte> BoneUseAnimTranslation
		{
			get{ CheckIsValid();return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BoneUseAnimTranslation__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BoneUseAnimTranslation__Offset, false);}
			
		}
		
		static readonly int ForceUseMeshTranslation__Offset;
		/// <summary>Cooked down version of ForceMeshTranslationBoneNames // @UE4: Do not change private - they will go away</summary>
		public TStructArray<byte> ForceUseMeshTranslation
		{
			get{ CheckIsValid();return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ForceUseMeshTranslation__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ForceUseMeshTranslation__Offset, false);}
			
		}
		
		static readonly int UseTranslationBoneNames__Offset;
		/// <summary>Names of bones that should use translation from the animation, if bAnimRotationOnly is set. // @UE4: Do not change private - they will go away</summary>
		public TStructArray<FName> UseTranslationBoneNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+UseTranslationBoneNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+UseTranslationBoneNames__Offset, false);}
			
		}
		
		static readonly int ForceMeshTranslationBoneNames__Offset;
		/// <summary>List of bones which are ALWAYS going to use their translation from the mesh and not the animation. // @UE4: Do not change private - they will go away</summary>
		public TStructArray<FName> ForceMeshTranslationBoneNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ForceMeshTranslationBoneNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ForceMeshTranslationBoneNames__Offset, false);}
			
		}
		
		static readonly int PreviewSkelMeshName__Offset;
		/// <summary>In the AnimSetEditor, when you switch to this AnimSet, it sees if this skeletal mesh is loaded and if so switches to it.</summary>
		public FName PreviewSkelMeshName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PreviewSkelMeshName__Offset, typeof(FName));}
			
		}
		
		static readonly int BestRatioSkelMeshName__Offset;
		/// <summary>Holds the name of the skeletal mesh whose reference skeleton best matches the TrackBoneName array.</summary>
		public FName BestRatioSkelMeshName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+BestRatioSkelMeshName__Offset, typeof(FName));}
			
		}
		
		static UAnimSet()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimSet");
			bAnimRotationOnly__Offset=GetPropertyOffset(NativeClassPtr,"bAnimRotationOnly");
			TrackBoneNames__Offset=GetPropertyOffset(NativeClassPtr,"TrackBoneNames");
			Sequences__Offset=GetPropertyOffset(NativeClassPtr,"Sequences");
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
