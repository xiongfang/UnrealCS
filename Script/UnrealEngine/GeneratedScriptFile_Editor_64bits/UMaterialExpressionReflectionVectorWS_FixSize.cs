#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionReflectionVectorWS
	{
		static readonly int CustomWorldNormal__Offset;
		/// <summary>Defaults to Reflection Vector if not specified</summary>
		public FExpressionInput CustomWorldNormal
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+CustomWorldNormal__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int bNormalizeCustomWorldNormal__Offset;
		/// <summary>(true): The specified world normal will be normalized. (false): WorldNormal will just be used as is, faster but possible artifacts if normal length isn't 1</summary>
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
