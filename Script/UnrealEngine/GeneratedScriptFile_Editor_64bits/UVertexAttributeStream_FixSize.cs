#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVertexAttributeStream
	{
		static readonly int Usage__Offset;
		/// <summary>e.g. FName(TEXT("Position"))</summary>
		public FName Usage
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+Usage__Offset, typeof(FName));}
			
		}
		
		static readonly int AttributeType__Offset;
		/// <summary>e.g. VAST_unknown</summary>
		public EVertexAttributeStreamType AttributeType
		{
			get{ CheckIsValid();return (EVertexAttributeStreamType)Marshal.PtrToStructure(_this.Get()+AttributeType__Offset, typeof(EVertexAttributeStreamType));}
			
		}
		
		static readonly int Data__Offset;
		/// <summary>actual type depends on AttributeType, position is indexed by IndicesPerFace, other attributes by CornerID (e.g. 10 quads result in 40 attributes)</summary>
		public TStructArray<byte> Data
		{
			get{ CheckIsValid();return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Data__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Data__Offset, false);}
			
		}
		
		static UVertexAttributeStream()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VertexAttributeStream");
			Usage__Offset=GetPropertyOffset(NativeClassPtr,"Usage");
			AttributeType__Offset=GetPropertyOffset(NativeClassPtr,"AttributeType");
			Data__Offset=GetPropertyOffset(NativeClassPtr,"Data");
			
		}
		
	}
	
}
#endif
#endif
