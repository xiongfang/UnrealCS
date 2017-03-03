#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UStaticMeshComponent
	{
		static readonly int ForcedLodModel__Offset;
		public int ForcedLodModel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ForcedLodModel__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForcedLodModel__Offset, false);}
			
		}
		
		static readonly int PreviousLODLevel__Offset;
		public int PreviousLODLevel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreviousLODLevel__Offset, typeof(int));}
			
		}
		
		static readonly int bOverrideMinLOD__Offset;
		public bool bOverrideMinLOD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideMinLOD__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideMinLOD__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MinLOD__Offset;
		public int MinLOD
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinLOD__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinLOD__Offset, false);}
			
		}
		
		static readonly int StaticMesh__Offset;
		public UStaticMesh StaticMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + StaticMesh__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + StaticMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + StaticMesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int bOverrideWireframeColor__Offset;
		public bool bOverrideWireframeColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideWireframeColor__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideWireframeColor__Offset, 1,0,1,255);}
			
		}
		
		static readonly int WireframeColorOverride__Offset;
		public FColor WireframeColorOverride
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+WireframeColorOverride__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WireframeColorOverride__Offset, false);}
			
		}
		
		static readonly int bOverrideNavigationExport__Offset;
		public bool bOverrideNavigationExport
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideNavigationExport__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bForceNavigationObstacle__Offset;
		public bool bForceNavigationObstacle
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceNavigationObstacle__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bDisallowMeshPaintPerInstance__Offset;
		public bool bDisallowMeshPaintPerInstance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisallowMeshPaintPerInstance__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisallowMeshPaintPerInstance__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bIgnoreInstanceForTextureStreaming__Offset;
		public bool bIgnoreInstanceForTextureStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreInstanceForTextureStreaming__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreInstanceForTextureStreaming__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bOverrideLightMapRes__Offset;
		public bool bOverrideLightMapRes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideLightMapRes__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideLightMapRes__Offset, 1,0,32,32);}
			
		}
		
		static readonly int OverriddenLightMapRes__Offset;
		public int OverriddenLightMapRes
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+OverriddenLightMapRes__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OverriddenLightMapRes__Offset, false);}
			
		}
		
		static readonly int bCastDistanceFieldIndirectShadow__Offset;
		public bool bCastDistanceFieldIndirectShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastDistanceFieldIndirectShadow__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastDistanceFieldIndirectShadow__Offset, 1,0,1,1);}
			
		}
		
		static readonly int DistanceFieldIndirectShadowMinVisibility__Offset;
		public float DistanceFieldIndirectShadowMinVisibility
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFieldIndirectShadowMinVisibility__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceFieldIndirectShadowMinVisibility__Offset, false);}
			
		}
		
		static readonly int StreamingDistanceMultiplier__Offset;
		public float StreamingDistanceMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StreamingDistanceMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StreamingDistanceMultiplier__Offset, false);}
			
		}
		
		static readonly int SubDivisionStepSize__Offset;
		public int SubDivisionStepSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubDivisionStepSize__Offset, typeof(int));}
			
		}
		
		static readonly int bUseSubDivisions__Offset;
		public bool bUseSubDivisions
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseSubDivisions__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int IrrelevantLights__Offset;
		public TStructArray<FGuid> IrrelevantLights
		{
			get{ CheckIsValid();return new TStructArray<FGuid>((FScriptArray)Marshal.PtrToStructure(_this.Get()+IrrelevantLights__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+IrrelevantLights__Offset, false);}
			
		}
		
		static readonly int LODData__Offset;
		public TStructArray<FStaticMeshComponentLODInfo> LODData
		{
			get{ CheckIsValid();return new TStructArray<FStaticMeshComponentLODInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODData__Offset, false);}
			
		}
		
		static readonly int StreamingTextureData__Offset;
		public TStructArray<FStreamingTextureBuildInfo> StreamingTextureData
		{
			get{ CheckIsValid();return new TStructArray<FStreamingTextureBuildInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StreamingTextureData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StreamingTextureData__Offset, false);}
			
		}
		
		static readonly int bUseDefaultCollision__Offset;
		public bool bUseDefaultCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDefaultCollision__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseDefaultCollision__Offset, 1,0,1,255);}
			
		}
		
		static readonly int LightmassSettings__Offset;
		public FLightmassPrimitiveSettings LightmassSettings
		{
			get{ CheckIsValid();return (FLightmassPrimitiveSettings)Marshal.PtrToStructure(_this.Get()+LightmassSettings__Offset, typeof(FLightmassPrimitiveSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmassSettings__Offset, false);}
			
		}
		
		static UStaticMeshComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("StaticMeshComponent");
			ForcedLodModel__Offset=GetPropertyOffset(NativeClassPtr,"ForcedLodModel");
			PreviousLODLevel__Offset=GetPropertyOffset(NativeClassPtr,"PreviousLODLevel");
			bOverrideMinLOD__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideMinLOD");
			MinLOD__Offset=GetPropertyOffset(NativeClassPtr,"MinLOD");
			StaticMesh__Offset=GetPropertyOffset(NativeClassPtr,"StaticMesh");
			bOverrideWireframeColor__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideWireframeColor");
			WireframeColorOverride__Offset=GetPropertyOffset(NativeClassPtr,"WireframeColorOverride");
			bOverrideNavigationExport__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideNavigationExport");
			bForceNavigationObstacle__Offset=GetPropertyOffset(NativeClassPtr,"bForceNavigationObstacle");
			bDisallowMeshPaintPerInstance__Offset=GetPropertyOffset(NativeClassPtr,"bDisallowMeshPaintPerInstance");
			bIgnoreInstanceForTextureStreaming__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreInstanceForTextureStreaming");
			bOverrideLightMapRes__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideLightMapRes");
			OverriddenLightMapRes__Offset=GetPropertyOffset(NativeClassPtr,"OverriddenLightMapRes");
			bCastDistanceFieldIndirectShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastDistanceFieldIndirectShadow");
			DistanceFieldIndirectShadowMinVisibility__Offset=GetPropertyOffset(NativeClassPtr,"DistanceFieldIndirectShadowMinVisibility");
			StreamingDistanceMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"StreamingDistanceMultiplier");
			SubDivisionStepSize__Offset=GetPropertyOffset(NativeClassPtr,"SubDivisionStepSize");
			bUseSubDivisions__Offset=GetPropertyOffset(NativeClassPtr,"bUseSubDivisions");
			IrrelevantLights__Offset=GetPropertyOffset(NativeClassPtr,"IrrelevantLights");
			LODData__Offset=GetPropertyOffset(NativeClassPtr,"LODData");
			StreamingTextureData__Offset=GetPropertyOffset(NativeClassPtr,"StreamingTextureData");
			bUseDefaultCollision__Offset=GetPropertyOffset(NativeClassPtr,"bUseDefaultCollision");
			LightmassSettings__Offset=GetPropertyOffset(NativeClassPtr,"LightmassSettings");
			
		}
		
	}
	
}
#endif
#endif
