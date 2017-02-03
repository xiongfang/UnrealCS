#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVertexAttributeStream
	{
		static readonly int Usage__Offset;
		public FName Usage
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+Usage__Offset, typeof(FName));}
			
		}
		
		static readonly int AttributeType__Offset;
		public EVertexAttributeStreamType AttributeType
		{
			get{ CheckIsValid();return (EVertexAttributeStreamType)Marshal.PtrToStructure(_this.Get()+AttributeType__Offset, typeof(EVertexAttributeStreamType));}
			
		}
		
		static readonly int Data__Offset;
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
