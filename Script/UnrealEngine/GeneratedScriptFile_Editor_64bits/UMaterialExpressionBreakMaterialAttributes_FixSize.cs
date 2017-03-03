#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionBreakMaterialAttributes
	{
		static readonly int MaterialAttributes__Offset;
		public FMaterialAttributesInput MaterialAttributes
		{
			get{ CheckIsValid();return (FMaterialAttributesInput)Marshal.PtrToStructure(_this.Get()+MaterialAttributes__Offset, typeof(FMaterialAttributesInput));}
			
		}
		
		static UMaterialExpressionBreakMaterialAttributes()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionBreakMaterialAttributes");
			MaterialAttributes__Offset=GetPropertyOffset(NativeClassPtr,"MaterialAttributes");
			
		}
		
	}
	
}
#endif
#endif
