#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Subdivision Surface Asset (Experimental, Early work in progress)</summary>
	public partial class USubDSurface
	{
		static readonly int VertexCountPerFace__Offset;
		/// <summary>
		/// becomes TopologyDescriptor::numVertsPerFace, TopologyDescriptor::numFaces = .Num()
		/// 32bit for OpenSubDiv TopologyDescriptor but it could be limited to 4 bits
		/// </summary>
		public TStructArray<uint> VertexCountPerFace
		{
			get{ CheckIsValid();return new TStructArray<uint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VertexCountPerFace__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VertexCountPerFace__Offset, false);}
			
		}
		
		static readonly int IndicesPerFace__Offset;
		/// <summary>becomes TopologyDescriptor::vertIndicesPerFace e.g. two triangles: 0,1,2, 2,3,0</summary>
		public TStructArray<uint> IndicesPerFace
		{
			get{ CheckIsValid();return new TStructArray<uint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+IndicesPerFace__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+IndicesPerFace__Offset, false);}
			
		}
		
		static readonly int VertexAttributeStreams__Offset;
		/// <summary>various streams e.g "Position"</summary>
		public TObjectArray<UVertexAttributeStream>  VertexAttributeStreams
		{
					get{ CheckIsValid();return new TObjectArray<UVertexAttributeStream>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VertexAttributeStreams__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VertexAttributeStreams__Offset, false);}
			
		}
		
		static readonly int Materials__Offset;
		/// <summary>Materials used by this mesh. Individual sections index in to this array.</summary>
		public TObjectArray<UMaterialInterface>  Materials
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialInterface>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Materials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Materials__Offset, false);}
			
		}
		
		static USubDSurface()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SubDSurface");
			VertexCountPerFace__Offset=GetPropertyOffset(NativeClassPtr,"VertexCountPerFace");
			IndicesPerFace__Offset=GetPropertyOffset(NativeClassPtr,"IndicesPerFace");
			VertexAttributeStreams__Offset=GetPropertyOffset(NativeClassPtr,"VertexAttributeStreams");
			Materials__Offset=GetPropertyOffset(NativeClassPtr,"Materials");
			
		}
		
	}
	
}
#endif
#endif
