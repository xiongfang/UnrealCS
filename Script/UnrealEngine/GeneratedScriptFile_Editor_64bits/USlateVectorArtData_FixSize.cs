#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Turn static mesh data into Slate's simple vector art format.</summary>
	public partial class USlateVectorArtData
	{
		static readonly int MeshAsset__Offset;
		/// <summary>The mesh data asset from which the vector art is sourced</summary>
		public UStaticMesh MeshAsset
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MeshAsset__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + MeshAsset__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + MeshAsset__Offset, value._this.Get()); }
			
		}
		
		static readonly int SourceMaterial__Offset;
		/// <summary>The material which we are using, or the material from with the MIC was constructed.</summary>
		public UMaterialInterface SourceMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SourceMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexData__Offset;
		/// <summary>@see GetVertexData()</summary>
		public TStructArray<FSlateMeshVertex> VertexData
		{
			get{ CheckIsValid();return new TStructArray<FSlateMeshVertex>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VertexData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VertexData__Offset, false);}
			
		}
		
		static readonly int IndexData__Offset;
		/// <summary>@see GetIndexData()</summary>
		public TStructArray<uint> IndexData
		{
			get{ CheckIsValid();return new TStructArray<uint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+IndexData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+IndexData__Offset, false);}
			
		}
		
		static readonly int Material__Offset;
		/// <summary>@see GetMaterial()</summary>
		public UMaterialInterface Material
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Material__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ExtentMin__Offset;
		public FVector2D ExtentMin
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+ExtentMin__Offset, typeof(FVector2D));}
			
		}
		
		static readonly int ExtentMax__Offset;
		public FVector2D ExtentMax
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+ExtentMax__Offset, typeof(FVector2D));}
			
		}
		
		static USlateVectorArtData()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SlateVectorArtData");
			MeshAsset__Offset=GetPropertyOffset(NativeClassPtr,"MeshAsset");
			SourceMaterial__Offset=GetPropertyOffset(NativeClassPtr,"SourceMaterial");
			VertexData__Offset=GetPropertyOffset(NativeClassPtr,"VertexData");
			IndexData__Offset=GetPropertyOffset(NativeClassPtr,"IndexData");
			Material__Offset=GetPropertyOffset(NativeClassPtr,"Material");
			ExtentMin__Offset=GetPropertyOffset(NativeClassPtr,"ExtentMin");
			ExtentMax__Offset=GetPropertyOffset(NativeClassPtr,"ExtentMax");
			
		}
		
	}
	
}
#endif
#endif
