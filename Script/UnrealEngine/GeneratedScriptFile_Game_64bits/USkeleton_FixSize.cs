#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USkeleton
	{
		static readonly int BoneTree__Offset;
		public TStructArray<FBoneNode> BoneTree
		{
			get{ CheckIsValid();return new TStructArray<FBoneNode>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BoneTree__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BoneTree__Offset, false);}
			
		}
		
		static readonly int RefLocalPoses__Offset;
		public TStructArray<FTransform> RefLocalPoses
		{
			get{ CheckIsValid();return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RefLocalPoses__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RefLocalPoses__Offset, false);}
			
		}
		
		static readonly int VirtualBoneGuid__Offset;
		public FGuid VirtualBoneGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+VirtualBoneGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int VirtualBones__Offset;
		public TStructArray<FVirtualBone> VirtualBones
		{
			get{ CheckIsValid();return new TStructArray<FVirtualBone>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VirtualBones__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VirtualBones__Offset, false);}
			
		}
		
		static readonly int LinkupCache__Offset;
		public TStructArray<FSkeletonToMeshLinkup> LinkupCache
		{
			get{ CheckIsValid();return new TStructArray<FSkeletonToMeshLinkup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LinkupCache__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LinkupCache__Offset, false);}
			
		}
		
		static readonly int Sockets__Offset;
		public TObjectArray<USkeletalMeshSocket>  Sockets
		{
					get{ CheckIsValid();return new TObjectArray<USkeletalMeshSocket>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sockets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sockets__Offset, false);}
			
		}
		
		static readonly int SmartNames__Offset;
		public FSmartNameContainer SmartNames
		{
			get{ CheckIsValid();return (FSmartNameContainer)Marshal.PtrToStructure(_this.Get()+SmartNames__Offset, typeof(FSmartNameContainer));}
			
		}
		
		static readonly int BlendProfiles__Offset;
		public TObjectArray<UBlendProfile>  BlendProfiles
		{
					get{ CheckIsValid();return new TObjectArray<UBlendProfile>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BlendProfiles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BlendProfiles__Offset, false);}
			
		}
		
		static readonly int SlotGroups__Offset;
		public TStructArray<FAnimSlotGroup> SlotGroups
		{
			get{ CheckIsValid();return new TStructArray<FAnimSlotGroup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SlotGroups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SlotGroups__Offset, false);}
			
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
			
		}
		
	}
	
}
#endif
#endif
