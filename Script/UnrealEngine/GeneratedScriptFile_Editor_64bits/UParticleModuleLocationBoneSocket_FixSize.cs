#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationBoneSocket
	{
		static readonly int SourceType__Offset;
		/// <summary>
		/// Whether the module uses Bones or Sockets for locations.
		/// BONESOCKETSOURCE_Bones          - Use Bones as the source locations.
		/// BONESOCKETSOURCE_Sockets        - Use Sockets as the source locations.
		/// </summary>
		public ELocationBoneSocketSource SourceType
		{
			get{ CheckIsValid();return (ELocationBoneSocketSource)Marshal.PtrToStructure(_this.Get()+SourceType__Offset, typeof(ELocationBoneSocketSource));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceType__Offset, false);}
			
		}
		
		static readonly int UniversalOffset__Offset;
		/// <summary>An offset to apply to each bone/socket</summary>
		public FVector UniversalOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+UniversalOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UniversalOffset__Offset, false);}
			
		}
		
		static readonly int SourceLocations__Offset;
		/// <summary>The name(s) of the bone/socket(s) to position at. If this is empty, the module will attempt to spawn from all bones or sockets.</summary>
		public TStructArray<FLocationBoneSocketInfo> SourceLocations
		{
			get{ CheckIsValid();return new TStructArray<FLocationBoneSocketInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SourceLocations__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SourceLocations__Offset, false);}
			
		}
		
		static readonly int SelectionMethod__Offset;
		/// <summary>
		/// The method by which to select the bone/socket to spawn at.
		/// SEL_Sequential                  - loop through the bone/socket array in order
		/// SEL_Random                              - randomly select a bone/socket from the array
		/// </summary>
		public ELocationBoneSocketSelectionMethod SelectionMethod
		{
			get{ CheckIsValid();return (ELocationBoneSocketSelectionMethod)Marshal.PtrToStructure(_this.Get()+SelectionMethod__Offset, typeof(ELocationBoneSocketSelectionMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectionMethod__Offset, false);}
			
		}
		
		static readonly int bUpdatePositionEachFrame__Offset;
		/// <summary>If true, update the particle locations each frame with that of the bone/socket</summary>
		public bool bUpdatePositionEachFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdatePositionEachFrame__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdatePositionEachFrame__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOrientMeshEmitters__Offset;
		/// <summary>If true, rotate mesh emitter meshes to orient w/ the socket</summary>
		public bool bOrientMeshEmitters
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOrientMeshEmitters__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOrientMeshEmitters__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bInheritBoneVelocity__Offset;
		/// <summary>If true, particles inherit the associated bone velocity when spawned</summary>
		public bool bInheritBoneVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritBoneVelocity__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritBoneVelocity__Offset, 1,0,4,4);}
			
		}
		
		static readonly int InheritVelocityScale__Offset;
		/// <summary>A scale on how much of the bone's velocity a particle will inherit.</summary>
		public float InheritVelocityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InheritVelocityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InheritVelocityScale__Offset, false);}
			
		}
		
		static readonly int SkelMeshActorParamName__Offset;
		/// <summary>The parameter name of the skeletal mesh actor that supplies the SkelMeshComponent for in-game.</summary>
		public FName SkelMeshActorParamName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SkelMeshActorParamName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SkelMeshActorParamName__Offset, false);}
			
		}
		
		static readonly int NumPreSelectedIndices__Offset;
		/// <summary>
		/// When we have no source locations and we need to track bone velocities due to bInheritBoneVelocity, we pre select a set of bones to use each frame. This property determines how big the list is.
		/// Too low and the randomness of selection may suffer, too high and memory will be wasted.
		/// </summary>
		public int NumPreSelectedIndices
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumPreSelectedIndices__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumPreSelectedIndices__Offset, false);}
			
		}
		
		static readonly int EditorSkelMesh__Offset;
		/// <summary>The name of the skeletal mesh to use in the editor</summary>
		public USkeletalMesh EditorSkelMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EditorSkelMesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMesh retValue = new USkeletalMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + EditorSkelMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + EditorSkelMesh__Offset, value._this.Get()); }
			
		}
		
		static UParticleModuleLocationBoneSocket()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationBoneSocket");
			SourceType__Offset=GetPropertyOffset(NativeClassPtr,"SourceType");
			UniversalOffset__Offset=GetPropertyOffset(NativeClassPtr,"UniversalOffset");
			SourceLocations__Offset=GetPropertyOffset(NativeClassPtr,"SourceLocations");
			SelectionMethod__Offset=GetPropertyOffset(NativeClassPtr,"SelectionMethod");
			bUpdatePositionEachFrame__Offset=GetPropertyOffset(NativeClassPtr,"bUpdatePositionEachFrame");
			bOrientMeshEmitters__Offset=GetPropertyOffset(NativeClassPtr,"bOrientMeshEmitters");
			bInheritBoneVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bInheritBoneVelocity");
			InheritVelocityScale__Offset=GetPropertyOffset(NativeClassPtr,"InheritVelocityScale");
			SkelMeshActorParamName__Offset=GetPropertyOffset(NativeClassPtr,"SkelMeshActorParamName");
			NumPreSelectedIndices__Offset=GetPropertyOffset(NativeClassPtr,"NumPreSelectedIndices");
			EditorSkelMesh__Offset=GetPropertyOffset(NativeClassPtr,"EditorSkelMesh");
			
		}
		
	}
	
}
#endif
#endif
