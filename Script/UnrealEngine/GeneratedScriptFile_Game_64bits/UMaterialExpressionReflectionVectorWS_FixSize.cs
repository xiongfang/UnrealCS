#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionReflectionVectorWS
	{
		static readonly int CustomWorldNormal__Offset;
		public FExpressionInput CustomWorldNormal
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+CustomWorldNormal__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int bNormalizeCustomWorldNormal__Offset;
		public bool bNormalizeCustomWorldNormal
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNormalizeCustomWorldNormal__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNormalizeCustomWorldNormal__Offset, 1,0,1,1);}
			
		}
		
		static UMaterialExpressionReflectionVectorWS()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionReflectionVectorWS");
			CustomWorldNormal__Offset=GetPropertyOffset(NativeClassPtr,"CustomWorldNormal");
			bNormalizeCustomWorldNormal__Offset=GetPropertyOffset(NativeClassPtr,"bNormalizeCustomWorldNormal");
			
		}
		
	}
	
}
#endif
#endif
