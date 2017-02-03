#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionGetMaterialAttributes
	{
		static readonly int MaterialAttributes__Offset;
		public FMaterialAttributesInput MaterialAttributes
		{
			get{ CheckIsValid();return (FMaterialAttributesInput)Marshal.PtrToStructure(_this.Get()+MaterialAttributes__Offset, typeof(FMaterialAttributesInput));}
			
		}
		
		static readonly int AttributeGetTypes__Offset;
		public TStructArray<FGuid> AttributeGetTypes
		{
			get{ CheckIsValid();return new TStructArray<FGuid>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AttributeGetTypes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AttributeGetTypes__Offset, false);}
			
		}
		
		static UMaterialExpressionGetMaterialAttributes()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionGetMaterialAttributes");
			MaterialAttributes__Offset=GetPropertyOffset(NativeClassPtr,"MaterialAttributes");
			AttributeGetTypes__Offset=GetPropertyOffset(NativeClassPtr,"AttributeGetTypes");
			
		}
		
	}
	
}
#endif
#endif
