#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Information to create an NxDestructibleAsset</summary>
	public partial class UDestructibleFractureSettings
	{
		static readonly int CellSiteCount__Offset;
		/// <summary>The number of voronoi cell sites.</summary>
		public int CellSiteCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CellSiteCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CellSiteCount__Offset, false);}
			
		}
		
		static readonly int FractureMaterialDesc__Offset;
		/// <summary>Stored interior material data.  Just need one as we only support Voronoi splitting.</summary>
		public FFractureMaterial FractureMaterialDesc
		{
			get{ CheckIsValid();return (FFractureMaterial)Marshal.PtrToStructure(_this.Get()+FractureMaterialDesc__Offset, typeof(FFractureMaterial));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FractureMaterialDesc__Offset, false);}
			
		}
		
		static readonly int RandomSeed__Offset;
		/// <summary>Random seed for reproducibility</summary>
		public int RandomSeed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RandomSeed__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RandomSeed__Offset, false);}
			
		}
		
		static readonly int VoronoiSites__Offset;
		/// <summary>Stored Voronoi sites</summary>
		public TStructArray<FVector> VoronoiSites
		{
			get{ CheckIsValid();return new TStructArray<FVector>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VoronoiSites__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VoronoiSites__Offset, false);}
			
		}
		
		static readonly int OriginalSubmeshCount__Offset;
		/// <summary>The mesh's original number of submeshes.  APEX needs to store this in the authoring.</summary>
		public int OriginalSubmeshCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+OriginalSubmeshCount__Offset, typeof(int));}
			
		}
		
		static readonly int Materials__Offset;
		/// <summary>APEX references materials by name, but we'll bypass that mechanism and use of UE materials instead.</summary>
		public TObjectArray<UMaterialInterface>  Materials
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialInterface>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Materials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Materials__Offset, false);}
			
		}
		
		static readonly int ChunkParameters__Offset;
		/// <summary>Per-chunk authoring parameters, which should be made writable when a chunk selection GUI is in place.</summary>
		public TStructArray<FDestructibleChunkParameters> ChunkParameters
		{
			get{ CheckIsValid();return new TStructArray<FDestructibleChunkParameters>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChunkParameters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChunkParameters__Offset, false);}
			
		}
		
		static UDestructibleFractureSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DestructibleFractureSettings");
			CellSiteCount__Offset=GetPropertyOffset(NativeClassPtr,"CellSiteCount");
			FractureMaterialDesc__Offset=GetPropertyOffset(NativeClassPtr,"FractureMaterialDesc");
			RandomSeed__Offset=GetPropertyOffset(NativeClassPtr,"RandomSeed");
			VoronoiSites__Offset=GetPropertyOffset(NativeClassPtr,"VoronoiSites");
			OriginalSubmeshCount__Offset=GetPropertyOffset(NativeClassPtr,"OriginalSubmeshCount");
			Materials__Offset=GetPropertyOffset(NativeClassPtr,"Materials");
			ChunkParameters__Offset=GetPropertyOffset(NativeClassPtr,"ChunkParameters");
			
		}
		
	}
	
}
#endif
#endif
