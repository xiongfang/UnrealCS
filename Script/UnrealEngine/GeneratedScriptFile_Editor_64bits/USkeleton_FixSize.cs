#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// USkeleton : that links between mesh and animation
	///         - Bone hierarchy for animations
	///         - Bone/track linkup between mesh and animation
	///         - Retargetting related
	///         - Mirror table
	/// </summary>
	public partial class USkeleton
	{
		static readonly int BoneTree__Offset;
		/// <summary>Skeleton bone tree - each contains name and parent index*</summary>
		public TStructArray<FBoneNode> BoneTree
		{
			get{ CheckIsValid();return new TStructArray<FBoneNode>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BoneTree__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BoneTree__Offset, false);}
			
		}
		
		static readonly int RefLocalPoses__Offset;
		/// <summary>Reference skeleton poses in local space</summary>
		public TStructArray<FTransform> RefLocalPoses
		{
			get{ CheckIsValid();return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RefLocalPoses__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RefLocalPoses__Offset, false);}
			
		}
		
		static readonly int VirtualBoneGuid__Offset;
		/// <summary>
		/// Guid for virtual bones.
		/// Separate so that we don't have to dirty the original guid when only changing virtual bones
		/// </summary>
		public FGuid VirtualBoneGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+VirtualBoneGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int VirtualBones__Offset;
		/// <summary>
		/// Array of this skeletons virtual bones. These are new bones are links between two existing bones
		/// and are baked into all the skeletons animations
		/// </summary>
		public TStructArray<FVirtualBone> VirtualBones
		{
			get{ CheckIsValid();return new TStructArray<FVirtualBone>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VirtualBones__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VirtualBones__Offset, false);}
			
		}
		
		static readonly int LinkupCache__Offset;
		/// <summary>Non-serialised cache of linkups between different skeletal meshes and this Skeleton.</summary>
		public TStructArray<FSkeletonToMeshLinkup> LinkupCache
		{
			get{ CheckIsValid();return new TStructArray<FSkeletonToMeshLinkup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LinkupCache__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LinkupCache__Offset, false);}
			
		}
		
		static readonly int Sockets__Offset;
		/// <summary>
		/// Array of named socket locations, set up in editor and used as a shortcut instead of specifying
		/// everything explicitly to AttachComponent in the SkeletalMeshComponent.
		/// </summary>
		public TObjectArray<USkeletalMeshSocket>  Sockets
		{
					get{ CheckIsValid();return new TObjectArray<USkeletalMeshSocket>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sockets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sockets__Offset, false);}
			
		}
		
		static readonly int SmartNames__Offset;
		/// <summary>Container for smart name mappings</summary>
		public FSmartNameContainer SmartNames
		{
			get{ CheckIsValid();return (FSmartNameContainer)Marshal.PtrToStructure(_this.Get()+SmartNames__Offset, typeof(FSmartNameContainer));}
			
		}
		
		static readonly int BlendProfiles__Offset;
		/// <summary>List of blend profiles available in this skeleton</summary>
		public TObjectArray<UBlendProfile>  BlendProfiles
		{
					get{ CheckIsValid();return new TObjectArray<UBlendProfile>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BlendProfiles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BlendProfiles__Offset, false);}
			
		}
		
		static readonly int SlotGroups__Offset;
		/// <summary>serialized slot groups and slot names.</summary>
		public TStructArray<FAnimSlotGroup> SlotGroups
		{
			get{ CheckIsValid();return new TStructArray<FAnimSlotGroup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SlotGroups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SlotGroups__Offset, false);}
			
		}
		
		static readonly int RigConfig__Offset;
		public FRigConfiguration RigConfig
		{
			get{ CheckIsValid();return (FRigConfiguration)Marshal.PtrToStructure(_this.Get()+RigConfig__Offset, typeof(FRigConfiguration));}
			
		}
		
		static readonly int AnimationNotifies__Offset;
		/// <summary>AnimNotifiers that has been created. Right now there is no delete step for this, but in the future we'll supply delete*</summary>
		public TStructArray<FName> AnimationNotifies
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AnimationNotifies__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AnimationNotifies__Offset, false);}
			
		}
		
		static readonly int PreviewAttachedAssetContainer__Offset;
		/// <summary>Attached assets component for this skeleton</summary>
		public FPreviewAssetAttachContainer PreviewAttachedAssetContainer
		{
			get{ CheckIsValid();return (FPreviewAssetAttachContainer)Marshal.PtrToStructure(_this.Get()+PreviewAttachedAssetContainer__Offset, typeof(FPreviewAssetAttachContainer));}
			
		}
		
		static USkeleton()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Skeleton");
			BoneTree__Offset=GetPropertyOffset(NativeClassPtr,"BoneTree");
			RefLocalPoses__Offset=GetPropertyOffset(NativeClassPtr,"RefLocalPoses");
			VirtualBoneGuid__Offset=GetPropertyOffset(NativeClassPtr,"VirtualBoneGuid");
			VirtualBones__Offset=GetPropertyOffset(NativeClassPtr,"VirtualBones");
			LinkupCache__Offset=GetPropertyOffset(NativeClassPtr,"LinkupCache");
			Sockets__Offset=GetPropertyOffset(NativeClassPtr,"Sockets");
			SmartNames__Offset=GetPropertyOffset(NativeClassPtr,"SmartNames");
			BlendProfiles__Offset=GetPropertyOffset(NativeClassPtr,"BlendProfiles");
			SlotGroups__Offset=GetPropertyOffset(NativeClassPtr,"SlotGroups");
			RigConfig__Offset=GetPropertyOffset(NativeClassPtr,"RigConfig");
			AnimationNotifies__Offset=GetPropertyOffset(NativeClassPtr,"AnimationNotifies");
			PreviewAttachedAssetContainer__Offset=GetPropertyOffset(NativeClassPtr,"PreviewAttachedAssetContainer");
			
		}
		
	}
	
}
#endif
#endif
