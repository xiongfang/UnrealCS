#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Asset class that contains a list of parameter names and their default values.
	/// Any number of materials can reference these parameters and get new values when the parameter values are changed.
	/// </summary>
	public partial class UMaterialParameterCollection
	{
		static readonly int StateId__Offset;
		/// <summary>Used by materials using this collection to know when to recompile.</summary>
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
