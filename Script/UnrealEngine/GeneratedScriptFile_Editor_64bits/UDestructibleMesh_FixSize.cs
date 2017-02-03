#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds an APEX destructible asset as well as an associated USkeletalMesh.</summary>
	public partial class UDestructibleMesh
	{
		static readonly int DefaultDestructibleParameters__Offset;
		/// <summary>Parameters controlling the destruction behavior.</summary>
		public FDestructibleParameters DefaultDestructibleParameters
		{
			get{ CheckIsValid();return (FDestructibleParameters)Marshal.PtrToStructure(_this.Get()+DefaultDestructibleParameters__Offset, typeof(FDestructibleParameters));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultDestructibleParameters__Offset, false);}
			
		}
		
		static readonly int FractureEffects__Offset;
		/// <summary>Fracture effects for each fracture level, unless overridden in the component.</summary>
		public TStructArray<FFractureEffect> FractureEffects
		{
			get{ CheckIsValid();return new TStructArray<FFractureEffect>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FractureEffects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FractureEffects__Offset, false);}
			
		}
		
		static readonly int FractureSettings__Offset;
		/// <summary>Information used to author an NxDestructibleAsset</summary>
		public UDestructibleFractureSettings FractureSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + FractureSettings__Offset); if (v == IntPtr.Zero)return null; UDestructibleFractureSettings retValue = new UDestructibleFractureSettings(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SourceStaticMesh__Offset;
		/// <summary>Static mesh this destructible mesh is created from. Is nullptr if not created from a static mesh</summary>
		public UStaticMesh SourceStaticMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SourceStaticMesh__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SourceSMImportTimestamp__Offset;
		/// <summary>Timestamp of the source static meshes last import at the time this destruction mesh has been generated.</summary>
		public FDateTime SourceSMImportTimestamp
		{
			get{ CheckIsValid();return (FDateTime)Marshal.PtrToStructure(_this.Get()+SourceSMImportTimestamp__Offset, typeof(FDateTime));}
			
		}
		
		static readonly int FractureChunkMeshes__Offset;
		/// <summary>Array of static meshes to build the fracture chunks from</summary>
		public TObjectArray<UStaticMesh>  FractureChunkMeshes
		{
					get{ CheckIsValid();return new TObjectArray<UStaticMesh>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FractureChunkMeshes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FractureChunkMeshes__Offset, false);}
			
		}
		
		static UDestructibleMesh()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DestructibleMesh");
			DefaultDestructibleParameters__Offset=GetPropertyOffset(NativeClassPtr,"DefaultDestructibleParameters");
			FractureEffects__Offset=GetPropertyOffset(NativeClassPtr,"FractureEffects");
			FractureSettings__Offset=GetPropertyOffset(NativeClassPtr,"FractureSettings");
			SourceStaticMesh__Offset=GetPropertyOffset(NativeClassPtr,"SourceStaticMesh");
			SourceSMImportTimestamp__Offset=GetPropertyOffset(NativeClassPtr,"SourceSMImportTimestamp");
			FractureChunkMeshes__Offset=GetPropertyOffset(NativeClassPtr,"FractureChunkMeshes");
			
		}
		
	}
	
}
#endif
#endif
