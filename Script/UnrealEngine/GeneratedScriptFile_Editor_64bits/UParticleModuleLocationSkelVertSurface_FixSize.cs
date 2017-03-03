#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationSkelVertSurface
	{
		static readonly int SourceType__Offset;
		/// <summary>
		/// Whether the module uses Verts or Surfaces for locations.
		/// VERTSURFACESOURCE_Vert          - Use Verts as the source locations.
		/// VERTSURFACESOURCE_Surface       - Use Surfaces as the source locations.
		/// </summary>
		public ELocationSkelVertSurfaceSource SourceType
		{
			get{ CheckIsValid();return (ELocationSkelVertSurfaceSource)Marshal.PtrToStructure(_this.Get()+SourceType__Offset, typeof(ELocationSkelVertSurfaceSource));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceType__Offset, false);}
			
		}
		
		static readonly int UniversalOffset__Offset;
		/// <summary>An offset to apply to each vert/surface</summary>
		public FVector UniversalOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+UniversalOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UniversalOffset__Offset, false);}
			
		}
		
		static readonly int bUpdatePositionEachFrame__Offset;
		/// <summary>If true, update the particle locations each frame with that of the vert/surface</summary>
		public bool bUpdatePositionEachFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdatePositionEachFrame__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdatePositionEachFrame__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOrientMeshEmitters__Offset;
		/// <summary>If true, rotate mesh emitter meshes to orient w/ the vert/surface</summary>
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
		
		static readonly int EditorSkelMesh__Offset;
		/// <summary>The name of the skeletal mesh to use in the editor</summary>
		public USkeletalMesh EditorSkelMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EditorSkelMesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMesh retValue = new USkeletalMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + EditorSkelMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + EditorSkelMesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int ValidAssociatedBones__Offset;
		/// <summary>This module will only spawn from verts or surfaces associated with the bones in this list</summary>
		public TStructArray<FName> ValidAssociatedBones
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ValidAssociatedBones__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ValidAssociatedBones__Offset, false);}
			
		}
		
		static readonly int bEnforceNormalCheck__Offset;
		/// <summary>When true use the RestrictToNormal and NormalTolerance values to check surface normals</summary>
		public bool bEnforceNormalCheck
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnforceNormalCheck__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnforceNormalCheck__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NormalToCompare__Offset;
		/// <summary>Use this normal to restrict spawning locations</summary>
		public FVector NormalToCompare
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+NormalToCompare__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalToCompare__Offset, false);}
			
		}
		
		static readonly int NormalCheckToleranceDegrees__Offset;
		/// <summary>Normal tolerance.  0 degrees means it must be an exact match, 180 degrees means it can be any angle.</summary>
		public float NormalCheckToleranceDegrees
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NormalCheckToleranceDegrees__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalCheckToleranceDegrees__Offset, false);}
			
		}
		
		static readonly int NormalCheckTolerance__Offset;
		/// <summary>
		/// Normal tolerance.  Value between 1.0 and -1.0 with 1.0 being exact match, 0.0 being everything up to
		///               perpendicular and -1.0 being any direction or don't restrict at all.
		/// </summary>
		public float NormalCheckTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NormalCheckTolerance__Offset, typeof(float));}
			
		}
		
		static readonly int ValidMaterialIndices__Offset;
		/// <summary>
		/// Array of material indices that are valid materials to spawn from.
		/// If empty, any material will be considered valid
		/// </summary>
		public TStructArray<int> ValidMaterialIndices
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ValidMaterialIndices__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ValidMaterialIndices__Offset, false);}
			
		}
		
		static readonly int bInheritVertexColor__Offset;
		/// <summary>If true, particles inherit the associated vertex color on spawn. This feature is not supported for GPU particles.</summary>
		public bool bInheritVertexColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritVertexColor__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritVertexColor__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bInheritUV__Offset;
		/// <summary>If true, particles inherit the associated UV data on spawn. Accessed through dynamic parameter module X and Y, must be a "Spawn Time Only" parameter on "AutoSet" mode. This feature is not supported for GPU particles.</summary>
		public bool bInheritUV
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritUV__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritUV__Offset, 1,0,2,2);}
			
		}
		
		static readonly int InheritUVChannel__Offset;
		/// <summary>UV channel to inherit from the spawn mesh, internally clamped to those available.</summary>
		public uint InheritUVChannel
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+InheritUVChannel__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InheritUVChannel__Offset, false);}
			
		}
		
		static UParticleModuleLocationSkelVertSurface()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationSkelVertSurface");
			SourceType__Offset=GetPropertyOffset(NativeClassPtr,"SourceType");
			UniversalOffset__Offset=GetPropertyOffset(NativeClassPtr,"UniversalOffset");
			bUpdatePositionEachFrame__Offset=GetPropertyOffset(NativeClassPtr,"bUpdatePositionEachFrame");
			bOrientMeshEmitters__Offset=GetPropertyOffset(NativeClassPtr,"bOrientMeshEmitters");
			bInheritBoneVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bInheritBoneVelocity");
			InheritVelocityScale__Offset=GetPropertyOffset(NativeClassPtr,"InheritVelocityScale");
			SkelMeshActorParamName__Offset=GetPropertyOffset(NativeClassPtr,"SkelMeshActorParamName");
			EditorSkelMesh__Offset=GetPropertyOffset(NativeClassPtr,"EditorSkelMesh");
			ValidAssociatedBones__Offset=GetPropertyOffset(NativeClassPtr,"ValidAssociatedBones");
			bEnforceNormalCheck__Offset=GetPropertyOffset(NativeClassPtr,"bEnforceNormalCheck");
			NormalToCompare__Offset=GetPropertyOffset(NativeClassPtr,"NormalToCompare");
			NormalCheckToleranceDegrees__Offset=GetPropertyOffset(NativeClassPtr,"NormalCheckToleranceDegrees");
			NormalCheckTolerance__Offset=GetPropertyOffset(NativeClassPtr,"NormalCheckTolerance");
			ValidMaterialIndices__Offset=GetPropertyOffset(NativeClassPtr,"ValidMaterialIndices");
			bInheritVertexColor__Offset=GetPropertyOffset(NativeClassPtr,"bInheritVertexColor");
			bInheritUV__Offset=GetPropertyOffset(NativeClassPtr,"bInheritUV");
			InheritUVChannel__Offset=GetPropertyOffset(NativeClassPtr,"InheritUVChannel");
			
		}
		
	}
	
}
#endif
#endif
