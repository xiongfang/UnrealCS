#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialParameterCollection
	{
		static readonly int StateId__Offset;
		public FGuid StateId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+StateId__Offset, typeof(FGuid));}
			
		}
		
		static readonly int ScalarParameters__Offset;
		public TStructArray<FCollectionScalarParameter> ScalarParameters
		{
			get{ CheckIsValid();return new TStructArray<FCollectionScalarParameter>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ScalarParameters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ScalarParameters__Offset, false);}
			
		}
		
		static readonly int VectorParameters__Offset;
		public TStructArray<FCollectionVectorParameter> VectorParameters
		{
			get{ CheckIsValid();return new TStructArray<FCollectionVectorParameter>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VectorParameters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VectorParameters__Offset, false);}
			
		}
		
		static UMaterialParameterCollection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialParameterCollection");
			StateId__Offset=GetPropertyOffset(NativeClassPtr,"StateId");
			ScalarParameters__Offset=GetPropertyOffset(NativeClassPtr,"ScalarParameters");
			VectorParameters__Offset=GetPropertyOffset(NativeClassPtr,"VectorParameters");
			
		}
		
	}
	
}
#endif
#endif
