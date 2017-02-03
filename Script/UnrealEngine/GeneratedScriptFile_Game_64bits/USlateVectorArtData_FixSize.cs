#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USlateVectorArtData
	{
		static readonly int VertexData__Offset;
		public TStructArray<FSlateMeshVertex> VertexData
		{
			get{ CheckIsValid();return new TStructArray<FSlateMeshVertex>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VertexData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VertexData__Offset, false);}
			
		}
		
		static readonly int IndexData__Offset;
		public TStructArray<uint> IndexData
		{
			get{ CheckIsValid();return new TStructArray<uint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+IndexData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+IndexData__Offset, false);}
			
		}
		
		static readonly int Material__Offset;
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
