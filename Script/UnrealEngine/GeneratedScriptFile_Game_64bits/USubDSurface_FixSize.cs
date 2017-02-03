#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USubDSurface
	{
		static readonly int VertexCountPerFace__Offset;
		public TStructArray<uint> VertexCountPerFace
		{
			get{ CheckIsValid();return new TStructArray<uint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VertexCountPerFace__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VertexCountPerFace__Offset, false);}
			
		}
		
		static readonly int IndicesPerFace__Offset;
		public TStructArray<uint> IndicesPerFace
		{
			get{ CheckIsValid();return new TStructArray<uint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+IndicesPerFace__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+IndicesPerFace__Offset, false);}
			
		}
		
		static readonly int VertexAttributeStreams__Offset;
		public TObjectArray<UVertexAttributeStream>  VertexAttributeStreams
		{
					get{ CheckIsValid();return new TObjectArray<UVertexAttributeStream>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VertexAttributeStreams__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VertexAttributeStreams__Offset, false);}
			
		}
		
		static readonly int Materials__Offset;
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
