#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionSetMaterialAttributes
	{
		static readonly int Inputs__Offset;
		public TStructArray<FExpressionInput> Inputs
		{
			get{ CheckIsValid();return new TStructArray<FExpressionInput>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Inputs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Inputs__Offset, false);}
			
		}
		
		static readonly int AttributeSetTypes__Offset;
		public TStructArray<FGuid> AttributeSetTypes
		{
			get{ CheckIsValid();return new TStructArray<FGuid>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AttributeSetTypes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AttributeSetTypes__Offset, false);}
			
		}
		
		static UMaterialExpressionSetMaterialAttributes()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionSetMaterialAttributes");
			Inputs__Offset=GetPropertyOffset(NativeClassPtr,"Inputs");
			AttributeSetTypes__Offset=GetPropertyOffset(NativeClassPtr,"AttributeSetTypes");
			
		}
		
	}
	
}
#endif
#endif
