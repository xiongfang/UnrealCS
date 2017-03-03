#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionReroute
	{
		static readonly int Input__Offset;
		public FExpressionInput Input
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Input__Offset, typeof(FExpressionInput));}
			
		}
		
		static UMaterialExpressionReroute()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionReroute");
			Input__Offset=GetPropertyOffset(NativeClassPtr,"Input");
			
		}
		
	}
	
}
#endif
#endif
