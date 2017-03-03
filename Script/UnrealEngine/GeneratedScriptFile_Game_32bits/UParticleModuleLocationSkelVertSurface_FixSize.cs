#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationSkelVertSurface
	{
		static readonly int SourceType__Offset;
		public ELocationSkelVertSurfaceSource SourceType
		{
			get{ CheckIsValid();return (ELocationSkelVertSurfaceSource)Marshal.PtrToStructure(_this.Get()+SourceType__Offset, typeof(ELocationSkelVertSurfaceSource));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceType__Offset, false);}
			
		}
		
		static readonly int UniversalOffset__Offset;
		public FVector UniversalOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+UniversalOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UniversalOffset__Offset, false);}
			
		}
		
		static readonly int bUpdatePositionEachFrame__Offset;
		public bool bUpdatePositionEachFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdatePositionEachFrame__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdatePositionEachFrame__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOrientMeshEmitters__Offset;
		public bool bOrientMeshEmitters
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOrientMeshEmitters__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOrientMeshEmitters__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bInheritBoneVelocity__Offset;
		public bool bInheritBoneVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritBoneVelocity__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritBoneVelocity__Offset, 1,0,4,4);}
			
		}
		
		static readonly int InheritVelocityScale__Offset;
		public float InheritVelocityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InheritVelocityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InheritVelocityScale__Offset, false);}
			
		}
		
		static readonly int SkelMeshActorParamName__Offset;
		public FName SkelMeshActorParamName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SkelMeshActorParamName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SkelMeshActorParamName__Offset, false);}
			
		}
		
		static readonly int ValidAssociatedBones__Offset;
		public TStructArray<FName> ValidAssociatedBones
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ValidAssociatedBones__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ValidAssociatedBones__Offset, false);}
			
		}
		
		static readonly int bEnforceNormalCheck__Offset;
		public bool bEnforceNormalCheck
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnforceNormalCheck__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnforceNormalCheck__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NormalToCompare__Offset;
		public FVector NormalToCompare
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+NormalToCompare__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalToCompare__Offset, false);}
			
		}
		
		static readonly int NormalCheckToleranceDegrees__Offset;
		public float NormalCheckToleranceDegrees
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NormalCheckToleranceDegrees__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalCheckToleranceDegrees__Offset, false);}
			
		}
		
		static readonly int NormalCheckTolerance__Offset;
		public float NormalCheckTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NormalCheckTolerance__Offset, typeof(float));}
			
		}
		
		static readonly int ValidMaterialIndices__Offset;
		public TStructArray<int> ValidMaterialIndices
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ValidMaterialIndices__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ValidMaterialIndices__Offset, false);}
			
		}
		
		static readonly int bInheritVertexColor__Offset;
		public bool bInheritVertexColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritVertexColor__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritVertexColor__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bInheritUV__Offset;
		public bool bInheritUV
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritUV__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritUV__Offset, 1,0,2,2);}
			
		}
		
		static readonly int InheritUVChannel__Offset;
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
